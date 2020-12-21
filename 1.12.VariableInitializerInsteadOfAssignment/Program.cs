using System;
using System.Collections.Generic;

namespace _1._12.VariableInitializerInsteadOfAssignment
{
    class Program
    {
        // 使用变量初始化替代赋值语句
        //初始化语句比构造函数中的语句更方便快捷。初始化语句被放在你的构造函数之前。初始化语句在基类构造函数之前执行，而且它们执行的顺序是定义它们的顺序。

        // 有三种情况，你不应该使用初始化语句语法：
        // 第一种情况是当你要将对象初始化为0或 null ，系统在你的代码执行之前，会默认为所有内容设置为0。系统产生的0初始化是使用非常低级的 CPU 指令设置整块内存为0。你的任何额外的0初始化都是多余的；
        // 第二种情况就是只有变量在所有构造函数中接收的初始化代码是一样的才使用初始化语句语法
        // 第三种情况是方便异常处理，不能在初始化语句中使用try语句

        // 第一种情况
        int i;// initialized to 0
        int i1 = 0; // 多余的操作

        // 第二种情况
        class MyClass
        {

            List<string> list = new List<string>();
            public MyClass()
            {
                list = new List<string>(100);// 这个就是多余的，这种请求会生成两个list，外面的list会立即变为垃圾
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
