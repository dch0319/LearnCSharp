using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17ref练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用方法交换两个int类型变量
            int n1 = 20;
            int n2 = 10;
            Test(ref n1, ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadKey();
        }

        public static void Test(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
