use std::cmp;

fn main() {

    let nums: [i32; 5] = [2,3,1,1,4];
    let result: i32 = jump(nums.to_vec());

    print!("\n{}", result);
}

pub fn jump(nums: Vec<i32>) -> i32 {
    let length: usize = nums.len();
    let last_index: usize = length - 1;
    let mut largest: usize = 0;
    let mut jump: usize = 0;
    let mut i = 0;
    let mut last = 0;

    if length <= 1 {
        return 0;
    }

    while i < last_index {
        let curr: usize = (nums[i] as usize + i) as usize;

        largest = cmp::max(curr, largest);

        if last == i {
            jump += 1;
            last = largest;
        }
        
        i += 1;
    }

    return jump as i32;
}
