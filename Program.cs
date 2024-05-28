using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so lo hang: ");
            n = int.Parse(Console.ReadLine());
            LoHang[] DSLoHang = new LoHang[n+1];
            Console.Clear();
            NhapDSLoHang(n, DSLoHang);
            XuatDSLoHang(n, DSLoHang);
            Console.WriteLine("So lo hang dien thoai: {0}", LoHangDienThoai.count);
            Console.WriteLine("So lo hang laptop: {0}", LoHangLaptop.count);
            Console.WriteLine();
            TimKiemLoHang(n, DSLoHang);
            Console.ReadKey();
        }

        private static void NhapDSLoHang(int n, LoHang[] DSLoHang)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap lo hang thu {0}", i + 1);
                Console.Write("Nhap ma phieu nhap hang: ");
                string maPhieuNhapHang = Console.ReadLine();
                Console.Write("Nhap ngay nhap hang:\nNhap ngay: ");
                int ngay = int.Parse(Console.ReadLine());
                Console.Write("Nhap thang: ");
                int thang = int.Parse(Console.ReadLine());
                Console.Write("Nhap nam: ");
                int nam = int.Parse(Console.ReadLine());
                NgayThangNam ngayNhapHang = new NgayThangNam(ngay, thang, nam);
                Console.Write("Nhap ten nha cung cap: ");
                string tenNhaCungCap = Console.ReadLine();
                Console.Write("Nhap mo ta cau hinh thiet bi: ");
                string moTaCauHinhThietBi = Console.ReadLine();
                Console.Write("Nhap so luong: ");
                int soLuong = int.Parse(Console.ReadLine());
                int x;
                Console.Write("Chon 1 neu la lo hang dien thoai, 2 neu la lo hang laptop: ");
                x = int.Parse(Console.ReadLine());
                do
                {
                    if (x == 1)
                    {
                        Console.Write("Nhap ma thung: ");
                        string maThung = Console.ReadLine();
                        Console.Write("Nhap phi chuyen cho: ");
                        double phiChuyenCho = double.Parse(Console.ReadLine());
                        Console.Write("Nhap don gia thung: ");
                        double donGiaThung = double.Parse(Console.ReadLine());
                        DSLoHang[i] = new LoHangDienThoai(maPhieuNhapHang, ngayNhapHang, tenNhaCungCap, moTaCauHinhThietBi, soLuong, maThung, phiChuyenCho, donGiaThung);
                        break;
                    }
                    else if (x == 2)
                    {
                        Console.Write("Nhap so serial: ");
                        string soSerial = Console.ReadLine();
                        Console.Write("Nhap gia von nhap hang: ");
                        double giaVonNhapHang = double.Parse(Console.ReadLine());
                        Console.Write("Nhap ty gia thue: ");
                        double tyGiaThue = double.Parse(Console.ReadLine());
                        DSLoHang[i] = new LoHangLaptop(maPhieuNhapHang, ngayNhapHang, tenNhaCungCap, moTaCauHinhThietBi, soLuong, soSerial, giaVonNhapHang, tyGiaThue);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ban nhap sai, vui long nhap lai!");
                    }
                } while (true);
                Console.Clear();
            }
        }
        private static void XuatDSLoHang(int n, LoHang[] DSLoHang)
        {
            Console.WriteLine("Danh sach lo hang");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Lo hang thu {0}", i + 1);
                Console.WriteLine(DSLoHang[i].Print());
                Console.WriteLine("---------------------------");
            }
        }
        private static void TimKiemLoHang(int n, LoHang[] DSLoHang)
        {
            int x;
            Console.WriteLine("Nhap 1 neu tim kiem theo ma phieu");
            Console.WriteLine("Nhap 2 neu tim kiem theo ngay");
            Console.WriteLine("Nhap 3 neu tim kiem theo ten nha cung cap");
            Console.WriteLine("Nhap 4 neu tim kiem theo mo ta cau hinh");
            Console.WriteLine("Nhap 0 de thoat");
            do
            {
                Console.Write("Nhap lua chon cua ban: ");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    TimKiemTheoMaPhieu(n, DSLoHang);
                }
                else if (x == 2)
                {
                    TimKiemTheoNgay(n, DSLoHang);
                }
                else if (x == 3)
                {
                    TimKiemTheoTenNhaCungCap(n, DSLoHang);
                }
                else if (x == 4)
                {
                    TimKiemTheoMoTaCauHinh(n, DSLoHang);
                }
                else if (x == 0)
                    break;
                else
                    Console.WriteLine("Lua chon khong hop le, vui long nhap lai!");
            } while (true);
        }
        private static void TimKiemTheoMaPhieu(int n, LoHang[] DSLoHang)
        {
            Console.Write("Nhap ma phieu can tim: ");
            string search = Console.ReadLine();
            Console.WriteLine("Cac don hang co ma phieu can tim:");
            int temp = 0;
            for(int i = 0; i < n; i++)
            {
                if (DSLoHang[i].MaPhieuNhapHang.ToLower() == search.ToLower())
                {
                    Console.WriteLine(DSLoHang[i].Print());
                    Console.WriteLine("---------------------------");
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Khong co thong tin lo hang can tim!");
            }
        }
        private static void TimKiemTheoNgay(int n, LoHang[] DSLoHang)
        {
            Console.WriteLine("Nhap thong tin de tim kiem theo ngay");
            Console.Write("Nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());
            Console.WriteLine("Lo hang co ngay can tim");
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if (ngay == DSLoHang[i].NgayNhapHang.Ngay && thang == DSLoHang[i].NgayNhapHang.Thang && nam == DSLoHang[i].NgayNhapHang.Nam)
                {
                    Console.WriteLine(DSLoHang[i].Print());
                    Console.WriteLine("---------------------------");
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Khong co thong tin lo hang can tim!");
            }
        }
        private static void TimKiemTheoTenNhaCungCap(int n, LoHang[] DSLoHang)
        {
            Console.Write("Nhap ten nha cung cap can tim: ");
            string search = Console.ReadLine();
            Console.WriteLine("Cac lo hang co ten nha cung cap can tim:");
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if (DSLoHang[i].TenNhaCungCap.ToLower() == search.ToLower())
                {
                    Console.WriteLine(DSLoHang[i].Print());
                    Console.WriteLine("---------------------------");
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Khong co thong tin lo hang can tim!");
            }
        }
        private static void TimKiemTheoMoTaCauHinh(int n, LoHang[] DSLoHang)
        {
            Console.Write("Nhap cau hinh can tim: ");
            string search = Console.ReadLine();
            Console.WriteLine("Cac lo hang co cau hinh can tim:");
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if (DSLoHang[i].MoTaCauHinhThietBi.ToLower() == search.ToLower())
                {
                    Console.WriteLine(DSLoHang[i].Print());
                    Console.WriteLine("---------------------------");
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Khong co thong tin lo hang can tim!");
            }
        }
    }
}
