using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPrac.LeetCode
{
    public static class ReverseInt
    {
        public static int ReverseIntSolution(int x)
        {
            try
            {
                var s = x.ToString();
                if (s[0] == '-')
                {
                    return int.Parse($"-{string.Join("", s.Substring(1, s.Length - 1).Reverse())}");
                }

                var r = s.Reverse().ToList();
                var c = 0;
                for (var i = 0; i < r.Count; i++)
                {
                    if (r[i] == '0')
                    {
                        c++;
                    }
                    else
                    {
                        for (var j = 0; j < c; j++)
                        {
                            r.RemoveAt(0);
                        }

                        return int.Parse(string.Join("", r));
                    }
                }

                return 0;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
