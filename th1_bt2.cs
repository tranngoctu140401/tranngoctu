using System;
using System.IO;

namespace bai_2_BTH_1_lap_trinh_huong_doi_tuong
{
    class Employee
    {
        private int id = 1;
        private int yearOfBirth;
        private string name;
        private double salaryLevel,basicSalary;
        public void Nhap()
        {
            Console.Write("Nhap ten:");
            name = Console.ReadLine();
            Console.Write("Nam sinh:");
            yearOfBirth = int.Parse(Console.ReadLine());
            Console.Write("Bac luong:");
            salaryLevel = double.Parse(Console.ReadLine());
            Console.Write("Luong co ban:");
            basicSalary = double.Parse(Console.ReadLine());
        }
        public int getid()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getYearOfBirth()
        {
            return yearOfBirth;
        }
        public double getIncome()
        {
            return salaryLevel * basicSalary;
        }
        public void display()
        {
            Console.WriteLine("Id\tName\tNam sinh\tLuong co ban");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",id,name,basicSalary);
        }
    }
    class program
    {
        static void Main (string[] args)
        {
            Employee a = new Employee();
            a.Nhap();
            a.display();
            Console.ReadKey();
        }
    }
}
