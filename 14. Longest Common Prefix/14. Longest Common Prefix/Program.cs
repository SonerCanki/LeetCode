
using Microsoft.VisualBasic;

string[] strs = [""];

LongestCommonPrefix(strs);

string LongestCommonPrefix(string[] strs)
{
    var longestCommonPrefix = "";
    var smallest = strs.Min(str => str.Length);
    for (int i = 0, j = 0; i < smallest; i++)
    {
        j = 0;
        var tempChar = strs[j][i];
        while (j < strs.Length)
        {
            if (strs[j][i] != tempChar)
                return longestCommonPrefix;
            j++;
        }
        longestCommonPrefix += tempChar;
    }

    return longestCommonPrefix;
}
//for (int j = 0; j < orderedStrs.Length; j++)
//{
//    Iscontinue = smallestLengt[i] == strs[j][i];

//    if (!Iscontinue)
//    {
//        break;
//    } 
//}
//if (!Iscontinue)
//{
//    break;
//}
//else
//{
//    longestCommonPrefix += smallestLengt[i];
//}