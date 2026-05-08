public class Solution {
    public bool hasDuplicate(int[] nums) {
        var values = new HashSet<int>();
        int value;

        foreach (var num in nums)
        {
            if (values.Contains(num))
            {
                return true;
            }

            values.Add(num);
        }

        return false;
    }
}
