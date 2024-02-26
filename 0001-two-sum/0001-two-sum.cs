public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0; i<nums.Length; i++)
        {
            int exptPair = target - nums[i];
            for(int j=0; j<nums.Length; j++)
            {
                if(i == j)
                    continue;
                if(nums[j] == exptPair)
                {
                    return new int[] {i, j};
                }    
            }
        }
        return new int[] {-1, -1};
    }
}