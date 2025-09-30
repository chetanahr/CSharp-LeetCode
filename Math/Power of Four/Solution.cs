public class Solution {
    public bool IsPowerOfFour(int n) 
    {

        if(n <= 0)
        {
            return false;
        }
        double x = Math.Log(n)/Math.Log(4);
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
