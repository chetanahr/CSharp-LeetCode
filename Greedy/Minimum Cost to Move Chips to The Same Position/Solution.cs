public class Solution {
    public int MinCostToMoveChips(int[] position) 
    {
        int odd = 0;
        int even = 0;
        for(int i = 0; i< position.Length; i++)
        {
            if(position[i] % 2 == 0) even++;
            else odd++;
        }
        if(even >= odd) return odd;
        else return even; 
    }
}
