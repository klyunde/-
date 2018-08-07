using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2枚举 {
     public  enum Bb {
        男,
        女
    }
    public enum week {
        周一,
        周二,
        周三,
        周四=10,
        周五,
        周六,
        周日
    }
    public struct Gb {
        public string name;
        public Bb cc1 ;
    }
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("------将字段转换为枚举值---------------");
            Bb zsGender = Bb.女;
            Console.WriteLine((int)zsGender);

            Console.WriteLine("------将枚举值转换为字段--------------");
            int myWorkDay = 4;
            Console.WriteLine((week)myWorkDay);

            Console.WriteLine("------将枚举转换为字符串--------------");
            week myWorkDay3 = week.周三;
            Console.WriteLine(myWorkDay3.ToString());
            Console.WriteLine(Convert.ToString(myWorkDay3));

            Console.WriteLine("------将字符串转换为枚举值--------------");
            week myWorkDay4 = week.周四;
            string mystr2 = myWorkDay4.ToString();
            Console.WriteLine((week)Enum.Parse(typeof(week),mystr2) );

            Console.ReadKey();
        }
    }
}
/*声明方式
 * [public] enum 枚举名 ｛ ｝
 *  与结构作用很类似，所以位置一样，但同时，枚举可以结构中被调用。
 *  
 *  枚举就是一个变量类型，int double string decimal
 * 
 * 只是枚举声明、赋值、使用的方式跟那些普通的变量类型不一样。
 * 
 * 类型转换《《《《《《《《《《《《《《
 * 枚举与int相互转换
 * 要获得枚举的值，只要转换为string类型。
 * 枚举与string相互转换
 * 如果将字符串转换成枚举类型则需要下面这样一行代码：
 * 。（要转换的枚举类型）Enum.Parse(typeof(要转换的枚举类型），"要转换的字符串");
 * 如果转换的字符串是数字，则就算枚举中没有，也不会抛异常。
 * 是文本的话，则抛异常。
 * 
 * 默认情况下，每个值都会根据定义的顺序从0开始，自动赋予每个值一个整型。
 * 当然，也可能人为指定一个枚举的基础值。
 */