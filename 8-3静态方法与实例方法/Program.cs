using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3静态方法与实例方法
{
    class Program
    {
        int exampleVar;//实例成员
        static int staticVar;//静态成员
        static void staticMethod()//静态方法
        {
            staticVar = 3;
        }
        void exampleMethod() {     //实例方法
            exampleVar = 3;
            staticVar = 5;
        }
        static void Main(string[] args)
        {
            staticMethod();//调用静态方法时直接调用
            
        }
    }
}
/*判断是否是静态方法和实例方法
有static 静态方法  没有就是实例方法
** 静态方法只能访问类中的静态成员，而不能使用实例成员。访问静态方法只能使用类名，
而不需要创建对象，也不能使用对象名来引用。
** 实例方法必须使用类的实例或对象来引用。实例方法对类的某个给定的实例进行操作，在
实例方法类中可以使用this来访问该实例。调用实例方法时，必须先创建一个对象。

    静态方法只能访问静态成员，不能使用关键字this. 
    实例方法可以访问静态和实例成员

    */