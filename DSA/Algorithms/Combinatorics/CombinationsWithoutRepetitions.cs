static void Main()
{
  Comb(0, 0);
}

static void Comb(int index, int start)
{
  if (index >= k)
  {
    PrintCombinations();
  }
  else
  {
    for (int i = start; i < n; i++)
    {
      arr[index] = i;
      Comb(index + 1, i + 1);
    }
  }
}
