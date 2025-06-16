public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();
        foreach(string str in strs)
        {
            var strArr = str.ToCharArray();
            Array.Sort(strArr);

            var canonical = new string(strArr);

            if(map.ContainsKey(canonical))
            {
                map[canonical].Add(str);
            }
            else
            {
                map.Add(canonical, new List<string> { str });
            }
        }
        return new List<IList<string>>(map.Values);
    }
}