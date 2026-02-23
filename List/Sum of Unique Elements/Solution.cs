public class Solution {
    public int SumOfUnique(int[] nums)
    {
        int sum = 0;
        List<int> x = new List<int>();
        List<int> y = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(x.Contains(nums[i]))
            {
                x.Remove(nums[i]);
                sum -= nums[i];
                y.Add(nums[i]);
            }
            else if(!x.Contains(nums[i]) && !y.Contains(nums[i]))
            {
                x.Add(nums[i]);
                sum += nums[i];
            }
        }
        return sum;
    }
}
