public class Solution {
    public bool IsPalindrome(string s) {
        short l = 0, r = (short)(s.Length - 1); 

        while (l < r)
        {
            while (l < r && !IsAlphaNumeric(s[l]))
            {
                ++l;
            }

            while (l < r && !IsAlphaNumeric(s[r]))
            {
                --r;
            }

            if (ToLower(s[l]) != ToLower(s[r]))
            {
                return false;
            }

            ++l;
            --r;
        }

        return true;
    }

    private bool IsAlphaNumeric(char c) =>
        (c is >= 'A' and <= 'Z') || (c is >= 'a' and <= 'z') || (c is >= '0' and <= '9');


    private char ToLower(char c) =>
        (c is >= 'A' and <= 'Z') ? (char)(c + 32) : c;
}
