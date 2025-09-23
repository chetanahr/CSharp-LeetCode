public class Solution {
    public int AddDigits(int num) 
    {
        if(num < 10)
        {
            return num;
        }
        while(num >= 10)
        {
            num = AddFunction(num);
        }
        return num;
        
    }
    public int AddFunction(int n)
    {
        int res = 0;
        while(n > 0)
        {
            int rem = n % 10;
            res +=rem;
            n /= 10;
        }
        return res;
    }
}
