public class Solution {
    public int HammingWeight(int n) 
    {
        string result = "";
        int total = 0;
        if(n == 0)
        {
            result = "0";
        }
        while(n > 0)
        {
            int bit = n & 1;
            result = bit + result;
            n >>= 1;
            if(bit == 1) 
            {
                total++;
            }
        }
        return total;
    }
}
