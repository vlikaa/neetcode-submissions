public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var dict = new Dictionary<int, int>();
        var freq = new List<int>[nums.Length + 1];
        var result = new List<int>();
        
        foreach (var n in nums)
        {
            if (!dict.TryAdd(n, 1))
            {
                ++dict[n];
            }
        }

        foreach (var kvp in dict)
        {
            if (freq[kvp.Value] is null)
            {
                freq[kvp.Value] = [];
            }
    
            freq[kvp.Value].Add(kvp.Key);
        }

        for (var i = freq.Length - 1; i > 0; --i)
        {
            if (freq[i] is null)
            {
                continue;
            }

            foreach (var n in freq[i])
            {
                if (result.Count == k)
                {
                    return result.ToArray();
                }

                result.Add(n);
            }
        }

        return result.ToArray();
    }
}
