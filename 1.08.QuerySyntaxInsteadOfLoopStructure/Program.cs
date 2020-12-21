using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._08.QuerySyntaxInsteadOfLoopStructure
{
    class Program
    {

        // 优先考虑查询语法（query syntax）而不是循环结构,多用Linq替代循环结构

        static void Main(string[] args)
        {
            Test2();
            Console.WriteLine("Hello World!");
        }

        static void Test1()
        {
            int[] nums = new int[100];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i * i;
            }

            foreach (int item in nums)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void Test2()
        {
            int[] nums = (from i in Enumerable.Range(0, 100) select i * i).ToArray();
            nums.ForAll(n => Console.WriteLine(n));
        }
    }

    public static class Extensions
    {
        public static void ForAll<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable)
            {
                action(item);
            }
        }
    }
}
