public class Solution 
{
    public string AddStrings(string num1, string num2) 
    {
        int i = num1.Length - 1;
        int j = num2.Length - 1;
        int carry = 0;

        StringBuilder result = new StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int d1 = (i >= 0) ? num1[i] - '0' : 0;
            int d2 = (j >= 0) ? num2[j] - '0' : 0;

            int sum = d1 + d2 + carry;

            result.Append((char)((sum % 10) + '0'));

            carry = sum / 10;

            i--;
            j--;
        }

        // Since digits were added from right to left
        // reverse the result before returning
        char[] arr = result.ToString().ToCharArray();
        Array.Reverse(arr);

        return new string(arr);
    }
}
