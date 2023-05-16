using Spectre.Console;
class zaverecnyProjekt
{
    public static void Main()
    {
        try
        {
            Random random = new Random();
            Console.WriteLine("vítej ve hře kamen nuzky papir :)");
            int mySkore = 0;
            int enemySkore = 0;
            string choice = "";
            while (true)
            {
                if (mySkore == 5 || enemySkore == 5) break;
                Console.Clear();
                AnsiConsole.Markup($"moje skore:[green]{mySkore}[/].enemy skore:[red]{enemySkore}[/]");
                Console.WriteLine("zadej pouze K(kamen) N(nuzky) P(papir)");
                choice = Console.ReadLine();
            }
            int enemymoznost = random.Next(0, 3);
            string[] counterList;
            if (counterList.Contains (choice)) { }
            if(counterList.Contains(choice))
            if(counterList.Contains(choice))
        }
        catch(Exception)
        {
           Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Špatně zadaná hodnota - zadej vstup znovu");
            Console.ForegroundColor = ConsoleColor.White;
        }
            
          
        
    }
}
