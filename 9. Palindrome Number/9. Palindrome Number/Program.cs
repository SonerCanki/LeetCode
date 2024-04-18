
IsPalindromeNumber(1215);

bool IsPalindromeNumber(int x)
{
    var y = x;
    var z = x;
    var palindromeNumber = 0;
    var counter = -1;
    if (x < 0)
    {
        return false;
    }

    while (z > 0)
    {
        z = z / 10;
        counter++;
    }

    while (y > 0)
    {
        int b = y % 10;
        y = y / 10;
        palindromeNumber += b * Convert.ToInt32(Math.Pow(10, counter));
        counter--;
    }

    if (x == palindromeNumber)
    { return true; }

    return false;
}
