public class Solution {

    public string Encode(IList<string> strs) {
        var result = new StringBuilder();

        foreach (var str in strs)
        {
            result.Append(str.Length);
            result.Append('#');
            result.Append(str);
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
            var str = s[(j + 1)..(j + 1 + length)];
            result.Add(str);

            i = j + 1 + length;
        }

        return result;
    }
}
