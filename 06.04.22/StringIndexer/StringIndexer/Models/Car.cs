using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer.Models
{
    class Car
    {
        private string _brand;
        private string _model;
        private string _color;

        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public string Color { get { return _color; } set { _color = value; } }

        public Car(string brand, string model, string color)
        {
            _brand = brand;
            _model = model;
            _color = color;
        }
    }
}
