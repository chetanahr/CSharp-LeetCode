public class Solution {
    public bool IsBalanced(string num) 
    {
        int sum1 = 0;
        int sum2 = 0;
        for(int i = 0; i< num.Length; i++)
        {
            int digit = num[i] - '0';
            if(i%2 == 0)
            {
                sum1 += digit;
            }
            else
            {
                sum2 += digit;
            }
        }
        if(sum1 == sum2) return true;
        else return false;
        
    }
}
