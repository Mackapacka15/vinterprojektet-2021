using System.Text.Json;

namespace vinterprojektet
{
    public class Kort
    {
        public string question { get; init; }
        public string answer { get; init; }
        string playeranswer;

        public void PrintJoke()
        {
            Console.WriteLine(question);
            playeranswer = Console.ReadLine();
            if (playeranswer.ToLower() == answer.ToLower())
            {
                Console.WriteLine("Haha, Du kunde svaret");
            }
            else
            {
                Console.WriteLine(answer);
            }
        }
    }
}