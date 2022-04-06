using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer.Models
{
    class AutoShowroom
    {
        private static int _idCounter;
        private static Car[] _cars;
        public Car this[int index]
        {
            get
            {
                if (index < _cars.Length && index >= 0)
                {
                    return _cars[index];
                }

                throw new Exception("Test Exception");

            }
            set
            {
                _cars[index] = value;
            }
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Length { get => _cars.Length; }

        static AutoShowroom()
        {
            _idCounter = 0;

        }

        private AutoShowroom(string v)
        {
            Id = ++_idCounter;
            CreatedDate = DateTime.Now;
            _cars = new Car[0];
        }
        public void AddCar(Car car)
        {
            Car[] newArray = CarArrayResize(_cars, _cars.Length - 1);
            newArray[^1] = car;
            _cars = newArray;
        }

        private static Car[] CarArrayResize(Car[] array, int newLength)
        {
            int loopCount = 0;
            loopCount = newLength > _cars.Length ? array.Length : newLength;
            Car[] cars = new Car[newLength];

            for (int i = 0; i < loopCount; i++)
            {
                cars[i] = array[i]; 
            }

            return cars;
        }
    }
}
