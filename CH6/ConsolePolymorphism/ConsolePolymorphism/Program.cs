using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace ConsolePolymorphism
{
    class Employee1
    {
        public string Name { get; set; }
        protected int m_salary;
        public virtual int Salary
        {
            get { return m_salary; }
            set
            {
                if (value < 20000) m_salary = 20000;
                else if (value > 40000) m_salary = 40000;
                else m_salary = value;
            }
        }
    }

    class Manager1 : Employee1
    {
        public override int Salary
        {
            get { return m_salary; }
            set
            {
                if (value < 30000) m_salary = 30000;
                else if (value > 60000) m_salary = 60000;
                else m_salary = value;
            }
        }
        public int Bonus { get; set; }

        public void ShowTotal()
        {
            Console.WriteLine("{0} 經理的薪資：{1, 0:n0}元\n", Name, Salary);
            Console.WriteLine("{0} 經理的獎金：{1, 0:n0}元\n", Name, Bonus);
            Console.WriteLine("實領的薪資：{0, 0:n0}元", Salary + Bonus);
        }
    }

    class Employee2
    {
        public string Name { get; set; }
        protected int m_salary;
        public virtual int Salary
        {
            get { return m_salary; }
            set
            {
                if (value < 20000) m_salary = 20000;
                else if (value > 40000) m_salary = 40000;
                else m_salary = value;
            }
        }

        public virtual void ShowMe()
        {
            Console.WriteLine("{0} 員工薪資：{1}", Name, Salary.ToString("#,#"));
        }

        public virtual void ShowTotal()
        {
            Console.WriteLine("\n底薪：{0} 元", Salary.ToString("#,#"));
        }
    }

    class Manager2 : Employee2
    {
        public override int Salary
        {
            get { return m_salary; }
            set
            {
                if (value < 30000) m_salary = 30000;
                else if (value > 60000) m_salary = 60000;
                else m_salary = value;
            }
        }
        public int Bonus { get; set; }

        public override void ShowMe()
        {
            Console.WriteLine("{0} 經理薪資：{1}", Name, Salary.ToString("#,#"));
            Console.WriteLine("{0} 經理獎金：{1}", Name, Bonus.ToString("#,#"));
        }

        public override void ShowTotal()
        {
            base.ShowTotal();
            Console.WriteLine("\n薪水+獎金共：{0}元", (Salary + Bonus).ToString("#,#"));
        }
    }

    class Traffic
    {
        protected static int _miles;

        public virtual void SpeedUp()
        {

        }
    }

    class Car : Traffic
    {
        public override void SpeedUp()
        {
            _miles += 2;
            Console.WriteLine("駕駛車子，加速中，前進 {0} 公里", _miles);
        }
    }

    class Airplane : Traffic
    {
        public override void SpeedUp()
        {
            _miles += 15;
            Console.WriteLine("駕駛飛機，加速中，前進 {0} 公里", _miles);
        }
    }

    abstract class Cal
    {
        public int x { get; set; }
        public int y { get; set; }

        public abstract float Answer();
    }

    class CalAdd : Cal
    {
        public override float Answer()
        {
            return x + y;
        }
    }

    class CalSub : Cal
    {
        public override float Answer()
        {
            return x - y;
        }
    }

    class CalMul : Cal
    {
        public override float Answer()
        {
            return x * y;
        }
    }

    class CalDiv : Cal
    {
        public override float Answer()
        {
            return x / y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
        }

        private static void ConsolePolymorphism1()
        {
            Manager1 peter = new Manager1
            { Name = "Peter", Salary = 70000, Bonus = 30000 };
            peter.ShowTotal();

            Console.Read();
        }

        private static void ConsolePolymorphism2()
        {
            Employee2 tom = new Employee2 { Name = "Tom", Salary = 50000 };
            Manager2 peter = new Manager2 { Name = "Peter", Salary = 70000, Bonus = 30000 };

            tom.ShowMe();
            tom.ShowTotal();
            Console.WriteLine("======================\n");

            peter.ShowMe();
            peter.ShowTotal();

            Console.Read();
        }

        private static void ConsolePolymorphism3()
        {
            int choice;
            Traffic traffic;
            Car car = new Car();
            Airplane airplane = new Airplane();

            do
            {
                Console.Write("請問要駕駛 -> 1.車子    2.飛機    其他.離開：");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choice == 1) traffic = car;
                else if (choice == 2) traffic = airplane;
                else break;

                traffic.SpeedUp();
                Console.WriteLine("------------------------------\n");
            }
            while (choice == 1 || choice == 2);
        }

        private static void ConsolePolymorphism4()
        {
            Cal cal;
            CalAdd add = new CalAdd();
            CalSub sub = new CalSub();
            CalMul mul = new CalMul();
            CalDiv div = new CalDiv();
            int x, y, choice;
            float ans;

            try
            {
                Console.Write("請輸入 x = ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("請輸入 y = ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine();

                do
                {
                    Console.Write("請選擇計算方式 -> 1.加\t2.減\t3.乘\t4.除\t其他.離開：");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 1:
                            cal = add;
                            break;
                        case 2:
                            cal = sub;
                            break;
                        case 3:
                            cal = mul;
                            break;
                        case 4:
                            cal = div;
                            break;
                        default:
                            continue;
                    }

                    cal.x = x; cal.y = y; ans = cal.Answer();
                    Console.WriteLine("答案是 {0}", ans);
                    Console.WriteLine("------------------------------\n");
                }
                while (choice == 1 || choice == 2 || choice == 3 || choice == 4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }
}
