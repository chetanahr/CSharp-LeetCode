public class Solution {
    public bool BackspaceCompare(string s, string t) 
    {
        return Build(s) == Build(t);
    }
    public string Build(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach(var c in s)
        {
            if(c == '#')
            {
                if(stack.Count>0) stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }
        return new string(stack.Reverse().ToArray());
    } 
}
