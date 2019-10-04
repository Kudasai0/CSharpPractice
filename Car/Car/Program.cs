using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car sedan = new Car();
            sedan.Weight = 2000;
            sedan.Color = "Black";
            sedan.MaxSpeed = 180;
            sedan.FuelConsumprion = 12;
            Console.WriteLine("Машина Sedan. \nВес: {0}. \nЦвет: {1}. \nМаксимальная скорость: {2}. \nРасход топлива: {3}.", sedan.Weight, sedan.Color, sedan.MaxSpeed, sedan.FuelConsumprion);

            Console.WriteLine();

            Car coupe = new Car();
            coupe.Weight = 1500;
            coupe.Color = "Red";
            coupe.MaxSpeed = 240;
            coupe.FuelConsumprion = 15;
            Console.WriteLine("Машина Coupe \nВес: {0}. \nЦвет: {1}. \nМаксимальная скорость: {2}. \nРасход топлива: {3}", coupe.Weight, coupe.Color, coupe.MaxSpeed, coupe.FuelConsumprion);

            Console.ReadKey();
        }
    }
}
