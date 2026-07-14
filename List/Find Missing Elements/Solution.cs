public class Solution {
    public IList<int> FindMissingElements(int[] nums) 
    {
        List<int> l1 = new List<int>();
        Array.Sort(nums);
        for(int i = nums[0]; i <= nums[nums.Length-1]; i++)
        {
            if(!nums.Contains(i)) l1.Add(i);
        }
        return l1;
    }
}
