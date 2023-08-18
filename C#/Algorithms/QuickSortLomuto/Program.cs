namespace Name
{
  class Program
  {
    static void Main(string[] args) {
      int[] arr = new int[]{2, 5, 9, 1, 6, 16, 2, 7};
      int start = 0;
      int end = arr.Length - 1;
      partOfSortLomuto(arr, start, end);
      quickSortLomuto(arr);
      Console.WriteLine(string.Join(" ", arr));
    }
    static int partOfSortLomuto(int[] arr, int start, int end) {
      int left = start;
      for (int current = start; current < end; current++)
      {
        if(arr[current] <= arr[end]) {
          int temp = arr[left];
          arr[left] = arr[current];
          arr[current] = temp;
          left++;
        }
      }
      int temp1 = arr[left];
      arr[left] = arr[end];
      arr[end] = temp1;
      return left;
    }
    static void quickSortLomuto(int[] arr, int start, int end) {
      if(start >= end) return;
      int rightStart = partOfSortLomuto(arr, start, end);
      quickSortLomuto(arr, start, rightStart - 1);
      quickSortLomuto(arr, rightStart + 1, end);
    }
    static void quickSortLomuto(int[] arr) {
      quickSortLomuto(arr, 0, arr.Length - 1);
    }
  }
}