public class Solution {
    public int MaxOperations(int[] nums, int k) {   
        Array.Sort(nums);
        var left =0;
        var right =nums.Length-1;
        var count =0;
        while(left<right)
        {
            if(nums[left] + nums[right] == k)
            {
                left++;
                right--;
                count++;
            }
            else if(nums[left] + nums[right] > k)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return count;
    }
}