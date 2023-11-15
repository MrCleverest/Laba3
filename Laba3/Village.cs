using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    // Похідний клас для села
    public class Village : Locality
    {
        // Кількість будинків
        int houses = 1;
        // Кількість мешканців в будинках
        int residents = 2;
        // Площа села
        double area = 20;
        public int Houses { get { return houses; } set { houses = value; } }
        public int Residents { get { return residents; } set { residents = value; } }
        public double Area { get { return area; } set { area = value; } }

        public Village(string name, int houses, int residents, double area)
            : base(name)
        {
            this.houses = houses;
            this.residents = residents;
            this.area = area;
        }
        // Перевизначений метод
        public override double PopulationDensity()
        {
            return houses * residents / area;
        }
    }
}
