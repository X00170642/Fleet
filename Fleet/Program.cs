using Fleet.Models;
using System.Collections.Generic;

namespace Fleet.Models
{

    public class Program
    {
        static void Main()
        {
           var CarList = new List<Car>
            {
                new Car("Honda", "Civic", "11-D-22332", 1500),
                new Car("Hyundai", "I30", "17-WX-29732", 2100),
                new Car("Mazda", "Swift", "07-D-290", 1800),
                new Car("Opel", "Corsa", "02-C-1278", 1600),
                new Car("Audi", "A4", "12-G-8788", 999),
            };



            var RegQuery = CarList
            .OrderBy(Car => Car.Registration);

            foreach (Car Details in RegQuery)
            {
                Console.WriteLine(Details.ToString());
            }


            var MazdaQuery = CarList
            .Where(Car => Car.Make == "Mazda");

            foreach (Car Details in MazdaQuery)
            {
                Console.WriteLine(Details.ToString());
            }


            var EngineSizeQuery = CarList
            .OrderByDescending(Car => Car.EngineSize);

            foreach (Car Details in EngineSizeQuery)
            {
                Console.WriteLine(Details.ToString());
            }


            var EngineSize1600Query = CarList
                .Where(Car => Car.EngineSize == 1600);


            foreach (Car Details in EngineSize1600Query)
            {
                Console.WriteLine("Make " + Details.Make + " | Model " + Details.Model);
            }


            var less1600Query = CarList
                .Where(Car => Car.EngineSize < 1600);

            var x = 0;
            foreach (Car Details in EngineSize1600Query)
            {
                x += 1;
            }
            Console.WriteLine("Number of cars with engine size less than 1600cc is: " + x);


        }


    }
}

