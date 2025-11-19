using System;
using System.Collections.Generic;
using System.Linq;

namespace GridGame
{
    public class GameManager
    {
        // Thêm '?' hoặc khởi tạo ngay để tránh lỗi CS8618
        public GridManager? gridManager; 
        public Player? player;
        public List<Enemy> enemyList = new List<Enemy>(); // Khởi tạo luôn
        
        private int xWide = 10;
        private int yHigh = 10;
        private Random rand = new Random();

        public void StartBattle()
        {
            gridManager = new GridManager(xWide, yHigh);
            enemyList.Clear(); // Reset list
            
            SpawnEntity();
            
            // Vòng lặp chính
            // Lưu ý: dùng dấu ! để cam kết player không null sau khi SpawnEntity
            while (player!.Health > 0 && enemyList.Count > 0)
            {
                Console.Clear();
                gridManager.UpdateGrid(player, enemyList);
                gridManager.DrawGrid();
                Console.WriteLine($"Player HP: {player.Health} | Weapon: {player.CurrentWeapon?.Name ?? "None"}");

                TurnPlayer();
                
                enemyList.RemoveAll(e => e.Health <= 0);
                if (enemyList.Count == 0) break;

                TurnEnemy();
                if (player.Health <= 0) break;

                System.Threading.Thread.Sleep(500);
            }
            CheckWinOrLose();
        }

        public void SpawnEntity()
        {
            player = new Player(rand.Next(0, xWide), rand.Next(0, yHigh), 100);
            
            var weapons = new List<Weapon>
            {
                new Weapon("Sword", 20, 1),
                new Weapon("Bow", 15, 3),
                new Weapon("Spear", 18, 2)
            };
            player.EquipWeapon(weapons[rand.Next(weapons.Count)]);

            for (int i = 0; i < 3; i++)
            {
                int ex, ey;
                do { ex = rand.Next(0, xWide); ey = rand.Next(0, yHigh); } 
                while (ex == player.PosX && ey == player.PosY);
                enemyList.Add(new Enemy(ex, ey));
            }
        }

        public void TurnPlayer()
        {
            Console.Write("Move (W/A/S/D) or Skip (Space): ");
            ConsoleKeyInfo key = Console.ReadKey();
            
            // gridManager! cam kết không null
            player!.Move(key.KeyChar, gridManager!.Grid, xWide, yHigh);
            gridManager.UpdateGrid(player, enemyList);

            // Ép kiểu Enemy về Character để dùng chung hàm
            var targets = enemyList.Cast<Character>().ToList();
            var target = player.CheckRangeAttack(gridManager.Grid, targets);
            if (target != null) player.Attack(target);
        }

        public void TurnEnemy()
        {
            foreach (var enemy in enemyList)
            {
                enemy.Move(' ', gridManager!.Grid, xWide, yHigh);
                var targets = new List<Character> { player! };
                var target = enemy.CheckRangeAttack(gridManager.Grid, targets);
                if (target != null) enemy.Attack(target);
            }
        }

        public void CheckWinOrLose()
        {
            Console.Clear();
            if (player != null && player.Health > 0)
                Console.WriteLine("VICTORY! All enemies defeated.");
            else
                Console.WriteLine("GAME OVER! You died.");
        }
    }
}