public class Solution {
    public string ToGoatLatin(string sentence) 
    {
        string[] arr = sentence.Split(" ");
        for(int i = 0; i < arr.Length; i++)
        {
            char c = arr[i][0];
            string s = new string('a', i+1);
            if(char.ToLower(c) == 'a' || char.ToLower(c) == 'e' || char.ToLower(c) == 'i' || char.ToLower(c) == 'o' || char.ToLower(c) == 'u')
            {
                arr[i] = arr[i] + "ma";
            }
            else 
            {
                arr[i] = arr[i].Substring(1) + c + "ma";
            }
            arr[i] = arr[i] + s;
        }
        return string.Join(" ", arr);
    }
}
