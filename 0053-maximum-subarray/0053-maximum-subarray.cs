public class Solution {
    public int MaxSubArray(int[] nums) {
        /*int maxCount =Int32.MinValue;
        for(int i=0; i<nums.Length; i++)
        {
            int subArrayCount =0;
            for(int j=i; j<nums.Length; j++)
            {
                subArrayCount += nums[j];
                maxCount = Math.Max(maxCount, subArrayCount);
            }
        }
        return maxCount;*/
        var sum = nums[0];
        var max = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            sum = Math.Max(sum + nums[i], nums[i]);
            Console.WriteLine(sum);
            max = Math.Max(max, sum);
        }

        return max;
    }
}