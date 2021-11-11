using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;
namespace Queue
{
    class Test
    {
        static void Main(string[] args)
        {
            //Queue functionality test//

            //var circularQueue = new CircularQueue<int>(5);
            //circularQueue.Enqueue(4);
            //circularQueue.Dequeue();
            //circularQueue.Enqueue(1);
            //circularQueue.Enqueue(2);
            //circularQueue.Enqueue(3);
            //circularQueue.Enqueue(3);
            //circularQueue.Enqueue(3);
            //circularQueue.Dequeue();
            //Console.WriteLine(circularQueue);

            //Enumerator test//

            //var enummerable = YieldSample.GetEnummerator();
            //var enummerator = enummerable.GetEnumerator();
            //enummerator.MoveNext();
            //Console.WriteLine(enummerator.Current);
            //Console.WriteLine(enummerator.Current);
            //Console.WriteLine(enummerator.Current);

            //Extension method test//

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            var circularQueue = new CircularQueue<int>(5);
            circularQueue.Enqueue(4);
            circularQueue.Enqueue(1);
            circularQueue.Enqueue(2);
            circularQueue.Enqueue(0);
            circularQueue.Enqueue(3);
            var filteredArr = circularQueue.Filter(a => a % 2 == 0);
            foreach (var e in filteredArr)
            {
                Console.WriteLine(e);
            }
        }
    }
}
