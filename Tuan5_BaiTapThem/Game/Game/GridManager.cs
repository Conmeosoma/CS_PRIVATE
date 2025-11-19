using System;
using System.Collections.Generic;

namespace GridGame
{
    public class GridManager
    {
        public int XWide { get; set; }
        public int YHigh { get; set; }
        public Tile[,] Grid { get; set; }

        public GridManager(int width, int height)
        {
            XWide = width;
            YHigh = height;
            Grid = new Tile[height, width];
            SpawnTiles();
        }

        public void SpawnTiles()
        {
            for (int y = 0; y < YHigh; y++)
            {
                for (int x = 0; x < XWide; x++)
                {
                    Grid[y, x] = new Tile(x, y);
                }
            }
        }

        public void UpdateGrid(Player player, List<Enemy> enemies)
        {
            // Xóa vị trí cũ
            foreach (var tile in Grid) tile.Occupant = null;

            // Cập nhật Player
            if (player.Health > 0)
                Grid[player.PosY, player.PosX].Occupant = player;

            // Cập nhật Enemies
            foreach (var enemy in enemies)
            {
                if (enemy.Health > 0)
                    Grid[enemy.PosY, enemy.PosX].Occupant = enemy;
            }
        }

        public void DrawGrid()
        {
            Console.WriteLine("\n--- MAP ---");
            for (int y = 0; y < YHigh; y++)
            {
                for (int x = 0; x < XWide; x++)
                {
                    if (Grid[y, x].Occupant == null)
                        Console.Write(". ");
                    else
                        Console.Write(Grid[y, x].Occupant!.Symbol + " "); // Dấu ! xác nhận không null
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
        }
    }
}