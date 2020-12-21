using System;

namespace _1._18.ValueTypeAndReferenceType
{
    class Program
    {
        // 值类型和引用类型的区别

        // 考虑4个问题
        // 1.这个类型只是为了存储数据
        // 2.这个类型的public接口只为了访问数据
        // 3.这个类型不会有子类
        // 4.这个类型不会被看成多态

        // 如果以上四个条件都满足的话，则使用值类型而非引用类型

        // 记住 值类型是用来存储数据的，而引用类型是用来表现行为的
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public struct Employee
    {
        public string Position { get; set; }
        public decimal CurrentPayamount { get; set; }

        public void Pay(BankAcount bankAcount)
        {
            bankAcount.Balance += CurrentPayamount;
        }
    }

    public class Employee2
    {
        public string Position { get; set; }
        public decimal CurrentPayamount { get; set; }

        public void Pay(BankAcount bankAcount)
        {
            bankAcount.Balance += CurrentPayamount;
        }
    }

    public class BankAcount
    {
        public decimal Balance { get; set; }
    }
}
