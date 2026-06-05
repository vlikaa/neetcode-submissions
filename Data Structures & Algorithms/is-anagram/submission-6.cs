public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        var freq = new int[26];

        foreach (var c in s)
        {
            ++freq[c - 'a'];
        }

        foreach (var c in t)
        {
            --freq[c - 'a'];

            if (freq[c -'a'] < 0)
            {
                return false;
            }
        }

        return true;
    }
}


