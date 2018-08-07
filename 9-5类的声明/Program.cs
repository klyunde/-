using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5类的声明
{
    class zsClass
    {

    }
    class Clerk1
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClerk zsClerk = new MyClerk();
            zsClerk._name = "张三";
            zsClerk._gender =Gender.女;
            zsClerk._age = 54;
            zsClerk._department = "人力部";
            zsClerk._workYears = 31;            
            zsClerk.Write();

            Console.WriteLine("-----------以下所示，字段可存储多个值，而变量只能存储一个值。----------");
            MyClerk lsClerk = new MyClerk();
            lsClerk._name = "李四";

            string zsls = "张三";
            zsls = "王五";

            Console.WriteLine(zsClerk._name);
            Console.WriteLine(lsClerk._name);
            Console.WriteLine(zsls);
            Console.WriteLine(zsls);
            Console.ReadKey();
        }
    }
}
/*类是一种数据结构，可以包含数据成员（常量和字段）、函数成员（方法、属性、
 * 事件、索引器、运算符、实例构造函数、静态构造函数和析构函数）以及嵌套类型。
 * 
 * C#中的一切类型都为类，除（引用的命名空间外）所有的语句都必须位于类（或结构）内，
 * 不存在任何处于类（或结构）之外的语句。因此，类是C#语言的核心和基本构成模块。
 * 默认代码中包含一个Program类。
 * 
 * 
 * */
