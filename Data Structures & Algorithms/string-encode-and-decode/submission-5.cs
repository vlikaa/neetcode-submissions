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

        for (var i = 0; i < s.Length; ++i)
        {    
            var separatorPos = i;
            while (s[separatorPos] != '#')
            {
                ++separatorPos;
            }

            var length = int.Parse(s[i..separatorPos]);
            var str = s[(separatorPos + 1)..(separatorPos + length + 1)];
            result.Add(str);

            i = separatorPos + length;
        }

        return result;
    }
}
