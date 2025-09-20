public class Solution {
    //optimising the solution because time was exceeding for larger strings
    public int CountBinarySubstrings(string s) 
    {
        int count = 0;
        int prev = 0;
        int curr = 1;
        for(int i = 1; i < s.Length ; i++)
        {
            if(s[i] == s[i-1])
            {
                curr++;
            }
            else
            {
                count += Math.Min(prev,curr);
                prev = curr;
                curr = 1;
            }
        }
        count += Math.Min(prev,curr);
        return count;
    }
}
