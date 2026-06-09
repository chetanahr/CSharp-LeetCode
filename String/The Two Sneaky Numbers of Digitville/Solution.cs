public class Solution {
    public int[] GetSneakyNumbers(int[] nums) 
    {
        List<int> n = new List<int>();
        List<int> c = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(!c.Contains(nums[i]))
            {
                c.Add(nums[i]);
            }
            else n.Add(nums[i]);
        }
        return n.ToArray();
    }
}
