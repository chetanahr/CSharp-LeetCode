public class Solution {
    public int MySqrt(int x) 
    {
        if(x == 0)
        {
            return 0;
        }
        if(x == 1 || x == 2 || x == 3)
        {
            return 1;
        }
        //solving using Newton–Raphson Method
        double n = x/2;
        double root = 0;
        while(true)
        {
            root = 0.5 *(n + x/n);
            if(Math.Abs(root - n)< 1)
            {
                break;
            }
            n = root;
        }
        return (int)root;
    }
}
