public class Solution {
    public string ClearDigits(string s) 
    {
        Stack<char> c = new Stack<char>();
        foreach(var i in s)
        {
            if(c.Count>0)
            {
                if(char.IsDigit(i)) c.Pop();
                else c.Push(i);
            }
            else c.Push(i);
        }
        return new string(c.Reverse().ToArray());
    }
}
