using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    public class CountryView
    {

        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }
        public Country DisplayCountry { get; set; }

        public void SetColor(int i)
        {
            try 
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[i]);
            }
            catch (Exception)
            {
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.ForegroundColor = ConsoleColor.Black;
        }

        public void Display()
        {
            string[] colors = new string[DisplayCountry.Colors.Count];
            for (int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                colors[i] = DisplayCountry.Colors[i];
            }
            if (DisplayCountry.Colors.Count == 2)
            {
                SetColor(0);
                Console.WriteLine($"Country: {DisplayCountry.Name}");
                SetColor(1);
                Console.WriteLine($"Continent: {DisplayCountry.Continent}");
                Console.ResetColor();
            }
            else if (DisplayCountry.Colors.Count == 3)
            {
                SetColor(0);
                Console.WriteLine($"Country: {DisplayCountry.Name}");
                SetColor(1);
                Console.WriteLine($"Continent: {DisplayCountry.Continent}");
                SetColor(2);
                Console.WriteLine($"Colors: {colors[0]}, {colors[1]}, {colors[2]}");
                Console.ResetColor(); 
            }
        }
    }
}
