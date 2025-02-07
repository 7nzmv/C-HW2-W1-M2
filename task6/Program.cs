int Max(int[] arr, int i = 0)
{
    if (i == arr.Length - 1)
        return arr[i];

    int max1 = Max(arr, i + 1);

    if (arr[i] > max1)
    return arr[i];
    
    else
    return max1;
}

int[] arr = { 17, 77, 99, 117, 999, 1111 };
System.Console.WriteLine($"Max Element : {Max(arr)}");