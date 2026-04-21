public class Solution {
    public int SmallestNumber(int n, int t) 
    {
        int sum = n > 9? Product(n): n;
        if(sum%t == 0) return n;
        else
        {
            for(int i = 1; i <= 10; i++)
            {
                int x = n+i;
                sum = Product(x);
                if((sum)%t == 0)
                {
                    return n+i;
                    break;
                }
            }
        }
        return 1;
    }
    private int Product (int n)
    {
        int sum = 1;
        while(n > 9)
        {
            sum *= n%10;
            n /= 10;
        }
        return sum*n;
    }
}
