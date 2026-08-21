public class Solution {
    public bool IsAnagram(string s, string t) {
        var firstString = s.ToArray();
        var secondString = t.ToArray();

        Array.Sort(firstString);
        Array.Sort(secondString);

        return firstString.SequenceEqual(secondString);
    }
}


