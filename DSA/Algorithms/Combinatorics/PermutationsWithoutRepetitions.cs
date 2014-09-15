static void Perm<T>(T[] arr, int k)
{
  if (k >= arr.Length)
  {
    Print(arr);
  }
  else
  {
    Perm(arr, k + 1);
    for (int i = k + 1; i < arr.Length; i++)
    {
      Swap(ref arr[k], ref arr[i]);
      Perm(arr, k + 1);
      Swap(ref arr[k], ref arr[i]);
    }
  }
}
