using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Generic;
namespace Queue
{
    static class CircularQueueUtils
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        {
            foreach(var e in enumerable)
              {
                if (predicate(e))
                {
                    yield return e;
                }
            }
        }
    }

}
