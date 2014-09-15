static void GenerateVariationsNoReps(int index)
{
  if (index >= k)
  {
    PrintVariations();
  }
  else
  {
    for (int i = 0; i < n; i++)
    {
      if (!used[i])
      {
        used[i] = true;
        arr[index] = i;
        GenerateVariationsNoReps(index + 1);
        used[i] = false;
      }
    }
  }
}

GenerateVariationsNoReps(0);
