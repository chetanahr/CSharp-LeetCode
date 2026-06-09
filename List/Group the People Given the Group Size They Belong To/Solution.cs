public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) 
    {
        IList<IList<int>> l = new List<IList<int>>();
       // List<int> m = groupSizes.ToList();
        for(int i = 0; i < groupSizes.Length; i++)
        {
            List<int> k = new List<int>();
            int c = groupSizes[i];
            if(c > 0)
            {
                for(int j = 0; j < groupSizes.Length && k.Count < c; j++)
                {
                    if(groupSizes[j] == c)
                    {
                        k.Add(j);
                        groupSizes[j] = 0;
                    }
                }
            }
            if(k.Count> 0) l.Add(k);
        }
        var sorted = l.OrderBy(l => l.Count).ToList();
        return sorted;
    }
}
