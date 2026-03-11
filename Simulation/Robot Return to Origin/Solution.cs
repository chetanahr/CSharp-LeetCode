public class Solution {
    public bool JudgeCircle(string moves) 
    {
        int[] a = [0,0];
        foreach(char c in moves)
        {
            if(c == 'R') a[0]++;
            else if(c == 'L') a[0]--;
            else if(c == 'U') a[1]++;
            else a[1]--;
        }
        if(a[0] == 0 && a[1] == 0) return true;
        return false;
    }
}
