using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class YieldSample
    {
        
        public static IEnumerable GetEnummerator()
        {
            yield return "";
            yield return 2;
            yield return 3;
            yield return 4;
        }
    }

}
