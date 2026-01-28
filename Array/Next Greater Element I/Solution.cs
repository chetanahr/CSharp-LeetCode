public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) 
    {
        int[] re = new int[nums1.Length];
        for(int i = 0; i < nums1.Length; i++)
        {
            int x = Array.IndexOf(nums2, nums1[i]);
            for(int j = x+1; j < nums2.Length; j++)
            {
                if(nums2[j] > nums1[i]) 
                {
                    re[i] = nums2[j];
                    break;
                }
            }
            if(re[i] == 0) re[i] = -1;
        }
        return re;
        
    }
}
