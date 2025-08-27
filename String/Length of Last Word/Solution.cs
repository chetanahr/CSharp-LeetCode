public class Solution {
    public int LengthOfLastWord(string s) 
    {
        string[] substring = s.Split(' ');
        string[] cleaned = substring.Where( s => !string.IsNullOrEmpty(s)).ToArray();
        int l = cleaned[cleaned.Length - 1].Length;
        return l;
    }
}
