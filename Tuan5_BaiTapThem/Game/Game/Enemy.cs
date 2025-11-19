namespace GridGame
{
// 2. Lớp Enemy
    public class Enemy : Character
    {
        private Random _rand = new Random();

        public Enemy(int x, int y) : base(x, y, 50, 10, 1) // Máu 50, Dmg 10, Tầm 1
        {
            Symbol = '1'; // Ký tự đại diện cho Enemy
        }

        public override void Move(char direction, Tile[,] grid, int xWide, int yHigh)
        {
            // Enemy tự random hướng, bỏ qua tham số direction
            int dir = _rand.Next(0, 4);
            int newX = PosX;
            int newY = PosY;

            switch (dir)
            {
                case 0: newY--; break; // Lên
                case 1: newY++; break; // Xuống
                case 2: newX--; break; // Trái
                case 3: newX++; break; // Phải
            }

            if (newX >= 0 && newX < xWide && newY >= 0 && newY < yHigh)
            {
                if (!grid[newY, newX].IsOccupied())
                {
                    PosX = newX;
                    PosY = newY;
                }
            }
        }
    }
}