using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
    internal abstract class LoHang
    {
        private string maPhieuNhapHang;
        private NgayThangNam ngayNhapHang;
        private string tenNhaCungCap;
        private string moTaCauHinhThietBi;
        private int soLuong;
        public string MaPhieuNhapHang
        {
            get { return maPhieuNhapHang; }
            set { maPhieuNhapHang = value; }
        }
        public NgayThangNam NgayNhapHang
        {
            get { return ngayNhapHang; }
            set { ngayNhapHang = value; }
        }
        public string TenNhaCungCap
        {
            get { return tenNhaCungCap; }
            set { tenNhaCungCap = value; }
        }
        public string MoTaCauHinhThietBi
        {
            get { return moTaCauHinhThietBi; }
            set { moTaCauHinhThietBi = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public LoHang()
        {
            this.maPhieuNhapHang = "";
            this.ngayNhapHang = new NgayThangNam();
            this.tenNhaCungCap = "";
            this.moTaCauHinhThietBi = "";
        }
        public LoHang(string maPhieuNhapHang, NgayThangNam ngayNhapHang,
            string tenNhaCungCap, string moTaCauHinhThietBi, int soLuong)
        {
            this.maPhieuNhapHang = maPhieuNhapHang;
            this.ngayNhapHang = ngayNhapHang;
            this.tenNhaCungCap = tenNhaCungCap;
            this.moTaCauHinhThietBi = moTaCauHinhThietBi;
            this.soLuong = soLuong;
        }
        public abstract double GiaTriLoHang();
        public virtual string Print()
        {
            return $"Ma phieu nhap hang: {maPhieuNhapHang} - Ngay nhap hang: {ngayNhapHang.Xuat()} " +
                $"- Ten nha cung cap: {tenNhaCungCap}\nMo ta cau hinh thiet bi: {moTaCauHinhThietBi} - So luong: {soLuong}\n";
        }
    }
}
