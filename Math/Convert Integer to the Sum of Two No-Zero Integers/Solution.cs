public class Solution {
    public int[] GetNoZeroIntegers(int n) 
    {
        int[] a = new int[2];
        for(int i = 1; i < n; i++)
        {
            int x = i;
            if(!x.ToString().Contains('0') && !(n-x).ToString().Contains('0'))
            {
                a[0] = x;
                a[1] = n-x;
                return a;
            }
        }
        return a;
    }
}
