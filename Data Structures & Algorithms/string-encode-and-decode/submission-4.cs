public class Solution {

    public string Encode(IList<string> strs) {
        var result = new StringBuilder();

        foreach (var s in strs)
        {
            result.Append(s.Length);
            result.Append('#');
            result.Append(s);
        }

        return result.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        var i = 0;

        while (i < s.Length)
        {
            var j = i;

            while (s[j] != '#')
            {
                ++j;
            }

            var length = int.Parse(s[i..j]);
            result.Add(s[(j + 1)..(j + 1 + length)]);
            i = j + 1 + length;
        }

        return result;
    }
}
