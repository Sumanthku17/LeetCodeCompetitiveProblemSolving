public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // if(s==null || s.Length ==0 || s.Length ==1)
        // {
        //     return s.Length;
        // }
        // var left =0;
        // var right=0;
        // var maxLength =1;
        // var checkList = new List<char>();
        // checkList.Add(s[left]);
        // while(right<s.Length)
        // {
        //     if(checkList.Contains(s[right]))
        //     {
        //         maxLength = Math.Max(maxLength, checkList.Count());
        //         left=s.Substring(left, checkList.Count()).IndexOf(s[right]);
        //         // left=right;
        //         checkList.Clear();
        //     }
        //     checkList.Add(s[right]);
        //     right++;
        // }
        // return maxLength;

        if (s == null || s.Length == 0) {
            return 0;
        }
        if (s.Length == 1) {
            return 1;
        }

        // Initialize two pointers, left and right, and the maximum length found
        int left = 0;
        int right = 0;
        int maxLength = 0;

        // Use a HashSet to store characters in the current window.
        // HashSet provides O(1) average time complexity for Add, Remove, and Contains operations.
        HashSet<char> charSet = new HashSet<char>();

        // Iterate through the string with the right pointer
        while (right < s.Length) {
            // If the character at the right pointer is not in the set,
            // it means it's a unique character for the current substring.
            if (!charSet.Contains(s[right])) {
                charSet.Add(s[right]);
                // Update maxLength with the current window's size
                maxLength = Math.Max(maxLength, charSet.Count);
                // Move the right pointer to expand the window
                right++;
            } else {
                // If the character at the right pointer IS in the set,
                // it means we have a duplicate.
                // We need to shrink the window from the left until the duplicate is removed.
                charSet.Remove(s[left]);
                // Move the left pointer to shrink the window
                left++;
            }
        }

        return maxLength;
    }
}