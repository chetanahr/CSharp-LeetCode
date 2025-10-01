public class Solution {
    public int[] NumberGame(int[] nums) 
    {
        Array.Sort(nums);
        int[] arr = new int[nums.Length];
        for(int i = 1; i< nums.Length; i++)
        {
            arr[i] = nums[i-1];
            arr[i-1] = nums[i];
            i++;
        }
        return arr;
    }
}
