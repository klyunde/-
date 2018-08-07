using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6属性的使用
{
    //public enum gender
    //{
    //    男,
    //    女
    //}
    class Clerk
    {
        private  string _name;//字段可存放多个值，变量只能存放一个值。

        //属性往往被声明在字段下方，并且将字段私有化。
        public string Name {
            get { return _name; }
            set { _name=value; }
        }
        private char _gender;
        public char Gender {
            get {if (_gender != '男'||_gender != '女') _gender = '女';
                return _gender; }
            set { _gender = value; }

        }
        private int _age;
        public int Age {
            get { return _age;


            }
            set { if (value < 0 || value > 80) value = 800;
                _age = value ;
                
            }
        }
        private string _department;
        public string Department {
            get;
            set;
        }
        private int _workYears;
        public int WorkYears {
            get;
            set;
        }
        
        //静态方法只能调用静态成员
        //非静态方法可以调用任何成员
        public void Write()//this. 表示当前已实例化的对象
        {
            Console.WriteLine("我叫{0}，我是{1}生，我今年{2}岁了，我在{3}部门任职，我现工作了{4}年。",
                this.Name, this.Gender, this.Age, this.Department, this.WorkYears);
        }
    }
}
//属性有三种属性：只读；只写；既读又写；自动