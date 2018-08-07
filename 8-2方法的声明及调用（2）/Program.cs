using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2方法的声明及调用_2_
{
    class Program
    {
        //编写一个方法用于计算给定整形数组元素的和
        static int Add(params int[] nums)
        {
            int sum = 0;
            foreach (int outnum in nums) sum += outnum;
            return sum;
        }
        //编写一个无返回值的方法,值参数
        static void Square1(int num1)
        {
            num1 *= num1;
            Console.WriteLine("的平方为：{0}", num1);
        }
        //编写一个无返回值的方法,引用参数
        static void Square2(ref int num2)
        {
            num2 *= num2;
            Console.WriteLine("的平方为：{0}", num2);
        }
        //求数组中的最大值并列出索引号
        static int MaxNum(int [] nums,out int MaxIdex)
        {
            int maxNum = nums[0];
            MaxIdex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (maxNum < nums[i])
                {
                    maxNum = nums[i];
                    MaxIdex = i;
                }
            }
            return maxNum;
        }
        static void Main(string[] args)
        {
            int A1 = Add(3, 4, 5, 6);
            Console.WriteLine("一种数组求和{0}", A1);
            int[] A2 = { 3, 4, 5, 6, 1, 2 };
            Console.WriteLine("另一种数组求和{0}", Add(A2));
            Console.WriteLine("------------↓↓值参数↓↓-------------------");
            int num1 = 5;
            Console.Write("{0}", num1);
            Square1(num1);
            Console.WriteLine("{0}", num1);
            Console.WriteLine("-------------↓↓引用参数↓↓------------------");
            int num3 = 5;
            Console.Write("{0}", num3);
            Square2(ref num3);
            Console.WriteLine("{0}", num3);
            Console.WriteLine("---------↓↓求数组中的最大值并列出索引号↓↓--------");
            int[] Array1 = { 3, 4, 55, 6, 7 };
            int Array1Index;
            Console.WriteLine("此数组的最大值是{0}，最大值的索引值是：{1}",MaxNum(Array1,out Array1Index),Array1Index);
            Console.ReadKey();
        }
    }
}
/*参数数组
 允许使用个数不定的参数调用方法，可使用params关键字来定义；参数数组可简化代码，
 因为在调用代码中不必传递数组，而是传递同类型的几个参数。
 3) 引用参数与值参数
  1>值参数：传值给方法，方法中的变量修改不影响参数列表
  2>引用参数：ref关键字指定
    使用ref两个限定
    a、调用函数变量必须非常量；
    b、调用变量必须初始化。
4）输出参数
执行方式与ref完全一样，关键字为out。
当希望返回多个值时，out非常有用
输出参数与引用参数的区别
未初始化的变量用作ref非法,out合法
函数调用out参数量，必须把它当作尚未赋值
out ref必须在调用及定义方法时声明
     */
