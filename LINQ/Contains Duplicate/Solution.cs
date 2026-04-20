public class Solution {
    public bool ContainsDuplicate(int[] nums) 
    {
        var x = nums.Distinct();
        if(nums.Length == x.Count()) return false;
        return true;
    }
}
