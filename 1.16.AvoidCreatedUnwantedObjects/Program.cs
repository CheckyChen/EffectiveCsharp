using System;
using System.Text;

namespace _1._16.AvoidCreatedUnwantedObjects
{
    class Program
    {
        // 避免创建不必要的对象

        // 字符串是不可变的，没次对一个字符串进行拼接，都会创建一个新的对象，之前的立即变成垃圾，如果需要对字符串进行频繁得操作，可以使用string.Format()
        // 或者 StringBuilder 或者插值表达式代替
        static void Main(string[] args)
        {

            string s = "a";
            s += " b";
            s += " c";
            s += " d";

            string s1 = string.Format("{0} {1} {2} {3}", "a", "b", "c", "d");

            StringBuilder sb = new StringBuilder();
            sb.Append("a");
            sb.Append("b");
            sb.Append("c");
            sb.Append("d");

            Console.WriteLine("Hello World!");
        }
    }
}
