public class Solution {
    public string RemoveOuterParentheses(string s) 
    {
       int c = 0;
       string s1 = "";
       foreach(var i in s)
       {
        if(i == '(' && c++ > 0)
        {
            s1+= "(";
        }
        else if(i == ')' && c-- > 1)
        {
            s1 += ")";
        }
       }
       return s1;
    }
}
