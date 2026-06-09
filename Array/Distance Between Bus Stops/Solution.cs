public class Solution {
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) 
    {
        int t = 0;
        int c = 0;
        int a = 0;
        if(destination < start)
        {
            int temp = start;
            start = destination;
            destination = temp;
        }
        for(int i = 0; i < distance.Length; i++)
        {
            t += distance[i];
            if(i>= start && i < destination) c += distance[i];
        }
        a = t - c;
        return (c>a)?a:c;
        
    }
}
