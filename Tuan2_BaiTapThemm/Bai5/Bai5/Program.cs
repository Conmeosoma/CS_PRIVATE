using System;
using System.Globalization;

namespace Bai5
{
    public class Program
    {
        public static int n;
        public static double[] diem;

        public void nhap()
        {
            Console.WriteLine("Nhap so luong hoc sinh: ");
            n = int.Parse(Console.ReadLine());
            diem = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap so diem cua cac sinh vien: ");
                diem[i] = double.Parse(Console.ReadLine());
            }
        }
        //Tính điểm trung bình của lớp
        //Tìm điểm cao nhất và thấp nhất


        public void diemTrungBinh()
        {
            double tongDiem = 0;
            for (int i = 0; i < n; i++)
            {
                tongDiem += diem[i];
            }

            Console.WriteLine("Diem trung binh cua ca lop la: " + (tongDiem / (double)n));
        }

        public void search()
        {
            double max = 0;
            double min = diem[0];

            for (int i = 0; i < n; i++)
            {
                if (diem[i] > max)
                {
                    max = diem[i];
                }

                if (diem[i] < min)
                {
                    min = diem[i];
                }
            }

            Console.WriteLine("Diem cao nhat: " + max);
            Console.WriteLine("Diem thap nhat: " + min);
        }

        //Tính tỷ lệ học sinh đạt (điểm ≥ 5.0)
        public void check()
        {
            int countYeu = 0, countTb = 0, countKha = 0, countGioi = 0;
            for (int i = 0; i < n; i++)
            {
                if (diem[i] < 5)
                {
                    countYeu++;
                }
                else if (5 <= diem[i] & diem[i] <= 6.4)
                {
                    countTb++;
                }
                else if (6.5 <= diem[i] & diem[i] <= 7.9)
                {
                    countKha++;
                }
                else
                {
                    countGioi++;
                }
            }

            Console.WriteLine("Ty le dat: " + (double)(countGioi + countTb + countKha) / n * 100 + "%");
            Console.WriteLine("Gioi: " + countGioi + " Hoc sinh");
            Console.WriteLine("Kha: " + countKha + " Hoc sinh");
            Console.WriteLine("Trung binh: " + countTb + " Hoc sinh");
            Console.WriteLine("Yeu: " + countYeu + " Hoc sinh");
        }

        static void Main(string[] args)
        {
            Program bai5 = new Program();
            bai5.nhap();
            bai5.diemTrungBinh();
            bai5.search();
            bai5.check();
        }
    }
}