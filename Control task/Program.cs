string[] strArray = {"hello", "2", "world", ":-)"};

int FindLengthResArray(string[] array)
{
    int count = 0;
    foreach (var index in array)
    {
        if (index.Length <= 3)
        {
            count++;
        }
    } 
    return count;
}

string[] FillResArray(string[] array, int count)
{
    string[] resArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i].Length <= 3)
        {
            resArray[j] = array[i];
            j++;
        } 
    }
    return resArray;
}

string[] result = FillResArray(strArray, FindLengthResArray(strArray));
Console.Write($"[{String.Join(", ", strArray)}]");
Console.Write($" -> [{String.Join(", ",result)}]");