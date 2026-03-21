public class Solution {
    public int MinimumChairs(string s) 
    {
        int x = 0;
        List<int> n = new List<int>();
        foreach(var i in s)
        {
            if(i == 'E') x++;
            else x --;
            n.Add(x);
        }
        return n.Max();        
    }
}
