using System;

namespace Stack
{
    class Stack<T>
    {
        private T[] Items { get; set; }
        public readonly int Capacity;
        public int Size { get; private set; }
        public Stack(int capacity)
        {
            Size = 0;
            Capacity = capacity;
            Items = new T[Capacity];
        }

        public Stack() : this(100) { }

        public bool IsFull()
        {
            return Size == Capacity;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public void IncreaseSizeBy1()
        {
            Size++;
        }

        public void DecreaseSizeBy1()
        {
            Size--;
        }
        public void Push(T item)
        {
            if (IsFull())
            {
                throw new StackOverFlowException();
            }
            Items[Size] = item;
            IncreaseSizeBy1();
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new StackEmptyException();
            }
            DecreaseSizeBy1();
            return Items[Size];
        }

        public T Peek()
        {
            return Items[Size - 1];
        }
    }

    class StackOverFlowException : Exception
    {
        public StackOverFlowException() : base("Stack is full") { }
    }

    class StackEmptyException : Exception
    {
        public StackEmptyException() : base("Stack is empty") { }
    }

    class StackTest
    {

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(8);
            stack.Push(1);
            stack.Push(3);
            Console.WriteLine(stack.Peek());    
            Console.WriteLine(stack.Pop());    
            Console.WriteLine(stack.Pop());    
            Console.WriteLine(stack.Pop());    
            Console.WriteLine(stack.Pop());
            stack.Push(18);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
