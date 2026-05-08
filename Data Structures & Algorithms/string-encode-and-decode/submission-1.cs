public class Solution {
    private const char Delimiter = '#';

    public string Encode(IList<string> strs) {
        var encoded = new StringBuilder();

        foreach (var s in strs)
        {
            encoded.Append(s.Length);
            encoded.Append(Delimiter);
            encoded.Append(s);
        }

        return encoded.ToString();
    }

    // "#3asd#basd"
    public List<string> Decode(string s) {
        var decoded = new List<string>();

        var startPos = 0;
        while (startPos < s.Length)
        {
            var delimiterPos = startPos;
            while (s[delimiterPos] != Delimiter)
            {
                ++delimiterPos;
            }

            var strLength = int.Parse(s[startPos..delimiterPos]);
            var strEnd = delimiterPos + strLength + 1;
            var str = s[(delimiterPos + 1)..strEnd];

            decoded.Add(str);

            startPos = strEnd;
        }
        
        return decoded;
   }
}
