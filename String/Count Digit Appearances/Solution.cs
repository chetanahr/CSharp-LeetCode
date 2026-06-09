public class Solution {
    public int CountDigitOccurrences(int[] nums, int digit) 
    {
        int c = 0;
        foreach(int i in nums)
        {
            string s = i.ToString();
            char b = (char)(digit+'0');
            c += s.Count(k => k == b);
        }
        return c;
    }
}
