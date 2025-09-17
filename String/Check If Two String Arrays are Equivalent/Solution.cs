public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) 
    {
        string one = "";
        foreach(var i in word1)
        {
            one= one+i;
        }
        string two = "";
        foreach(var i in word2)
        {
            two = two + i;
        }
        if(one == two)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
