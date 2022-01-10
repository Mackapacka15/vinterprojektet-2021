using System;

namespace vinterprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            Game g = new Game();
            while (playing)
            {
                playing = g.Update();
            }

        }

    }

}
