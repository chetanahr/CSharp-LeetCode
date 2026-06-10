public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) 
    {
        var x = hours.Where(c => c >= target);
        return x.Count();
    }
}
