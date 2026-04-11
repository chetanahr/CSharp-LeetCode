public class Solution {
    public int DistanceTraveled(int mainTank, int additionalTank) 
    {
        int n = 0;
        while(mainTank >= 5)
        {
            n += 50;
            mainTank -= 5;
            if(additionalTank > 0)
            {
                additionalTank--;
                mainTank++;
            }
            
        }
        n += mainTank*10;
        return n;
    }
}
