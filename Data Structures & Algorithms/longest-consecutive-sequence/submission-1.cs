public class Solution {
    public int LongestConsecutive(int[] nums) {
        var numSet = new HashSet<int>(nums);
        var longest = 0;

        foreach (var n in numSet)
        {
            if (!numSet.Contains(n - 1))
            {
                var length = 0;
                while (numSet.Contains(n + ++length));
                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
