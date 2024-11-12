using LeetCodeSolutions.Problems.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionsTest.Problems.Easy
{
    [TestClass]
    public class ValidAnagramTest
    {
        [TestMethod]
        public void IsValidAnagramWithHashMap()
        {
            string s = "jar", t = "jam";
            var anagram = new ValidAnagram();
            var result = anagram.IsValidAnagramWithHashMap(s, t);
            Assert.IsTrue(result,"Can't calulate valid angram");
        }
        [TestMethod]
        public void IsValidAnagram()
        {
            string s = "racecar", t = "carrace";
            var anagram = new ValidAnagram();
            var result = anagram.IsValidAnagramSimple(s, t);
            Assert.IsTrue(result,"Can't calulate valid angram");
        }
    }
}
