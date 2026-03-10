public class Solution {
    public IList<string> FizzBuzz(int n) 
    {
        List<string> l1 = new List<string>(n);
        for(int i = 1; i <= n; i++)
        {
            if(i % 3 == 0 && i % 5 == 0) l1.Add("FizzBuzz");
            else if(i % 3 == 0 && i % 5 != 0) l1.Add("Fizz");
            else if(i % 3 != 0 && i % 5 == 0) l1.Add("Buzz");
            else l1.Add(i.ToString());
        }
        return l1;
        
    }
}
