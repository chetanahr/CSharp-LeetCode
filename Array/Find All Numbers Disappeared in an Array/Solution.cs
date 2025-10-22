public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) 
    {
        List<int> ans = Enumerable.Range(1,nums.Length).ToList();
        for(int i = 0; i < nums.Length; i++)
        {
            if(ans.Contains(nums[i])) ans.Remove(nums[i]);
        }
        return ans;
    }
}
