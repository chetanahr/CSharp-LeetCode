public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        List<bool> l = new List<bool>();
        int m = candies.Max();
        for(int i = 0; i < candies.Length; i++)
        {
            if(candies[i]+ extraCandies >= m) l.Add(true);
            else l.Add(false);
        }
        return l;
    }
}
