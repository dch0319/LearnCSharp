using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08使用out参数做登录
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别的提示用户输入用户名和密码
            //你写一个方法来判断用户输入的是否正确
            //返回给用户一个登录的结果，并且还要单独返回一个登录信息
            //如果用户名错误，除了返回登陆结果，还要返回用户名错误
            Console.WriteLine("1");
            string username = Console.ReadLine();
            Console.WriteLine("2");
            string userpassword = Console.ReadLine();
            string msg;
            bool b = IsLogin(username, userpassword, out msg);
        }

        /// <summary>
        /// 判断用户输入的是否正确,除了返回登陆结果，还要返回用户名错误
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool IsLogin(string name, string pwd, out string msg)
        {
            if (name == "admin" && pwd == "123456")
            {
                msg = "登陆成功";
                return true;
            }
            else if (name == "admin")
            {
                msg = "密码错误";
                return false;
            }
            else if (pwd == "123456")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false;
            }
        }
    }
}
