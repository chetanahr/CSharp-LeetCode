public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        BigInteger number = BigInteger.Parse(string.Join("", digits));
        number++;
        digits = number.ToString().Select(x => x - '0').ToArray();
        return digits;
        
    }
}
```
