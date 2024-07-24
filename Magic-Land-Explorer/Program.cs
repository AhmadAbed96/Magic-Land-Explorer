using Magic_Land_Explorer.Tasks;
using Newtonsoft.Json;

namespace Magic_Land_Explorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "data/MagicLandData.json");
            string json = File.ReadAllText(filePath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json)!;
            while (true)
            {
                Console.WriteLine("\nMagic Land Explorer:");
                Console.WriteLine("1- Show filtered destinations (duration < 100 minutes)");
                Console.WriteLine("2- Show destination with the longest duration");
                Console.WriteLine("3- Sort destinations by name");
                Console.WriteLine("4- Show top 3 longest-duration destinations");
                Console.WriteLine("5- Exit");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Destinations with duration less than 100 minutes:");
                        FilterDestinations.printLessthan100(categories, duration => duration < 100);
                        break;
                    case "2":
                        LongestDuration.ShowLongestDuration(categories);
                        break;
                    case "3":
                        SortByName.SortingByName(categories);
                        break;
                    case "4":
                        Top3Duration.TopThreeDuration(categories);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

    }
}

