using System;
using System.Collections.Generic;

namespace _1._14.ReduceReapeatedInitializationLogic
{
    class Program
    {
        // 减少重复的初始化逻辑

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class MyClass
    {

        private List<string> list;
        private string name;

        public MyClass()
        {
            CommonConstractor();
        }

        public MyClass(int size)
        {
            CommonConstractor(size);
        }

        public MyClass(int size, string name)
        {
            CommonConstractor(size, name);
        }

        // 使用一个通用的构造函数，避免每个重载的构造函数写入相同的逻辑
        private void CommonConstractor(int size = 0, string name = "")
        {

            list = size > 0 ? new List<string>(size) : new List<string>();
            this.name = name;
        }
    }
}
