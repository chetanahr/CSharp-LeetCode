public class Solution {
    public int FindGCD(int[] nums) 
    {
        int x = 1;
        nums.Sort();
        for(int i = 1; i <= nums[0]; i++)
        {
            if(nums[0]%i == 0 && nums[nums.Length-1]%i == 0 && i > x)
            {
                x = i;
            }
        }
        return x;
    }
}
