namespace LeetCodeSolutions;

public class TwoSumProblem
{
    public int[] TwoSum(int[] nums, int target)
    {
        var hashMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (hashMap.ContainsKey(diff))
            {
                return new int[] { hashMap[diff], i };
            }
            hashMap[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}
