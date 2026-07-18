public class Solution {
    public int FindMin(int[] nums) {
        int min = nums[0];

        for (var i = 1; i < nums.Length; ++i)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }

        return min;
    }
}
