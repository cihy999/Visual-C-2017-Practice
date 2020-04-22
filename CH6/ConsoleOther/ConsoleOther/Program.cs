using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleOther
{
    delegate bool CompareFunc(int x, int y);

    class MyArray
    {
        public static void MySort(int[] nums, CompareFunc compareMethod)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    int temp;
                    if (compareMethod(nums[i], nums[j]))
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }

        public static bool IsSmaller(int x, int y)
        {
            return x < y;
        }

        public static bool IsBigger(int x, int y)
        {
            return x > y;
        }
    }

    class Member
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void ConsoleDelegate()
        {
            int[] nums = new int[] { 32, 34, 12, 54, 21 };

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.Write("由小到大排序：");
                    MyArray.MySort(nums, MyArray.IsBigger);
                }
                else
                {
                    Console.Write("由大到小排序：");
                    MyArray.MySort(nums, MyArray.IsSmaller);
                }

                for (int j = 0; j < nums.Length; j++)
                    Console.Write("{0}, ", nums[j]);
                Console.WriteLine("\n");
            }

            Console.Read();
        }

        private static void ConsoleGenerics1()
        {
            List<int> listInt = new List<int>();
            List<Member> listMember = new List<Member>();

            listInt.Add(123);
            listInt.Add(789);
            listInt.Insert(1, 456);
            Console.WriteLine("=== int整數串列 ===");
            for (int i = 0; i < listInt.Count; i++)
                Console.WriteLine("listInt[{0}]={1}", i, listInt[i]);

            Console.WriteLine("\n");

            listMember.Add(new Member { ID = "M01", Name = "小明" });
            listMember.Add(new Member { ID = "M02", Name = "小美" });
            listMember.Add(new Member { ID = "M03", Name = "阿龍" });
            listMember.RemoveAt(1);
            Console.WriteLine("=== Member會員串列 ===");
            for (int i = 0; i < listMember.Count; i++)
            {
                Console.WriteLine("listMember[{0}]=>帳號：{1}, 姓名：{2}",
                    i, listMember[i].ID, listMember[i].Name);
            }

            Console.Read();
        }
    }
}
