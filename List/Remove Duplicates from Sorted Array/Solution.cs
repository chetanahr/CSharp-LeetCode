public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        List<int> distintElements = new List<int>();
        distintElements.Add(nums[0]);
        List<int> checking = nums.ToList();
        List<int> distinct = checking.Distinct().ToList();
        int count = 1;
        if(distinct.Count == 1)
        {
            return 1;
        }
        int i = 1;
        while(count < distinct.Count)
        {
            //if(nums[i]< nums[i-1])
            //{
              //  break;
            //}
            if(distintElements.Contains(nums[i]))
            {
                MoveToEnd(i, nums);
            }
            else
            {
                distintElements.Add(nums[i]);
                count++;
                i++;
            }
        }
        return distintElements.Count();
        
    }

    public int[] MoveToEnd(int index, int[] array)
    {
        int temp = array[index];
        for(int i = index; i<array.Length -1 ; i++)
        {
            array[i] = array[i+1];
        }
        array[array.Length - 1] = temp;
        return array;
    }
}
