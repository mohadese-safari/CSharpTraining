using System;
using System.Threading;
namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart method = (object o) =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    Console.Write(o);
                }
            };

            Thread t1 = new Thread(method);
            Thread t2 = new Thread(method);

            t1.Start("x");
            t1.Join();
            //while (t1.ThreadState != ThreadState.Stopped)
            //    Thread.Sleep(0);
            Console.WriteLine("finished");
        }
    }
}
