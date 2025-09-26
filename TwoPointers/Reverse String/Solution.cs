public class Solution {
    public void ReverseString(char[] s) 
    {
        int start = 0;
        int end = s.Length-1;
        int mid = end/2;
        while(start <= mid)
        {
            char x = s[start];
            s[start] = s[end];
            s[end] = x;
            start++;
            end--;
        }
    }
}
