using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructsFinalEddie
{
    class Plant
    {
        public string Name { get; set; }
        public int TrayNum { get; set; }

        public Plant(string name, int trayNum)
        {
            Name = name;
            TrayNum = trayNum;
        }

        // Insertion sorting for a list of plants in alphabetical order
        public static List<Plant> InsertionSort(List<Plant> plants)
        {
            for (int i = 0; i < plants.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (plants[j - 1].Name.CompareTo(plants[j].Name) == 1)
                    {
                        Plant temp = plants[j - 1];
                        plants[j - 1] = plants[j];
                        plants[j] = temp;
                    }
                }
            }
            return plants;
        }
    }
}
