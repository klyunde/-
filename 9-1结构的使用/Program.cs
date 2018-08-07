using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1结构的使用 {
    public struct Clerk1 {
        public string name;
        public int Age;
        public string Department;
    }
    class Program {
        static void Main(string[] args) {
            Clerk1 zsName = new Clerk1();
            zsName.name = "张三";
            zsName.Age = 43;
            zsName.Department = "三国";
            
            Console.WriteLine("如{0}下{1}所{2}示",zsName.name ,zsName .Age,zsName .Department);
            Console.ReadKey();
        }
    }
}
/*结构的声明方式 关键字struct
 * 
 * 声明的位置
 * 将结构声明到命名空间的下面，类的外面，表示这个命名空间下，
 * 所有的类都可以使用这个枚举。
 * 
 * 结构的使用
 * 1）使用参数化构造函数，即使用new 关键字
 * 2）是在声明结构后分别访问成员（如果只给部分字段赋值会报错）
 * 
 */