public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) 
    {
        int c = grid.GetLength(0);
        List<int> x = new List<int>();
        List<int> y = Enumerable.Range(1, (c*c)).ToList();
        int[] r = new int[2];
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(x.Contains(grid[i][j])) r[0] = grid[i][j];
                else
                {
                    x.Add(grid[i][j]);
                    y.Remove(grid[i][j]);
                }
            }
        }
        r[1] = y[0];
        return r;

        

        
    }
}
