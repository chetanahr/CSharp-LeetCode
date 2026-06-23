public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) 
    {
        int s = 0;
        for(int i= 0; i < nums.Length; i++)
        {
            int a = nums[i]+ diff;
            int b = a + diff;
            if(nums.Contains(a) && nums.Contains(b)) s++;
        }
        return s;
    }
}
