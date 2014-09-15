static void Main()
{
  Comb(0, 0);
}

static void CombReps(int index, int start)
{
  if (index >= k)
  {
    PrintVariations();
  }
  else
  {
    for (int i = start; i < n; i++)
    {
      arr[index] = i;
      CombReps(index + 1, i);
    }
  }
}
