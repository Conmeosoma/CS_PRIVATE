namespace GridGame // <--- Thêm namespace
{
    public class Tile
    {
        // Thêm dấu '?' để báo hiệu ô này có thể không có người đứng
        public Character? Occupant { get; set; } 
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Tile(int x, int y)
        {
            PosX = x;
            PosY = y;
            Occupant = null;
        }

        public bool IsOccupied()
        {
            return Occupant != null;
        }
    }
}