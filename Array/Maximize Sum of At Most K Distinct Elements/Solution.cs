public class Solution {
    public int[] MaxKDistinct(int[] nums, int k) 
    {
        nums.Sort();
        Array.Reverse(nums);
        List<int> n = new List<int>();
        for(int i= 0; i < nums.Length; i++)
        {
            if(!n.Contains(nums[i])) n.Add(nums[i]);
            if(n.Count() == k) break;
        }
        return n.ToArray();
        
    }
}
