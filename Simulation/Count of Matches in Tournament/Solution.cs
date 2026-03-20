public class Solution {
    public int NumberOfMatches(int n) 
    {
        int total = 0;
        while(n>1)
        {
            if(n % 2 == 0)
            {
                total += n/2;
                n /= 2;
            }
            else
            {
                total += (n-1)/2;
                n = 1 + (n-1)/2;
            }
        }
        return total;
        //You can simply return n-1, but this code computes the value.
    }
}
