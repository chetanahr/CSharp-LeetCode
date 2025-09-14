public class Solution {
    public int[] CountBits(int n) 
    {
        if( n == 0)
        {
            return [0];
        }
        int[] arr = new int[n+1];
        arr[0] = 0;
        for(int i = 1; i <= n; i++)
        {
            arr[i] = NoOf1s(i);
        }
        return arr;  
    }
    public int NoOf1s (int n)
    {
        string s = "";
        int count = 0;
        while(n>0)
        {
            int bit = n & 1;
            s = bit + s;
            n >>= 1;
            if(bit == 1)
            count++;
        }
        return count;

    }
}
