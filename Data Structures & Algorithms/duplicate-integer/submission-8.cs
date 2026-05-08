public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashSet = new HashSet<int>();

        foreach (var n in nums)
        {
            if (!hashSet.Add(n))
            {
                return true;
            }
        }

        return false;
    }
}