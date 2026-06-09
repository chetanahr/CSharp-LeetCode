public class Solution {
    public int FindTheWinner(int n, int k) 
    {
        List<int> l = Enumerable.Range(1,n).ToList();
        int i = 0;
        while(l.Count != 1)
        {
            
            i = (i + k - 1) % l.Count;
            l.RemoveAt(i);
        }
        return l[0];
    }
}
