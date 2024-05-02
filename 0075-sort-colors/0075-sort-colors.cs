public class Solution {
    public void SortColors(int[] nums) {
        List<int> listNums = new List<int>(nums);
        listNums = listNums.OrderBy(num => num).ToList();
        listNums.CopyTo(nums);
    }
}