public class Solution {
    public int CountBinarySubstrings(string s) 
    {
        int count = 0;
        int start = 0;
        while(start < s.Length)
        {
            int end = start;
            while(end < s.Length)
            {
                string x = s.Substring(start, end - start+1);
                if(HaveEqualConsecutive(x))
                {
                    count++;
                }
                end++;
            }
            start++;
        }
        return count;
    }
    public bool HaveEqualConsecutive(string x)
    {
        if(x.Length %2 != 0)
        {
            return false;
        }
        else
        {
            int mid = x.Length/2;
            string s1 = x.Substring(0, mid);
            string s2 = x.Substring(mid);
            //if(s1 == s2)
            //{
                //return true;
            //}
            if(s1.Distinct().Count() == 1 && s2.Distinct().Count() == 1)
            {
                var d1 = s1.Distinct().ToArray();
                var d2 = s2.Distinct().ToArray();

                if((d1[0] == '0' && d2[0]== '1') || (d1[0] == '1' && d2[0] == '0'))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }
    }
}
