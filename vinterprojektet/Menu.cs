using System;

namespace vinterprojektet
{
    public class Menu
    {
        private string svar = "";
        public int playerCount = -1;
        public Menu()
        {
            //Kör två metoder
            Welcome();
            Players();
        }
        //Skriver ut reglerna och hölsar dig välkommen
        private void Welcome()
        {
            Console.WriteLine("Välkommen till Den som skrattar förlorar spelet");
            Console.WriteLine("Målet med spelet är att inte skratta");
            Console.WriteLine("Alla spelare börjar med 5 liv");
            Console.WriteLine("Man förlorar ett liv varje gång man skrattar");
        }
        //Tar reda på hur många spelare som ska vara med
        private void Players()
        {
            while (playerCount == -1)
            {
                Console.WriteLine("Hur många spelare ska vara med?");
                svar = Console.ReadLine();
                playerCount = IntMaker(svar);
                if (playerCount == 1)
                {
                    Console.WriteLine("Spelar du själv?");
                    svar = Console.ReadLine();
                    if (svar.ToLower() == "ja")
                    {
                        playerCount = 1;
                    }
                }
            }
            //Skapar så många spelare som ska vara med
            MakePlayers();
        }
        //Skapar en ny spelare och ger den ett namn
        private void MakePlayers()
        {
            for (int i = 0; i < playerCount; i++)
            {
                new Player();
            }
        }
        //Gör om en String till en Int
        private int IntMaker(string input)
        {
            bool correct;
            int output;
            correct = int.TryParse(input, out output);
            if (correct)
            {
                return output;
            }
            Console.WriteLine("That Was Not A valid Number");
            return -1;
        }
    }
}