public class Solution {
    public bool DetectCapitalUse(string word) 
    {
        bool c = char.IsUpper(word[0]);
        int up = 0;
        for(int i = 1; i < word.Length; i++)
        {
            if(char.IsUpper(word[i])) up++;
        }
        if(c && (up == 0 || up == word.Length-1)) return true;
        else if(!c && up == 0) return true;
        return false;
        
    }
}
