public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        List<int> intList = new List<int>();
        for(int i=0; i<matrix.Length; i++)
        {
            intList.AddRange(matrix[i]);
        }
        var index = intList.BinarySearch(target);
        if(index>=0)
            return true;
        else
            return false;
    }
}