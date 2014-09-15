static void Main()
{
  GenerateVariations(0);
}

static void GenerateVariations(int index)
{
  if (index >= k)
  {
    Print(arr);
  }
  else
    for (int i = 0; i < n; i++)
    {
      arr[index] = i;
      GenerateVariations(index + 1);
    }
}
