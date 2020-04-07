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

        private static void ConsoleAmount()
        {
            int[][] amt = new int[3][];
            amt[0] = new int[] { 1100, 2200, 3300 };
            amt[1] = new int[] { 1500, 2500 };
            amt[2] = new int[] { 1000, 2000, 3000, 4000 };
            float[] sum = new float[3];
            float total = 0;

            Console.WriteLine("\t第一處\t第二處\t第三處\t第四處\t(單位：千元)");
            for (int i = 0; i < amt.Length; i++)
            {
                for (int j = 0; j < amt[i].Length; j++)
                {
                    Console.Write("\t{0}", amt[i][j]);
                    sum[i] += amt[i][j] * 1000;
                }
                total += sum[i];
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            Console.WriteLine("台北分公司營運額：{0:c}元\t營業率：{1}", sum[0], (sum[0] / total).ToString("##.##%"));
            Console.WriteLine("台中分公司營運額：{0:c}元\t營業率：{1}", sum[1], (sum[1] / total).ToString("##.##%"));
            Console.WriteLine("高雄分公司營運額：{0:c}元\t營業率：{1}", sum[2], (sum[2] / total).ToString("##.##%"));

            Console.WriteLine("\n總營業額：{0:c}元", total);
            Console.Read();
        }
    }
}
