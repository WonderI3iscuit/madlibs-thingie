using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is one that will walk the user through a madlibs 
            by me lol
            */


            // Let the user know that the program is starting:



            // Give the Mad Lib a title:
            string title = "acid trip v2";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("the thing started nerd, look alive.");


            
            //for the name
            Console.Write("enter a name: ");
            string name = Console.ReadLine();
            //the adjectives
            Console.Write($"okay, {name}. give me an adjective ");
            string adjOne = Console.ReadLine();
            Console.Write($"okay, give me another one");
            string adjTwo = Console.ReadLine();
            Console.Write($"last one, one more adjective please ");
            string adjThree = Console.ReadLine();
            //a verb
            Console.Write($"enter a verb, please ");
            string verbOne = Console.ReadLine();
            //some nouns
            Console.Write($"first noun? ");
            string nounOne = Console.ReadLine();
            Console.Write($"noun dos ");
            string nounTwo = Console.ReadLine();
            //random stuff
            Console.Write($"gimmie animal");
            string animal = Console.ReadLine();
            Console.Write($"gimmie food");
            string food = Console.ReadLine();
            Console.Write($"gimmie fruit ");
            string fruit = Console.ReadLine();
            Console.Write($"gimmie a superhero ");
            string hero = Console.ReadLine();
            Console.Write($"gimmie country ");
            string country = Console.ReadLine();
            Console.Write($"gimmie dessert");
            string dessert = Console.ReadLine();
            Console.Write($"ok, last one. gimmie a year ");
            string year = Console.ReadLine();

            // Print the story:

            string story = $"This morning {name} woke up feeling {adjOne}. " +
                $"'It is going to be a {adjTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. " +
                $"They began to {verbOne} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjThree}. Concerned, {name} texted {hero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}." +
                $" {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


        }
    }
}