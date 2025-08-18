public class Solution {
    public bool IsPalindrome(int x) 
    {
        string x1 = x.ToString();
        string x2 = new string(x1.Reverse().ToArray());
        if(x1 == x2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
