using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5重写方法 {
    class A1 {
        public virtual void write() {
            Console.WriteLine("这是一个虚方法");
        }
    }
    class B1:A1 {
        public override sealed  void write() {
            Console.WriteLine("这是一个重写了的基方法");
        }
    }     
    class C1 : A1 {

    }
    class Program {
        static void Main(string[] args) {
            A1 sA = new A1();
            B1 sB = new B1();
            C1 sC = new C1();
       
            sA.write();
            sB.write();
            sC.write();
            Console.ReadKey ();
        }
    }
}
/*重写方法
 * 用相同的签名(即参数列表)重写所继承的虚方法。虚方法声明用于引入新方法，而重写方法声明
 * 则用于使现有的继承方法专用化。由override声明所写的方法称为已重写了的基方法。
 * 
 * 重写声明和已重写了的基方法具有相同的声明可访问性。换句话说，重写声明不能更改所
 * 对应的虚方法的可访问性。但是，如果已重写的基方法是protected时，并且声明它的程序
 * 集不是包含重写方法的程序集，则重写方法声明的可访问性必须是protected.
 * 
 * 
 * 
 * */