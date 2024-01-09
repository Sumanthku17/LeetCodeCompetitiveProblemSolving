public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var numSum = new List<IList<int>>();
        int n = nums.Length;
        for(int i=0; i<n-2; i++)
        {
            if(i==0 || (i>0 && nums[i] != nums[i-1]))
            {
                int lo = i+1;
                int hi = n-1;
                int sum = 0 - nums[i];
                
                while(lo<hi)
                {
                    if(nums[lo] + nums[hi] == sum)
                    {
                        numSum.Add(new List<int>(){nums[i], nums[lo], nums[hi]});
                        while(lo<hi && nums[lo]==nums[lo+1])
                            lo++;
                        while(lo<hi && nums[hi]==nums[hi-1])
                            hi--;
                        lo++; hi--; 
                    }
                    else if(nums[lo] + nums[hi] > sum)
                    {
                        hi--;
                    }
                    else
                    {
                        lo++;
                    }
                }
            }
        }
        return numSum;
    }
}