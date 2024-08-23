using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Khanh_HoNgoc
{
    abstract public class NhanVien
    {
        public string ma, ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public int namVL, SoNN;



        public int NamVL
        {
            get { return namVL; }
            set { namVL = value; }
        }
        private double heSL;


        public double HeSL
        {
            get { return heSL; }
            set { heSL = value; }
        }
        protected static double luongCB = 1150;

        public NhanVien()
        {
            ma = "NV001";
            Ten = "Ho Ngoc Khanh";
            GioiTinh = "Nam";
            NamVL = 2021;
            heSL = 3.15;
        }


        public NhanVien(string ma,string ten,string gioiTinh,double heSL,int namVL)
        {
            this.Ten = ten;
            this.Ma = ma;
            this.GioiTinh = gioiTinh;
            this.HeSL = heSL;
            this.NamVL = namVL;
        }
        public double phuCTN()
        {
            int tn = DateTime.Today.Year - namVL;
            if (tn >= 5)
                return tn * luongCB - namVL;
            return 0;
        }
        abstract public char xepLoai();
        abstract public double tinhLuong();
        public double thuNhap()
        {
            char xl = xepLoai();
            double hsTD = 0;
            if (xl == 'A')
                hsTD = 1.0;
            if (xl == 'B')
                hsTD = 0.75;
            if (xl == 'C')
                hsTD = 0.5;
            return hsTD * tinhLuong() + phuCTN();
        }
        public virtual void nhap()
        {
            Console.WriteLine("Ma nhan vien:");
            Ma = Console.ReadLine();
            Console.WriteLine("Ten nhan vien:");
            Ten = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh:");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap he so luong:");
            HeSL = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam vao lam:");
            NamVL = int.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("-----Thong Tin Nhan Vien----\n");
            Console.WriteLine("Ma nhan vien:" + ma + "\nTen nhan vien:" + Ten + "\nGioi tinh :" + GioiTinh + "\nHe so luong:" + HeSL + "\nNam vao lam:" + NamVL + "\nSo ngay nghi:" + SoNN + "\nXep Loai:" + xepLoai() + "\nThu nhap:" + thuNhap());
        }
      

    }
}
