using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10方法章节小结及任务实施 {
    class Program {
        static void List1(int i1) {
            Console.WriteLine("{0}的乘法表是：",i1);
            for (int i=1;i<=i1; i++) {
                if (i1 % i != 0) continue;
                else {
                    Console.WriteLine("{0}*{1}={2}",i,i1/i,i1);
                }
            } 
        }
        static void Add1(int num2) {
            Console.WriteLine("{0}的加法表如下 ：",num2);
            for(int i = 1; i <= num2; i++) {
                Console.WriteLine("{0}+{1}={2}",i,num2-i,num2);
            }
        }
        static void Main(string[] args) {
            List1(8);
            Add1(12);
            Console.ReadKey();
        }
    }
}
