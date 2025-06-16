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

        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach(var pair in numFreq)
        {
            minHeap.Enqueue(pair.Key, pair.Value);
            if (minHeap.Count > k) {
                minHeap.Dequeue();
            }
        }

        int[] result = new int[k];
        for(int i=0; i<k; i++)
        {
            result[i] = minHeap.Dequeue();
        }
        return result;
        // return numFreq.OrderByDescending(pair => pair.Value)
        //         .Take(k)
        //         .Select(pair => pair.Key)
        //         .ToArray();
    }
}