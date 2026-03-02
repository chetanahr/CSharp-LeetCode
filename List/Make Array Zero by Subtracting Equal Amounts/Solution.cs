public class Solution {
    public int MinimumOperations(int[] nums) 
    {
        List<int> x = nums.Distinct().ToList();
        x.RemoveAll(c => c == 0);
        return x.Count;
        
    }
}
