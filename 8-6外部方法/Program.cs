using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _8_6外部方法 {
    class Program {
        [DllImport("User32.dll")]

        public static extern int MessageBox(int a, string b, string c, int d);
        static int  Main(string[] args) {
            Console.Write("请输入名字：");
            string name1 = Console.ReadLine();
            return MessageBox (0,"   你好!\n"+name1+"\n"+"欢迎来到这里" ,"这是标题框",0);

        }
    }
}
/*方法声明中包含extern 修饰符时，此方法为外部方法。
 * 外部方法是在外部实现的，编程语言通常是使用C#以外的语言。
 * 外部方法不可以是泛型。
 * 
 * extend修饰符通常与DLLImport属性一起使用，从而使外部方法可以
 * 由DLL（动态链接阵）实现。
 * 执行环境可以支持其他用来提供外部方法实现的机制。
 * 当外部方法包含DLLImport属性时，该方法声明必须同时包含一个static修饰符。
 *  
 * 
 * */