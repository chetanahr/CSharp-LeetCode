public class Solution {
    public int AlternatingSum(int[] nums) 
    {
        int s = 0;
        for(int i = 0; i< nums.Length; i++)
        {
            if(i%2 == 0) s+= nums[i];
            else s-= nums[i];
        }
        return s;
    }
}
