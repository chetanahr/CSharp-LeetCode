public class Solution {
    public int MaxDepth(string s) 
    {
        int l = 0;
        int r = 0;
        int c = 0;
        int d = 0;
        foreach(var i in s)
        {
            if(i == '(') l++;
            else if(i == ')')  r++;
            else
            {
                int x = l-r;
                if(x > c) c = x;
            }
            if(c >= r && l > c && l-r>d ) d = l-r;
            if(l == r)
            {
                l = 0;
                r = 0;
            }
        }
        if(d>0)return d;
        return c;
    }
}
