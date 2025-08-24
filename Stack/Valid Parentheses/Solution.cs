public class Solution {
    public bool IsValid(string s) 
    {
        char[] bracket = s.ToCharArray();
        Stack<char> stack = new Stack<char>();
        stack.Push(bracket[0]);
        //bool valid = false;

        for(int i = 1; i< bracket.Length; i++)
        {
            if(stack.Count == 0)
            {
                stack.Push(bracket[i]);
            }
            else if(CheckBracket(stack.Peek(), bracket[i]))
            {
                stack.Pop();
            }
            else
            {
                stack.Push(bracket[i]);
            }
        }
        if(stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CheckBracket(char opening, char closing)
    {
        switch((opening, closing))
        {
            case ('(',')') : return true;
            case ('[',']') : return true;
            case ('{','}') : return true;
            default : return false;
            //case ('(','}') : return false;
            //case ('(',']') : return false;
            //case ('[',')') : return false;
           // case ('[','}') : return false;
        }
    }
}
