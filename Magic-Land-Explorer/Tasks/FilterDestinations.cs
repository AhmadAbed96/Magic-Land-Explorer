using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class FilterDestinations
    {
        public static void printLessthan100(List<Category> categories, Predicate<int> IsLessThan100)
        {
            Action<string> printnamedelegate = printname;
            var destinations = categories.SelectMany(e => e.Destinations).ToList();  

            Console.WriteLine();
            foreach (var category in destinations)
            {
                if ((int.TryParse(category.Duration?.Split(" ")[0],
                        out int Duration)
                        && IsLessThan100(Duration))
                        || category.Duration == null)   
                {
                    printnamedelegate(category.Name);
                }
            }
        }



        private static void printname(string name)
        {
            Console.WriteLine(name);
        }
    }
}
