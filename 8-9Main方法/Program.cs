using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_9Main方法 {
    class Program {
        /*Main方法有四种表现形式
         * 1）public static void Main()
         * 2)public static int Main()
         * 3)public void Main(string[] args)
         * 4)public int Main(string[] args)
         * */
        static void Main(string[] args) {
            Console.WriteLine("{0}个命令行参数被调用",args.Length);
            foreach (string ii in args) Console.WriteLine(ii);
            Console.ReadKey();

        }
    }
}
/*上述有返回值int时，可以用于表示应用程序的终止方式，通常用作一种错误提示。
 * 一般情况下，反映了“正常”终止。
 * 
 * Main的可选参数args 是从应用程序的外部接受信息的方法，这些信息在运行应用程序
 * 时以命令行参数的形式指定。
 * 
 * 在执行控制台应用程序时，指定的任何命令行参数都放在args数组中，接着可以根据
 * 需要在应用程序中使用这些参数。
 */