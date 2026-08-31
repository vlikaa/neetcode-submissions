public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            var chars = s.ToArray();
            Array.Sort(chars);
            var str = new string(chars);

            if (!dict.TryAdd(str, [s]))
            {
                dict[str].Add(s);
            }
        }

        return dict.Values.ToList();
    }
}
