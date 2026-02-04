public class Solution {
    public int ArrangeCoins(int n) 
    {
        int x = n;
        int i = 1;
        if(n == 1) return 1;
        while(i < x && n-i >= 0)
        {
            n -= i;
            i++;
        }
        return i-1;
    }
}
