using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    internal class SortByName
    {
       public static void SortingByName(List<Category> categories)
        {
            var sortedDestinations = categories
                .SelectMany(c => c.Destinations)
                .OrderBy(d => d.Name)
                .Select(d => d.Name);

            Console.WriteLine("\nSorted destinations by name:");
            foreach (var name in sortedDestinations)
            {
                Console.WriteLine(name);
            }
        }
    }
}
