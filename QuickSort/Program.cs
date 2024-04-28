class Program
{
    public static int[] QuickSort(int[] array)
    {
        if (array.Length < 2)
        {
            return array;
        }
        else
        {
            int pivot = array[0];
            int[] less = array.Where((int element, int index) => element <= pivot && index > 0).ToArray();
            int[] higher = array.Where((int element, int index) => element > pivot && index > 0).ToArray();

            return [.. QuickSort(less), pivot, .. QuickSort(higher)];
        }
    }

    public static void Main(string[] args)
    {
        int[] elements = [10, 5, 2, 3, 1, 12, 19, 13, 16, 11];
        int[] sortedElements = QuickSort(elements);

        foreach (int item in sortedElements)
        {
            Console.WriteLine(item);
        }
    }
}