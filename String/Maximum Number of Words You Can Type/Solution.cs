public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) 
    {
        string[] s = text.Split(" ");
        int z = 0;
        for(int i = 0; i < s.Length; i++)
        {
            bool c = false;
            for(int j = 0; j < brokenLetters.Length; j++)
            {
                if(s[i].Contains(brokenLetters[j])) c = true;
            }
            if(!c) z++;
        }
        return z;
    }
}
