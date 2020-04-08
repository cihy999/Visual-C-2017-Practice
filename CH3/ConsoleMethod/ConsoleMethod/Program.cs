using System;

namespace ConsoleMethod
{
    class Class1
    {
        public static string GetWelcome(string username, bool isMale)
        {
            string welcome = username + (isMale ? "先生" : "小姐") + "，歡迎光臨！\n";

            return welcome;
        }
    }

    class Class2
    {
        public string GetWelcome(string username, bool isMale)
        {
            string welcome = username + (isMale ? "先生" : "小姐") + "，歡迎光臨！\n";

            return welcome;
        }
    }

    class SumCollection
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public static string Sum(string a, string b)
        {
            return a + b;
        }

        public static string Sum(string a, string b, string c)
        {
            return a + b + c;
        }
    }

    class Class3
    {
        private static int age = 25;
        public static string name = "陳春嬌";
    }

    class Program
    {
        private static int age = 25;
        private static string name = "王志明";

        static void Main(string[] args)
        {
            Console.WriteLine("Program類別靜態變數的資訊-->{0}的年齡為{1}歲", name, age);
            Console.WriteLine("Class3類別靜態變數的資訊-->{0}的年齡無法取得",Class3.name);
            Console.Read();
        }

        private static void Login(string username, bool isMale)
        {
            Console.WriteLine("{0} {1}，歡迎光臨！\n", username, isMale ? "先生" : "小姐");
        }
        private static void ConsoleMethod1()
        {
            Login("Jack Wu", true); //Call by Value 傳值呼叫
            Login("Mary Lin", false);
            Console.Read();
        }

        private static string GetWelcome(string username, bool isMale)
        {
            string welcome = username + (isMale ? "先生" : "小姐") + "，歡迎光臨！\n";

            return welcome;
        }
        private static void ConsoleMethod2()
        {
            Console.WriteLine(GetWelcome("Jack Wu", true));
            Console.WriteLine(GetWelcome("Mary Lin", false));
            Console.Read();
        }

        private static void ConsoleMethod3()
        {
            Console.WriteLine(Class1.GetWelcome("Jack Wu", true));
            Console.WriteLine(Class1.GetWelcome("Mary Lin", false));
            Console.Read();
        }

        private static void ConsoleMethod4()
        {
            Class2 instance = new Class2();

            Console.WriteLine(instance.GetWelcome("Jack Wu", true));
            Console.WriteLine(instance.GetWelcome("Mary Lin", false));
            Console.Read();
        }

        private static void CallValue(int x, int y)
        {
            int z;
            x = 33; y = 66;
            Console.WriteLine("2.方法內交換前\t\t\t：x={0}\ty={1}\n", x, y);

            z = x;
            x = y;
            y = z;
            Console.WriteLine("3.方法內交換後\t\t\t：x={0}\ty={1}\n", x, y);
        }
        private static void ConsoleByVal()
        {
            int a = 50, b = 80;

            Console.WriteLine("**** Call By Value 傳值呼叫 ****\n");
            Console.WriteLine("1.呼叫敘述 未進入方法前\t\t：a={0}\tb={1}\n", a, b);
            CallValue(a, b);
            Console.WriteLine("4.呼叫敘述 離開方法回原處時\t：a={0}\tb={1}\n", a, b);
            Console.Read();
        }

        private static void CallRef(ref int x, ref int y)
        {
            int z;
            x = 20; y = 30;
            Console.WriteLine("2.方法內交換前\t\t\t：x={0}\ty={1}\n", x, y);

            z = x;
            x = y;
            y = z;
            Console.WriteLine("3.方法內交換後\t\t\t：x={0}\ty={1}\n", x, y);
        }
        private static void ConsoleByRef()
        {
            int a = 10, b = 12;

            Console.WriteLine("**** Call By Reference 參考呼叫 ****\n");
            Console.WriteLine("1.呼叫敘述 未進入方法前\t\t：a={0}\tb={1}\n", a, b);
            CallRef(ref a, ref b);
            Console.WriteLine("4.呼叫敘述 離開方法回原處時\t：a={0}\tb={1}\n", a, b);
            Console.Read();
        }

        private static void CallOut(out int x, out int y)
        {
            int z;
            x = 20; y = 30;
            Console.WriteLine("2.方法內交換前\t\t\t：x={0}\ty={1}\n", x, y);

            z = x;
            x = y;
            y = z;
            Console.WriteLine("3.方法內交換後\t\t\t：x={0}\ty={1}\n", x, y);
        }
        private static void ConsoleOutput()
        {
            int a, b;

            Console.WriteLine("**** Call Ot 傳出參數 ****\n");
            Console.WriteLine("1.呼叫敘述 未進入方法前 a 和 b 未設定初值\n");
            CallOut(out a, out b);
            Console.WriteLine("4.呼叫敘述 離開方法回主程式\t：a={0}\tb={1}\n", a, b);
            Console.Read();
        }

        private static int GetMax(int[] ary)
        {
            //會改變Array的方式
            //Array.Sort(ary);
            //Array.Reverse(ary);

            //不改變Array的方式
            int index = 0, max = ary[0];
            for (int i = 0; i < ary.Length; i++)
            {
                if (i + 1 >= ary.Length) break;

                if (max <= ary[i + 1])
                {
                    index = i + 1;
                    max = ary[i + 1];
                }
            }

            return max;
        }
        private static void ConsoleGetMax()
        {
            int[] ary = new int[] { 12, 15, 38, 21, 25 };

            Console.WriteLine("=== 陣列元素如下 ===\n");
            for (int i = 0; i < ary.Length; i++) Console.Write("{0},\t", ary[i]);
            Console.WriteLine("\n");

            Console.WriteLine("陣列最大值：{0}", GetMax(ary));
            Console.Read();
        }

        private static void ConsoleOverloads()
        {
            Console.WriteLine("sum({0}, {1}) = {2}\n", 10, 20, SumCollection.Sum(10, 20));
            Console.WriteLine("sum({0}, {1}, {2}) = {3}\n", 10, 20, 30, SumCollection.Sum(10, 20, 30));
            Console.WriteLine("sum({0}, {1}) = {2}\n", "\"Good \"", "\"Day.\"", SumCollection.Sum("Good ", "Day."));
            Console.WriteLine("sum({0}, {1}, {2}) = {3}\n", "\"Good \"", "\"Luck \"", "\"To You!\"", SumCollection.Sum("Good ", "Luck ", "To You!"));
            Console.Read();
        }
    }
}
