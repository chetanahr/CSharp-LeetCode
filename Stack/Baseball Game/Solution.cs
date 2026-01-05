public class Solution {
    public int CalPoints(string[] operations) 
    {
        Stack<int> s = new Stack<int>();
        foreach(var x in operations)
        {
            if(x == "+")
            {
                int a = s.Pop();
                int b = s.Pop();
                s.Push(b);
                s.Push(a);
                s.Push(a+b);
            }
            else if(x == "D")
            {
                s.Push(2*s.Peek());
            }
            else if(x == "C")
            {
                s.Pop();
            }
            else
            {
                int y = int.Parse(x);
                s.Push(y);
            }
        }
        return s.Sum();
    }
}
