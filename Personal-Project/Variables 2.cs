using System;
namespace Personal_Project
{
    public class Variables_2
    {
        public Variables_2()
        {
            Console.WriteLine("What is your name?");
            Console.WriteLine("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            /*
            string myLastName;
            Console.WriteLine("Type your last name: ");
            myLastName = Console.ReadLine();
            */

            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine();


            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);

        }
    }
}
