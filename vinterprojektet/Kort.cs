using System.Text.Json;
using System.Text.Json.Serialization;

namespace vinterprojektet
{
    public class Kort
    {

        [JsonPropertyName("question")]
        public string Question { get; init; }

        [JsonPropertyName("answer")]
        public string Answer { get; init; }
        string playeranswer;

        public void PrintJoke()
        {
            Console.WriteLine(Question);
            playeranswer = Console.ReadLine();
            if (playeranswer.ToLower() == Answer.ToLower())
            {
                Console.WriteLine("Haha, Du kunde svaret");
            }
            else
            {
                Console.WriteLine(Answer);
            }
        }
    }
}