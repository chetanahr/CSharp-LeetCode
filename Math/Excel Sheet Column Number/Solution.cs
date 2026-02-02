public class Solution {
    public int TitleToNumber(string columnTitle) 
    {
        double value = 0;
        string x = new string(columnTitle.Reverse().ToArray());
        for(int i = 0; i < x.Length; i++)
        {
            value += (Math.Pow(26,i) * ((double)x[i]-64));
        }
        return (int)value;
    }
}
