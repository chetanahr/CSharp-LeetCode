public class Solution {
    public string RemoveDuplicates(string s) 
    {
        Stack<char> c = new Stack<char>();
        c.Push(s[0]);
        for(int i = 1; i < s.Length; i++)
        {
            if(c.Count() > 0) 
            {
                char j = c.Peek();
                if(s[i]== j) c.Pop();
                else c.Push(s[i]);
            }
            else c.Push(s[i]);
        }
        return new string(c.Reverse().ToArray());
        
    }
}
