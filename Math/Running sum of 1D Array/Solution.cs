public class Solution {
    public int[] RunningSum(int[] nums) 
    {
        int sum = 0;
        int[] s = new int[nums.Length];
        for(int i = 0; i < s.Length; i++)
        {
            sum += nums[i];
            s[i] = sum;
        }
        return s;
    }
}
