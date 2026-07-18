public class Solution {
    public int FindMin(int[] nums) {
        var result = nums[0];
        int l = 0, r = nums.Length - 1;

        while (l <= r)
        {
            if (nums[l] < nums[r])
            {
                return Math.Min(result, nums[l]);
            }

            var m = (l + r) / 2;
            result = Math.Min(result, nums[m]);

            if (nums[m] >= nums[l])
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        return result;
    }
}
