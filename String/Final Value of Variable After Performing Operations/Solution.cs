public class Solution {
    public int FinalValueAfterOperations(string[] operations) 
    {
        int y = 0;
        for(int i = 0; i < operations.Length; i++)
        {
            if(operations[i].Contains('+')) y++;
            else y--;
        }
        return y;
    }
}
