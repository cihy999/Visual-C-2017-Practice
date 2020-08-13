using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleInherits
{
    class Employee
    {
        public string Name { get; set; }

        private int m_salary;
        public int Salary
        {
            get
            {
                return m_salary;
            }
            set
            {
                if (value < 20000) m_salary = 20000;
                else if (value > 40000) m_salary = 40000;
                else m_salary = value;
            }
        }
    }

    class Manager : Employee
    {
        public int Bonus { get; set; }

        public void ShowTotal()
        {
            Console.WriteLine("{0}經理薪水：{1}", Name, Salary.ToString("#,#"));
            Console.WriteLine("{0}經理獎金：{1}", Name, Bonus.ToString("#,#"));
            Console.WriteLine();
            Console.WriteLine("實領薪水：{0}", (Salary + Bonus).ToString("#,#"));
        }
    }

    class Car
    {
        public static int Total { get; set; }
        private int number;
        
        public Car()
        {
            Total++;
            number = Total;
        }

        public static void ShowTotalCars()
        {
            Console.WriteLine("現在共有 {0} 部車子", Total);
        }

        public void ShowMe(string name)
        {
            Console.WriteLine("{0} 是第 {1} 部車", name, number);
        }

        ~Car()
        {
            Total--;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleStaticMember();
        }

        private static void ConsoleInherits1()
        {
            Employee tom = new Employee { Name = "Tom", Salary = 50000 };
            Manager peter = new Manager { Name = "Peter", Salary = 50000, Bonus = 30000 };

            Console.WriteLine("{0}員工薪水：{1}", tom.Name, tom.Salary.ToString("#,#"));
            Console.WriteLine("==================");
            Console.WriteLine();
            peter.ShowTotal();

            Console.Read();
        }

        private static void ConsoleStaticMember()
        {
            Car.ShowTotalCars();
            Console.WriteLine("=====================\n");

            Car benz = new Car();
            benz.ShowMe("Benz");
            Car.ShowTotalCars();
            Console.WriteLine("=====================\n");

            Car bmw = new Car();
            bmw.ShowMe("BMW");
            Car ford = new Car();
            ford.ShowMe("Ford");
            Car.ShowTotalCars();
            Console.WriteLine("=====================\n");

            Car.ShowTotalCars();
            Console.WriteLine("=====================\n");

            Car myCar = bmw;
            myCar.ShowMe("MyCar");

            Console.Read();
        }
    }
}
