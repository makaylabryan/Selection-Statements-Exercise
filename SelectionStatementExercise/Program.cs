using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favoriteNumber = r.Next(1, 1000);
           
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favoriteNumber)
            {
                Console.WriteLine("Too low");
            }
            else if(userInput > favoriteNumber)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Great job!");
            }
        }
    }
}
