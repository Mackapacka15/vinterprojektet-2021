using System;

namespace vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            Game g = new Game();
            //Detta är min game Loop som bara kör en Update metod
            while (playing)
            {
                playing = g.Update();
            }
            Console.ReadLine();

        }

    }

}
