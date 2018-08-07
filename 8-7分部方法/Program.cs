using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7分部方法 {
    public partial  class Program {
         partial  void Write1();
         partial  void Write1(){
            Console.WriteLine("这是一个分部方法!");
        }
    }
    public partial  class Program {
        static void Main(string[] args) {

            Program DD = new Program();
            DD.Write1();
            Console.ReadKey();
        }
    }
}
/*分部方法：方法声明中含有partial 修饰符
 * 分部方法必须在分部类或分部结构中声明，必须私有。
 * 
 * 分部方法有着严格的限制
 * 1）方法必须返回void,只能默认为private;
 * 2)分部方法不能为virtual和extern方法；
 * 3)分部方法可以有ref参数，但不能有out参数；
 * 
 * 因为任何针对没有被实现的分部方法的调用都会简单地被忽略，
 * 所以说这些限制是非常有必要的。
 * 
 * */
