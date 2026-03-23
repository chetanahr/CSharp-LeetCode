public class Solution {
    public string MakeGood(string s) 
    {
        Stack<char> c = new Stack<char>();
        c.Push(s[0]);
        for(int i = 1; i < s.Length; i++)
        {
            
            if(c.Count>0)
            {
                char a = c.Peek();
                if(char.IsUpper(s[i]) && a == char.ToLower(s[i]))
                {
                    c.Pop();
                }
                else if(char.IsLower(s[i]) && a == char.ToUpper(s[i])) c.Pop();
                else c.Push(s[i]);
            }
            else c.Push(s[i]);
        }
        return new string(c.Reverse().ToArray());
    }
}
