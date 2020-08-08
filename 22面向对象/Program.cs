using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22面向对象
{
    class Program
    {
        /// <summary>
        /// 类
        /// 语法：
        /// [public] class 类名
        /// {
        /// 字段;
        /// 属性;
        /// 方法;
        /// }
        /// 写好一个类之后，需要创建这个类的对象
        /// 那么，我们管创建这个类的对象过程称为类的实例化
        /// 使用关键词new
        /// 
        /// this:表示当前这个类的对象
        /// 类不占内存,而对象占内存
        /// 
        /// 
        /// 
        /// 
        /// 属性
        /// 属性的作用就是保护字段，对字段的赋值和取值进行限定
        /// 属性的本质就是两个方法，一个叫get()一个叫set()
        /// 
        /// Field字段
        /// Method方法
        /// Properties属性
        /// 
        /// 
        /// *****字段就是女人，属性才是男人
        /// 
        /// 
        /// 访问修饰符
        /// public:公共的，在哪都能访问
        /// private:私有的，只能在当前类的内部访问，出了类就访问不到了
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //创建Person类的对象
            Person sunquan = new Person();
            sunquan.Name = "孙全";
            sunquan.Age = 23;
            sunquan.Gender = '男';
            sunquan.CHLSS();
            Console.ReadKey();
        }
    }
}
