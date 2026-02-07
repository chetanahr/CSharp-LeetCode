public class Solution {
    public bool CheckPerfectNumber(int num) 
    {
        int x = 0;
        for(int i = 1; i <= num/2; i++)
        {
            if(num%i == 0) x += i;
        }
        if(x == num) return true;
        else return false;
        
    }
}
