public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        bool x = false;
        for(int i = 0; i <flowerbed.Length; i++)
        {
            if(flowerbed[i] == 1) 
            {
                if(x) n++;
                x = true;
            }
            else if(flowerbed[i] == 0 && x == false) 
            {
                n--;
                x = true;
            }
            else if(flowerbed[i] == 0 && x) x = false;
        }
        if(n>0) return false;
        else return true;
        
    }
}
