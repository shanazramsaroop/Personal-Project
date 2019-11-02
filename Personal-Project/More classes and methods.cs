using System;
namespace Personal_Project
{
    public class More_classes_and_methods
    {
        public More_classes_and_methods()
        {
            Car myCar = new Car();

            Car.myMethod();

            /*
            myCar.Make = "OldMobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            

            Car myThirdCar = new Car("ford", "escape", 2005, "white");

            Car MyOtherCar;
            MyOtherCar = myCar;

            
            Console.WriteLine("{0} {1} {2} {3}",
                MyOtherCar.Make ,
                MyOtherCar.Model ,
                MyOtherCar.Year ,
                MyOtherCar.Color  );
            

            MyOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            MyOtherCar = null;
            */

            Console.ReadLine();
        }
    }
    class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Make = "Nissan";
        }

        public Car(string model, string make, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void myMethod()
        {
            Console.WriteLine("Called the static myMethod");
            Console.ReadLine();
        }

    }
}
