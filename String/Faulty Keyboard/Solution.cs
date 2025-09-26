public class Solution {
    public string FinalString(string s) 
    {
        StringBuilder sb = new StringBuilder(s.Length);
        for(int i = 0; i < s.Length ; i++ )
        {
            if(s[i]== 'i')
            {
                sb = Reverse(sb);
            }
            else
            {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }
    public StringBuilder Reverse(StringBuilder s)
    {
        StringBuilder sb = new StringBuilder(s.Length);
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);  // Append characters in reverse order
        }
        return sb;
    }
}
