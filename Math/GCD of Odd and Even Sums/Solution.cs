public class Solution {
    public int GcdOfOddEvenSums(int n) 
    {
        int s1 = 0;
        int s2 = 0;
        for(int  i = 1; i <= 2*n; i++)
        {
            if(i%2 == 0) s2 += i;
            else s1 += i;
        }
        for(int i = s2/2; i >= 1; i--)
        {
           if(s1%i == 0 && s2%i == 0) return i;
        }
        return 1;
    }
}
