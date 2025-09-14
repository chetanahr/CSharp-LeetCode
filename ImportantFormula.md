static string DecimalToBinaryInteger(int N)
{
    if (N == 0) return "0";

    string result = "";
    while (N > 0)
    {
        int bit = N & 1;       // take last bit
        result = bit + result; // prepend
        N >>= 1;               // right shift (N /= 2)
    }
    return result;
}
