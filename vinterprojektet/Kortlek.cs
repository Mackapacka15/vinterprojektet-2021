using System;
using System.Text.Json;

namespace vinterprojektet
{
    public class Kortlek
    {
        public List<Kort> mildaKort = new List<Kort>();
        public List<Kort> pappaKort = new List<Kort>();
        public List<GrovaKort> grovaKort = new List<GrovaKort>();
        public List<Kort> semiGrovaKort = new List<Kort>();

        public Kortlek()
        {
            string mildaString = File.ReadAllText("Milda.json");
            mildaKort = JsonSerializer.Deserialize<List<Kort>>(mildaString);
            string pappaString = File.ReadAllText("Pappa.json");
            pappaKort = JsonSerializer.Deserialize<List<Kort>>(pappaString);
            string grovaString = File.ReadAllText("Grova.json");
            grovaKort = JsonSerializer.Deserialize<List<GrovaKort>>(grovaString);
            string semiGrovaString = File.ReadAllText("SemiGrova.json");
            semiGrovaKort = JsonSerializer.Deserialize<List<Kort>>(semiGrovaString);

        }
    }
}