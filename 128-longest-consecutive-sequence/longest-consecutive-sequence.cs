public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums.Length ==0 || nums.Length ==1)
        {
            return nums.Length;
        }

        HashSet<int> hs = new HashSet<int>(nums.ToList());
        List<int> hsList = hs.ToList();
        hsList.Sort();
        int max =1;
        int count =1;
        for(int i=0; i<hsList.Count-1; i++)
        {
            if(hsList[i+1] - hsList[i] == 1)
            {
                count++;
                if(count>max)
                {
                    max=count;
                }
            }
            else
            {
                count = 1;
            }
        }
        return max;
    }
}