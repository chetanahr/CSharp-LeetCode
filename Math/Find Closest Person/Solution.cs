public class Solution {
    public int FindClosest(int x, int y, int z) 
    {
        int a = Math.Abs(z - x);
        int b = Math.Abs(z - y);
        if(a == b) return 0;
        return (a>b)?2:1;
        
    }
}
