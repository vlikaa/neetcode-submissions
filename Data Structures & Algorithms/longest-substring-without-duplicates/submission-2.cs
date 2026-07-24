public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        var length = 0;
        var l = 0;

        for (var r = 0; r < s.Length; ++r)
        {
            while (set.Contains(s[r]))
            {
                set.Remove(s[l]);
                ++l;
            }

            set.Add(s[r]);
            length = Math.Max(length, r - l + 1);
        }

        return length;
    }
}
