/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) 
    {
        int low = 1;
        int high = n;
        int x = 0;
        while(low<=high)
        {
            int mid = low + (high - low) / 2;
            x = guess(mid);
            if(x == 0) return mid;
            else if(x == 1) low = mid+1;
            else high = mid-1;
        }
        return x;
    }
}
