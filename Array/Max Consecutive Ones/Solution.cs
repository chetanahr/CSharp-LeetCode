public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int c = 0;
        int last = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i]== 1) c++;
            else
            {   
                if(last < c) last = c;
                c = 0;
            }
        }
        if(last < c) last = c;
        return last;
    }
}
