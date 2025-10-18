function removeDuplicatesSorted(nums: number[]): number {
    let  j = 1;
    for(let i = 0; i < nums.length - 2; i++) {
        if(nums[i] !== nums[j]) {
            nums[i] = nums[j];
            j++;
        }
    }
    
    return 1;
};