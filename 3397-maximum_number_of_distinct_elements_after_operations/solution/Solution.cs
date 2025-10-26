public class Solution
{
    public int MaxDistinctElements(int[] nums, int k)
    {
        //sort numbers O(nlogn)
        var sortedNums = nums.Order().ToList();
        var size = sortedNums.Count();
        int distinctCount = 0;

        for (int i = 0; i < size; i++)
        {
            var curr = sortedNums[i];

            var addOperation = curr + k;
            var subOperation = curr - k;

            var prev = i > 0 ? sortedNums[i - 1] : int.MinValue;

            var min = Math.Min(Math.Max(subOperation, prev + 1), addOperation);

            if (min > prev)
            {
                distinctCount++;
            }
                sortedNums[i] = min;

        }

        return distinctCount;
    }
}