public class Solution {
    public bool IsAnagram(string s, string t) {
        // List<Char> chList1 = s.ToCharArray().ToList();
        // List<Char> chList2 = t.ToCharArray().ToList();

        // foreach(Char ch in chList1)
        // {
        //     if(chList2.Contains(ch))
        //     {
        //         chList2.Remove(ch);
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }

        // return (chList2.Count() == 0);

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