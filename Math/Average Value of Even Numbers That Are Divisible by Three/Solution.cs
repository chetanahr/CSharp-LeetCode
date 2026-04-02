public class Solution {
    public int AverageValue(int[] nums) 
    {
        int sum = 0;
        int i = 0;
        for(int j = 0; j < nums.Length; j++)
        {
            if(nums[j]%6 == 0)
            {
                sum += nums[j];
                i++;
            }
        }
        if(i>0) return sum/i;
        return 0;
        
    }
}
