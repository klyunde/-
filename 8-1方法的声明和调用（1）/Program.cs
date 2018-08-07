using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    class Program
    {
        //无返回值方法
        static void A1(int num1)
        {
            int a = 1;
            for (int i = num1; i > 0; i--) a *= i;
            Console.WriteLine("{0}的阶乘是:{1}", num1, a);
        }

        //有返回值方法
        static int Add1(int a, int b)
        {
            int c = a + b;
            return c;
        }
        static void Main(string[] args)
        {
            A1(3);
            A1(5);
            A1(2);
            int c = Add1(3, 4);
            Console.WriteLine("两者相加的结果是:{0}", c);
            Console.ReadKey();
        }
    }
}
/*修饰符 返回值类型  方法名称 （参数列表）  ｛ 方法体｝
修饰符：public、private\static等
返回值类型：void\int\double
参数列表可为数组

*/
