public class Solution {
    public int FindContentChildren(int[] g, int[] s) 
    {
        int c = 0;
        Array.Sort(g);
        Array.Sort(s);
        List<int> list = s.ToList();

        for(int i = 0; i < g.Length && i < list.Count; i++)
        {
            if(list[i] < g[i])
            {
                list.Remove(list[i]);
                i--;
            }
            else c++;
            
        }
        return c;
    }
}
