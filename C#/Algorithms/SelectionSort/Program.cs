using System.Collections.Generic;

int[] array = new int[] { 8, 3, 4, 7, 1, 2, 9 };

for (int i = 0; i < array.Length - 1; i++)
{
  int min_index = i;
  for (int j = i + 1; j < array.Length; j++)
  {
    if (array[min_index] > array[j]) min_index = j;
  }
  if (min_index != i) {
    int temp = array[min_index];
    array[min_index] = array[i];
    array[i] = temp;
  }
}
Console.WriteLine(string.Join(" ", array));
 