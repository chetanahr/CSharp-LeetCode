public class Solution {
    public int CommonFactors(int a, int b) 
    {
        int x = 1;
        for( int i = 2; i <= a || i <= b ; i++)
        {
            if(a % i == 0 && b % i == 0) x++;
        }
        return x;
    }
}
