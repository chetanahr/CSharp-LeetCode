public class Solution {
    public string Interpret(string command) 
    {
        string s = "";
        for(int i = 0; i < command.Length; i++)
        {
            if(command[i]== 'G') s += 'G';
            else if(command[i] == '(')
            {
                if(command[i+1] == ')') 
                {
                    s += 'o';
                    i++;
                }
                else 
                {
                    s += "al";
                    i += 3;
                }
            }
        }
        return s;
        
    }
}
