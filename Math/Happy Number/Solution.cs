public class Solution {
    public bool IsHappy(int n) 
    {
        while(n > 4 || n ==1)
        {
            n = SquareOfDigits(n);
            if(n==1)
            {
                return true;
            }
        }
        return false;
    }
    public int SquareOfDigits(int n)
    {
        int sum = 0;
        while(n>0)
        {
            int rem = n % 10;
            sum += rem*rem;
            n /=10;
        }
        return sum;
    }
}
