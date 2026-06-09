public class Solution {
    public int MaximumWealth(int[][] accounts) 
    {
        int s = 0;
        for(int i = 0; i < accounts.Length; i++)
        {
            int a = 0;
            for(int j = 0; j < accounts[i].Length; j++)
            {
                a += accounts[i][j];
            }
            if(s < a) s = a;
        }
        return s;
    }
}
