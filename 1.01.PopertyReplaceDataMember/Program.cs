using System;

namespace _1._01.PopertyReplaceDataMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Customer
    {
        private string name;
        /// <summary>
        /// 可以对数据进行检测
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be blank!", "Name");
                }
                name = value;
            }
        }


        private int age;
        private static object syncHandle = new object();

        /// <summary>
        /// 支持异步的属性
        /// </summary>
        public int Age
        {
            get
            {
                lock (syncHandle) return age;
            }
            set
            {
                lock (syncHandle) age = value;
            }
        }

        public string Gender
        {
            get; protected set;
        }
    }
}
