public class Solution {
    public int MirrorDistance(int n) 
    {
        int x = 0;
        int c = n;
        while(n > 0)
        {
            x = (n%10) + (x*10);
            n /= 10;
        }
        return Math.Abs(c - x);
    }
}
