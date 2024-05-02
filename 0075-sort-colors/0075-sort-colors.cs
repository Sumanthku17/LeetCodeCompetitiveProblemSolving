public class Solution {
    public void SortColors(int[] nums) {
        var zeroCount = 0;
        var oneCount = 0;
        var twoCount = 0;
        
        for (int i=0; i<nums.Length; i++)
        {
            if(nums[i] == 0)
                zeroCount++;
            else if(nums[i] == 1)
                oneCount++;
            else
                twoCount++;
        }
        int j=0;
        while(zeroCount>0)
        {
            nums[j++] = 0;
            zeroCount--;
        }
        while(oneCount>0)
        {
            nums[j++] = 1;
            oneCount--;
        }
        while(twoCount>0)
        {
            nums[j++] = 2;
            twoCount--;
        }
    }
}