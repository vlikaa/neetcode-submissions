public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dict = new Dictionary<char, int>();
        var l = 0;

        var res = 0;
        var maxF = 0;

        for (var r = 0; r < s.Length; ++r)
        {
            if (!dict.TryAdd(s[r], 1))
            {
                ++dict[s[r]];
            }

            maxF = Math.Max(maxF, dict[s[r]]);

            while ((r - l + 1) - maxF > k)
            {
                --dict[s[l++]];
            } 

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
