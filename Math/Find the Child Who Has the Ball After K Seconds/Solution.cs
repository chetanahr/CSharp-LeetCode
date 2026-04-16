public class Solution {
    public int NumberOfChild(int n, int k) 
    {
        int ans = -1;
        int dir = 1;   
        for(int i = 0; i <= k; i++)
        {
            ans += dir;
            if(ans == n-1) dir = -1;
            if(ans == 0) dir = 1;
        }
        return ans;
    }
}
