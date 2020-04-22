using System;

namespace ConsoleInterface
{
    interface IFly
    {
        void Fly(int n);
    }

    class Car : IFly
    {
        public void SpeedUp()
        {

        }

        public void Fly(int n)
        {
            Console.WriteLine("車子飛上天前進 {0} 公里", n);
        }
    }

    class Bird : IFly
    {
        public void Eat()
        {

        }

        public void Fly(int n)
        {
            Console.WriteLine("小鳥飛上天前進 {0} 公里", n);
        }
    }

    class Vector1 : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector1()
        {
            X = 0;
            Y = 0;
        }

        public Vector1(int x, int y)
        {
            X = x;
            Y = y;
        }

        int IComparable.CompareTo(object obj)
        {
            Vector1 v = (Vector1)obj;
            return (X * X + Y * Y) - (v.X * v.X + v.Y * v.Y);
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
    }

    interface IMyComparable
    {
        int MyComparableTo(object obj);
    }

    class MyArray
    {
        public static void MySort(IMyComparable[] objs)
        {
            for (int i = 0; i < objs.Length - 1; i++)
            {
                for (int j = i; j < objs.Length; j++)
                {
                    IMyComparable temp;

                    if (objs[i].MyComparableTo(objs[j]) > 0)
                    {
                        temp = objs[i];
                        objs[i] = objs[j];
                        objs[j] = temp;
                    }
                }
            }
        }
    }

    class Vector2 : IMyComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2()
        {
            X = 0;
            Y = 0;
        }

        public Vector2(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        int IMyComparable.MyComparableTo(object obj)
        {
            Vector2 v = (Vector2)obj;
            return (X * X + Y * Y) - (v.X * v.X + v.Y * v.Y);
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void ConsoleInterface1()
        {
            IFly car = new Car();
            IFly bird = new Bird();

            car.Fly(30);
            Console.WriteLine();
            bird.Fly(5);

            Console.Read();
        }

        private static void ConsoleInterface2()
        {
            Vector1[] vecArray = new Vector1[]
{
                new Vector1(20, 10),
                new Vector1(50, 20),
                new Vector1(90, 40),
                new Vector1(10, 10),
                new Vector1(40, 30)
};

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.Write("1.排序前：");
                }
                else
                {
                    Array.Sort(vecArray);
                    Console.Write("2.排序後：");
                }

                for (int j = 0; j < vecArray.Length; j++)
                    Console.Write("{0} ", vecArray[j]);
                Console.WriteLine("\n");
            }

            Console.Read();
        }

        private static void ConsoleInterface3()
        {
            Vector2[] vecArray = new Vector2[]
            {
                new Vector2(20, 10),
                new Vector2(50, 20),
                new Vector2(90, 40),
                new Vector2(10, 10),
                new Vector2(40, 30)
            };

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.Write("1.排序前：");
                }
                else
                {
                    MyArray.MySort(vecArray);
                    Console.Write("2.排序後：");
                }

                for (int j = 0; j < vecArray.Length; j++)
                    Console.Write("{0} ", vecArray[j]);
                Console.WriteLine("\n");
            }

            Console.Read();
        }
    }
}
