int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

int[] expectedNums = [0, 1, 2, 3, 4];

int k = RemoveDuplicates(nums);

if (expectedNums.Length == k)
{
    Console.WriteLine(k);
}
for (int i = 0; i < k; i++)
{
    if (nums[i] == expectedNums[i])
    {
        Console.WriteLine("true");
    }
}

Console.ReadLine();


int RemoveDuplicates(int[] nums)
{
    var list = new List<int>();

    int k = 0;

    foreach (int i in nums)
    {
        if (!list.Contains(i))
        {
            k++;
            list.Add(i);
        }
    }
    
   return k;
}