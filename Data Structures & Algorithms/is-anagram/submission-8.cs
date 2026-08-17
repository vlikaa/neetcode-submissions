public class Solution {
    public bool IsAnagram(string s, string t) {
        var dict = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (!dict.TryAdd(c, 1))
            {
                ++dict[c];
            }
        }

        foreach (var c in t)
        {
            if (!dict.TryAdd(c, -1))
            {
                --dict[c];
            }
        }

        foreach (var value in dict.Values)
        {
            if (value != 0)
            {
                return false;
            }
        }

        return true;
    }
}


