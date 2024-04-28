class Program
{
    public static int ArraySum(int[] elements)
    {
        if (elements.Length == 0)
        {
            return 0;
        }

        if (elements.Length == 1)
        {
            return elements.First();
        }

        return elements.First() + ArraySum(elements.Skip(1).ToArray());
    }

    public static int ArrayCount(int[] elements)
    {
        if (elements.Length == 0)
        {
            return 0;
        }

        return 1 + ArrayCount(elements.Skip(1).ToArray());
    }

    public static int FindArrayMax(int[] elements, int max)
    {
        if (elements.Length == 0)
        {
            return max;
        }

        if (elements.First() > max)
        {
            max = elements.First();
        }

        return FindArrayMax(elements.Skip(1).ToArray(), max);
    }



    public static int BinarySearch(int[] elements, int target)
    {
        static int BinarySearchRecursive(int[] elements, int target, double left, double right)
        {
            int middle = (int)Math.Floor((left + right) / 2);

            if (left <= right)
            {
                if (target > elements[middle])
                {
                    return BinarySearchRecursive(elements, target, middle + 1, right);
                }

                if (target < elements[middle])
                {
                    return BinarySearchRecursive(elements, target, left, middle - 1);
                }

                return middle;
            }

            return -1;
        }

        return BinarySearchRecursive(elements, target, 0, elements.Length - 1);
    }



    public static void Main(string[] args)
    {
        int[] elements = [12, 20, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int sum = ArraySum(elements);
        int count = ArrayCount(elements);
        int max = FindArrayMax(elements, 0);
        int element = BinarySearch(elements, 4);

        Console.WriteLine(sum);
        Console.WriteLine(count);
        Console.WriteLine(max);
        Console.WriteLine(element);
    }
}