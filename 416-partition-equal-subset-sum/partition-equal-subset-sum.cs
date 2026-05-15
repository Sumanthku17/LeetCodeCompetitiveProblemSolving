public class Solution {
    public bool CanPartition(int[] nums) {
        var sum = nums.Sum();
        if(sum%2 == 0)
        {
            return CanReallyPartition(nums, nums.Count(), sum/2);
        }
        else
        {
            return false;
        }
    }

    public bool CanReallyPartition(int[] nums, int n, int w)
    {
        bool[,] matrix = new bool[n+1,w+1];

        for(int i=0; i<n+1; i++)
        {
            for(int j=0; j<w+1; j++)
            {
                if(i==0 && j==0)
                    matrix[i,j]=true;

                else if(i==0)
                    matrix[i,j]=false;

                else if(j==0)
                    matrix[i,j]=true;
            }
        }


        for(int i=1; i<n+1; i++)
        {
            for(int j=1; j<w+1; j++)
            {
                if(nums[i-1]<=j)
                {
                    matrix[i,j] = matrix[i-1,j-nums[i-1]] || matrix[i-1,j];
                }
                else
                {
                    matrix[i,j] = matrix[i-1,j];
                }
            }
        }
        return matrix[n,w];
    }
}