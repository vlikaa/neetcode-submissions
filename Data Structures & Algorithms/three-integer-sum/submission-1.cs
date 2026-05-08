public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();

         Array.Sort(nums);

        for (var i = 0; i < nums.Length; ++i)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int left = i + 1;
            int right = nums.Length - 1;
            
            while (left < right)
            {
                var threeSum = nums[i] + nums[left] + nums[right];

                if (threeSum > 0)
                {
                    --right;
                }
                else if (threeSum < 0)
                {
                    ++left;
                }
                else
                {
                    result.Add([nums[i], nums[left], nums[right]]);
                    
                    int leftValue = nums[left];
                    while (left < right && nums[left] == leftValue)
                    {
                        ++left;
                    }
                    
                    int rightValue = nums[right];
                    while (left < right && nums[right] == rightValue)
                    {
                        --right;
                    }
                }
            } 
        }

        return result;
    }
}