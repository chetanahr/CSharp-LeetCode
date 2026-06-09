public class Solution {
    public int[] ConcatWithReverse(int[] nums) 
    {
        int[] ans = new int[nums.Length*2];
        int j = ans.Length -1;
        for(int i = 0 ; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[j] = nums[i];
            j--;
        }
        return ans;
    }
}
