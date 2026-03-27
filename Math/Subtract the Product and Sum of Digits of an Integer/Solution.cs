public class Solution {
    public int SubtractProductAndSum(int n) 
    {
        int sum = 0;
        int pr = 1;
        while(n>0)
        {
            int x = n%10;
            sum += x;
            pr *= x;
            n /= 10;
        }
        return pr-sum;
    }
}
