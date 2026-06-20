public class Solution {
    public int LargestAltitude(int[] gain) 
    {
        int[] s = new int[gain.Length+1];
        s[0] = 0;
        for(int i = 0; i< gain.Length; i++)
        {
            s[i+1] = s[i] + gain[i];
        }
        Array.Sort(s);
        return s[s.Length-1];
    }
}
