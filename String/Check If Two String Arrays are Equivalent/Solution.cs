public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) 
    { 
        string a = string.Join("",word1);
        string b = string.Join("", word2);
        if(a == b) return true;
        else return false;
        
    }
}
