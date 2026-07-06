public class Solution {
    public string RestoreString(string s, int[] indices) 
    {
        char[] n = new char[s.Length];
        for(int i = 0; i < s.Length; i++)
        {
            int j = indices[i];
            n[j] = s[i];
        }
        string m = new string(n);
        return m;
    }
}
