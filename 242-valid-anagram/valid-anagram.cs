public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false;

        Dictionary<char, int> charFreq = new Dictionary<char, int>();
        foreach(char ch in s)
        {
            charFreq[ch] = charFreq.GetValueOrDefault(ch, 0) + 1;
        }

        foreach(char ch in t)
        {
            if(!charFreq.ContainsKey(ch) || charFreq[ch] == 0)
            {
                return false;
            }
            charFreq[ch]--;
        }
        return true;
    }
}