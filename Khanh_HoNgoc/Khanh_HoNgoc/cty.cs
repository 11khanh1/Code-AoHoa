using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Khanh_HoNgoc
{
    class cty
    {
        List<NhanVien> lst = new List<NhanVien>();

        public string Tencty;
        public List<NhanVien> Lst
        {
            get { return lst; }
            set { lst = value; }
        }

        public void nhap(string file)
        {
            string a, b, c,j;
            int d, e;
            double f,g,h,k;
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNode n = read.SelectSingleNode("/cty");
            Tencty = n["tencty"].InnerText;
            XmlNodeList nodelist = read.SelectNodes("cty/dsnv/nv");
            foreach (XmlNode node in nodelist)
            {
                NhanVien nv = new NhanVienSX();
                int loai = int.Parse(node.Attributes["loai"].Value);
                a = node["ma"].InnerText;
                b = node["ten"].InnerText;
                c = node["gt"].InnerText;
                d = int.Parse(node["namVL"].InnerText);
                f = double.Parse(node["hSL"].InnerText);

                if (loai == 1)
                {
                    e = int.Parse(node["soNN"].InnerText);
                    nv = new NhanVienSX(e, a, b, c, f, d);
                }
                if (loai == 2)
                {
                    g = double.Parse(node["dt"].InnerText);
                    h = double.Parse(node["dttt"].InnerText);
                    nv = new NhanVienKD(h, g, a, b, c, f, d);
                }
                if (loai == 3)
                {
                    j = node["cv"].InnerText;
                    k = double.Parse(node["hspccv"].InnerText);
                    nv = new CanBo(j, k, a, b, c, f, d);

                }
                lst.Add(nv);
            }
        }

        public double TinhTongLuongCty()
        {
            return Lst.Sum(nv => nv.tinhLuong());
        }

        public List<NhanVien> GetNhanVienCoHeSoLuong4_34()
        {
            return Lst.Where(nv => nv.HeSL > 4.34).ToList();
        }
        public void xuat()
        {
            Console.WriteLine("Danh sach nhan vien:");
            foreach (NhanVien nv in lst)
                nv.xuat();
            
        }
    }
}
