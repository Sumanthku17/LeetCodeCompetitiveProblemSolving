public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        int []nums3 = new int[m+n];
        
        int i=0;
        int j=0;
        int k=0;
        while(i<m && j<n)
        {
            if(nums1[i]<nums2[j])
            {
                nums3[k++] = nums1[i++];
            }
            else
            {
                nums3[k++] = nums2[j++];
            }
        }
        while(i<m)
        {
            nums3[k++] = nums1[i++];
        }
        while(j<n)
        {
            nums3[k++] = nums2[j++];
        }
        nums3.CopyTo(nums1, 0);
    }
}