public class Solution {
    public int DifferenceOfSum(int[] nums) 
    {
        int sum = 0;
        int dsum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            int j = nums[i];
            sum += j;
            if(j< 10) dsum += j;
            else
            {
                while(j > 9)
                {
                    dsum += j%10;
                    j /= 10;
                }
                dsum += j;
            }
        }
        return Math.Abs(sum-dsum);
        
    }
}
