public class Solution {
    public string RemoveTrailingZeros(string num) 
    {
        List<char> s = num.ToList();
        while(s.Last() == '0')
        {
            s.RemoveAt(s.Count -1 );
        }
        string result = new string(s.ToArray());
        return result;
    }
}
