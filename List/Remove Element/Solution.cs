public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        List<int> dummy = nums.ToList();
        dummy.Sort();
        //nums = dummy.ToArray();
        int count = dummy.Count(x => x == val);
        int loopVariable = 0;
        int i = 0;
        while(loopVariable < count)
        {
            if(nums[i] == val)
            {
                MoveToEnd(nums, i);
                loopVariable++;
            }
            else
            {
                i++;
            }
        }
        return nums.Length - count;
    }
    public int[] MoveToEnd(int[] array, int index)
    {
        int temp = array[index];
        for(int i = index; i < array.Length -1; i++)
        {
            array[i] = array[i+1];
        }
        array[array.Length - 1] = temp;
        return array;
    }
}
