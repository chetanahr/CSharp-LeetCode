public class Solution {
    public bool IsPalindrome(string s) 
    {
        if(s == "")
        {
            return false;
        }
        string result = new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray());
        char[] arr = result.ToCharArray();
        Array.Reverse(arr);
        string reverse = new string(arr);
        if(result == reverse)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
