public class Solution {
    public int ThirdMax(int[] nums) 
    {
        if(nums.Distinct().ToArray().Length < 3) return nums.Max();
        
        for(int i = 0; i<2; i++)
        {
            nums = nums.Where(x => x != nums.Max()).ToArray();
        }
        return nums.Max();
    }
}
