public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];

        var prefix = 1;
        for (var i = 0; i < result.Length; ++i)
        {
            result[i] = prefix;
            prefix *= nums[i]; 
        }

        var postfix = 1;
        for (var i = result.Length - 1; i >= 0; --i)
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }

        return result;
    }
}
