using System;

namespace vinterprojektet
{
    public class Player
    {
        public static List<Player> playersList = new List<Player>();
        static int playerNr = 1;
        int lives = 5;
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
        public void didLaugh()
        {
            Console.WriteLine($"Skrattade {Name}?");
            svar = Console.ReadLine();
            if (svar.ToLower() == "ja")
            {
                lives--;
            }
        }
        public bool IsAive()
        {
            if (lives <= 0)
            {
                Console.WriteLine($"{Name} har sktattat för mycket och är ute ur spelet");
                return false;
            }
            return true;
        }
        public static bool LaughCheck()
        {
            foreach (var p in playersList)
            {
                p.didLaugh();
            }
            playersList.RemoveAll(a => !a.IsAive());
            if (playerNr != 1)
            {
                if (playersList.Count == 1)
                {
                    return true;
                }
            }
            if (playersList.Count == 0)
            {
                Console.WriteLine("Bra spelat hoppas du hade kul");
            }
            return false;
        }
    }
}