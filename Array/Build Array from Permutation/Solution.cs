public class Solution {
    public int[] BuildArray(int[] nums) 
    {
        int[] ans = new int[nums.Length];
        for(int i = 0; i< nums.Length; i++)
        {
            int x = nums[i];
            ans[i] = nums[x];
        }
        return ans;
    }
}
