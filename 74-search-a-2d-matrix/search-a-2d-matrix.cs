public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        List<int> intList = new List<int>();
        for(int i=0; i<matrix.Length; i++)
        {
            intList.AddRange(matrix[i]);
        }


        int low=0;
        int hi=intList.Count()-1;
        while(low<=hi)
        {
            int mid = low + (hi - low) / 2;
            if(target>intList[mid])
            {
                low=mid+1;
            }
            else if(target<intList[mid])
            {
                hi=mid-1;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}