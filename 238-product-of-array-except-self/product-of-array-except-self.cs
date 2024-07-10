public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] LeftSideProduct = new int[nums.Length];
        int[] RightSideProduct = new int[nums.Length];
        
        for(int i=0;i<nums.Length;i++)
        {
            if(i==0)
            {
                LeftSideProduct[i] = 1;
            }
            else
            {
                LeftSideProduct[i] = LeftSideProduct[i-1] * nums[i-1];
            }
        }
        
        for(int i=nums.Length-1;i>=0;i--)
        {
            if(i==nums.Length-1)
            {
                RightSideProduct[i] = 1;
            }
            else
            {
                RightSideProduct[i] = RightSideProduct[i+1] * nums[i+1];
            }
        }
        
        for(int i=0;i<nums.Length;i++)
        {
            nums[i] = LeftSideProduct[i]*RightSideProduct[i];
        }
        
        return nums;
    }
}