public class Solution {
    public int AlternateDigitSum(int n) 
    {
        int sum = 0;
        int[] str = n.ToString().Select(c => c -'0').ToArray();
        for(int i = 0; i < str.Length; i++)
        {
            if(i % 2 == 0)
            {
                sum += str[i];
            }
            else sum-= str[i];
        }
        return sum;
        
    }
}
