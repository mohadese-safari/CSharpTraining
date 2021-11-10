using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class CircularBuffer : IEnumerable
    {
        private int[] _data;
        private int StartIndex { get; set; }
        public CircularBuffer(int[] data, int startIndex)
        {
            _data = data;
            StartIndex = startIndex;
        }


        public IEnumerator GetEnumerator()
        {
            return new CircularBufferEnummerator(this);
        }

        private class CircularBufferEnummerator : IEnumerator
        {
            private CircularBuffer Parent { get; }
            private int Position { get; set; }
            public CircularBufferEnummerator(CircularBuffer parent)
            {
                Position = -1;
                Parent = parent;
            }

            public object Current
            {
                get
                {
                    if (Position < 0 || Position >= Parent._data.Length)
                    {
                        throw new InvalidOperationException("No current");
                    }

                    return Parent._data[(Position + Parent.StartIndex) % Parent._data.Length];
                }
            }

            public bool MoveNext()
            {
                Position++;
                return Position < Parent._data.Length;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
