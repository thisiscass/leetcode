function removeDuplicates(nums: number[]): number {
    let j = 1;
    let i = 0;
    let notEqual = 0;
    while(j < nums.length) {
        if(nums[i] !== nums[j]) {
            nums[i + 1] = nums[j];
            i++;
            notEqual += 1;
        } 

        j++;
    }

    return notEqual + 1;
};

let nums = [1,1,2];

let result = removeDuplicates(nums);

console.log(result)
console.log(nums)