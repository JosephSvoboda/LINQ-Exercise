namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "osrs", "mw2", "elden ring", "LoL", "WoW"};

            games.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
