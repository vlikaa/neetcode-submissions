public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();

        foreach (var str in strs)
        {
            var key = SortString(str);

            if (!dict.TryAdd(key, new List<string> {str}))
            {
                dict[key].Add(str);
            }
        }

        foreach (var v in dict.Values)
        {
            result.Add(v);
        }

        return result;
    }

    private string SortString(string str)
    {
        char[] chars = str.ToCharArray();

        Array.Sort(chars);

        return new string(chars);
    }
}
