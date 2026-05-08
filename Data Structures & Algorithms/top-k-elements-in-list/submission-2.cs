public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            if (!dict.TryAdd(n, 1))
            {
                ++dict[n];
            }
        }

        var freq = new List<int>[nums.Length + 1];
        for (var i = 0; i < freq.Length; ++i)
        {
            freq[i] = new List<int>();
        }

        foreach (var kvp in dict)
        {
            freq[kvp.Value].Add(kvp.Key);
        }

        var res = new List<int>();
        for (var i = freq.Length - 1; i >= 0; --i)
        {
            foreach (var f in freq[i])
            {
                res.Add(f);

                if (res.Count == k)
                {
                    return res.ToArray();
                }
            }
        }

        return res.ToArray();
    }
}
