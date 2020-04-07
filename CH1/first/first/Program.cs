using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Product oldOne;
            oldOne.no = "TVGame001";
            oldOne.name = "Xbox One（含Kinect）";
            oldOne.price = 17200;

            Product newOne;
            Console.Write("請輸入產品編號：");
            newOne.no = Console.ReadLine();
            Console.Write("請輸入產品名稱：");
            newOne.name = Console.ReadLine();
            Console.Write("請輸入產品單價：");
            newOne.price = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("=====產品單價清單=====");
            Console.WriteLine("產品編號：{0}\n產品名稱：{1}\n產品單價：{2}",
                oldOne.no, oldOne.name, oldOne.price);
            Console.WriteLine("產品編號：{0}\n產品名稱：{1}\n產品單價：{2}",
                newOne.no, newOne.name, newOne.price);

            Console.Read();
        }

        private static void ConsoleEx1()
        {
            Console.Write("請輸入品名：");
            string productName = Console.ReadLine();
            Console.Write("請輸入單價：");
            int productPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("品名：{0}   單價：{1}  這筆紀錄儲存成功！", productName, productPrice);
            Console.Read();
        }

        private static void ConsoleFormat()
        {
            Console.WriteLine("1.以貨幣方式 C|c 顯示資料，以 NT$ 開頭 =====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0}/{1}/{2}", 1234, -1234, 123.4);
            Console.WriteLine("{0, 0:C}   {1, 0:C3}\n{2, 15:c3}\n{3, -15:c3}", 5, -5, -5, -5);
            Console.WriteLine();

            Console.WriteLine("2.以十進位方式 D|d 顯示資料，空白處補零 =====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0, 0:D5}\n{1, 10:D5}\n{2, -10:D5}", 25, 25, -25);
            Console.WriteLine();

            Console.WriteLine("3.以指數方式 E 顯示資料 =====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0, 0:e}\n{1, 0:e3}\n{2, 0:e3}\n{3, 20:e3}\n{4, -20:e3}",
                250000, 25000, 0.0012345, 25000, -25000);
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("3.以浮點數的方式 F|f 顯示資料 =====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0, 0:f}\n{1, 0:f0}\n{2, 0:f3}\n{3, 20:f3}\n{4, -20:f3}",
                12345, 12345, 12345, 12345, -12345);
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("4.以一般方式 G|g 顯示資料 =====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0, 0:g}\n{1, 0:g0}\n{2, 0:g3}\n{3, 20:g5}\n{4, -20:g3}",
                123.4567, 123.4567, 123.4555, 123.4567, -123.45);
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("5.以千位符號 N|n 顯示資料，不加$ =====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0, 0:n}\n{1, 0:n0}\n{2, 0:n1}\n{3, 20:n2}\n{4, -20:n2}",
                2500000, 2500000, 2500000, 2500000, 2500000, 2500000);
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("6.以16進制 X|x 顯示資料");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine("{0, 0:x}\n{1, 10:x}\n{2, -10:x}\n{3, 0:x4}\n{4, 0:x}",
                255, 255, 255, 12, 12);

            Console.Read();
        }

        private static void ConsoleToString()
        {
            double myvar1 = 0801234567;
            Console.WriteLine("1. " + myvar1.ToString("(0##) ###-####"));

            int myvar2 = -12345;
            Console.WriteLine("2. " + myvar2.ToString("######"));
            Console.WriteLine("3. " + myvar2.ToString("000000"));

            double myvar4 = -2.455;
            Console.WriteLine("4. " + myvar4.ToString("#.##"));

            double myvar5 = -2.4;
            Console.WriteLine("5. " + myvar5.ToString("0.00"));
            Console.WriteLine("6. " + myvar4.ToString("00.00"));

            double myvar7 = 1234567890;
            Console.WriteLine("7. " + myvar7.ToString("#,#"));
            Console.WriteLine("8. " + myvar7.ToString("#,"));
            Console.WriteLine("9. " + myvar7.ToString("#,,"));
            Console.WriteLine("10. " + myvar7.ToString("#,,,"));
            Console.WriteLine("11. " + myvar7.ToString("#,##0,,"));

            double myvar12 = 0.086;
            Console.WriteLine("12. " + myvar12.ToString("#0.##%"));

            double myvar13 = 0.08647;
            Console.WriteLine("13. " + myvar13.ToString("#0.##%"));

            double myvar14 = 16880;
            Console.WriteLine("14. " + myvar14.ToString("0.###E+0"));
            Console.WriteLine("15. " + myvar14.ToString("0.###E+000"));
            Console.WriteLine("16. " + myvar14.ToString("0.###E-000"));

            double myvar17 = 123456;
            Console.WriteLine("17. " + myvar17.ToString("[##-##-##]"));

            double myvar18 = 1234;
            Console.WriteLine("18. " + myvar18.ToString("##;(##)"));
            Console.WriteLine("19. " + myvar18.ToString("(##);##"));

            double myvar20 = -1234;
            Console.WriteLine("20. " + myvar20.ToString("##;(##)"));

            Console.Read();
        }

        private static void ConsoleEscSeq()
        {
            Console.WriteLine("12345678901234567890123456789012345678901234567890");
            Console.WriteLine("\t{0}\t{1}", "Everyone say: \"Hello World\"", "Wonderful");

            Console.Write("\nWelcome To VS 2017\n");
            Console.WriteLine("c:\\cs\\hw1.cs");
            Console.WriteLine(@"c:\cs\hw1.cs");

            Console.WriteLine("\n\nc:\\cs\\hw1.cs");
            Console.WriteLine("\n" + @"c:\cs\hw1.cs");

            Console.WriteLine("C# 2017 is cool !");
            Console.WriteLine("\"C# 2017 is cool !\"");

            Console.WriteLine("\u0041pple電腦");
            Console.Write("\\\u0061\n\nBegin:");

            Console.Read();
        }

        private static void ConsoleShift()
        {
            int n = 10;
            n = n << 1; //左移一位乘以2 n=10*2=20
            Console.WriteLine("n=n<<1 左移一位：{0}", n);

            n <<= 2; //左移兩位乘以4 n=20*4=80
            Console.WriteLine("n=n<<2 左移兩位：{0}", n);

            n = n >> 2; //右移兩位除以4 n=80/4=20
            Console.WriteLine("n=n>>2 右移兩位：{0}", n);

            n >>= 1; //右移一位除以2 n=20/2=10
            Console.WriteLine("n=n>>1 右移一位：{0}", n);
            Console.WriteLine();

            char c1 = '9';
            char c2 = '2';
            char c3 = '1';
            Console.WriteLine("原編碼訊息：" + c1 + c2 + c3);

            int key = 11;
            // c1 ^ key 進行位元運算之後，再將結果轉成字元並指定給 c1;
            c1 = (char)(c1 ^ key);
            c2 = (char)(c2 ^ key);
            c3 = (char)(c3 ^ key);
            Console.WriteLine("編碼後訊息：" + c1 + c2 + c3);

            c1 = (char)(c1 ^ key);
            c2 = (char)(c2 ^ key);
            c3 = (char)(c3 ^ key);
            Console.WriteLine("解碼後訊息：" + c1 + c2 + c3);

            Console.Read();
        }

        private enum WeekDays : int
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        private static void ConsoleEnum()
        {
            Console.WriteLine("星期三列舉常數值：{0}", (int)WeekDays.Wednesday);
            Console.WriteLine("星期五列舉常數值：{0}", (int)WeekDays.Friday);

            Console.Read();
        }

        private struct Product
        {
            public string no, name;
            public int price;
        }

        private static void ConsoleStruct()
        {
            Product oldOne;
            oldOne.no = "TVGame001";
            oldOne.name = "Xbox One（含Kinect）";
            oldOne.price = 17200;

            Product newOne;
            Console.Write("請輸入產品編號：");
            newOne.no = Console.ReadLine();
            Console.Write("請輸入產品名稱：");
            newOne.name = Console.ReadLine();
            Console.Write("請輸入產品單價：");
            newOne.price = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("=====產品單價清單=====");
            Console.WriteLine("產品編號：{0}\n產品名稱：{1}\n產品單價：{2}",
                oldOne.no, oldOne.name, oldOne.price);
            Console.WriteLine("產品編號：{0}\n產品名稱：{1}\n產品單價：{2}",
                newOne.no, newOne.name, newOne.price);

            Console.Read();
        }
    }
}
