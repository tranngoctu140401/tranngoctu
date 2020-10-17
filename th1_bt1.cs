using System;

namespace bai_TH2_Dev_huong_doi_tuong
{
    class Diem
    {
        private double x;
        private double y;
        public Diem() //khoi tao gia tri theo y nguoi lap trinh
        {
            x = y = 0;
        }
        public Diem(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.Write("Nhap x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y:");
            y = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("({0};{1})",x,y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Diem a = new Diem();
            a.Nhap();
            a.Hien();
        }
    }
}
