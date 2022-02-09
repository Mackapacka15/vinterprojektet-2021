using System;

namespace vinterprojektet
{
    public class Game
    {
        Menu m = new Menu();
        Kortlek k = new Kortlek();
        int playerCount;
        bool cardsLeft;

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

            //Visar nästa kort och kollar om det finns kort kvar.
            cardsLeft = k.PlayCard();
            //Frågar vem som skrattade och retunerar om spelet ska avslutas
            if (cardsLeft)
            {
                return Player.LaughCheck(playerCount);
            }
            else
            {
                Console.WriteLine("Grattis! Du är världens kallaste människa. Spelet har slut på skämt.");
                return cardsLeft;
            }
        }


    }
}