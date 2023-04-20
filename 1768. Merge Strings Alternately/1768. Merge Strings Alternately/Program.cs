
Console.WriteLine(MergeAlternately("sonerab", "cankipqr"));


string MergeAlternately(string word1, string word2)
{
    var merged = "";
    var length = word1.Length < word2.Length ? word1.Length : word2.Length;

    for (int i = 0; i < length; i++)
    {
        merged += word1[i].ToString() + word2[i].ToString();
    }

    if (word1.Length > word2.Length)
        merged += word1.Substring(length);
    else
        merged += word2.Substring(length);
    return merged;
}