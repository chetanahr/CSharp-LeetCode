public class Solution {
    public int CountDigits(int num) 
    {
        int n = 0;
        int b = num;
        while(b>9)
        {
            int a = b%10;
            if(num%a  == 0) n++;
            b /= 10;
        }
        if(num%b == 0) n++;
        return n;
    }
}
