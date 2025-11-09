using System;

namespace Bai1
{
    public class Mainn
    {
        public static void Main(string[] args)
        {
            CongNhanControl control = new CongNhanControl();
            do
            {
                Console.WriteLine("Chuong trinh quan ly cong nhan codeBy Conmeosoma");
                Console.WriteLine("______MENU_______");
                Console.WriteLine("1.Add cong nhan");
                Console.WriteLine("2.Hien thi cong nhan");
                Console.WriteLine("3.Sap xep theo ten");
                Console.WriteLine("4.Tim cong nhan theo ma cong nhan");
                Console.WriteLine("0. THoat");
                Console.WriteLine("Nhap lua chon cua ban: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        control.themCongNhan();
                        break;
                    case 2:
                        control.hienThiDanhSach();
                        break;
                    case 3:
                        control.SapXep();
                        break;
                    case 4:
                        control.timCongNhanTheoMa();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le!!!");
                        break;
                }
            } while (true);
        }
    }
}