public class Solution {
    public bool IsArraySpecial(int[] nums) 
    {
        if(nums.Length == 1) return true;
        bool x = true;
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] % 2 == 0 && nums[i-1] % 2 == 0) x =false;
            else if(nums[i] % 2 != 0 && nums[i-1] % 2 != 0) x = false;
        }
        return x;
    }
}
