 public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) 
    {
        int[] s = new int[nums.Length];
        for(int i = 0; i< nums.Length; i++)
        {
            int a = 0;
            for(int j = 0; j< nums.Length; j++)
            {
                if(nums[j] < nums[i]) a++;
            }
            s[i] = a;
        }
        return s;
    }
}
