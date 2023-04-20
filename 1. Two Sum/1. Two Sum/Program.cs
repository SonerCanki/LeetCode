
foreach (var item in TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11))
{
    Console.WriteLine(item);
}


int[] TwoSum(int[] nums, int target)
{

    var dic = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int compalement = target - nums[i];
        if (dic.ContainsKey(compalement))
        {
            return new int[] { dic.GetValueOrDefault(compalement), i };
        }
        if (!dic.ContainsKey(nums[i]))
            dic.Add(nums[i], i);
    }

    return new int[] { -1, -1 };
}

//int[] TwoSum(int[] nums, int target)
//{
//    int[] result = new int[2];
//    var index = 0;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        for (int j = 0; j < nums.Length; j++)
//        {
//            if (nums[i] + nums[j] == target)
//            {
//                result[index] = i;
//                index++;
//            }
//        }
//    }

//    return result;
//}