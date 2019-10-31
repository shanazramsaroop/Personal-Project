using System;
namespace Personal_Project
{
    public class Working_with_Classes
    {
        public Working_with_Classes()
        {
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlass Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value );

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Console.ReadLine();

        }

        private static decimal DetermineMarketValue(Car car)

        {

            decimal carValue = 100.0M;

            return carValue;


        }

    }


    class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;

        }
    }
}
