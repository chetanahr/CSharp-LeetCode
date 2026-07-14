public class Solution {
    public int[] FinalPrices(int[] prices) 
    {
        int[] s = new int[prices.Length];
        for(int i = 0; i < prices.Length; i++)
        {
            bool a = true;
            for(int j = i+1; j < prices.Length && a; j++)
            {
                if(prices[j] <= prices[i])
                {
                    a = false;
                    s[i] = prices[i] - prices[j];
                }
            }
            if(a) s[i] = prices[i];
        }
        return s;
    }
}
