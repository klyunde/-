using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5类的声明
{
    public enum Gender
    {
        男,
        女
    }
    class MyClerk
    {
        public string _name;//字段可存放多个值，变量只能存放一个值。
        public Gender _gender;
        public int _age;        
        public string _department;
        public int _workYears;
        //静态方法只能调用静态成员
        //非静态方法可以调用任何成员
        public  void Write()//this. 表示当前已实例化的对象
        {
            Console.WriteLine("我叫{0}，我是{1}生，我今年{2}岁了，我在{3}部门任职，我现工作了{4}年。", 
                this._name,this._gender,this._age,this._department,this._workYears);
        }
    }


}
