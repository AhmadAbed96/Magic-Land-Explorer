using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class Top3Duration
    {
        public static void TopThreeDuration(List<Category> categories)
        {
            var LongestDuration = categories.SelectMany(e => e.Destinations).OrderByDescending(e => {

                var Duration = 0;
                var ConvertToInt = int.TryParse(e.Duration?.Split(" ")[0], out Duration);
                return Duration;

            }).Take(3);

            foreach (var category in LongestDuration)
            {
                Console.WriteLine($"{category.Name} : {category.Duration} ");
                Console.WriteLine();
            }
        }
    }
}
