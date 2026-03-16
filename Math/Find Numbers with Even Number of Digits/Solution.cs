public class Solution {
    public int FindNumbers(int[] nums) 
    {
        int x = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(Digits(nums[i])%2 == 0) x++;
        }
        return x;
    }
    public int Digits(int num)
    {
        int n = 0;
        while(num != 0)
        {
            num /= 10;
            n++;
        }
        return n;
    }
}
