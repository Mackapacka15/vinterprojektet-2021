using System;
using System.Text.Json;

namespace vinterprojektet
{
    public static class Kortlek
    {
        public static List<Kort> mildaKort = new List<Kort>();
        public static List<GrovaKort> grovaKort = new List<GrovaKort>();
        public static List<Kort> semiGrovaKort = new List<Kort>();
        static private int visatKort;
        static Random generator = new Random();

        static public void SetKortlek()
        {
            string mildaString = File.ReadAllText("Milda.json");
            mildaKort = JsonSerializer.Deserialize<List<Kort>>(mildaString);
            string grovaString = File.ReadAllText("Grova.json");
            grovaKort = JsonSerializer.Deserialize<List<GrovaKort>>(grovaString);
            string semiGrovaString = File.ReadAllText("SemiGrova.json");
            semiGrovaKort = JsonSerializer.Deserialize<List<Kort>>(semiGrovaString);
        }
        static public void PlayCard()
        {
            string svar;
            Console.WriteLine("Vilken kortlek ska användas?");
            Console.WriteLine("Milda kort = 1");
            Console.WriteLine("Semi Grova kort = 2");
            Console.WriteLine("Grova kort = 3");
            svar = Console.ReadLine();

            if (svar == "1")
            {
                Card(mildaKort.ToArray());
                mildaKort.RemoveAt(visatKort);
            }
            if (svar == "2")
            {
                Card(semiGrovaKort.ToArray());
                semiGrovaKort.RemoveAt(visatKort);
            }
            if (svar == "3")
            {
                Card(grovaKort.ToArray());
                grovaKort.RemoveAt(visatKort);
            }
        }
        static void Card(Kort[] kortLista)
        {
            visatKort = generator.Next(0, kortLista.Length);
            if (kortLista.Length != 0)
            {
                visatKort = generator.Next(0, kortLista.Length);
                kortLista[visatKort].PrintJoke();
            }
            else
            {
                Console.WriteLine("Det var tyvärr slut på kort i den leken. Du får ett milt kort istället");
                if (mildaKort.Count != 0)
                {
                    mildaKort[1].PrintJoke();
                    mildaKort.RemoveAt(1);
                }
                else
                {

                }
            }
        }
    }
}