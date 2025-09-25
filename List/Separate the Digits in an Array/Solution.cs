public class Solution {
    public int[] SeparateDigits(int[] nums) 
    {
        List<int> digits = new List<int>();
        foreach(var x in nums)
        {
            digits.AddRange(Digits(x));
        }
        return digits.ToArray();
        
    }
    public List<int> Digits(int n)
    {
        List<int> digits = new List<int>();
        while(n > 0)
        {
            digits.Insert(0, n % 10);
            n /= 10;
        }
        return digits;
    }
}
