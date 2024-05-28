using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class NgayThangNam
    {
        int ngay;
        int thang;
        int nam;
        public int Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }
        public int Nam
        {
            get { return nam; }
            set { nam = value; }
        }
        public NgayThangNam()
        {
            ngay = 1;
            thang = 1;
            nam = 1900;
        }
        public NgayThangNam(int ngay, int thang, int nam)
        {
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
        }
        public string Xuat()
        {
            return $"{ngay}/{thang}/{nam}";
        }
    }
}
