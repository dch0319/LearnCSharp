using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ref参数
{
    class Program
    {
        /// <summary>
        /// ref参数能够将一个变量带入一个方法中进行改变，再将改变后的值带出方法
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double salary = 5000;
            JiangJin(ref salary);
            
        }

        public static void JiangJin(ref double s)
        {
            s += 500;
        }

        public static void FaKuan(double s)
        {
            s -= 500;
        }
    }
}
