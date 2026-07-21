public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1;
        var result = nums[0];

        while (l <= r)
        {
            if (nums[l] <= nums[r])
            {
                return Math.Min(result, nums[l]);
            }

            var m = (l + r) / 2;
            result = Math.Min(result, nums[m]);

            if (nums[l] <= nums[m])
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
