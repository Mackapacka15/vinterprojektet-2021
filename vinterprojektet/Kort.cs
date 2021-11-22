using System.Text.Json;

namespace vinterprojektet
{
    public class Kort
    {
        public string question { get; init; }
        public string answer { get; init; }
        string score;
        string playeranswer;

        public void PrintJoke()
        {
            Console.WriteLine(question);
            playeranswer = Console.ReadLine();
            if (playeranswer.ToLower() == answer.ToLower())
            {
                Console.WriteLine("Haha, Congrats you knew it");
            }
            else
            {
                Console.WriteLine(answer);
            }
            Console.WriteLine("How good was the joke? (0-10)");
            score = Console.ReadLine();
            if (score == null)
            {
                score = "0";
            }

        }
    }
}