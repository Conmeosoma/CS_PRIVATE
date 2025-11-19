using System;
using System.Collections.Generic;

namespace GridGame
{
    public abstract class Character
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public double Damage { get; set; }
        public int RangeAttack { get; set; }
        public double Health { get; set; }
        public char Symbol { get; set; }

        public Character(int x, int y, double health, double damage, int range)
        {
            PosX = x;
            PosY = y;
            Health = health;
            Damage = damage;
            RangeAttack = range;
        }

        // Sửa logic: Nhận List<Character> thay vì List<Enemy> để tổng quát hóa
        public abstract void Move(char direction, Tile[,] grid, int xWide, int yHigh);

        public void TakeDamage(double dmg)
        {
            Health -= dmg;
            if (Health < 0) Health = 0;
            Console.WriteLine($"{this.GetType().Name} took {dmg} damage! Remaining HP: {Health}");
        }

        public virtual void Attack(Character target)
        {
            if (target != null)
            {
                Console.WriteLine($"{this.GetType().Name} attacks {target.GetType().Name}!");
                target.TakeDamage(this.Damage);
            }
        }

        // Trả về Character? (có thể null)
        public virtual Character? CheckRangeAttack(Tile[,] grid, List<Character> targets)
        {
            foreach (var target in targets)
            {
                if (target.Health <= 0) continue; // Bỏ qua mục tiêu đã chết
                
                double distance = Math.Sqrt(Math.Pow(PosX - target.PosX, 2) + Math.Pow(PosY - target.PosY, 2));
                if (distance <= RangeAttack)
                {
                    return target;
                }
            }
            return null;
        }
    }
}