public class Solution {
    public bool CheckValidString(string s) 
    {
        int low = 0;
        int high = 0;
        foreach(var i in s)
        {
            if(i == '(')
            {
                high++;
                low++;
            }
            else if(i == ')')
            {
                high--;
                low--;
            }
            else
            {
                low--;
                high++;
            }
            if(high < 0) return false;
            if(low < 0) low =0;
        }
        if(low == 0) return true;
        return false;
    }
}
