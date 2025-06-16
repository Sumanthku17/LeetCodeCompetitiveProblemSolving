public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // value of num and index mapping
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++)
        {
            var compliment = target - nums[i];

            if(map.ContainsKey(compliment))
            {
                return new int[] {i, map[compliment]};
            }

            map[nums[i]] = i;
        }
        return new int[2];
    }
}