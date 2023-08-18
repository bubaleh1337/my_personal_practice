namespace Name
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = new int[] { 8, 2, 6, 1, 9, 3, 6 };
      int left = 0;
      int right = arr.Length - 1;
      partOfSortHoara(arr, left, right);
      quickSortHoara(arr);
      Console.WriteLine(string.Join(" ", arr));
    }
    static int partOfSortHoara(int[] arr, int left, int right)
    {
      int pivot = arr[(left + right) / 2];
      while (left <= right)
      {
        while (arr[left] < pivot) left++;
        while (arr[right] > pivot) right--;
        if (left <= right)
        {
          int temp = arr[left];
          arr[left] = arr[right];
          arr[right] = temp;
          left++;
          right--;
        }
      }
      return left;
    }
    static void quickSortHoara(int[] arr, int start, int end)
    {
      if (start >= end) return;
      int rightStart = partOfSortHoara(arr, start, end);
      quickSortHoara(arr, start, rightStart - 1);
      quickSortHoara(arr, rightStart, end);
    }
    static void quickSortHoara(int[] arr)
    {
      quickSortHoara(arr, 0, arr.Length - 1);
    }
  }
}