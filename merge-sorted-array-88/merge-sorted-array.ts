/**
 Do not return anything, modify nums1 in-place instead.
 */
 function merge(nums1: number[], m: number, nums2: number[], n: number): void {
    let i = m - 1 , j = n - 1 , idx = m + n - 1;
    while(i >= 0 && j >= 0)
    {
        if(nums1[i] >= nums2[j])
        {
            nums1[idx] = nums1[i];
            i--;
        }
        else
        {
            nums1[idx] = nums2[j];
            j--;
        }
        idx--;
    }
    while(i >= 0)
        nums1[idx--] = nums1[i--];
    while(j >= 0)
        nums1[idx--] = nums2[j--];
    return;
};

let nums1 =  [1,2,3,0,0,0]
let m = 3
let nums2 = [2,5,6]
let n = 3

merge(nums1, m, nums2, n);

console.log(nums1)