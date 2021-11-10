using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array initializing
            //int[] a1 = new int[] { 1, 2, 3, 4 };
            //int[] a2 = { 1, 2, 3, 4 };
            //var a3 = new[] { 1, 2, 3, 4 };
            //var a4 = new[] {(object)"hi" ,"string", 2, 3, 4 };//object رو پیدا میکنه نوع مشترک 
            //var a5 = new[] { new A(),new A(),new B(),new C()};
            var circularBufferData = new[] { 1, 24, 4, 7, 21, 3 };
            CircularBuffer circularBuffer = new CircularBuffer(data: circularBufferData, startIndex: 6);
            foreach(var x in circularBuffer)
            {
                Console.WriteLine(x);
            }
        }
    }

    class A
    {

    }
    class B : A
    {

    }
    class C : A
    {

    }
}
