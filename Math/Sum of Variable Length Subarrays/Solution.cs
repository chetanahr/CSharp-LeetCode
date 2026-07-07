public class Solution {
    public int SubarraySum(int[] nums) 
    {
        int s = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            int j = Math.Max(0, i-nums[i]);
            for(int k = j; k <= i; k++)
            {
                s+= nums[k];
            }
        }
        return s;
    }
}
