public class Solution {
    public int[] DistributeCandies(int candies, int num_people) 
    {
        int j = 1;
        int[] n = new int[num_people];
        while(candies > 0)
        {
            for(int i = 0; i < n.Length; i++)
            {
                if(candies - j >= 0) 
                {
                    n[i] = n[i]+ j;
                    candies -= j;
                }
                else
                {
                    n[i] = n[i] + candies;
                    return n;
                }
                j++;
            }
        }
        return n;
    }
}
