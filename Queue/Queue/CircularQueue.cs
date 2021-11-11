using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class CircularQueue<T> : IEnumerable<T>
    {
        public int Front { get; private set; } = 0;
        public int Rear { get; private set; } = -1;
        private T[] elements { get; set; }
        public int Size { get; set; }


        public bool IsFull()
        {
            return Size == Capacity;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public readonly int Capacity;
        public CircularQueue(int capacity)
        {
            Capacity = capacity;
            elements = new T[capacity];
        }
        public void Enqueue(T element)
        {
            if (IsFull())
                throw new FullQueueException();

            Rear = (Rear + 1) % Capacity;
            elements[Rear] = element;
            Size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new EmptyQueueException();

            Front = (Front + 1) % Capacity;
            Size--;
            return elements[Front + 1];
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = Front, count = 0; count < Size; i = (i + 1) % Capacity, count++)
            {
                stringBuilder.Append(elements[i]);
            }
            return stringBuilder.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Front, count = 0; count < Size; i = (i + 1) % Capacity, count++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class QueueException : Exception
    {
        public QueueException(string message) : base(message)
        {

        }
    }

    class EmptyQueueException : QueueException
    {
        public EmptyQueueException() : base("Queue is empty!")
        {

        }
    }

    class FullQueueException : QueueException
    {
        public FullQueueException() : base("Queue is Full!")
        {

        }
    }
}
