
var s = "abcabcbb";

var lenght = LengthOfLongestSubstring(s);
Console.WriteLine(lenght);
int LengthOfLongestSubstring(string s)
{
    var dic = new Dictionary<char, int>();
    var lenght = 0;
    for (int i = 0; i < s.Length; i++)
    {
        dic.Add(s[i], i);
        if (dic.ContainsKey(s[i]))
        {
            lenght = lenght > dic.Keys.Count ? lenght : dic.Keys.Count;
            dic.Clear();
        }
        
    }
    return lenght;
}