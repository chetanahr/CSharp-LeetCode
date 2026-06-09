public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) 
    {
        List<int> m = new List<int>();
        for(int i = left;  i <= right; i++)
        {
            if(Digits(i)) m.Add(i);
        }
        return m;
    }
    public bool Digits (int n)
    {
        int b = n;
        while(n > 9)
        {
            int a = n%10;
            if(a == 0 || b%a != 0) return false;
            if(n !=0) n /= 10;
        }
        if(b%n != 0) return false;
        return true;
    }
}
