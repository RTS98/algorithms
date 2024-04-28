class Program
{
    private static readonly Dictionary<string, string[]> relations = [];
    public static void CreateRelations()
    {
        relations.Add("Alice", ["Bob", "Joshy", "Claires"]);
        relations.Add("Bob", ["Peggy", "Anuj"]);
        relations.Add("Joshy", ["Peggy"]);
        relations.Add("Claires", ["Jonny", "Thom"]);
        relations.Add("Anuj", []);
        relations.Add("Jonny", []);
        relations.Add("Peggy", []);
        relations.Add("Thom", []);
    }

    public static void Main(string[] args)
    {
        CreateRelations();
        HashSet<string> checkedFriends = [];
        Queue<string> people = new(relations["Alice"]);

        while (people.Count > 0)
        {
            string friend = people.Dequeue();

            if (!checkedFriends.Contains(friend))
            {
                if (friend.Length % 2 == 0)
                {
                    Console.WriteLine($"Am gasit {friend}");
                    return;
                }

                foreach (string item in relations[friend])
                {
                    people.Enqueue(item);
                }

                checkedFriends.Add(friend);
            }
        }
    }
}
