using System;

namespace IBM
{
    class Notebook
    {
        public void Say()
        {
            Console.WriteLine("Hi, 我是 IBM 的筆電！");
        }
    }

    namespace Taiwan
    {
        class Notebook
        {
            public void Say()
            {
                Console.WriteLine("Hi, 我是來自台灣的 IBM 筆電！");
            }
        }
    }

    namespace Japan
    {
        class Notebook
        {
            public void Say()
            {
                Console.WriteLine("Hi, 我是來自日本的 IBM 筆電！");
            }
        }
    }
}

namespace Apple
{
    class Notebook
    {
        public void Say()
        {
            Console.WriteLine("Hi, 我是 Apple 的筆電！");
        }
    }
}

namespace ConsoleClass
{
    class MyFirstClass
    {
        public void Say()
        {
            Console.WriteLine("物件A 已建立完成！！\n請按 <Enter>鍵 結束...");
        }
    }

    class Car1
    {
        public int speed;
    }

    class Car2
    {
        private int _speed;

        public int GetSpeed()
        {
            return _speed;
        }

        public void SetSpeed(int vSpeed)
        {
            if (vSpeed < 0) vSpeed = 0;
            else if (vSpeed > 200) vSpeed = 200;

            _speed = vSpeed;
        }
    }

    class Car3
    {
        private int _speed = 0;
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value < 0) value = 0;
                else if (value > 200) value = 200;

                _speed = value;
            }
        }

        private int _angle = 10;
        public int Angle
        {
            get { return _angle; }
        }

        private bool _turbo = false;
        public bool Turbo
        {
            set { _turbo = value; }
        }

        public void Accelerate()
        {
            Speed++;
        }

        public void Accelerate(int addSpeed)
        {
            Speed += addSpeed;
        }

        public void Accelerate(string action)
        {
            if (action == "Stop")
            {
                Speed = 0;
            }
        }
    }

    class Student1
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }

    class Student2
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public Student2()
        {
            Height = 160;
            Weight = 48;
        }

        public Student2(int w)
        {
            Height = 160;
            Weight = w;
        }

        public Student2(int w, int h)
        {
            Height = h;
            Weight = w;
        }
    }

    class Car4
    {
        public int Speed { get; set; }

        public Car4()
        {
            Speed = 4;
        }

        public Car4(int v)
        {
            Speed = v;
        }

        ~Car4()
        {
            Console.WriteLine("車子物件消滅了......");
        }
    }

    class Member
    {
        public string Id { set; get; }
        public string Pwd { set; get; }
        public string Name { set; get; }
        public string Tel { set; get; }
        public string Andress { set; get; }

        public void Self_Intro()
        {
            Console.WriteLine("帳號設定為 {0}, 密碼：{1}, 姓名為 {2}, 電話：{3}, 地址：{4}\n", Id, Pwd, Name, Tel, Andress);
        }
    }

    delegate void DangerEvent(int vSpeed); //宣告 delegate 型別
    class Car5
    {
        public event DangerEvent danger; //宣告事件
        private int _speed = 0;
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value > 200)
                    if (danger != null) danger(value); //啟動事件
            }
        }
    }

    class Stack
    {
        private int[] _aryData;
        private int _top;

        public Stack(int n)
        {
            _aryData = new int[n];
            _top = 0;
        }

        public void Push(int n)
        {
            if (_top == _aryData.Length)
            {
                Console.WriteLine("\n==> 堆疊滿了！......\n");
                return;
            }
            else
            {
                _aryData[_top] = n;
                _top++;
                Console.WriteLine("\n==> 壓入 {0} 到推疊內......\n", n);
            }
        }

        public void Pop()
        {
            if (_top == 0)
            {
                Console.WriteLine("\n==> 堆疊空了！......\n");
                return;
            }
            else
            {
                _top--;
                Console.WriteLine("\n==> 堆疊彈出資料：{0}\n", _aryData[_top]);
            }
        }

        public void PrintStack()
        {
            if (_top == 0)
            {
                Console.WriteLine("\n==> 堆疊內沒有資料！......\n");
                return;
            }
            else
            {
                Console.Write("\n==> 顯示堆疊內容：");
                for (int i = 0; i < _top; i++) Console.Write("{0} ", _aryData[i]);
                Console.WriteLine("\n");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void Draw(int vType)
        {
            switch (vType)
            {
                case 0:
                    Console.WriteLine("畫{0}！", "圓");
                    break;
                case 1:
                    Console.WriteLine("畫{0}！", "線");
                    break;
                case 2:
                    Console.WriteLine("畫{0}！", "圓弧");
                    break;
                default:
                    Console.WriteLine("X_X 畫不出來！");
                    break;
            }
        }
        private static void ConsoleAbstractionDemo1()
        {
            Draw(0);
            Draw(1);
            Draw(2);
            Console.Read();
        }

        private enum Shape : int
        {
            Circle = 0,
            Line = 1,
            Arc = 2
        }
        private static void Draw(Shape vType)
        {
            switch (vType)
            {
                case Shape.Circle:
                    Console.WriteLine("畫{0}！", "圓");
                    break;
                case Shape.Line:
                    Console.WriteLine("畫{0}！", "線");
                    break;
                case Shape.Arc:
                    Console.WriteLine("畫{0}！", "圓弧");
                    break;
                default:
                    Console.WriteLine("X_X 畫不出來！");
                    break;
            }
        }
        private static void ConsoleAbstractionDemo2()
        {
            Draw(Shape.Circle);
            Draw(Shape.Line);
            Draw(Shape.Arc);
            Console.Read();
        }

        private static void ConsoleMyFirstClass()
        {
            Console.WriteLine("建立一個屬於 MyFirstClass 類別的物件A");
            MyFirstClass myFirst = new MyFirstClass();
            myFirst.Say();
            Console.Read();
        }

        private static void ConsoleNamespace()
        {
            IBM.Notebook notebook1 = new IBM.Notebook();
            Apple.Notebook notebook2 = new Apple.Notebook();

            notebook1.Say();
            notebook2.Say();

            Console.Read();
        }

        private static void ConsoleSubNamespace()
        {
            IBM.Taiwan.Notebook notebook1 = new IBM.Taiwan.Notebook();
            IBM.Japan.Notebook notebook2 = new IBM.Japan.Notebook();

            notebook1.Say();
            notebook2.Say();

            Console.Read();
        }

        private static void ConsoleProperty1()
        {
            Car1 Benz = new Car1();
            Benz.speed = 100;
            Console.WriteLine("Benz.speed = {0}", Benz.speed);
            Console.Read();
        }

        private static void ConsoleAccessor1()
        {
            Car2 Benz = new Car2();
            Benz.SetSpeed(500);
            Console.WriteLine("Benz.GetSpeed() = {0}", Benz.GetSpeed());
            Console.Read();
        }

        private static void ConsoleProperty2()
        {
            Car3 Benz = new Car3();
            Benz.Speed = 500;
            Console.WriteLine("Benz.Speed = {0}", Benz.Speed);
            Console.Read();
        }

        private static void ConsoleProperty3()
        {
            Car3 Benz = new Car3();
            Console.WriteLine("Benz.Angle = {0}", Benz.Angle);
            Console.Read();
        }

        private static void ConsoleProperty4()
        {
            Car3 Benz = new Car3();
            Benz.Turbo = true;
        }

        private static void ConsoleCallPropertyFunction1()
        {
            Car3 Benz = new Car3();
            Benz.Speed = 199;

            Console.WriteLine("1. 現在速度：{0}\t加速", Benz.Speed);
            Benz.Accelerate();
            Console.WriteLine("2. 現在速度：{0}\t加速", Benz.Speed);
            Benz.Accelerate();
            Console.WriteLine("3. 現在速度：{0}", Benz.Speed);
            Console.Read();
        }

        private static void ConsoleOverloading1()
        {
            Car3 Benz = new Car3();
            Console.WriteLine("1. 現在速度：{0}\t加速 {1} ...", Benz.Speed, 1);
            Benz.Accelerate();
            Console.WriteLine("2. 現在速度：{0}\t加速 {1} ...", Benz.Speed, 10);
            Benz.Accelerate(10);
            Console.WriteLine("3. 現在速度：{0}\t停車 ...", Benz.Speed);
            Benz.Accelerate("Stop");
            Console.WriteLine("4. 現在速度：{0}", Benz.Speed);
            Console.Read();
        }

        private static void ConsoleConstructor1()
        {
            Student2[] students = new Student2[]
            {
                new Student2(){ Name= "Peter"},
                new Student2(56){ Name = "David"},
                new Student2(48, 150){ Name = "Mary"},
            };
            string[] constructorUsing = new string[]
            {
                "使用Student()建構式", "使用Student(56)建構式", "使用Student(48, 150)建構式",
            };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("{0} 的資料-->{1}", students[i].Name, constructorUsing[i]);
                Console.WriteLine("身高是 {0}\n體重是 {1}", students[i].Height, students[i].Weight);
                Console.WriteLine();
            }

            Console.Read();
        }

        private static void ConstructorDestructor()
        {
            Console.WriteLine("進入程序，並宣告 BMW 物件...\n");
            Car4 BMW = new Car4();
            Console.WriteLine("初始化後速度 = {0}\n", BMW.Speed);
            Console.WriteLine("BMW 物件宣告完成，準備離開方法...\n");
            Console.WriteLine("宣告 Benz 物件...\n");
            Car4 Benz = new Car4(0);
            Console.WriteLine("初始化後速度 = {0}\n", BMW.Speed);
            Console.WriteLine("Benz 物件宣告完成...\n");
            Console.WriteLine("準備執行 Benz = null ...\n");
            Benz = null;
            Console.WriteLine("Benz = null 執行完成！！\n");
            GC.Collect();
            Console.Read();
        }

        private static void ConsoleInitializer()
        {
            Member Jasper = new Member { Id = "Jasper" };
            Member Anita = new Member { Id = "Anita", Pwd = "123", Name = "愛尼塔" };
            Member Aliya = new Member { Id = "Aliya", Pwd = "456", Name = "愛麗雅", Andress = "台北市忠山路1號", Tel = "02-22551133" };

            Jasper.Self_Intro();
            Anita.Self_Intro();
            Aliya.Self_Intro();

            Console.Read();
        }

        private static void TooFast(int speed)
        {
            Console.WriteLine("你目前的速度是 {0}，超過 200，請減速！！！", speed);
        }
        private static void ConsoleEvent1()
        {
            Car5 Benz = new Car5();
            Benz.danger += new DangerEvent(TooFast); //指定 Danger 事件由 TooFast 方法來處理
            Benz.Speed = 300;
            Console.Read();
        }

        private static void ConsoleStackDemo()
        {
            int amount = 0, option, val;

            Console.Write("請輸入堆疊可存放的數量：");
            amount = int.Parse(Console.ReadLine());
            Stack stack = new Stack(amount);
            Console.WriteLine();

            do
            {
                Console.WriteLine("=== Stack Operation ===");
                Console.WriteLine("\t1. Push Operation");
                Console.WriteLine("\t2. Pop Operation");
                Console.WriteLine("\t3. Printout Stack");
                Console.WriteLine("\t4. Quit");
                Console.WriteLine("=======================");
                Console.Write("\t請選擇 [1-4]：");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Write("\n請輸入要放入堆疊的資料：");
                    val = int.Parse(Console.ReadLine());
                    stack.Push(val);
                }
                else if (option == 2)
                    stack.Pop();
                else if (option == 3)
                    stack.PrintStack();
                else if (option == 4)
                    break;
                else
                    Console.WriteLine("\n--- Error input(0-3)！！\n");
            }
            while (true);
        }
    }
}
