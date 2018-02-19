using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    class BandLid
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Geslacht { get; set; }

        public BandLid(string naam, int leeftijd, string geslacht)
        {
            naam = Naam;
            leeftijd = Leeftijd;
            geslacht = Geslacht;
        }
    }
}
