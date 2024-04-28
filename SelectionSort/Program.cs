class Program
{
    public static int FindSmallest(int[] arr)
    {
        int smallest = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < smallest)
            {
                smallest = arr[i];
            }
        }

        return smallest;
    }
    public static void Main(string[] args)
    {
        int[] elements = [12, 20, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int[] temp = elements;
        int[] sortedElements = new int[elements.Length];

        for (int i = 0; i < elements.Length; i++)
        {
            int smallest = FindSmallest(temp);
            temp = temp.Where((int element) => element != smallest).ToArray();
            sortedElements[i] = smallest;
        }

        foreach (int item in sortedElements)
        {
            Console.WriteLine(item);
        }
    }
}
