public class Solution {
    public int[] Shuffle(int[] nums, int n) 
    {
        int[] s = new int[nums.Length];
        int j = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            s[i] = nums[j];
            s[i+1] = nums[j+n];
            j++;
            i++;
            if(j == n) break;
        }
        return s;
    }
}
