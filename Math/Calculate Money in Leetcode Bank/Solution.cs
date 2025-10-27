public class Solution {
    public int TotalMoney(int n) 
    {
        int mul = 0;
        int x = n % 7;
        int sum = 0;
        for(int i = 1; i <= n / 7; i++)
        {
            sum += (i+3)*7;
            mul = i;
        }
        if(sum > 0) sum += ((mul+x)*(x+mul+1)/2) - (mul*(mul+1)/2);
        else sum = (x*(x+1)/2) ;
        return sum;
    }
}
