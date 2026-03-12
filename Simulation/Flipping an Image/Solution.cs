public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) 
    {
        for(int i = 0 ; i < image.Length; i++)
        {
            int[] x = image[i];
            Array.Reverse(x);
            for(int j = 0; j < x.Length; j++)
            {
                x[j] = 1 - x[j];
            }
            image[i] = x;
        }
        return image;
        
    }
}
