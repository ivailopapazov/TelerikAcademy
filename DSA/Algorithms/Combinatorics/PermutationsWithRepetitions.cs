var arr = new int[] { 3, 5, 1, 5, 5 };
Array.Sort(arr);
PermuteRep(arr, 0, arr.Length);

static void PermuteRep(int[] array, int start, int n)
{
    Console.WriteLine(string.Join(", ", array));
    for (int left = n - 2; left >= start; left--)
    {
        for (int right = left + 1; right < n; right++)
        {
            if (array[left] != array[right])
            {
                Swap(ref array[left], ref array[right]);
                PermuteRep(array, left + 1, n);
            }
        }

        var firstElement = array[left];
        for (int i = left; i < n - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[n - 1] = firstElement;
    }
}

private static void Swap(ref int firstValue, ref int secondValue)
{
    var oldValue = firstValue;
    firstValue = secondValue;
    secondValue = oldValue;
}
