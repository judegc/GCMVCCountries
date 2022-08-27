using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    public class Country
    {
        public Country(string name, string continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }
    }
}
