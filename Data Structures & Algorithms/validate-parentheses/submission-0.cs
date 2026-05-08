public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var brackets = new Dictionary<char, char> {{'}', '{'}, {')', '('}, {']', '['}};

        foreach (var c in s)
        {
            if (brackets.ContainsKey(c))
            {
                if (stack.Count != 0 && brackets[c] == stack.Peek())
                {
                    stack.Pop();
                }
                else 
                {
                    return false;
                }
            }
            else 
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
