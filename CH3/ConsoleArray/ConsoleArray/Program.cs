using System;

namespace ConsoleArray
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void ConsoleAry()
        {
            string[] roleName = new string[] { "魯夫", "喬巴", "羅賓", "香吉士", "騙人布" };
            int[] money = new int[] { 300000000, 50, 78000000, 77000000, 30000000 };

            Console.WriteLine("== 草帽海賊團成員 ==\n");
            Console.WriteLine("姓名\t懸賞金額");
            Console.WriteLine("===================");

            for (int i = 0; i < roleName.Length; i++)
            {
                Console.WriteLine("{0}\t{1:n0}", roleName[i], money[i]);
            }

            Console.Read();
        }

        private static void ConsoleForEach()
        {
            int num;
            float sum = 0f;
            float[] heightAry;

            Console.Write("請輸入總人數：");
            num = int.Parse(Console.ReadLine());
            heightAry = new float[num];

            Console.WriteLine("\n");

            for (int i = 0; i < num; i++)
            {
                Console.Write("請輸入第 {0} 位身高(公分)：", i + 1);
                heightAry[i] = float.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            foreach (float height in heightAry)
                sum += height;
            Console.WriteLine("=== {0} 位平均身高：{1:f2}", num, sum / num);

            Console.Read();
        }

        private static void ShowArea(int r)
        {
            Console.WriteLine("\n半徑：{0:} 的圓面積：{1}", r, r * r * 3.14f);
        }
        private static void ConsoleAryForEach2()
        {
            int[] ary = new int[] { 2, 4, 6, 8 };
            Action<int> eachAction = new Action<int>(ShowArea);
            Array.ForEach(ary, eachAction);
            Console.Read();
        }

        private static void ConsoleSort1()
        {
            string[] roleName = new string[] { "魯夫", "喬巴", "羅賓", "香吉士", "騙人布" };
            int[] money = new int[] { 300000000, 50, 78000000, 77000000, 30000000 };

            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("== 草帽海賊團成員{0} ==\n", i == 0 ? "(遞增排序)" : "(遞減排序)");
                Console.WriteLine("姓名\t懸賞金額");
                Console.WriteLine("===================");

                if (i == 0)
                    Array.Sort(money, roleName);
                else
                {
                    Array.Reverse(money);
                    Array.Reverse(roleName);
                }
                for (int j = 0; j < roleName.Length; j++)
                {
                    Console.WriteLine("{0}\t{1:n0}", roleName[j], money[j]);
                }

                Console.WriteLine("\n");
            }

            Console.Read();
        }
    }
}
