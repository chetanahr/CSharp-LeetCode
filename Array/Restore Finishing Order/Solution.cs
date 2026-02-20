public class Solution {
    public int[] RecoverOrder(int[] order, int[] friends) 
    {
        int[] x = new int[friends.Length];
        int j = 0;
        for(int i = 0; i < order.Length; i++)
        {
            if(friends.Contains(order[i]))
            {
                x[j] = order[i];
                j++;
            }
        }
        return x;
    }
}
