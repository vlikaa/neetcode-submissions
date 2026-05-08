public class Solution {
    public int LongestConsecutive(int[] nums) {
                var sequences = new Dictionary<int, List<int>>();
        
        foreach (var n in nums) 
        {
            if (!nums.Contains(n - 1))
            {
                sequences[n] = new List<int>();

                sequences[n].Add(n);

                var i = n;
                while (nums.Contains(++i))
                {
                    sequences[n].Add(i);
                }
            }
        }

        int maxSequence = 0;
        foreach (var value in sequences.Values)
        {
            if (value.Count > maxSequence)
            {
                maxSequence = value.Count;
            }
        }

        return maxSequence;
    }
}
