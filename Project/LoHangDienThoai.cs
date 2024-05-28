using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class LoHangDienThoai:LoHang
    {
        private string maThung;
        private double phiChuyenCho;
        private double donGiaThung;
        public static int count = 0;
        public string MaThung
        {
            get { return maThung; }
            set { maThung = value; }
        }
        public double PhiChuyenCho
        {
            get { return phiChuyenCho; }
            set { phiChuyenCho = value; }
        }
        public double DonGiaThung
        {
            get { return donGiaThung; }
            set { donGiaThung = value; }
        }
        public LoHangDienThoai()
        {
            this.maThung = "";
            this.phiChuyenCho = 0;
            this.donGiaThung = 0;
            count++;
        }
        public LoHangDienThoai(string maPhieuNhapHang, NgayThangNam ngayNhapHang, string tenNhaCungCap, string moTaCauHinhThietBi, int soLuong,
            string maThung, double phiChuyenCho, double donGiaThung):base(maPhieuNhapHang, ngayNhapHang, tenNhaCungCap, moTaCauHinhThietBi, soLuong)
        {
            this.maThung = maThung;
            this.phiChuyenCho = phiChuyenCho;
            this.donGiaThung = donGiaThung;
            count++;
        }
        public override double GiaTriLoHang()
        {
            return SoLuong * donGiaThung + phiChuyenCho;
        }
        public override string Print()
        {
            return $"{base.Print()}Ma thung: {maThung} - Phi chuyen cho: {phiChuyenCho} - Don gia thung: {donGiaThung}\n" +
                $"Gia tri lo hang: {GiaTriLoHang()}";
        }
    }
}
