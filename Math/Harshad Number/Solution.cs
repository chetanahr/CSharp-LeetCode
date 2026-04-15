public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) 
    {
        int n = 0;
        int y = x;
        while(y > 9)
        {
            n += y % 10;
            y /= 10;
        }
        n += y;
        if(x%n == 0) return n;
        else return -1;
        
    }
}
