using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.ConsoleGuessNum();
        }

        private static void ConsoleIfElse1()
        {
            Console.Write("請輸入年齡：");
            int age = int.Parse(Console.ReadLine());

            if (age >= 10 && age <= 19)
                Console.WriteLine("你的年齡是{0}，是青少年", age);
            else
                Console.WriteLine("你的年齡是{0}，不是青少年", age);

            Console.Read();
        }

        private static void ConsoleIfElse3()
        {
            int n1, n2, n3 = 0;
            int max = 0;

            Console.Write("\n1. 請輸入第一個數值：");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("2. 請輸入第二個數值：");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("3. 請輸入第三個數值：");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 || n1 == n2)
            {
                if (n1 > n3 || n1 == n3) max = n1;
                else max = n3;
            }
            else
            {
                if (n2 > n3 || n2 == n3) max = n2;
                else max = n3;
            }

            Console.WriteLine("\n=== {0},{1},{2} 三數中最大值為：{3}", n1, n2, n3, max);
            Console.Read();
        }

        private static void ConsoleTest()
        {
            Console.WriteLine("題目：\n" +
            "試問 Visual Studio 可開發下列應用程式？\n" +
            "1.視窗程式 2.Web程式 3.裝置應用程式 4.以上皆是");

            string answer = null;
            Console.Write("\n請作答：");
            answer = Console.ReadLine();

            if (answer == "4")
                Console.WriteLine("\n=== 答對了，真不愧是 .NET 達人.....");
            else if (answer == "1" || answer == "2" || answer == "3")
                Console.WriteLine("\n=== 答錯了，正確答案是 4.");
            else
                Console.WriteLine("\n=== 無此選項......");

            Console.Read();
        }

        private static void ConsoleNum()
        {
            Console.Write("請輸入 1-9 任一個數字：");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("{0} 為奇數", i);
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("{0} 為偶數", i);
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

            Console.Read();
        }

        private static void ConsoleSwitch1()
        {
            Console.WriteLine("題目：\n" +
            "試問 Visual Studio 可開發下列應用程式？\n" +
            "1.視窗程式 2.Web程式 3.裝置應用程式 4.以上皆是");

            string answer = null;
            Console.Write("\n請作答：");
            answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                case "2":
                case "3":
                    Console.WriteLine("\n=== 答錯了，正確答案是 4.");
                    break;
                case "4":
                    Console.WriteLine("\n=== 答對了，真不愧是 .NET 達人.....");
                    break;
                default:
                    Console.WriteLine("\n=== 無此選項......");
                    break;
            }

            Console.Read();
        }

        private static void ConsoleTenary()
        {
            Console.Write(">>>>> 請輸入全年綜合所得淨額(元)：");
            double netIncome = int.Parse(Console.ReadLine());

            int stage = 0;
            double taxRate = 0;
            int discount = 0;
            double tax = 0;

            stage = netIncome < 0 ? 0 : (netIncome <= 520000 ? 1 :
                (netIncome <= 1170000 ? 2 : (netIncome <= 2350000 ? 3 :
                (netIncome <= 4400000 ? 4 : (netIncome <= 10000000 ? 5 : 6)))));

            switch (stage)
            {
                case 1:
                    taxRate = 0.05f;
                    discount = 0;
                    break;
                case 2:
                    taxRate = 0.12f;
                    discount = 36400;
                    break;
                case 3:
                    taxRate = 0.2f;
                    discount = 130000;
                    break;
                case 4:
                    taxRate = 0.3f;
                    discount = 365000;
                    break;
                case 5:
                    taxRate = 0.4f;
                    discount = 805000;
                    break;
                case 6:
                    taxRate = 0.45f;
                    discount = 1305000;
                    break;
                default:
                    taxRate = 0;
                    discount = 0;
                    break;
            }
            tax = Math.Abs(netIncome * taxRate - discount);

            Console.WriteLine();
            if (stage == 0)
            {
                Console.WriteLine("=== 全年所得淨額為負！不用繳稅...");
                Console.WriteLine("**** 無此距級 ****\n");
            }
            Console.WriteLine("== 1. 綜合淨所得：NT${0} 元", netIncome.ToString("#,#.00"));
            Console.WriteLine("== 2. 所得稅級距：第 {0} 級", stage);
            Console.WriteLine("== 3. 累進稅率：{0}", taxRate.ToString("#0.##%"));
            Console.WriteLine("== 4. 累進差額：NT${0} 元", discount.ToString("#0,#.00"));
            Console.WriteLine("== 5. 應繳稅額：NT${0} 元", tax.ToString("#0,#.00"));

            Console.Read();
        }

        private static void ConsoleFor1()
        {
            string ans = "best";

            for (int i = 1; i < 4; i++)
            {
                Console.Write(">>>>> 請輸入密碼（四個字元）：");
                if (ans == Console.ReadLine())
                {
                    Console.WriteLine("=== 登入成功，歡迎進入本系統！！！......");
                    break;
                }
                else
                {
                    Console.WriteLine("=== Sorry！密碼錯誤{0}次，請重新輸入...", i);
                    if (i == 3) Console.WriteLine("\n**** 非法進入！！！ ****");
                }
                Console.WriteLine();
            }

            Console.Read();
        }

        private static void ConsoleNextFor1()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("\t{0}", j);
                }
                Console.WriteLine();
            }

            Console.Read();
        }

        private static void ConsoleWhile1()
        {
            Console.Write("請由整數 1~50 中輸入一數字當因數：");
            int factor = int.Parse(Console.ReadLine());

            if (factor >= 1 && factor <= 50)
            {
                Console.WriteLine("\n== 求 1 到 100 能被 {0} 整除的因數 ==\n", factor);
                int num = 1;
                int count = 1;
                while (num <= 100)
                {
                    if (num % factor == 0)
                    {
                        Console.Write("\t{0},", num);
                        if (count % 5 == 0)
                            Console.WriteLine();
                        count++;
                    }
                    num++;
                }

                Console.WriteLine("\n\n=== 由 1 到 100 共有 {0} 個整數可被 {1} 整除！", count, factor);
            }
            else
                Console.WriteLine("\n=== 輸入的資料超出範圍 (1~50)! @_@......");

            Console.Read();
        }

        private static void ConsoleDoWhile()
        {
            Console.WriteLine("=== 程式語言設計成績試算 ===\n");

            int count = 0;
            int score = 0;
            int sum = 0;
            string ans;
            do
            {
                count++;
                Console.Write("{0}. 請輸入第 {0} 位同學成績：", count);
                score = int.Parse(Console.ReadLine());
                Console.Write("== 是否繼續？(Y/N)：");
                ans = Console.ReadLine();
                sum += score;
            }
            while (ans == "Y" || ans == "y");

            Console.WriteLine("\n== 共輸入 {0} 位同學成績，班上平均成績：{1}", count, sum / count);
            Console.Read();
        }

        private static void ConsoleBreakContinue()
        {
            int sum, upper, n; //sum為連加的總和，upper為臨界值，n為連加的終值
            sum = 0; n = 0;

            Console.WriteLine("== 求 1 + 2 + 3 + ...... + N <= Upper(臨界值)\n");
            Console.Write("1. 請輸入 Upper(臨界值)：");
            upper = int.Parse(Console.ReadLine());
            do
            {
                n++;
                if (sum <= upper)
                {
                    sum += n;
                    continue;
                }
                else
                {
                    sum -= n - 1;
                    n -= 2;
                    break;
                }
            } while (n > 0);
            Console.WriteLine("2. 電腦自動算出 N (終值)：{0}", n);
            Console.WriteLine("3. 1 + 2 + 3 + ...... + {0} = {1}", n, sum);
            Console.Read();
        }

        private static void ConsoleGuessNum()
        {
            Console.WriteLine("====== 猜數字遊戲 ======\n");

            int min, max, guess, count;
            min = 1; max = 99; count = 0;
            Random r = new Random();
            guess = r.Next(min, max + 1);

            do
            {
                count++;
                Console.Write("{0}. 猜數字範圍 {1} < ? < {2}：", count, min, max);
                int ans = int.Parse(Console.ReadLine());

                if (ans >= min && ans <= max)
                {
                    if (ans < guess)
                    {
                        Console.WriteLine("再大一點，您已經猜了 {0} 次......\n", count);
                        min = ans;
                        continue;
                    }
                    else if (ans > guess)
                    {
                        Console.WriteLine("再小一點，您已經猜了 {0} 次......\n", count);
                        max = ans;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\n^=^ 賓果！！！猜對了，共猜 {0} 次", count);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("X_X 請輸入提示範圍內的數字！------\n");
                    continue;
                }

            } while (count > 0);

            Console.Read();
        }
    }
}
