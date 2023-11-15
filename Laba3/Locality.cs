using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    // Батьківський клас
    public abstract class Locality
    {
        string name;
        public string Name { get { return name; } set { name = value; } }

        public Locality(string name)
        {
            this.name = name;
        }

        // Віртуальний метод для обчислення щільності населення
        public abstract double PopulationDensity();
    }
}

