using System.Collections.Generic;
using System.Linq;

namespace AlgoPrac.Algorithms.Problems
{
    public static class TwoSum
    {
        public static IList<int> TwoSumSolution(IList<int> nums, int target)
        {
            var map = new List<KeyValuePair<int, int>>();

            for (var i = 0; i < nums.Count; i++)
            {
                var c = target - nums[i];
                if (map.Any(x => x.Key == c))
                {
                    return new List<int> { map.Find(x => x.Key == c).Value, i };
                }

                map.Add(new KeyValuePair<int, int>(nums[i], i));
            }

            return null;
        }
    }
}