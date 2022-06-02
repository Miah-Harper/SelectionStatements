using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //var favNumber = r.Next(1, 10);
            //Console.WriteLine("Guess the number!");
            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput < favNumber)
            //{
            //Console.WriteLine("too low");

            //}
            //else if (userInput > favNumber)
            //{
            //Console.WriteLine("too high");
            //}
            //else
            //{ 
            //Console.WriteLine("You guessed it!");
            //}

            Console.WriteLine("What's your favorite school subject?");

            string favSubject = Console.ReadLine();

            switch (favSubject)

            {

                case "math":
                    Console.WriteLine("Math is hard!");
                    break;

                case "science":
                    Console.WriteLine("I love science!");
                    break;

                case "photography":
                    Console.WriteLine("Photography is my favorite too!");
                    break;

                case "german":
                    Console.WriteLine("I studided german for 7 years!");
                    break;

                case "lunch":
                    Console.WriteLine("Lunch isn't a class!");
                    break;

                default:
                    Console.WriteLine("I love all subjects!");
                    break;

            }

        }
    }
}
