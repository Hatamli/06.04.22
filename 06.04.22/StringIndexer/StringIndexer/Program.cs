using System;
using StringIndexer.Models;

namespace StringIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car BMW = new Car("BMW", "M", "Black");
            Car Mercedes = new Car("Mercedes", "Mayback", "Black");

            AutoShowroom Hatamli = new AutoShowroom("Hatamli");

            Hatamli.AddCar(BMW);
            Hatamli.AddCar(Mercedes);


        }
    }
}
