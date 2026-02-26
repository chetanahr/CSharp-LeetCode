public class Solution {
    public int MaxNumberOfBalloons(string text) 
    {
        int[] arr = new int[5];
        int c = 0;
        arr[0] = text.Count(c => c == 'b');
        arr[1] = text.Count(c => c == 'a');
        arr[2] = text.Count(c => c == 'l');
        arr[3] = text.Count(c => c == 'o');
        arr[4] = text.Count(c => c == 'n');
        if(arr.Contains(0) || arr[2] == 1 || arr[3] == 1) return 0;
        else
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int temp = c;
                if(i == 2 || i == 3) c = arr[i]/2;
                else c = arr[i];
                if(c > temp && temp > 0) c = temp;
            }
        }
        return c;
    }
}
