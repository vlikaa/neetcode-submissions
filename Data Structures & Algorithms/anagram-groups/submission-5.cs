public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var key = new string(charArray);

            if (!dict.TryAdd(key, [str]))
            {
                dict[key].Add(str);
            }
        }

        return dict.Values.ToList();
    }
}
