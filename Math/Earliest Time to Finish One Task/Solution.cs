public class Solution {
    public int EarliestTime(int[][] tasks) 
    {
        int[] s = new int[tasks.Length];
        for(int i =0; i < tasks.Length; i++)
        {
            int a = 0;
            for(int j =0; j < tasks[i].Length; j++)
            {
                a += tasks[i][j];
            }
            s[i] = a;
        }
        return s.Min();
    }
}
