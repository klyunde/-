using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6属性的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Clerk zsClerk = new Clerk();
            zsClerk.Name = "张三";           
            zsClerk.Age = -12;
            zsClerk.Write();

            Console.ReadKey();
        }
    }
}
