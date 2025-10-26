using System;

namespace Bai2
{
    public class Program
    {
        public static double circle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public static double retangle(double length, double width)
        {
            return length * width;
        }

        public static double triagular(double canhday, double high)
        {
            return 0.5 * canhday * high;
        }


        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("_______MENU_________");
                Console.WriteLine("1. Tinh dien tich hinh tron");
                Console.WriteLine("2. Tinh dien tich hinh chu nhat");
                Console.WriteLine("3. Tinh dien tich hinh tamm giac");
                Console.WriteLine("Nhap lua chon cua ban: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Nhap r: ");
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine("Dien tich hinh tron ban kinh r la: " + circle(r));
                        break;
                    case 2:
                        Console.WriteLine("Nhap chieu dai va chieu rong cua HCN");
                        double chieudai = double.Parse(Console.ReadLine());
                        double chieurong = double.Parse(Console.ReadLine());
                        Console.WriteLine("Dien tich hinh chu nhat la: " + retangle(chieudai, chieurong));
                        break;
                    case 3:
                        Console.WriteLine("Nhap canh day , chieu cao cua hinh tam giac: ");
                        double canhday = double.Parse(Console.ReadLine());
                        double chieucao = double.Parse(Console.ReadLine());
                        Console.WriteLine("Dien tich hinh tam giac la: " + triagular(canhday, chieucao));
                        break;
                    default: Console.WriteLine("Lua chon cua ban khong hop le!");
                        break;
                }
            } while (true);
        }
    }
}