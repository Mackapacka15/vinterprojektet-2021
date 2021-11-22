using System;

namespace vinterprojektet
{
    public class Menu
    {
        private string svar = "";
        private int svarInt = -1;
        public void Welcome()
        {
            Console.WriteLine("Välkommen till Den som skrattar förlorar spelet");
            Console.WriteLine("Målet med spelet är att inte skratta");
            Console.WriteLine("Alla spelare börjar med 5 liv");
            Console.WriteLine("Man förlorar ett liv varje gång man skrattar");
        }
        public int Players()
        {
            while (svarInt == -1)
            {
                Console.WriteLine("Hur många spelare ska vara med?");
                svar = Console.ReadLine();
                svarInt = IntMaker(svar);
                if (svarInt <= 1)
                {
                    Console.WriteLine("Spelar du själv?");
                    if (svar.ToLower() == "ja")
                    {
                        svarInt = 1;
                    }
                }
            }
            return svarInt;
        }
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