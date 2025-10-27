/**
 * @param {number[]} nums
 * @return {boolean}
 */
var canJump = function (nums) {
    let size = nums.length; 
    let lastIndex = size - 1; 
    let furtherst = 0;

    for (let i = 0; i <= furtherst && i < size; i++) {
        let currentFurtherst = nums[i] + i;
        furtherst = Math.max(furtherst, currentFurtherst); 

        if(furtherst >= lastIndex) {
            return true;
        }

    }

    return false;
};

var nums = [3,0,8,2,0,0,1];
console.log(canJump(nums));


