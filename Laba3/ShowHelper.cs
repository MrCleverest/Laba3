using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    public class ShowHelper
    {
        public ObservableCollection<PopulationData> PopulationCollection { get; }
        public ShowHelper()
        {
            PopulationCollection = new ObservableCollection<PopulationData>();
        }
        public void AddPopulation(Locality population, double density)
        {
            PopulationData data = new PopulationData
            {
                LocalityType = GetLocalityType(population),
                LocalityName = population.Name,
                PopulationDensity = density
            };

            PopulationCollection.Add(data);
        }
        private string GetLocalityType(Locality locality)
        {
            if (locality is City)
            {
                return "Місто";
            }
            else if (locality is Village)
            {
                return "Село";
            }

            return "Інше";
        }
        public double FindMinimumDensity()
        {
            if (PopulationCollection.Count == 0)
            {
                throw new InvalidOperationException("The population collection is empty.");
            }

            double minDensity = PopulationCollection.Min(item => item.PopulationDensity);
            return minDensity;
        }
    }
}
