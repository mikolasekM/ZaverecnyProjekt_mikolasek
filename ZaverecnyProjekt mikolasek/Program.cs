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
                switch (choice)
                {
                    case "K" or "N" or "P": break;
                    default:
                        {
                            Console.WriteLine("nevybral jsi spravny objekt");
                            Console.ReadKey();
                            continue;
                        }
                }
                int enemychoice = random.Next(0, 3);
                if (enemychoice == 0)
                {
                    Console.WriteLine(" enemy vybral kamínek");
                    switch (choice)
                    {
                        case "K":
                            Console.WriteLine("remízka");
                            mySkore++;
                            enemySkore++;
                            break;
                        case "N":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("prohrál jsi nůbe");
                            enemySkore++;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "P":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("vyhrál jsi :D");
                            mySkore++;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
                else if (enemychoice == 1)
                {
                    Console.WriteLine("enemy vybral nůžtičky");
                    switch (choice)
                    {
                        case "K":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("vyhral jsi :D");
                            mySkore++;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "N":
                            Console.WriteLine("remízka");
                            mySkore++;
                            enemySkore++;
                            break;
                        case "P":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("prohrál jsi nůbe");
                            Console.ForegroundColor = ConsoleColor.White;
                            enemySkore++;
                            break;
                    }
                }
                else if (enemychoice == 2)
                {
                    Console.WriteLine("enemy použil papír");
                    switch (choice)
                    {
                        case "K":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("prohrál jsi nůbe");
                            Console.ForegroundColor = ConsoleColor.White;
                            enemySkore++;
                            break;
                        case "N":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("vyhrál jsi :D");
                            Console.ForegroundColor = ConsoleColor.White;
                            mySkore++;
                            break;
                        case "P":
                            Console.WriteLine("remízka");
                            mySkore++;
                            enemySkore++;
                            break;
                    }
                }
                Console.ReadKey();
            }
               if (enemySkore== 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("LOOSER JSII ;-;");
                Console.ForegroundColor = ConsoleColor.White;
            }      
               else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("JSI WINNER °-°");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        catch(Exception)
        {
           Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Špatně zadaná hodnota - zadej vstup znovu");
            Console.ForegroundColor = ConsoleColor.White;
        }
            
          
        
    }
}
