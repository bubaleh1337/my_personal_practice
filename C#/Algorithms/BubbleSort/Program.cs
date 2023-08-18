int[] array = new int[] { 8, 3, 4, 7, 1, 2, 9 };
int size = array.Length;

while (size != 0)
{
  int max_size = 0;
  for (int i = 1; i < size; i++)
  {
    if (array[i - 1] > array[i])
    {
      int temp = array[i - 1];
      array[i - 1] = array[i];
      array[i] = temp;
      max_size = i;
    }
  }
  size = max_size;
}

Console.WriteLine(string.Join(" ", array));