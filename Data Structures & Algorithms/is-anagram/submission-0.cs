public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        var matches = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (!matches.ContainsKey(c))
            {
                matches[c] = 0;
            }

            ++matches[c];
        }
        

        foreach (var c in t)
        {
            if (!matches.ContainsKey(c))
            {
                return false;
            }

            --matches[c];
        }

        foreach (var item in matches)
        {
            if (item.Value != 0)
            {
                return false;
            }
        }

        return true;
    }
}
