public class Solution {
    public int MinMaxGame(int[] nums) 
    {
        int n = nums.Length;
        int[] b = nums;
        int s = 0;
        if(n <= 2) return nums.Min();
        while(n!=1)
        {
            int[] a = new int[n/2];
            for(int i = 0; i < a.Length; i++)
            {
                if(i%2 == 0) a[i] = Math.Min(b[2*i],b[(2*i)+1]);
                else a[i] = Math.Max(b[2*i],b[(2*i)+1]);
            } 
            if(a.Length == 2) s = Math.Min(a[0], a[1]);
            b = a;
            n /= 2;
        }
        return s;
    }
}
