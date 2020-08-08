using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入yes或no");
            string str = Console.ReadLine();
            string result = IsYesOrNo(str);
        }

        /// <summary>
        /// 限定用户只能输入yes或者no 并返回
        /// </summary>
        /// <param name="input">输入</param>
        /// <returns>返回yes或者no</returns>
        public static string IsYesOrNo(string input)
        {
            while (true)
            {
                if (input == "yes" || input == "no")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("请重新输入");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
