using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4虚方法
{
    class class1 {//新建一个类  ，默认的方法是私有的。
        public virtual void virtualMethod() {
            Console.WriteLine("这是一个●⊥基类⊥●虚方法");
        }
        public void nonVirtualMethod() {
            Console.WriteLine("这是一个基类非虚方法");
        }
    }
    class class2 : class1 {//将class2继承于class1
        public override void virtualMethod() {
            Console.WriteLine("这是一个  子  类的虚方法");
            //base.virtualMethod();
        }
        public new void nonVirtualMethod() {
            Console.WriteLine("这是一个 子  类 非虚方法");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            class1 c21=new class1();
            c21.virtualMethod();
            c21.nonVirtualMethod();
            Console.WriteLine("-----------------------");
            class2 c22 = new class2();           
            c22.virtualMethod();
            c22.nonVirtualMethod();
            Console.WriteLine("-----------------------");
            c21 = c22;
            c21.virtualMethod();
            c21.nonVirtualMethod();
            Console.ReadKey();
        }
    }
}
/*虚方法指的是一个实例方法的声明中含有virtual修饰符，
 若无则称之为非虚方法。

    实例：
    创建一个虚方法和一个非虚方法，分别通过另一个类继承，
    并比较它们的调用结果。

    非虚方法的实现是一成不变的：无论该方法是在声明它的类的实例上调用还是
    在派生类的实例上调用，实现均相同。与此相反，虚方法的实现可以由派生类取代。
    取代所继承的虚方法的实现过程称为重写（override）该方法。在虚方法调用中，
    该调用所涉及的那个实例的运行时类型确定了要被调用的究竟是该方法的哪一种实现。
    在非虚方法调用中，相关的实例的编译时类型是决定性因素。

 */