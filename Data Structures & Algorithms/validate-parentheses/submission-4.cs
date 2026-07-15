public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var dict = new Dictionary<char, char>
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        foreach (var c in s)
        {
            if (dict.Values.Contains(c))
            {
                stack.Push(c);
                continue;
            }

            if (stack.Count == 0 || stack.Peek() != dict[c])
            {
                return false;
            }

            stack.Pop();
        }

        return stack.Count == 0;
    }
}
