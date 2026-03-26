public class Solution {
    public int MinLength(string s)
    {
         Stack<char> c = new Stack<char>();
        foreach(var i in s)
        {
            if(c.Count() > 0)
            {
                char p = c.Peek();
                if((p == 'A' && i == 'B') || (p == 'C' && i == 'D')) c.Pop();
                else c.Push(i);
            }
            else c.Push(i);
        }
        return c.Count();
        
        
    }
}
