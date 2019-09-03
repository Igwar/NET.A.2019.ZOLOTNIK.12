using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLib
{
    public static class FibNum
    {
        public static List<int> Find(int n)
        {
            List<int> result = new List<int>();
            int n1 = 1;
            int n2 = 1;
            result.Add(n1);
            result.Add(n2);
            for (int i = 3; i <= n; ++i)
            {
                var n3 = n1 + n2;
                result.Add(n3);
                n1 = n2;
                n2 = n3;

            }

            return result;
        }
    }
}
