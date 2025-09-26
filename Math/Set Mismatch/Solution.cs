public class Solution {
    public int[] FindErrorNums(int[] nums) 
    {
       long sum = 0;
       long exSum = 0;
       long sumSq = 0;
       long exSumSq = 0;
       for(int i = 1; i <= nums.Length; i++)
       {
        sum += nums[i-1];
        exSum +=i;
        sumSq += nums[i-1] * nums[i-1];
        exSumSq += i * i; 
       }
       long diffSum = sum - exSum;
       long diffSq = sumSq - exSumSq;
       int D = (int)(diffSum + (diffSq / diffSum)) / 2;
       int M = D - (int)diffSum;
       return [D,M];
    }
}
