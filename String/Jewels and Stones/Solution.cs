public class Solution {
    public int NumJewelsInStones(string jewels, string stones) 
    {
        int c = 0;
        foreach(char i in jewels)
        {
            c += stones.Count(c => c == i);
        }
        return c;
    }
}
