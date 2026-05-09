public class Solution {
    public int[] TwoSum(int[] nums, int target) {        
        for (var i = 0; i < nums.Length; ++i)
        {
            var diff = target - nums[i];
            var index = Array.IndexOf(nums, diff, i + 1);
            if (index != -1)
            {
                return [i, index];
            }
        }

        return [];
    }
}
