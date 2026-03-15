public class Solution {
    public string MaximumOddBinaryNumber(string s) 
    {
        int count = s.Count(c => c == '1');
        char[] c = new char[s.Length];
        c[s.Length-1] = '1';
        count--;
        for(int i = 0; i < s.Length-1; i++)
        {
            if(count!= 0)
            {
                c[i] = '1';
                count--;
            }
            else c[i] = '0';
        }
        string r = new string(c);
        return r;
        
    }
}
