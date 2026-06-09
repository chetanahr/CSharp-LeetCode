public class Solution {
    public int[] TransformArray(int[] nums) 
    {
        int[] n = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++ )
        {
            n[i] = nums[i]%2 == 0 ? 0 : 1;
        }
        Array.Sort(n);
        return n;
    }
}
