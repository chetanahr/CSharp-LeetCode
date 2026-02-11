public class Solution {
    public bool LemonadeChange(int[] bills) 
    {
        int x = 0;
        List<int> c = new List<int>();
        for(int i = 0; i < bills.Length; i++)
        {
            if(bills[i] == 5) 
            {
                c.Add(5);
                x++;
            }
            else
            {
                if(bills[i] == 10)
                {
                    c.Add(10);
                   if(c.Contains(5)) 
                   {
                        c.Remove(5);
                        x--;
                   }
                   else return false;
                   
                }
                else if(bills[i] == 20)
                {
                    c.Add(20);
                    if(c.Contains(5) && c.Contains(10))
                    {
                        c.Remove(10);
                        c.Remove(5);
                        x--;
                    }
                    else if(x >= 3)
                    {
                       c.Remove(5);
                       c.Remove(5);
                       c.Remove(5); 
                       x = x- 3;
                    }
                    else return false;
                }
                
            }
        }
        return true;
    }
}
