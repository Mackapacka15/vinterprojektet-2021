using System;

namespace vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            bool winner = false;
            Menu m = new Menu();
            Kortlek k = new Kortlek();
            k.SetKortlek();
            while (playing)
            {
                if (!winner)
                {
                    k.PlayCard();
                    winner = Player.LaughCheck();
                }
                else
                {
                    Console.WriteLine($"The winner is {Player.playersList[0].Name}");
                }
            }


            Console.ReadLine();

        }

    }

}
