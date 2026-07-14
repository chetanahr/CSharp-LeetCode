public class Solution {
    public bool CheckGoodInteger(int n) 
    {
        var x = DigitSum(n);
        if(x.a-x.b >= 50) return true;
        return false;
    }
    public (int a, int b) DigitSum(int n)
    {
        int s = 0;
        int s1 = 0;
        while(n > 0)
        {
            s += n%10;
            s1 += (n%10)*(n%10);
            n /= 10;
        }
        return (s1,s);
    }
}
