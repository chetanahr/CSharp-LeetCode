public class Solution {
    public string ConvertToTitle(int columnNumber) 
    {
        List<char> column = new List<char>();
        if(columnNumber<= 26)
        {
            string s = NumberToChar(columnNumber).ToString();
            return s;
        }
        int quo = columnNumber / 26;
        int rem = columnNumber % 26;
        if(rem == 0)
        {
            column.Add(NumberToChar(26));
            quo--;
        }
        else
        {
            column.Add(NumberToChar(rem));
        }  
        while(quo > 26)
        {
            int temp = quo;
            quo /= 26;
            int newRem = temp % 26;
            if(newRem == 0)
            {
                column.Add(NumberToChar(26));
                quo--;
            }
            else
            {
                column.Add(NumberToChar(newRem));
            }  
        }
        column.Add(NumberToChar(quo));
        string dummy = new string(column.ToArray());
        string current = new string(dummy.Reverse().ToArray());
        return current;
    }
    public char NumberToChar(int number)
    {
        char x = (char)('A' + number - 1);
        return x;
    }
}
