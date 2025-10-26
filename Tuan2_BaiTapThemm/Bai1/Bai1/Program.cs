using System;

public class Bai1
{
    static double a, b, c;

    public static void nhap()
    {
        Console.Write("Nhap canh a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Nhap canh b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Nhap canh c: ");
        c = double.Parse(Console.ReadLine());
    }

    public static void xuLy()
    {
        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
                Console.WriteLine("Day la tam giac DEU");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Day la tam giac CAN");
            else
                Console.WriteLine("Day la tam giac THUONG");
        }
        else
        {
            Console.WriteLine("Do dai khong hop le, khong tao thanh tam giac");
        }
    }
    public static void Main(string[] args)
    {
        nhap();
        xuLy();
    }

    
}