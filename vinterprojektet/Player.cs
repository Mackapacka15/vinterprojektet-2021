using System;

namespace vinterprojektet
{
    public class Player
    {
        //En lista med alla spelare
        public static List<Player> playersList = new List<Player>();
        static int playerNr = 1;
        int lives = 5;
        string name;
        string svar;

        //Frågar vad spelaren ska heta och lägger till spelaren i listan med spelare
        public Player()
        {
            Console.WriteLine($"Vad heter spelare {playerNr}?");
            name = Console.ReadLine();
            playerNr++;
            playersList.Add(this);
        }

        //Frågar om spelaren skrattade
        public void DidLaugh()
        {
            Console.WriteLine($"Skrattade {name}?");
            svar = Console.ReadLine();
            if (svar.ToLower() == "ja")
            {
                lives--;
            }
        }
        //Kollar om spelare är vid liv
        public bool IsAlive()
        {
            if (lives <= 0)
            {
                Console.WriteLine($"{name} har skattat för mycket och är ute ur spelet");
                return false;
            }
            return true;
        }
        //Frågar om spelaren skrattade
        public static bool LaughCheck(int playerCount)
        {
            if (playerCount == 1)
            {
                //Använder metoden LaughCheckSingle om man spelar själv och retunerar om spelet ska avsluts
                return LaughCheckSingle();
            }
            else
            {
                //Använder metoden LaughCheckMulti om man är fler och retunerar om man spelet ska avslutas
                return LaughCheckMulti();
            }
        }
        //Används för att ta reda på om spelaren är vid liv eller inte
        private static bool LaughCheckSingle()
        {
            playersList[0].DidLaugh();
            if (playersList[0].IsAlive())
            {
                return true;
            }
            Console.WriteLine("Bra spelat hoppas du hade kul");
            return false;
        }
        //Används för att kolla vilka som skrattade samt ta bort spelare som åkt ut
        private static bool LaughCheckMulti()
        {
            foreach (var p in playersList)
            {
                p.DidLaugh();
            }
            //Tar bort alla spelare som åkt ut
            playersList.RemoveAll(a => !a.IsAlive());

            //Stopar spelet när det endast är en spelare kvar
            if (playersList.Count == 1)
            {
                Console.WriteLine($"Vi har en vinnare. Grattis {playersList[0].name}.");
                return false;
            }
            return true;
        }
    }
}