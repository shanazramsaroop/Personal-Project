using System;
namespace Personal_Project
{
    public class Understanding_LINQ
    {
        public Understanding_LINQ()
        {

            List<Car> myCars = new List<Car>() {
                new Car(){ VIN = "AI", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 2009 },
                new Car(){ VIN = "B2", Make = "Toyota", Model = "4Runner", StickerPrice = 35000, Year = 2010 },
                new Car(){ VIN = "C3", Make = "BMW", Model = "745Li", StickerPrice = 75000, Year =  2008},
                new Car(){ VIN = "D4", Make = "Ford", Model = "Escape", StickerPrice = 25000, Year = 2008 },
                new Car(){ VIN = "E5", Make = "BMW", Model = "55i", StickerPrice = 57000, Year =  2010},
            };

            //Query syntax
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
                       
            */


            //Method syntax
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            //Ordered list (query)
            /*var orderedCars = from Car in myCars
                              orderby Car.Year descending
                              select Car;
                              */

            //Ordered list (method)
            //var orderedCars = myCars.OrderByDescending(p => p.Year);

            /*
            var FirstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(FirstBMW.VIN);
            */

            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));

            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //Console.WriteLine(myCars.Exists(p => p.Model == "745Li"));

            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));


            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Year, car.Model, car.VIN);

            }
            */

            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws.GetType());

            var newCars = from car in myCars
                          where car.Make == "BMW"
                          && car.Year == 2010
                          select new { car.Make, car.Model };

            Console.WriteLine(newCars.GetType());

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public int StickerPrice { get; set; }


    }
}
