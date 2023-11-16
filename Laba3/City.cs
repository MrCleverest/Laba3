using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    // Похідний клас для міста
    public class City : Locality
    {
        // Кількість населення
        int population = 10000;
        // Площа міста
        double area = 100;
        public int Population { get { return population; } set { population = value; } }
        public double Area { get { return area; } set { area = value; } }

        public City(string name, int houses, int residents, double area)
            : base(name)
        {
            population = houses * residents;
            this.area = area;
        }
        // Перевизначений метод
        public override double PopulationDensity()
        {
            return population / area;
        }
    }
}
