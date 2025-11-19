using hh;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine(">>>>>MENU<<<<<<");
            Console.WriteLine("1.Bai1: ");
            Console.WriteLine("2.Bai2: ");
            Console.WriteLine("3.Bai3: ");
            Console.WriteLine("4.Bai3++: ");
            Console.WriteLine("Nhap lua chon cua anh: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1 : 
                    Console.WriteLine("Bai 1");
                    Wizard phuthuy = new Wizard("Pt 1", 10, 12);
                    phuthuy.CastSpell(); 
                    break;
                case 2 : 
                    Console.WriteLine("================");
                    Console.WriteLine("Bai 2");
                    Warrior chienbinh1 = new Warrior("Hs1", 20);
                    Warrior chienbinh2 = new Warrior("Hs2", 30);
                    Mage phapsu1 = new Mage("ps1", 15);
                    chienbinh1.UseAbility();
                    chienbinh2.UseAbility();
                    phapsu1.UseAbility();
                    break;
                case 3:
                    Console.WriteLine("================");
                    Console.WriteLine("Bai3");
                    Player nguoiChoi = new Player("Hiep Si", 100, 25);
                    Enemy quaiVat = new Enemy("Slime", 100, 5);
                    // Console.WriteLine("Nhap so luot danh: ");
                    // int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < 10; i++)
                    {
                        nguoiChoi.PreformAttack(quaiVat);
                        if (quaiVat.Health == 0)
                        {
                            break;
                        }
                        quaiVat.PreformAttack(nguoiChoi);
            
                    }
                    break;
                case 4 : 
                    Console.WriteLine("================");
                    Console.WriteLine("Bai4");
                    Console.WriteLine("Khos:) 10 điểm này hơi kó lấy :)))");
                    break;
            }
        } while (true);
        
        
        
       
        



    }
}