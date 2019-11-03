﻿using System;
using System.Collections.Generic;

namespace Personal_Project
{
    public class Working_with_collections
    {
        public Working_with_collections()
        {
            /*
            Car car1 = new Car();
            car1.Make = "OldMobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism ";
            car2.VIN = "B2";


            Book b1 = new Book();
            b1.Author = "Robert Taylor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */

            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car1);
            myArrayList.Remove(car1);


            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            

            //Dictionary <TKey, TValue>

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */

            //string[] names = { "shanaz", "bob", "sophia", "chuck" };

            /*
            Object initializer
            Car car1 = new Car() { Make = "BMW", Model = "750", VIN = "C3" };
            Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };
            */

            //Collection initializer
            List<Car> myList = new List<Car>() {
                new Car { Make = "BMW", Model = "750", VIN = "C3" },
                new Car { Make = "Toyota", Model = "4Runner", VIN = "D4" },

            };




            Console.ReadLine();
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
