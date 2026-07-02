public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) 
    {
        int s = 0;
        int x = 0;
        if(ruleKey == "type") x = 0;
        else if(ruleKey == "color") x = 1;
        else x = 2;
        foreach(var i in items)
        {
            if(i[x] == ruleValue) s++;
        }
        return s;
    }
}
