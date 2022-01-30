using System;

namespace TurboAz
{
    class Program //main programda olmalidir 1 dene
    {
       static void Main()
        {
            Car car1 = new Car();
            car1.brandName = "Mercedes";
            car1.cityName = "Baku";
            car1.model = "E 300";
            car1.yearofIssue = 2017;
            car1.bodyType = "Sedan";
            car1.color = "black";
            car1.engine = 2;
            car1.power = 245;
            car1.fuelType = "petrol";
            car1.mileage = 75000;
            car1.transmitter = "back";
            car1.price = 55000;


            Car car2 = new Car();
            car2.brandName = "BMW";
            car2.cityName = "Baku";
            car2.model = "M3";
            car2.yearofIssue = 2015;
            car2.bodyType = "Sedan";
            car2.color = "white";
            car2.engine = 3;
            car2.power = 431;
            car2.fuelType = "petrol";
            car2.mileage = 70000;
            car2.transmitter = "back";
            car2.price = 35000;

            Car[] cars = new Car[2];

            cars[0] = car1;
            cars[1] = car2;

            foreach (Car car in cars)
            {
                Console.WriteLine(car.GetInfoCar());
                Console.WriteLine("-----------------------");
            }










        }
    }
}
