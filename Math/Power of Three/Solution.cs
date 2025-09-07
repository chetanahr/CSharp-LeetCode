public class Solution {
    public bool IsPowerOfThree(int n) 
    {
        if(n <= 0)
        {
            return false;
        }
        double x = Math.Log(n)/Math.Log(3);
        if(Math.Abs(x - Math.Round(x)) < 1e-10)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
