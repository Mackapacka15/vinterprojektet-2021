using System;

namespace vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            Menu m = new Menu();
            Kortlek.SetKortlek();
            while (playing)
            {
                MakePlayers(m.playerCount);
                while (Player.players.Count() != 1)
                {
                    Kortlek.PlayCard();
                    Player.LaughCheck();

                }

            }


            Console.ReadLine();

        }
        static void MakePlayers(int playerCount)
        {
            if (Player.players.Count() != 0)
            {
                for (int i = 0; i < playerCount; i++)
                {
                    new Player();
                }
            }
        }
        public static void EndGame()
        {
            
        }
    }

}
