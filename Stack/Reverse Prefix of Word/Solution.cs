public class Solution {
    public string ReversePrefix(string word, char ch) 
    {
        string n = "";
        bool isFound = false;
        Stack<char> s = new Stack<char>();
        for(int i = 0; i < word.Length; i++)
        {
            if(word[i]==ch)
            {
                s.Push(word[i]);
                n = word.Substring(i+1);
                isFound = true;
                break;
            }
            else s.Push(word[i]);
        }
        if(!isFound) return new string(s.Reverse().ToArray());
        return new string(s.ToArray()) + n;
    }
}
