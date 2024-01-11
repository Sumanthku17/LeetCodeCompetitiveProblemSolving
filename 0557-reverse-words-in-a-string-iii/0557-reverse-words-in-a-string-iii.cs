public class Solution {
    public string ReverseWords(string s) {
        string[] strArr = s.Split(' ');
        return String.Join(' ', reverseString(strArr));
    }
    public IEnumerable<string> reverseString(string[] strArr)
    {
        return strArr.Select(str => string.Concat((str.ToArray().Reverse())));
    }
}