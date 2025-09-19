public class Solution {
    public int Reverse(int x) 
    {
        if(x<0)
        {
            if(x <= int.MinValue)
                return 0;
            else
                return -(ReverseInt(Math.Abs(x)));
        }
        else
        {
            return ReverseInt(x);
        }
        
    }
    public int ReverseInt(int x)
    {
        double rev = 0;
        while(x > 0)
        {
            int rem = x % 10;
            rev = rev*10 + rem;
            x /=10;
        }
        if(rev > int.MaxValue)
            return 0;
        else
            return (int)rev;
    }
}
