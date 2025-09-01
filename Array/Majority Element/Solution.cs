public class Solution {
    public int MajorityElement(int[] nums) 
    {
        Array.Sort(nums);
        int n = (int)nums.Length/2;       
        return nums[n];
        
    }
}
