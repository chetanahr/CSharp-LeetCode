public class Solution {
    public int MinElement(int[] nums) 
    {
        int[] n = new int[nums.Length];
        for(int i = 0; i< nums.Length; i++)
        {
            n[i] = Sum(nums[i]);
        }
        return n.Min();
    }
    public int Sum(int n)
    {
        int s = 0;
        while(n > 0)
        {
            s += n%10;
            n /= 10;
        } 
        return s;
    }
}
