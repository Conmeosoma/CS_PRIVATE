namespace GridGame
{

    public class Player : Character
    {
        public Weapon CurrentWeapon { get; set; }

        public Player(int x, int y, double hp) : base(x, y, hp, 0, 0)
        {
            Symbol = '0'; // Ký tự đại diện cho Player
        }

        public void EquipWeapon(Weapon weapon)
        {
            CurrentWeapon = weapon;
            this.Damage = weapon.Damage;
            this.RangeAttack = weapon.RangeAttack;
            Console.WriteLine($"Player equipped {weapon.Name} (Dmg: {Damage}, Range: {RangeAttack})");
        }

        public override void Move(char direction, Tile[,] grid, int xWide, int yHigh)
        {
            int newX = PosX;
            int newY = PosY;

            switch (char.ToUpper(direction))
            {
                case 'W': newY--; break; // Lên
                case 'S': newY++; break; // Xuống
                case 'A': newX--; break; // Trái
                case 'D': newX++; break; // Phải
                default: return; // Bỏ lượt
            }

            // Kiểm tra biên và va chạm
            if (newX >= 0 && newX < xWide && newY >= 0 && newY < yHigh)
            {
                if (!grid[newY, newX].IsOccupied())
                {
                    PosX = newX;
                    PosY = newY;
                }
                else
                {
                    Console.WriteLine("Path blocked!");
                }
            }
        }
    }
}
