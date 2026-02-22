public class Solution {
    public int MinimizedStringLength(string s) 
    {
        char[] c = s.ToCharArray();
        char[] d = c.Distinct().ToArray();
        return d.Length;
    }
}
