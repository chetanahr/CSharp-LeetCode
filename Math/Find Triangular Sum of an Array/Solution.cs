public class Solution {
    public int TriangularSum(int[] nums) 
    {
        int n = nums.Length;
        int sum = 0;
        int[] b = nums;
        if(nums.Length <= 2) return nums.Sum()%10;
        while(n!= 1)
        {
            int[] a = new int[n-1];
            for(int i = 1; i < b.Length; i++)
            {
                a[i-1] = (b[i-1]+b[i])%10;
            } 
            if(a.Length == 2) sum = a.Sum()%10;
            b = a;
            n--;
        }
        return sum;
    }
}
