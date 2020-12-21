using System;

namespace _1._17.StandardDisposePattern
{
    class Program
    {

        // 实现标准的Dispose模式

        // 1.释放所有非托管资源。
        // 2.释放所有托管资源（包括卸载事件）。
        // 3.设置表示对象依据被清理的标记位。在 public 方法你需要坚持这个状态值，并且如果已经被回收对象的调用要抛出 ObjectDisposed 异常。
        // 4.阻止析构。你通过调用 GC.SuppressFinalize(this) 来完成这项工作。

        static void Main(string[] args)
        {

            //using (DrivedResourceHog drivedResourceHog = new DrivedResourceHog())
            //{

            //}

            using DrivedResourceHog drivedResourceHog = new DrivedResourceHog();

            //DrivedResourceHog drivedResourceHog = new DrivedResourceHog(); // 不会自动释放

            Console.WriteLine("Hello World!");
        }
    }


    public class MyResourceHog : IDisposable
    {
        private bool alreadyDisposed = false;

        public void Dispose()
        {            
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (alreadyDisposed)
            {
                return;
            }

            if (isDisposing)
            {
                Console.WriteLine("Dispose resource here.");
            }

            alreadyDisposed = true;
        }
    }

    public class DrivedResourceHog : MyResourceHog
    {
        private bool disposed = false;

        protected override void Dispose(bool isDisposing)
        {
            if (disposed)
            {
                return;
            }

            if (isDisposing)
            {
                Console.WriteLine("drive dispose resource here.");
            }

            base.Dispose(isDisposing);

            disposed = true;
        }
    }
}
