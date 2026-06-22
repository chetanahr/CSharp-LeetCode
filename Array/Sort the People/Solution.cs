public class Solution {
    public string[] SortPeople(string[] names, int[] heights) 
    {
        //List<int> n = heights.ToList();
        string[] s = new string[names.Length];
        for(int i = 0; i < s.Length; i++)
        {
            int m = heights.Max();
            int index = Array.IndexOf(heights, m);
            s[i] = names[index];
            heights[index] = 0;
        }
        return s;
    }
}
