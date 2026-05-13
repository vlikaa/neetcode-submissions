public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            dict[n] = dict.GetValueOrDefault(n, 0) + 1;
        }

        var freq = new List<int>[dict.Values.Max() + 1];
            
        foreach (var kvp in dict)
        {
            if (freq[kvp.Value] != null)
            {
                freq[kvp.Value].Add(kvp.Key);
                
                continue;
            }

            freq[kvp.Value] = [kvp.Key];
        }

        var result = new List<int>();
        

        for (var i = freq.Length - 1; i > 0; --i)
        {
            if (freq[i] == null) continue;

            foreach (var n in freq[i])
            {
                result.Add(n);
                if (result.Count == k)
                {
                    return result.ToArray();
                }
            }
        }

        return result.ToArray();
    }
}
