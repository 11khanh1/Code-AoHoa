using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Khanh_HoNgoc
{
    class Program
    {
        static void Main(string[] args)
        {
            cty cty = new cty();
            cty.nhap("../../CongTy.xml");
            //cty.xuat();


            Console.WriteLine("Tong So tien luong:" + cty.TinhTongLuongCty());

            Console.WriteLine("Nhan vieen co he so luong 4.34:");
            var nvc = cty.GetNhanVienCoHeSoLuong4_34();
            foreach (var t in nvc)
            {
                t.xuat();
            }
            Console.ReadLine();
            
        }
    }
}
