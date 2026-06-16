public class Solution {
    public string ProcessStr(string s) 
    {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i]== '*' && sb.Length > 0) sb.Remove(sb.Length-1,1);
            else if(s[i] == '#') sb.Append(sb);
            else if(s[i] == '%' && sb.Length > 0) sb = ReverseS(sb);
            else if(s[i] != '*' && s[i]!= '%')sb.Append(s[i]);
        }
        string ss = sb.ToString();
        return ss;
    }
    public StringBuilder ReverseS(StringBuilder s)
    {
        StringBuilder sb = new StringBuilder();
        for(int i = s.Length-1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb;
    } 
}
