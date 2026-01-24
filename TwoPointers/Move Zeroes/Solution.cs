public class Solution {
    public void MoveZeroes(int[] nums) 
    {
        int zero = 0;
        int non = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i]== 0) zero++;
            else
            {
                nums[non]= nums[i];
                non++;
            }
        }
        for(int j = nums.Length-zero; j<nums.Length; j++)
        {
            nums[j]=0;
        }
        
    }
}
