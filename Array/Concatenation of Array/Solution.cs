public class Solution {
    public int[] GetConcatenation(int[] nums) 
    {
        int[] n = new int[nums.Length*2];
        for(int i = 0; i < nums.Length; i++)
        {
            n[i] = nums[i];
            n[i+nums.Length] = nums[i];
        }
        return n;
    }
}
