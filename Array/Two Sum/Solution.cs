public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        for(int i = 0; i < nums.Count(); i++)
        {
            for(int j = 0; j < nums.Count(); j++)
            {
                if(i != j)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        return [i,j];
                    }
                }
            }
        }
        return [0,0];
    }
}
