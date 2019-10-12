using System;
namespace Personal_Project
{
    public class Helper_Method
    {
        public Helper_Method()
        {
            Console.WriteLine("The name game");


            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();

            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);
            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);
            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);
            string result = "";
            foreach (char item in firstNameArray)
            {
                result += item;
            }
            result += " ";
            foreach (char item in lastNameArray)
            {
                result += item;
            }
            result += " ";
            foreach (char item in cityArray)
            {
                result += item;
            }
            Console.WriteLine("Results: " + result);
            */


            Console.Write("Results: ");

            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);
            string reversedCity = ReverseString(city);

            /*
            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
                */

            Console.ReadLine();
        }

        private static void ReverseString(string message)
        {


            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);


        }

        private static void DisplayResult();

        Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));

        }
}
}
