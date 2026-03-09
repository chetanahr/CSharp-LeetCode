public class Solution {
    public bool IsUgly(int n) 
    {
        if(n<1) return false;
        if(n == 1 || n == 2 || n == 3 || n == 5) return true;
        if(IsPrime(n))return false;
        List<int> l = new List<int>();
        for(int i = 2; i <= n; i++)
        {
            while(n % i == 0)
            {
                if(i!= 2 && i!= 3 && i!=5) l.Add(i);
                n /= i;
                if(IsPrime(n) && n>=7) return false;
            }
        }
        if (l.Count == 0) return true;

        else return false;  
    }
    public bool IsPrime(long n)
    {
        for(long i = 2; i * i <= n; i++)
        {
            if(n % i == 0) return false;
        }
        return true;
    }

}
