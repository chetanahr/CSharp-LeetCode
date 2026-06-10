public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) 
    {
        int x = 0;
        foreach(int i in hours)
        {
            if(i >= target) x++;
        }
        return x;
    }
}
