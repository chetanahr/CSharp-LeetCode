public class Solution {
    public int MostWordsFound(string[] sentences) 
    {
        int x = 0;
        for(int i = 0; i < sentences.Length; i++)
        {
            string[] s = sentences[i].Split(' ');
            if(x < s.Length) x = s.Length;
        }
        return x;
    }
}
