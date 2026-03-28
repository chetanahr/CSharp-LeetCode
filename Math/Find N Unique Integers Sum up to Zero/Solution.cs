public class Solution {
    public int[] SumZero(int n) 
    {
        int[] s = new int[n];
        int c = 1;
        
        for(int i = 1; i < n ; i++)
        {
            s[i-1] = -c;
            s[i] = c;  
            i++;
            c++;
        }
        if(n % 2 != 0)
        {
            s[n-1] = 0;
        }
        return s;
    }
}
