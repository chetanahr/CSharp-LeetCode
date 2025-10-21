public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int i = 0;
        int j = 0;
        int[] result = new int[m+n];
        if(m == 0) result = nums2;
        else if(n == 0) result = nums1;
        else
        {
            result = nums1;
            for(int k = 0; k < n; k++)
            {
                result[k+m] = nums2[k];
            }
            Array.Sort(result);
        }
        Array.Copy(result, nums1, m+n);
    }
}
