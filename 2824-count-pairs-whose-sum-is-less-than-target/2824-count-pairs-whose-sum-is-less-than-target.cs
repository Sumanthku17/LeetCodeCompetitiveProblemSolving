public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        nums = nums.OrderBy(x => x).ToList(); // sort the vector nums
        int count = 0; // variable to store the count
        int left = 0; // variable to store the left
        int right = nums.Count-1; // variable to store the right
        while(left < right){ // loop until left is less than right
            if(nums[left] + nums[right] < target){ // if nums[left] + nums[right] is less than target
                count += right-left; // update the count
                left++; // increment the left
            }
            else{ // else
                right--; // decrement the right
            }
        }
        return count; // return the count
    }
}