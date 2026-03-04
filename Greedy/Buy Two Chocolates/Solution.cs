public class Solution {
    public int BuyChoco(int[] prices, int money) 
    {
        int x = money;
        Array.Sort(prices);
        for(int i = 0; i < 2; i++)
        {
            if(money - prices[i] >= 0)
            {
                money -= prices[i];
            }
            else 
            {
                money = x;
                break;
            }
        }
        return money;
    }
}
