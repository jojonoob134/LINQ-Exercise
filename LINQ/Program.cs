namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gameStuff = new List<string>();
            gameStuff.Add("hollow kight");
            gameStuff.Add("GTA 5");
            gameStuff.Add("Librery of ruina");
            gameStuff.Add("balders gate 3");
            gameStuff.Add("persona 5 royal");
            gameStuff.Add("elden ring");
            
            var orderGames  = gameStuff.OrderBy(x => x.Length);

            foreach (var game in orderGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
