public class Solution {
    public bool IsThree(int n) 
    {
        int x = 1;
        for(int i = 2;i <= n; i++)
        {
            if(n%i == 0) x++;
        }
        if(x == 3)return true;
        return false;
        
    }
}
