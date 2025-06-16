public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        if(nums == null || nums.Length == 0)
        {
            return new int[k];
        }

        Dictionary<int, int> numFreq = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            numFreq[num] = numFreq.GetValueOrDefault(num, 0)+1;
        }

        return numFreq.OrderByDescending(pair => pair.Value)
                .Take(k)
                .Select(pair => pair.Key)
                .ToArray();
    }
}