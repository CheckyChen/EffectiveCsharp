using System;

namespace _1._02.MoreReadonlyLessConst
{
    class Program
    {

        // 宁可选择一个慢一点的正确程序，不选择一个快速但是可能出错的程序，出于这个考虑，更偏向于运行时常量
        // 只有在性能是一个致命问题时才考虑用编译时常量

        // 编译时常量只能在基本类型（内建整数和浮点数类型），枚举类型，或字符串。
        // public const DateTime MyDateTime = new DateTime(); // 编译错误：不能将 DateTime 声明为 const 

        public static readonly DateTime MyDateTime = new DateTime();

        // 编译时常量
        public const int Millennium = 1000;

        // 运行时常量
        public static readonly int ThisYear = 2020;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }
}
