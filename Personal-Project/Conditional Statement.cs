using System;
namespace Personal_Project
{
    public class Conditional_Statement
    {
        public Conditional_Statement()
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";

            //Console.WriteLine("You won a ");
            //Console.Write(message);
            //Console.Write(".");

            //Console.WriteLine("You won a {0}.", message);

            Console.WriteLine("You entered: {0}, therefore, you won a {1}.", userValue, message);

            Console.ReadLine();

        }
    }
}
