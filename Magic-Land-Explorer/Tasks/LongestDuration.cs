using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class LongestDuration
    {
        public static void ShowLongestDuration(List<Category> categories)
        {
            string? LongestDuration = categories.SelectMany(e => e.Destinations).OrderByDescending(e => { 

                var Duration = 0;
                var FromSmallestToBiggest = int.TryParse(e.Duration?.Split(" ")[0], out Duration);
                return Duration;

            }).FirstOrDefault()?.Name;


            Console.WriteLine(LongestDuration);
        }
    }
}
