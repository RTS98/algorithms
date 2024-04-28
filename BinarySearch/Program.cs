class Program
{
    public static int? BinarySearch(int[] arr, int item)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == item)
            {
                return mid;
            }

            if (arr[mid] < item)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return null;
    }

    static void Main(string[] args)
    {
        int[] elements = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        int? result = BinarySearch(elements, 11);

        Console.WriteLine(result);
    }
}
