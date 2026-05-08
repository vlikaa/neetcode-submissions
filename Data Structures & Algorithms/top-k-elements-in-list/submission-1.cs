public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            if (!count.TryAdd(n, 1))
            {
                ++count[n];
            }
        }

        var freq = new List<int>[nums.Length + 1];
        for (var i = 0; i < freq.Length; ++i)
        {
            freq[i] = [];
        }

        foreach (var kvp in count)
        {
            freq[kvp.Value].Add(kvp.Key);
        }

        List<int> res = new List<int>();
        for (int i = freq.Length - 1; i >= 0; i--) 
        {
            foreach (int n in freq[i]) 
            {
                res.Add(n);
                if (res.Count == k) {
                    return res.ToArray();
                }
            }
        }

        return res.ToArray();
    }
}
