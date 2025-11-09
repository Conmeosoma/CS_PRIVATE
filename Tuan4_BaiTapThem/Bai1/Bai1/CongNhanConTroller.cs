using System;
using System.Collections.Generic;

namespace Bai1
{
    public class CongNhanControl
    {
        private List<CONGNHAN> dsCongNhan = new List<CONGNHAN>();

        public void themCongNhan()
        {
            Console.Write("Nhap so luong cong nhan: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin cong nhan thu " + (i + 1) + ": ");
                Console.Write("Ma cong nhan: ");
                string maCongNhan = Console.ReadLine();

                Console.Write("Ho va ten: ");
                string hoTen = Console.ReadLine();

                Console.Write("Tuoi: ");
                int tuoi = int.Parse(Console.ReadLine());

                Console.Write("Dia chi: ");
                string diaChi = Console.ReadLine();

                ChucVu chucVu;
                while (true)
                {
                    Console.WriteLine("Chon chuc vu:");
                    Console.WriteLine("1. Truong nhom");
                    Console.WriteLine("2. Pho nhom");
                    Console.WriteLine("3. Cong Nhan Bac 1");
                    Console.WriteLine("4. Cong Nhan Bac 2");
                    Console.WriteLine("5. Cong Nhan Bac 3");
                    Console.WriteLine("6. Cong Nhan Khac");
                    Console.Write("Nhap lua chon: ");
                    string Chon = Console.ReadLine();

                    switch (Chon)
                    {
                        case "1":
                            chucVu = ChucVu.TruongNhom;
                            break;
                        case "2":
                            chucVu = ChucVu.PhoNhom;
                            break;
                        case "3":
                            chucVu = ChucVu.CongNhanBac1;
                            break;
                        case "4":
                            chucVu = ChucVu.CongNhanBac2;
                            break;
                        case "5":
                            chucVu = ChucVu.CongNhanBac3;
                            break;
                        case "6":
                            chucVu = ChucVu.Khac;
                            break;
                        default:
                            Console.WriteLine("Lua chon khong hop le, vui long nhap lai!");
                            continue;
                    }

                    break;
                }

                CONGNHAN cn = new CONGNHAN(maCongNhan, hoTen, tuoi, diaChi, chucVu);
                dsCongNhan.Add(cn);
                Console.WriteLine("Da them cong nhan thanh cong!");
            }
        }

        public void hienThiDanhSach()
        {
            Console.WriteLine("=== Danh sach cong nhan ===");
            if (dsCongNhan.Count == 0)
            {
                Console.WriteLine("Chua co cong nhan nao trong danh sach.");
            }
            else
            {
                foreach (CONGNHAN congnhan in dsCongNhan)
                {
                    congnhan.toString();
                }
            }
        }

        public void SapXep()
        {
            dsCongNhan.Sort((cn1, cn2) =>
            {
                int soSanhTen = string.Compare(cn1.HoTen, cn2.HoTen, StringComparison.OrdinalIgnoreCase);
                if (soSanhTen == 0)
                {
                    return cn1.tinhLuong().CompareTo(cn2.tinhLuong());
                }

                return soSanhTen;
            });

            Console.WriteLine(" Danh sach cong nhan sau khi sap xep theo ten");
            hienThiDanhSach();
        }

        public void timCongNhanTheoMa()
        {
            Console.Write("Nhap ma cong nhan can tim: ");
            string ma = Console.ReadLine();
            bool flag;
            foreach (CONGNHAN congnhan in dsCongNhan)
            {
                if (ma.Equals(congnhan.MaCongNhan, StringComparison.OrdinalIgnoreCase))
                {
                    hienThiDanhSach();
                    flag = true;
                    break;
                }

                if (flag = false)
                {
                    Console.WriteLine("Khong thay cong nhan nao");
                }
            }
        }
    }
}