using System;

namespace vinterprojektet
{
    public class Game
    {
        Menu m = new Menu();
        Kortlek k = new Kortlek();
        int playerCount;

        public Game()
        {
            playerCount = m.playerCount;
            k.SetKortlek();
        }

        public bool Update()
        {
            k.PlayCard();
            return Player.LaughCheck(playerCount);
        }
    }
}