using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_8方法的重载 {
    class  Area1 {
        public void Area2(int r) {
           // int r1=1;
            double  area3 = Math.PI * r * r;
            Console.WriteLine("圆的面积为："+area3 );
        }
        public void Area2(int wi,int length) {
            //int wi = 1;int  length=1;
            int area3 = wi * length;
            Console.WriteLine("长方形的面积为："+area3);
        }
        public void Area2(int a,int b,int c) {
            int p = a + b + c;
            double area3 = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("三角形的面积为："+area3);
        }
    }
    class Program {
        static void Main(string[] args) {
            //console.writeline("请输入数据，用于求面积：");
            //string ab =console.readline();
            Area1 a = new Area1();
            a.Area2(12);
            a.Area2(2, 3);
            a.Area2(4, 3, 5); 
            Console.ReadKey();
        }
    }
}
/*方法的重载 是一种操作性多态。有的时候，可能需要在多个不同的实现中对不同的
 * 数据执行相同的逻辑操作。
 * 以WriteLine方法为例，有时可能向它传递一个格式字符串和其他一些参数，
 * 也可能只传递一个整数。这样实现不同，但逻辑上都是负责输出数据。
 * 
 * 在类中可定义多个方法名相同、方法中参数个数和参数顺序不同的方法。称之为参数列表不同。
 * 
 * 需要注意的是这里没有提到方法的返回值。
 * 
 * 决定方法是否构成重载有三个条件：
 * 1）在同一个类中：
 * 2）方法名相同：
 * 3）参数列表不同。
 * 
 * */
