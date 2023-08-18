int[] array = new int[] { 8, 3, 4, 7, 1, 2, 9 };
for (int i = 1; i < array.Length; i++)
{
  int sorted = i - 1;
  while (sorted > -1 && array[sorted] > array[sorted + 1])
  {
    int temp = array[sorted];
    array[sorted] = array[sorted + 1];
    array[sorted + 1] = temp;
    sorted--;
   }
}

Console.WriteLine(string.Join(" ", array)); 