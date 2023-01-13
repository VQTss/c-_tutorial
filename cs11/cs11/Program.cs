using System;

namespace cs11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };

            int winner = Convert.ToInt32(Console.ReadLine());

            //this should show the winner and "Game Over"
            FinalRound finalRound = new FinalRound(finalists, winner);

            Person p1 = new Person();
        }
    }
    class FinalRound
    {
        public FinalRound(string[] finalists, int winner)
        {
            //complete the constructor
            Console.WriteLine("Winner is " + finalists[winner]);
        }

        //create destructor => "Game Over"
        ~FinalRound()
        {
            Console.WriteLine("Game Over");
        }
    }

    class Person
    {
        public Person()
        {
            Console.WriteLine("Constructor called.");
        }

        // destructor
        ~Person()
        {
            Console.WriteLine("Destructor called.");
        }
    }
}
