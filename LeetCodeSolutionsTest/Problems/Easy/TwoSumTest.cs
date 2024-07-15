using LeetCodeSolutions;

namespace LeetCodeSolutionsTest.Problems.Easy;
[TestClass]
public class TwoSumTest
{
    [TestMethod]
    public void TestCase1()
    {
        var nums = new int[] { 3, 4, 5, 6 };
        var target = 7;
        var expectedResult = new int[] { 0, 1 };
        var twoSum = new TwoSumProblem();
        var result = twoSum.TwoSum(nums, target);
        CollectionAssert.AreEqual(expectedResult, result, "error");
    }
    [TestMethod]
    public void TestCase2()
    {
        var nums = new int[] { 4, 5, 6 };
        var target = 10;
        var expectedResult = new int[] { 0, 2 };
        var twoSum = new TwoSumProblem();
        var result = twoSum.TwoSum(nums, target);
        CollectionAssert.AreEqual(expectedResult, result, "error");
    }
    [TestMethod]
    public void TestCase3()
    {
        var nums = new int[] { 5, 5 };
        var target = 10;
        var expectedResult = new int[] { 0, 1 };
        var twoSum = new TwoSumProblem();
        var result = twoSum.TwoSum(nums, target);
        CollectionAssert.AreEqual( expectedResult,  result, "error");
    }
}
