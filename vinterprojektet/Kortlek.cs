using System;
using System.Text.Json;

namespace vinterprojektet
{
    public class Kortlek
    {
        private List<Kort> mildaKort = new List<Kort>();
        private List<GrovaKort> grovaKort = new List<GrovaKort>();
        private List<Kort> semiGrovaKort = new List<Kort>();

        private Queue<Kort> kortsamling = new Queue<Kort>();
        static Random generator = new Random();

        public void SetKortlek()
        {
            List<Kort> kort = new List<Kort>();
            string mildaString = File.ReadAllText("Milda.json");
            mildaKort = JsonSerializer.Deserialize<List<Kort>>(mildaString);
            string grovaString = File.ReadAllText("Grova.json");
            grovaKort = JsonSerializer.Deserialize<List<GrovaKort>>(grovaString);
            string semiGrovaString = File.ReadAllText("SemiGrova.json");
            semiGrovaKort = JsonSerializer.Deserialize<List<Kort>>(semiGrovaString);

            Console.WriteLine("Vilka kortlekar vill du använda? (Svara med siffran)");
            Console.WriteLine("1) Milda");
            Console.WriteLine("2) Milda + Semi Grova");
            Console.WriteLine("3) Alla");
            string svar = Console.ReadLine();

            switch (svar)
            {
                case "1":
                    kort.AddRange(mildaKort);
                    break;
                case "2":
                    kort.AddRange(mildaKort);
                    kort.AddRange(semiGrovaKort);
                    break;
                case "3":
                    kort.AddRange(mildaKort);
                    kort.AddRange(semiGrovaKort);
                    Console.WriteLine("Hur grova ska de grova skämten vara? (1-10)");
                    string svar2 = Console.ReadLine();
                    int svarint = IntMaker(svar2);
                    foreach (var item in grovaKort)
                    {
                        if (item.grovLvl <= svarint)
                        {
                            kort.Add(item);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Det där var inte en giltig siffra. Du får milda kort");
                    kort.AddRange(mildaKort);
                    break;
            }
            RandomizeList(kort);
        }

        private void RandomizeList(List<Kort> k)
        {
            while (k.Count != 0)
            {
                Kort tillagt = k[generator.Next(0, k.Count)];
                kortsamling.Enqueue(tillagt);
                k.Remove(tillagt);
            }
        }
        public void PlayCard()
        {
            kortsamling.Dequeue().PrintJoke();
        }
        public int IntMaker(string input)
        {
            bool correct;
            int output;
            correct = int.TryParse(input, out output);
            if (correct)
            {
                if (output <= 10)
                {
                    return output;
                }
            }
            Console.WriteLine("That Was Not A valid Number. Du får inga grova skämt");
            return 0;
        }
    }
}