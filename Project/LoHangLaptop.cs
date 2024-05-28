using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class LoHangLaptop:LoHang
    {
        private string soSerial;
        private double giaVonNhapHang;
        private double tyGiaThue;
        public static int count = 0;
        public string SoSerial
        {
            get { return soSerial; }
            set { soSerial = value; }
        }
        public double GiaVonNhapHang
        {
            get { return giaVonNhapHang; }
            set { giaVonNhapHang = value; }
        }
        public double TyGiaThue
        {
            get { return tyGiaThue; }
            set { tyGiaThue = value; }
        }
        public LoHangLaptop()
        {
            this.soSerial = "";
            this.giaVonNhapHang = 0;
            this.tyGiaThue = 0;
            count++;
        }
        public LoHangLaptop(string maPhieuNhapHang, NgayThangNam ngayNhapHang, string tenNhaCungCap, string moTaCauHinhThietBi, int soLuong,
            string soSerial, double giaVonNhapHang, double tyGiaThue): base(maPhieuNhapHang, ngayNhapHang, tenNhaCungCap, moTaCauHinhThietBi, soLuong)
        {
            this.soSerial = soSerial;
            this.giaVonNhapHang = giaVonNhapHang;
            this.tyGiaThue = tyGiaThue;
            count++;
        }
        public double Thue()
        {
            return tyGiaThue * giaVonNhapHang;
        }
        public override double GiaTriLoHang()
        {
            return SoLuong * (giaVonNhapHang + Thue());
        }
        public override string Print()
        {
            return $"{base.Print()}So serial: {soSerial} - Gia von nhap hang: {giaVonNhapHang} - Ty gia thue: {tyGiaThue} - Thue: {Thue()}\n" +
                $"Gia tri lo hang: {GiaTriLoHang()}";
        }
    }
}
