public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        if(piles ==null || piles.Length ==0)
        {
            return -1;
        }
        
        int low =1;
        int high =piles.Max();
        int mink =high;
        while(low<=high)
        {
            int mid = low + (high-low)/2;
            if(canComplete(piles, h, mid))
            {
                mink=mid;
                high=mid-1;
            }
            else
            {
                low=mid+1;
            }
        }
        return mink;
    }

    public bool canComplete(int[] piles, int h, int mid)
    {
        long completedHours = 0;
        for(int i=0; i<piles.Length; i++)
        {
            //completedHours += (long)Math.Ceiling((double)piles[i]/mid);
            completedHours += (piles[i] + mid -1)/mid;
            if(completedHours > h)
            {
                return false;
            }
        }
        return completedHours <= h;
    }
}