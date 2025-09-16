public class Solution {
    public int CountPrimeSetBits(int left, int right)
    {
        //Using Sieve of Eratosthenes
        bool[] arr = new bool[right+1];
        //setting all the values in array to true
        Array.Fill(arr, true);
        //making 0, 1st element as false
        arr[0] = false;
        arr[1] = false;
        int i = 2;
        while(i <= Math.Round(Math.Sqrt(right)))
        {
            if(arr[i])
            {
                for(int j = 2; j <= right; j++)
                {
                    if(i*j <= right)
                    {
                        arr[i*j] = false;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            i++;
        }
        int total = 0;
        for(int k = left; k<=right; k++)
        {
            int one = NumberOf1s(k);
            if(arr[one])
            {
                total++;
            }
        }

        return total;
    }
    public int NumberOf1s(int n)
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
