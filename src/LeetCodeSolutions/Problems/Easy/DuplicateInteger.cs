using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Easy
{
    public class DuplicateInteger
    {
        public bool HasDuplicate(int[] nums)
        {
            var hashset = new HashSet<int>();
            foreach (var num in nums)
            {
                if (hashset.Contains(num))
                    return true;
                hashset.Add(num);
            }
            return false;
        }
    }
}
