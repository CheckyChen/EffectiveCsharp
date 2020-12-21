using System;

namespace _1._05.AlwaysProvideToStringMethod
{
    class Program
    {
        // 对于自定义的类，最好提供相应的 ToString() 方法，输出必要的说明

        static void Main(string[] args)
        {
            var c = new Customer();
            c.Name = "checky";
            c.Age = 22;
            c.Address = "beijing";
            Console.WriteLine(c.ToString());
            // name = checky,age = 22,address = beijing
            Console.WriteLine("Hello World!");
        }
    }

    class Customer
    {
        private string name;
        private int age;
        private string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// 重写 ToString() 方法，提供并要的输出信息
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"name = {name},age = {age},address = {address}";
        }
    }
}
