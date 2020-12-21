using System;

namespace _1._11.LittleMethodCharm
{
    class Program
    {
        // 体会小函数的魅力

        // 短小的函数意味着 JIT 编译器只编译逻辑上需要的函数，而不是你没有立即使用整个一长串代码。
        // switch 结构可以节省好几被的 JIT 开销，如果每个 case 条件定义为 inline 而不是 单独的函数.

        // 越简单越好。一个简短的函数很可能包含更少的局部变量，可以使得 JIT 编译器更容易使用寄存器优化程序        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
