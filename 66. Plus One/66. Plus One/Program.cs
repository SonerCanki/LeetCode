int[] test = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
int[] test2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 9 };
int[] test3 = { 8, 7, 6, 5, 4, 3, 2, 1, 9 };
int[] test5 = { 8, 7, 6, 5, 4, 3, 9, 9, 9 };
int[] test4 = { 9, 9, 9, 9, 9 };

var a = PlusOne(test4);
var b = 1;
int[] PlusOne(int[] digits)
{
    var key = true;

    for (int i = digits.Length - 1; i >= 0; i--)
    {
        if (digits[i] == 9 && key)
        {
            digits[i] = 0;
        }
        else
        {
            digits[i] = digits[i] + 1;
            break;
        }
    }

    if (digits[0] == 0)
    {
        int[] newArray = new int[digits.Length + 1];
        newArray[0] = 1;
        for (int i = 0; i < digits.Length - 1; i++)
        {
            newArray[i + 1] = digits[i];
        }
        return newArray;
    }

    return digits;
}