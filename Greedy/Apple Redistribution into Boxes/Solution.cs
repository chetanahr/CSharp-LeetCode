public class Solution {
    public int MinimumBoxes(int[] apple, int[] capacity) 
    {
        int n = 0;
        int rem = 0;
        int sum1 = apple.Sum();
        int sum2 = capacity.Sum();
        if(sum1 == sum2) return capacity.Length;
        Array.Sort(capacity);
        Array.Reverse(capacity);
        for(int i = 0; i < apple.Length; i++)
        {
            if(rem == 0)
            {
                rem = capacity[n] - apple[i];
                n++;
            }
            else 
            {
                rem -= apple[i];
                
            }
            while(rem < 0) 
            {
                rem = capacity[n] + rem;
                n++;
            }      
        }
        if(rem < 0) n++;
        return n;
    }
}
