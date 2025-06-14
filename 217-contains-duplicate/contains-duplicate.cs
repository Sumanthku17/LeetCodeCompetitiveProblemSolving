public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> unique = new List<int>();
        foreach(int i in nums)
        {
            if(unique.Contains(i))
            {
                return true;
            }
            unique.Add(i);
        }
        return false;
    }
}