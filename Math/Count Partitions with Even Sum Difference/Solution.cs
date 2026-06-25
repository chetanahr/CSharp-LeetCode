public class Solution {
    public int CountPartitions(int[] nums) 
    {
        if(nums.Sum() % 2 == 0) return nums.Length-1;
        return 0;
        
    }
}
