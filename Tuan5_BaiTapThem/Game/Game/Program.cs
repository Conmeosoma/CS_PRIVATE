using System;
using GridGame; // <--- QUAN TRỌNG: Để nhìn thấy các class kia

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- GRID BATTLE GAME ---");
        
        // Bây giờ GameManager đã được tìm thấy
        GameManager game = new GameManager();
        game.StartBattle();
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}