using System;

namespace _1._13.AppropriateWayInitializeStaticMembers
{
    class Program
    {
        // 使用恰当的方式对静态成员进行初始化
        // 静态成员变量在创建对象实例之前就已经初始化了。
        // C# 提供了静态初始化语法和【静态构造函数】对静态成员变量进行初始化。
        // 静态构造函数是一个比【其他函数，变量，属性】在没有访问之前就被执行的特殊函数。
        // 你可以使用这个函数初始化静态变量，完善单例模式，或者任何需要在类还没有被使用的必要工作。
        // 你不能使用构造函数，一些特殊 private 函数，或其他语法初始化静态变量


        // 如果静态变量的初始化逻辑比较复杂，可以使用静态构造函数对其进行初始化

        static void Main(string[] args)
        {

            var singleton2 = MySingleton2.TheOnly;
            var singleton21 = MySingleton2.TheOnly;
            Console.WriteLine(singleton2 == singleton21); // true
            Console.WriteLine("Hello World!");
        }
    }

    class Mysingleton
    {
        private static readonly Mysingleton theOneAndOnly = new Mysingleton();
        public static Mysingleton TheOnly
        {
            get { return theOneAndOnly; }
        }

        private Mysingleton() { }
    }

    public class MySingleton2
    {
        private static readonly MySingleton2 theOneAndOnly;

        // 如果初始化逻辑比较复杂，可以通过静态构造函数对静态变量进行初始化
        static MySingleton2()
        {
            theOneAndOnly = new MySingleton2();
        }

        public static MySingleton2 TheOnly
        {
            get { return theOneAndOnly; }
        }

        private MySingleton2() { }


    }
}
