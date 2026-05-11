public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var key = SortString(str);

            if (!dict.TryAdd(key, new List<string> {str}))
            {
                dict[key].Add(str);
            }
        }

        return dict.Values.ToList<List<string>>();
    }

    private string SortString(string str)
    {
        char[] chars = str.ToCharArray();

        Array.Sort(chars);

        return new string(chars);
    }
}
