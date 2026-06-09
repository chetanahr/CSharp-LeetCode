public class Solution {
    public int WateringPlants(int[] plants, int capacity) 
    {
        int s = 0;
        int c = capacity;
        for(int i = 0; i < plants.Length; i++)
        {
            if(c < plants[i])
            {
                s += (i*2) + 1;
                c = capacity-plants[i];
            }
            else
            {
                s ++;
                c -= plants[i];
            }
        }
        return s;
    }
}
