public class Solution {
    public int MinCost(int n) 
    {
        int a = 0;
        while(n!=1)
        {
            a += n-1;
            n--;
        }
        return a;
        
    }
}
