public class Solution {
    public int CountEven(int num) 
    {
        int n = 0;
        for(int i = 2; i <= num; i++)
        {
            if(i < 9 && i % 2 == 0) n++;
            if(i > 9)
            {
                int j = 0;
                int k = i;
                while(k > 9)
                {
                    j += k%10;
                    k /= 10;
                }
                j += k;
                if(j % 2 == 0) n++;
            }
        }
        return n;
    }
}
