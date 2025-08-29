public class Solution 
{
    public string AddBinary(string a, string b) 
    {
        if( a == "0" && b == "0")
        {
            return "0";
        }
        BigInteger num1 = ConvertToBig(a);
        BigInteger num2 = ConvertToBig(b);
        
        BigInteger sum = num1 + num2;
        StringBuilder sb = new StringBuilder();
        while(sum > 0)
        {
            sb.Insert(0, (sum % 2 == 0? '0' : '1'));
            sum >>= 1;
        }
        return sb.ToString();
    }
    public BigInteger ConvertToBig (string a)
    {
        BigInteger bigNum = 0;
        foreach (char bit in a)
        {
            bigNum <<= 1;         // shift left (multiply by 2)
            if (bit == '1')
                bigNum += 1;
        }
        return bigNum;
    }
}
