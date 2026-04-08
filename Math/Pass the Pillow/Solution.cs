public class Solution {
    public int PassThePillow(int n, int time) 
    {
        int dir = 1;
        int ans = 1;
        for(int i = 1; i <= time; i++)
        {
            ans += dir;
            if(ans == n) dir = -1;
            if(ans == 1) dir = 1;
        }
        return ans;
    }
}
