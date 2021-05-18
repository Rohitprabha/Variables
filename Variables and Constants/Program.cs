using System;

namespace Variables_and_Constants
{
    class Program
    {
        public void local()
        {
            int a = 0;
            Console.WriteLine("Local variable {0}", a);

        }
        int x;                      //non-static variable
        static int y = 200;           //static variable
        const float pi = 3.14f;
        readonly bool flag;
        public Program(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main(string[] args)
        {
            int z = 10;              //static variable
            //Console.WriteLine(x);
            Console.WriteLine(Program.y);           //static variable doesnot require instance of class
            Console.WriteLine(z);
            Console.WriteLine(pi);          //constant variable doesnot require instance of class
            //Console.WriteLine(flag);          
            Program p1 = new Program(50, true);
            Program p2 = new Program(150, false);
            //p1.flag = false;
            Console.WriteLine(p1.x + "   " + p2.x);
            Console.WriteLine(p1.flag);
            Console.WriteLine(p2.flag);
            p1.local();
        }
    }
}
