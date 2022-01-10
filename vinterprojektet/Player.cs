using System;

namespace vinterprojektet
{
    public class Player
    {
        public static List<Player> playersList = new List<Player>();
        static int playerNr = 1;
        int lives = 2;
        public string Name { get; init; }
        string svar;

        public Player()
        {
            Console.WriteLine($"Vad heter spelare {playerNr}?");
            Name = Console.ReadLine();
            playerNr++;
            playersList.Add(this);
        }
        public void LooseLife()
        {
            lives--;
        }
        public void DidLaugh()
        {
            Console.WriteLine($"Skrattade {Name}?");
            svar = Console.ReadLine();
            if (svar.ToLower() == "ja")
            {
                lives--;
            }
        }
        public bool IsAlive()
        {
            if (lives <= 0)
            {
                Console.WriteLine($"{Name} har sktattat för mycket och är ute ur spelet");
                return false;
            }
            return true;
        }
        public static bool LaughCheck(int playerCount)
        {
            if (playerCount == 1)
            {
                return LaughCheckSingle();
            }
            else
            {
                return LaughCheckMulti();
            }
        }
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
        private static bool LaughCheckMulti()
        {
            foreach (var p in playersList)
            {
                p.DidLaugh();
            }
            playersList.RemoveAll(a => !a.IsAlive());
            if (playersList.Count == 1)
            {
                Console.WriteLine($"Vi har en vinnare. Grattis {playersList[0].Name}.");
                return false;
            }
            return true;
        }
    }
}