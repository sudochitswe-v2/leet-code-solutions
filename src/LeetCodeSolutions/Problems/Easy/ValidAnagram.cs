using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Problems.Easy
{
    public class ValidAnagram
    {
        /// <summary>
        /// Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsValidAnagramWithHashMap(string s, string t)
        {
            var dicS = new Dictionary<char, int>();
            var dicT = new Dictionary<char, int>();
            if (s.Length != t.Length) return false;
            for (int i = 0; i < s.Length; i++)
            {
                int valueX = dicS.GetValueOrDefault(s[i], 0);
                int valueY = dicT.GetValueOrDefault(t[i], 0);
                dicS[s[i]] = 1 + valueX;
                dicT[t[i]] = 1 + valueY;
            }
            foreach (var key in dicT.Select(dic => dic.Key))
            {
                if (dicT[key] != dicS[key])
                    return false;
            }
            return true;
        }
        public bool IsValidAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            char[] charS = s.ToCharArray();
            char[] charT = t.ToCharArray();
            Array.Sort(charT);
            Array.Sort(charS);
            var newT = new string(charT);
            var newS = new string(charS);
            return newT == newS;
        }
        public bool IsValidAnagramSimple(string s,string t)
        {
            if (s.Length != t.Length) return false;

            int[] store = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                store[s[i] - 'a']++;
                store[t[i] - 'a']--;
            }

            foreach (int n in store) if (n != 0) return false;

            return true;
        }

    }
}
