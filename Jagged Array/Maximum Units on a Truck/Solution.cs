 public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) 
    {
        int x = 0;
        Array.Sort(boxTypes, (a, b) => b[1].CompareTo(a[1]));
        foreach(var a in boxTypes)
        {
            if(truckSize >= a[0]) 
            {
                x+= a[1]*a[0];
                truckSize -= a[0];
            }
            else
            {
                x+= a[1]*truckSize;
                break;
            }
        }
        return x;
        
    }
}
