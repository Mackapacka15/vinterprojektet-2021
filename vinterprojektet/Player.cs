using System;

namespace vinterprojektet
{
    public class Player
    {
        public static List<Player> players = new List<Player>();
        static int playerNr = 1;
        int lives = 5;
        string name;
        string svar;

        public Player()
        {
            Console.WriteLine($"Vad heter spelare {playerNr}?");
            name = Console.ReadLine();
            playerNr++;
            players.Add(this);
        }
        public void LooseLife()
        {
            lives--;
        }
        public void didLaugh()
        {
            Console.WriteLine($"Skrattade {name}?");
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
                return false;
            }
            return true;
        }
        public static void LaughCheck()
        {
            foreach (var p in players)
            {
                p.didLaugh();
            }
            players.RemoveAll(a => a.IsAive());
        }
    }
}