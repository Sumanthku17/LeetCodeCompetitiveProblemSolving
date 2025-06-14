public class Solution {
    public bool IsAnagram(string s, string t) {
        List<Char> chList1 = s.ToCharArray().ToList();
        List<Char> chList2 = t.ToCharArray().ToList();

        foreach(Char ch in chList1)
        {
            if(chList2.Contains(ch))
            {
                chList2.Remove(ch);
            }
            else
            {
                return false;
            }
        }

        return (chList2.Count() == 0);
    }
}