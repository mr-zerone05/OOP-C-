
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp
{
    public class phanSo
    {
        // thuoc tinh cua phan so
        private int ts;
        private int ms;
        // phuong thuc
        // 1 kiem tra rang buoc
        public bool kiemTraMauSo(int m)
        {
            return (m != 0);
        }
        // 2 khoi tao
        // 2.1 khoi tao phan so co mau la 0/1
        public void khoiTao()
        {
            ts = 0;
            ms = 1;
        }
        // 2.2 khoi tao phan so co tu va mau cho truoc
        public void khoitao(int t, int m)
        {
            if (kiemTraMauSo(m))
            {
                ts = t;
                ms = m;
            }
            else
            {
                ts = 0;
                ms = 1;
            }
        }
        // 2.3 khoi tao phan so bang 1 phan so da co
        public void khoiTao(phanSo p)
        {
            ts= p.ts;
            ms = p.ms;  
        }
        // 3 cap nhat phan so
        public void ganTuso(int t)
        {
            ts = t;
        }
        public void ganMauSo(int m)
        {
            if (kiemTraMauSo(m))
            {
                ms = m;
            }
        }
        // 4 xu li tinh toan
        public void Nhap()
        {
            Console.Write("nhap tu so: ");
            ts = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("nhap mau so:");
                ms = int.Parse(Console.ReadLine());
            }
            while (ms == 0);
        }


        public void Xuat()
        {
            Console.WriteLine(ts + "/" + ms);
        }


        // 5 cung cap thong tin
        public int DocTuSo() { return ts; }
        public int DocMauSo() { return ms; }

    }
    class Program
    {
       
     
        static void Main(string[] args)
        {
            // khai bao 
            phanSo a, b, t;
            // tao doi tuong 
            a = new phanSo();
            b = new phanSo();
            t = new phanSo();
            Console.WriteLine("nhap phan so thu nhat");
            a.Nhap();
            Console.WriteLine(" nhap phan so thu hai");
            b.Nhap();
            t.ganTuso(a.DocTuSo()*b.DocTuSo());
            t.ganMauSo(a.DocMauSo()*b.DocMauSo());
            Console.WriteLine("Tich: ");
            t.Xuat();
            Console.WriteLine();

        }
    }
}