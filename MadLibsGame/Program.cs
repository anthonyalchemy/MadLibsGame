using System;

namespace MadLibsGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string colour, pluralNoun, celebrity; //declaring variables 

            Console.Write("Enter a colour");
            colour = Console.ReadLine();//storing user input in variable

            Console.Write("Enter a plural noun:");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are " + colour);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);


            Console.ReadLine(); 
        }
    }
}
