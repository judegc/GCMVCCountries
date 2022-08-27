using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>
        {
            new Country("USA", "North America", new List<string>() {"Red", "White", "Blue"}),
            new Country("Brazil", "South America", new List<string>() {"Green", "Yellow", "Blue"}),
            new Country("France", "Europe", new List<string>() {"Blue", "White", "Red"}),
            new Country("India", "Asia", new List<string>() {"Orange", "White", "Green"}),
            new Country("Egypt", "Africa", new List<string>() {"Red", "White", "Black"}),
            new Country("Australia", "Australia", new List<string>() {"White","Blue","Red"})
        };


        public void CountryAction(Country c)
        {
            var country = new CountryView(c);
            country.Display();
        }

        public void WelcomeAction()
        {
            var countryList = new CountryListView(CountryDb);
            do
            {
                Console.Clear();
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                countryList.Display();
                string userInput = Console.ReadLine();
                int selection = 0;
                if (int.TryParse(userInput, out selection) && selection > 0 && selection <= CountryDb.Count)
                {
                    CountryAction(CountryDb[selection - 1]);
                    Console.WriteLine("Press the <Enter> key to continue: ");
                }
                else Console.WriteLine("I'm sorry, that is not a valid selection. Please press the <Enter> key to continue");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.WriteLine("Would you like to run another search for a country? (y/n)");                
            } while (Console.ReadKey().Key == ConsoleKey.Y);
            Console.WriteLine("");
            Console.WriteLine("Goodbye! Press the <Enter> key to close the program");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
