public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var twoDimList = new List<IList<int>>();
        for(int i=0; i<Math.Pow(2, nums.Length); i++)
        {
            var list = convertDeciToBi(i);
            var internalList = new List<int>();
            for(int j=0; j<list.Count; j++)
            {
                if(list[j]==1)
                {
                    internalList.Add(nums[j]);
                }
            }
            twoDimList.Add(internalList);
        }
        return twoDimList;
    }
    
    public IList<int> convertDeciToBi(int num)
    {
        var list = new List<int>();
        for(int i=0; num>0; i++)
        {
            list.Add(num%2);
            num = num/2;
        }
        return list;
    }
}