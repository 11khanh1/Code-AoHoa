using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khanh_HoNgoc
{
    class NhanVienKD: NhanVien
    {
        double doanhThuTT, doanhThu;

        public double DoanhThu
        {
            get { return doanhThu; }
            set { doanhThu = value; }
        }

        public double DoanhThuTT
        {
            get { return doanhThuTT; }
            set { doanhThuTT = value; }
        }
        public NhanVienKD()
        {
            DoanhThu = 1000000;
            DoanhThuTT = 800000;
        }
        public NhanVienKD(double doanhThuTT, double doanhThu, string ma, string ten, string gioiTinh, double heSL, int namVL)
            : base(ma, ten, gioiTinh, heSL, namVL)
        {
            this.DoanhThuTT = doanhThuTT;
            this.DoanhThu = doanhThu;
        }
        public override char xepLoai()
        {
            if (doanhThu < 0.5 * doanhThuTT)
                return 'D';
            if (doanhThu < doanhThuTT)
                return 'C';
            if (doanhThu < 2 * doanhThuTT)
                return 'B';
            return 'A';
        }
        public double hoaHong()
        {       
            double vuot = doanhThu - doanhThuTT;
            if (vuot > 0)
                return 0.15 * vuot;
            return 0;
        }
        public override double tinhLuong()
        {
            return HeSL * luongCB + hoaHong();
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap doanh thu:");
            DoanhThu = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap doanh thu TT:");
            DoanhThuTT = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Doanh Thu :" + doanhThu + "\nDoanh Thu TT:" + DoanhThuTT);
        }
    }
}
