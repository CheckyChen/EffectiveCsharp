using System;
using System.Diagnostics;

namespace _1._04.UseConditionalAttributeReplaceSharpIf
{
    class Program
    {

        // 用 Conditional 属性代替 #if #endif 使得条件代码分离更加清晰

        static void Main(string[] args)
        {
            var c = new Customer();
            c.test();
            c.test1();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }


    class Customer
    {
        public void test()
        {
            // 将解决方案配置为 Release 时，该段代码不会执行
#if DEBUG
            Console.WriteLine("debug block console.");
#endif
        }

        // 用 Conditional 属性代替 #if #endif，
        // 当解决方案配置器下来框为非 Debug 时，这个方法在调用的时候并不执行
        [Conditional("DEBUG")]
        public void test1()
        {
            Console.WriteLine("conditional debug block console.");
        }
    }
}
