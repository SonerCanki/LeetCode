var testString = "   fly me   to   the moon  ";

Console.WriteLine(LengthOfLastWord(testString));

int LengthOfLastWord(string s)
{
    var a = s.Split(" ").Where(x => x.Length > 0).LastOrDefault().Length;

    return a;
}