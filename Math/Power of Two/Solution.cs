public class Solution {
    public bool IsPowerOfTwo(int n) 
    {
        if( n <= 0)
        {
            return false;
        }
        double x = Math.Log(n)/Math.Log(2);
        if(Math.Abs(x - Math.Round(x))< 1e-10)
        return true;
        else
        return false;
        
    }
}
