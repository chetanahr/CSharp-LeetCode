public class Solution {
    public int ReverseDegree(string s) 
    {
        int s1 = 0;
        for(int i = 0; i < s.Length; i++)
        {
            int x = 91 - Char.ToUpper(s[i]);
            s1 += x*(i+1);
        }
        return s1;
        
    }
}
