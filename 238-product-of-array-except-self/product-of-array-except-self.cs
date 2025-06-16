public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        // int[] LeftSideProduct = new int[nums.Length];
        // int[] RightSideProduct = new int[nums.Length];
        
        // for(int i=0;i<nums.Length;i++)
        // {
        //     if(i==0)
        //     {
        //         LeftSideProduct[i] = 1;
        //     }
        //     else
        //     {
        //         LeftSideProduct[i] = LeftSideProduct[i-1] * nums[i-1];
        //     }
        // }
        
        // for(int i=nums.Length-1;i>=0;i--)
        // {
        //     if(i==nums.Length-1)
        //     {
        //         RightSideProduct[i] = 1;
        //     }
        //     else
        //     {
        //         RightSideProduct[i] = RightSideProduct[i+1] * nums[i+1];
        //     }
        // }
        
        // for(int i=0;i<nums.Length;i++)
        // {
        //     nums[i] = LeftSideProduct[i]*RightSideProduct[i];
        // }
        
        // return nums;

        var prefixProduct = new int[nums.Length];
        var suffixProduct = new int[nums.Length];
        var result = new int[nums.Length];
        int product = 1;
        for(int i=0; i<nums.Length; i++)
        {
            
            prefixProduct[i] = product;
            product *= nums[i];
        }

        product = 1;
        for(int i=nums.Length-1; i>=0; i--)
        {
            
            suffixProduct[i] = product;
            product *= nums[i];
        }

        for(int i=0; i<nums.Length; i++)
        {
            result[i] = prefixProduct[i] * suffixProduct[i];
        }

        return result;
    }
}