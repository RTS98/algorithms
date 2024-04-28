class Program
{
    private static readonly Dictionary<int, int[]> relations = [];

    public static void CreateTree()
    {
        relations.Add(0, [1, 3]);
        relations.Add(1, [2, 4]);
        relations.Add(2, [5, 7]);
        relations.Add(3, [8, 9]);
        relations.Add(4, [6]);
        relations.Add(5, []);
        relations.Add(6, []);
        relations.Add(7, []);
        relations.Add(8, []);
        relations.Add(9, [10]);
        relations.Add(10, []);
    }

    public static void BreadthFirstSearch()
    {
        Queue<int> numbers = new(relations[0]);

        while (numbers.Count > 0)
        {
            int number = numbers.Dequeue();

            Console.WriteLine(number);
            if (relations[number].Length != 0)
            {
                foreach (int item in relations[number])
                {
                    numbers.Enqueue(item);
                }
            }
        }
    }

    public static void DepthFirstSearch(int startingPoint)
    {
        int[] values = relations[startingPoint];

        foreach (int node in values)
        {
            Console.WriteLine(node);
            if (relations[node].Length != 0)
            {
                DepthFirstSearch(node);
            }
        }
    }

    public static void Main(string[] args)
    {
        CreateTree();
        Console.WriteLine("--- BREADTH FIRST SEARCH ---");
        BreadthFirstSearch();
        Console.WriteLine("--- DEPTH FIRST SEARCH ---");
        DepthFirstSearch(0);
    }
}