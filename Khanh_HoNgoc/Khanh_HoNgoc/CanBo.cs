using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khanh_HoNgoc
{
    class CanBo : NhanVien
    {
        private string chucVu;

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
        private double hSPCCV;

        public double HSPCCV
        {
            get { return hSPCCV; }
            set { hSPCCV = value; }
        }
        public CanBo()
        {
            ChucVu = "Giam Doc";
            HSPCCV = 0.5;
        }
        public CanBo(string chucVu,double hSPCCV,string ma,string ten,string gioiTinh,double heSL,int namVL): base(ma,ten,gioiTinh,heSL,namVL)
        {
            this.ChucVu = chucVu;
            this.HSPCCV = hSPCCV;
        }
        public override char xepLoai()
        {
            return 'A';
        }
        public double phuCCV()
        {
            return 1100 * hSPCCV;
        }
        public override double tinhLuong()
        {
            return HeSL * luongCB + phuCCV();
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap chuc vu:");
            ChucVu = Console.ReadLine();
            Console.WriteLine("He SPCCV:");
            HSPCCV = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Chuc vu:" + ChucVu + "\nHe SPCCV:" + HSPCCV);
        }
    }
}
