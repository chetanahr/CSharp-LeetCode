public class Solution {
    public int MinOperations(int n) 
    {
        int x = ((n-1)*2)+1;
        int a = 0;
        int c = 0;
        int y = 0;
        if(x%2 == 0) 
        {
            a = x/2;
            c = (n-1)/2;
        }
        else 
        {
            a = (x+1)/2;
            c = n/2;
        }
        for(int i = 0; i < c; i++)
        {
            int s = (2*i)+1;
            y += a-s;
        }
        return y;
    }
}
