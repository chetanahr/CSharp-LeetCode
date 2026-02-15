public class Solution {
    public string RemoveTrailingZeros(string num) 
    {
        string s = "";
        bool x = false;
        for(int i = num.Length-1; i>=0; i--)
        {
            if(num[i]!='0') x = true;
            if(x) s += num[i];
        }
        string reversed = new string(s.Reverse().ToArray());
        return reversed;
    }
}
