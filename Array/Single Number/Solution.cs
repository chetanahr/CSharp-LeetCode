public class Solution {
    public int SingleNumber(int[] nums) 
    {
        //using XOR property
        // a ^ a = 0 and a ^ 0 = a
        int result = 0;
        foreach(int x in nums)
        {
            result ^= x;
        }
        return result;
        
    }
}
