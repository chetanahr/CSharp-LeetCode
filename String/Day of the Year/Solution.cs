public class Solution {
    public int DayOfYear(string date) 
    { 
        int feb = 0;
        int year = int.Parse(date.Substring(0,4));
        int month = int.Parse(date.Substring(5,2));
        int day = int.Parse(date.Substring(8,2));
        if(year % 4 == 0)
        {
            if(year % 100 == 0 && year % 400 == 0) feb = 29;
            else if(year % 100 == 0 && year % 400 != 0) feb = 28;
            else feb = 29;
        }
        else feb = 28;
        int[] arr = new int[] {31, feb, 31,30,31,30,31,31,30,31,30,31};
        int doy = 0;
        for(int i = 1; i < month; i++)
        {
            doy += arr[i-1];
        }
        doy += day;
        return doy;
    }
}
