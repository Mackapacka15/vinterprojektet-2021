using System;

namespace vinterprojektet
{
    public class Game
    {
        Menu m = new Menu();
        Kortlek k = new Kortlek();
        int playerCount;

        //Körs så fort man skapar ett nytt Game objekt
        public Game()
        {
            //Sparar en variabel med hur många spelare som är med och spelar
            playerCount = m.playerCount;
            //Fixar kortleken
            k.SetKortlek();
        }

        public bool Update()
        {
            //Visar nästa kort.
            k.PlayCard();
            //Frågar vem som skrattade och retunerar om spelet ska avslutas
            return Player.LaughCheck(playerCount);
        }
    }
}