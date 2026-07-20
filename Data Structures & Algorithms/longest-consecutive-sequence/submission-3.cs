public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        var longest = 0;

        foreach (var n in nums)
        {
            if (!set.Contains(n - 1))
            {
                var length = 1;

                while (set.Contains(n + length))
                {
                    ++length;
                }

                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
