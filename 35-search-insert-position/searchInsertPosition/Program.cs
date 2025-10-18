using searchInsertPosition;

/*
Example 1:
Input: nums = [1,3,5,6], target = 5
Output: 2

Example 2:
Input: nums = [1,3,5,6], target = 2
Output: 1

Example 3:
Input: nums = [1,3,5,6], target = 7
Output: 4
*/

int[] arr = [1,3,5,6];

var solution = new InsertPosition();
var result = solution.SearchInsert(arr, 7);
Console.WriteLine(result);



