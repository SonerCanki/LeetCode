
IsValid("((");
IsValid("{([])}");
IsValid("()[]{([(}])}");

bool IsValid(string s)
{
    //var isValid = true;

    char[] openBrackets = { '(', '{', '[' };
    char[] closeBrackets = { ')', '}', ']' };
    var checkOpens=new List<char>();

    if (s.Length<=1)
    {
        return false;
    }


    for (int i = 0; i < s.Length; i++)
    {
        var currentBraketIndex = Array.IndexOf(openBrackets, s[i]);
        
        if (currentBraketIndex < 0)
        {
            if (checkOpens.LastOrDefault() != s[i])
                return false;

            checkOpens.Remove(checkOpens.LastOrDefault());
            continue;   
        }
        
        var closeBraket = closeBrackets[currentBraketIndex];

        if (openBrackets.Contains(s[i + 1]))
        {
            checkOpens.Add(closeBraket);
            continue;
        }
        else
        {
            if (closeBraket != s[i + 1])
                return false;
            else
                i++;
        }

    }
    return true;
}

