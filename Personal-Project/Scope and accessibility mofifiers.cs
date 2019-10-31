using System;

namespace Personal_Project
{
    public class Scope_and_accessibility_mofifiers
    {
        private static string k = "";

        public Scope_and_accessibility_mofifiers()
        {
            string j = " ";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }

                //Console.WriteLine(l);

            }
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();

        }
        static void HelperMethod()
        {

            Console.WriteLine("Value of k from the HelperMethod(): " + k);

        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}
