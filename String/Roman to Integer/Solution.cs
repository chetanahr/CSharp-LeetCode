public class Solution {
    public int RomanToInt(string s) 
    {
        Dictionary< char , int>  dict = new Dictionary<char , int>();
        dict['I'] = 1;
        dict['V'] = 5;
        dict['X'] = 10;
        dict['L'] = 50;
        dict['C'] = 100;
        dict['D'] = 500;
        dict['M'] = 1000;
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        int intValue = dict[array[0]];
        for(int i = 1; i<array.Count(); i++)
        {
            if( dict[array[i]] > intValue || dict[array[i]] == dict[array[i-1]]) 
            {
                intValue += dict[array[i]] ;
            }
            else
            {
                intValue -= dict[array[i]] ;
            }
        }
        return intValue;
    }
}
