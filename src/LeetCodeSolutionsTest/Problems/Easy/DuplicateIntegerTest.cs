using LeetCodeSolutions.Problems.Easy;
namespace LeetCodeSolutionsTest.Problems.Easy
{
    [TestClass]
    public class DuplicateIntegerTest
    {
        [TestMethod]
        public void DuplicateFound()
        {
            var nums = new int[] { 1, 2, 3, 3 };
            var duplicateInteger = new DuplicateInteger();
            bool result = duplicateInteger.HasDuplicate(nums);
            Assert.IsTrue(result,"Duplicate item should be found.");
        }
        [TestMethod]
        public void DuplicateNotFound()
        {
            var nums = new int[] { 1, 2, 3, 4 };
            var duplicateInteger = new DuplicateInteger();
            bool result = duplicateInteger.HasDuplicate(nums);
            Assert.IsFalse(result, "Duplicate item shouldn't found.");
        }
    }
}