public class Solution {
    public bool CanAliceWin(int[] nums) 
    {
        int single = 0;
        int d = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i]<10) single += nums[i];
            else d += nums[i];
        }
        if(single == d) return false;
        else return true;
        
    }
}
