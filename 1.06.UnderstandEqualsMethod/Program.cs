using System;

namespace _1._06.UnderstandEqualsMethod
{
    class Program
    {

        // public static bool ReferenceEquals (object left, object right);
        // 当 right 和 left 的内存地址时同一个地址时，返回 True

        // public static bool Equals(object left, object right);
        // 当两个值相同时，返回 True，引用对象还是比较 内存地址

        // public virtual bool Equals(object right);
        // 比较对象的值，引用对象比较内存地址

        // public static bool operator == (MyClass left, MyClass right);



        static void Main(string[] args)
        {

            int i = 5;
            int j = 5;
            //bool reFlag = object.ReferenceEquals(i, j);
            Console.WriteLine(object.ReferenceEquals(i,i));
            Console.WriteLine(object.ReferenceEquals(i, j)); // False
            Console.WriteLine(object.Equals(i, j)); // True

            Console.WriteLine("Hello World!");
        }
    }

    internal class Customer
    {

        private string name;
        private int age;
        public Customer(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public static new bool ReferenceEquals(object left, object right)
        {
            return true;
        }

        public static bool operator ==(Customer left, Customer right)
        {
            return left.ToString() == right.ToString();
        }

        public static bool operator !=(Customer left, Customer right)
        {
            return left.ToString() != right.ToString();
        }

        public override string ToString()
        {
            return $"name:{name},age:{age}.";
        }
    }
}
