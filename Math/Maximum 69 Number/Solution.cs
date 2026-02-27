public class Solution {
    public int Maximum69Number (int num) 
    {
        int[] x = num.ToString().Select(c => c - '0').ToArray();
        for(int i = 0; i < x.Length; i++)
        {
            int temp = num;
            bool oper = false;
            if(x[i] == 6) 
            {
                x[i] = 9;
                oper = true;
            }
            num = int.Parse(string.Join("", x));
            if(num < temp) num = temp;
            if(oper) x[i] = 6;
        }
        return num;
    }
}
