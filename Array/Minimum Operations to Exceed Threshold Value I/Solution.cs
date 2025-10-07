public class Solution {
    public int MinOperations(int[] nums, int k) 
    {
        Array.Sort(nums);
        int n = 0;
        for(int i = 0; i< nums.Length; i++)
        {
            if(nums[i]>= k) return n;
            else n++;
        }
        return n;
    }
}
