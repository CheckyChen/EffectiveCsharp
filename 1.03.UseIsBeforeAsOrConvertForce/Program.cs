using System;

namespace _1._03.UseIsBeforeAsOrConvertForce
{
    class Program
    {

        // 在使用类型转换时，先用is进行类型判断，再用 as 或者 强制类型转换

        static void Main(string[] args)
        {

            try
            {
                // 普通写法
                object o = "abc";
                string s = (string)o;
                Console.WriteLine(s);
            }
            catch (InvalidCastException)
            {
                throw;
            }


            // 改良好的写法
            object o1 = "abc";
            string s1;
            if (o1 is string)
            {
                s1 = o1 as string;
                Console.WriteLine(s1);
            }
            else
            {
                throw new InvalidCastException("s1 is not string type.");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
