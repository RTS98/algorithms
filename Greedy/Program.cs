class Program
{
    private static readonly Dictionary<string, HashSet<string>> stations = [];

    public static void CreateStations()
    {
        stations.Add("one", ["id", "nv", "ut"]);
        stations.Add("two", ["wa", "id", "mt"]);
        stations.Add("three", ["or", "nv", "ca"]);
        stations.Add("four", ["nv", "ut"]);
        stations.Add("five", ["ca", "az"]);
    }

    public static void Main(string[] args)
    {
        HashSet<string> states = ["mt", "wa", "or", "id", "nv", "ut", "ca", "az"];
        HashSet<string> finalStations = [];
        
        CreateStations();

        while (states.Count > 0)
        {
            string bestStation = string.Empty;
            HashSet<string> coveredStates = [];

            foreach (string item in stations.Keys)
            {
                HashSet<string> covered = states.Intersect(stations[item]).ToHashSet();

                if (covered.Count > coveredStates.Count)
                {
                    bestStation = item;
                    coveredStates = covered;
                }
            }
            
            states = states.Except(coveredStates).ToHashSet();
            finalStations.Add(bestStation);
        }

        foreach(string station in finalStations) 
        {
            Console.WriteLine(station);
        }
    }
}