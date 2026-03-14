public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) 
    {
        int n = numBottles;
        int rem = 0;
        int quo = 0;
        while(numBottles + rem >= numExchange)
        {
            quo = (numBottles+rem)/numExchange;
            n += quo;
            rem = (numBottles+rem)%numExchange;
            numBottles = quo;
        }
        return n;
        
    }
}
