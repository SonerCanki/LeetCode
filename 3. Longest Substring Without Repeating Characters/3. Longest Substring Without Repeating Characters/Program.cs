
var s = "aab";

var length = LengthOfLongestSubstring(s);
Console.WriteLine(length);

int LengthOfLongestSubstring(string s)
{
    Dictionary<char, int> dic = new Dictionary<char, int>();
    var length = 0;
    for (int i = 0; i < s.Length; i++)
    {
        dic.Add(s[i], i);
    }

    return length;
}



//if (dic.ContainsKey(s[i]))
//        {
//            length = length > dic.Keys.Count ? length : dic.Keys.Count;
//            dic.Clear();
//        }