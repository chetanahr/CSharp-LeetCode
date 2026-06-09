public class Solution {
    public int[] MinOperations(string boxes) 
    {
        int[] x = new int[boxes.Length];
        for(int i = 0; i < boxes.Length; i++)
        {
            for(int j = 0; j < boxes.Length; j++)
            {
                if(boxes[j]== '1')
                {
                    x[i] += Math.Abs(j-i);
                }
            }
        }
        return x;
    }
}
