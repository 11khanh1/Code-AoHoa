using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khanh_HoNgoc
{
    class NhanVienSX : NhanVien
    {
        private int soNN;
        static double hSPCNN = 0.1;
        public override char xepLoai()
        {
            if (SoNN <= 1)
                return 'A';
            if (SoNN <= 3)
                return 'B';
            if (SoNN <= 5)
                return 'C';
            return 'D';
        }
        public NhanVienSX()
        {
            soNN = 1;
        }
        public NhanVienSX(int soNN, string ma, string ten, string gioiTinh, double heSL, int namVL)
            : base(ma, ten, gioiTinh, heSL, namVL)
        {
            this.soNN = soNN;
        }

        public override double tinhLuong()
        {
            return HeSL * luongCB * (1 + hSPCNN);
        }

        public override void xuat()
        {
            
            base.xuat();
            Console.WriteLine("So ngay nghi:" + soNN);
        }
    }
}
