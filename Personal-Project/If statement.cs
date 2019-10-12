using System;
namespace Personal_Project
{
    public class If_statement
    {
        public If_statement()
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            String userValue = Console.ReadLine();
            String message = "";


            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a boat";
            else if (userValue == "3")
                message = "You won a cat!";
            else
                message = "Sorry, we didn't understand.";

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
