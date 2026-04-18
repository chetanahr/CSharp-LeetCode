public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) 
    {
        seats.Sort();
        students.Sort();
        int x = 0;
        for(int i = 0; i < seats.Length; i++)
        {
            x += Math.Abs(seats[i]-students[i]);
        }
        return x;
    }
}
