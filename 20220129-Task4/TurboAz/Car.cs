using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz
{
    class Car
    {

        //fields
        
        public string brandName;
        public string cityName;
        public string model;
        public int yearofIssue;
        public string bodyType;
        public string color;
        public int engine;
        public int power;
        public string fuelType;
        public double mileage;
        public string transmitter;
        public double price;

        public string GetInfoCar()
        {
            string output = $"{this.brandName}\n" +
                $"{this.cityName}\n" +
                $"{this.model}\n" +
                $"{this.yearofIssue}\n" +
                $"{this.bodyType}\n" +
                $"{this.color}\n" +
                $"{this.engine}\n" +
                $"{this.power}\n" +
                $"{this.fuelType}\n" +
                $"{this.mileage}\n" +
                $"{this.transmitter}\n" +
                $"{this.price}\n";

            return output;
        }



       }
}


