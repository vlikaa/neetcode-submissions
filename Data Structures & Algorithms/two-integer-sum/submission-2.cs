public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>{{nums[0], 0}};

        for (var i = 1; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (map.ContainsKey(diff))
            {
                return new int[] {map[diff], i};
            }

            map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
