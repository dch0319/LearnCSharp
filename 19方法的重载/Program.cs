using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19方法的重载
{
    class Program
    {
        /// <summary>
        /// 方法的重载指方法的名称相同，但参数不同
        /// 1)如果参数的个数相同，那么类型就不同
        /// 2)如果参数的类型相同，那么个数就不同
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //M()
            Console.WriteLine(1);
            Console.WriteLine(1.4);
            Console.WriteLine("a");
            Console.WriteLine('c');
            Console.WriteLine(5000m);
        }
        public static void M(int n1, int n2)
        {
            int result = n1 + n2;
        }
        public static double M(double d1, double d2)
        {
            return d1 + d2;
        }
        public static void M(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
        }
        public static string M(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
