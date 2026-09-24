public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var chars = str.ToCharArray();
            Array.Sort(chars);
            var sorted = new string(chars);

            if (!dict.TryAdd(sorted, [str]))
            {
                dict[sorted].Add(str);
            }
        }

        return dict.Values.ToList();
    }
}
