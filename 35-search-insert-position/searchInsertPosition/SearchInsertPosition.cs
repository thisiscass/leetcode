namespace searchInsertPosition;

public class InsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        int initial = 0;
        int end = nums.Length;

        while (initial < end)
        {
            int mid = (end + initial) / 2;

            if (nums[mid] == target) return mid;

            if (nums[mid] < target)
            {
                initial = mid + 1;
            }
            else end = mid;
        }
        
        return initial;
    }
}


