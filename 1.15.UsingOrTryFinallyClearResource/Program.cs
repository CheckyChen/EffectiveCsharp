using System;
using System.IO;

namespace _1._15.UsingOrTryFinallyClearResource
{
    class Program
    {
        // 使用Using 、try/finally 清理资源
        static void Main(string[] args)
        {
            string path = "Program.cs";
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {

            }

            FileStream fs1 = null;
            try
            {
                fs1 = new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                fs1?.Dispose();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
