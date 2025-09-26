public class Solution {
    public int MissingNumber(int[] nums) 
    {
        int n = nums.Length+1;
        int missing = 0;
        for(int  i = 0; i < n; i++)
        {
            if(nums.Contains(i)) continue;
            else missing = i;
        }
        return missing;
    }
}
