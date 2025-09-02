/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n)
    {
        if(n == 1)
        {
            return 1;
        }
        bool isBad = true;
        while(isBad)
        {
            isBad = IsBadVersion(n);
            n--;
        }
        return n+2;
        
    }
}
