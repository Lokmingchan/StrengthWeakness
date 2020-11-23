using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.BusinessLayer
{
    public class Elements
    {
        public Elements()
        {
            PokemonElements = new Element[19];

            PokemonElements[0] = MissingNo;

            PokemonElements[1] = Normal;
            PokemonElements[2] = Fire;
            PokemonElements[3] = Water;
            PokemonElements[4] = Electric;
            PokemonElements[5] = Grass;

            PokemonElements[6] = Ice;
            PokemonElements[7] = Fight;
            PokemonElements[8] = Poison;
            PokemonElements[9] = Ground;
            PokemonElements[10] = Flying;

            PokemonElements[11] = Psychic;
            PokemonElements[12] = Bug;
            PokemonElements[13] = Rock;
            PokemonElements[14] = Ghost;
            PokemonElements[15] = Dragon;

            PokemonElements[16] = Dark;
            PokemonElements[17] = Steel;
            PokemonElements[18] = Fairy;
            
        }

        //public enum ElementNames
        //{
        //    Normal = 1, Fire = 2, Water = 3, Electric = 4, Grass = 5,
        //    Ice = 6, Fight = 7, Poison = 8, Ground = 9, Flying = 10,
        //    Psychic = 11, Bug = 12, Rock = 13, Ghost = 14, Dragon = 15,
        //    Dark = 16, Steel = 17, Fairy = 18
        //};

        public Element[] PokemonElements
        {
            get;
            set;
        }

        public Element GetElement(string ElementName)
        {
            foreach (Element e in PokemonElements)
            {
                if (e.ElementName == ElementName)
                {
                    return e;
                }
            }

            return MissingNo;
        }

        private Element Normal = new Element("Normal",
            1, 1, 1, 1, 1,
            1, 1, 1, 1, 1,
            1, 1, .5, 0, 1,
            1, .5, 1);

        private Element Fire = new Element("Fire",
            1, .5, .5, 1, 2,
            2, 1, 1, 1, 1,
            1, 2, .5, 1, .5,
            1, 2, 1);

        private Element Water = new Element("Water",
            1, 2, .5, 1, .5,
            1, 1, 1, 2, 1,
            1, 1, 2, 1, .5,
            1, 1, 1);

        private Element Electric = new Element("Electric",
            1, 1, 2, .5, .5,
            1, 1, 1, 0, 2,
            1, 1, 1, 1, .5,
            1, 1, 1);

        private Element Grass = new Element("Grass",
            1, .5, 2, 1, .5,
            1, 1, .5, 2, .5,
            1, .5, 2, 1, .5,
            1, .5, 1);

        private Element Ice = new Element("Ice",
            1, .5, .5, 1, 2,
            .5, 1, 1, 2, 2,
            1, 1, 1, 1, 2,
            1, .5, 1);

        private Element Fight = new Element("Fight",
            2, 1, 1, 1, 1,
            2, 1, .5, 1, .5,
            .5, .5, 2, 0, 1,
            2, 2, .5);

        private Element Poison = new Element("Poison",
            1, 1, 1, 1, 2,
            1, 1, .5, .5, 1,
            1, 1, .5, .5, 1,
            1, 0, 2);

        private Element Ground = new Element("Ground",
            1, 2, 1, 2, .5,
            1, 1, 2, 1, 0,
            1, .5, 2, 1, 1,
            1, 2, 1);

        private Element Flying = new Element("Flying",
            1, 1, 1, .5, 2,
            1, 2, 1, 1, 1,
            1, 2, .5, 1, 1,
            1, .5, 1);

        private Element Psychic = new Element("Psychic",
            1, 1, 1, 1, 1,
            1, 2, 2, 1, 1,
            .5, 1, 1, 1, 1,
            0, .5, 1);

        private Element Bug = new Element("Bug",
            1, .5, 1, 1, 2,
            1, .5, .5, 1, .5,
            2, 1, 1, .5, 1,
            2, .5, .5);

        private Element Rock = new Element("Rock",
            1, 2, 1, 1, 1,
            2, .5, 1, .5, 2,
            1, 2, 1, 1, 1,
            1, .5, 1);

        private Element Ghost = new Element("Ghost",
            0, 1, 1, 1, 1,
            1, 1, 1, 1, 1,
            2, 1, 1, 2, 1,
            .5, 1, 1);

        private Element Dragon = new Element("Dragon",
            1, 1, 1, 1, 1,
            1, 1, 1, 1, 1,
            1, 1, 1, 1, 2,
            1, .5, 0);

        private Element Dark = new Element("Dark",
            1, 1, 1, 1, 1,
            1, .5, 1, 1, 1,
            2, 1, 1, 2, 1,
            .5, 1, .5);

        private Element Steel = new Element("Steel",
            1, .5, .5, .5, 1,
            2, 1, 1, 1, 1,
            1, 1, 2, 1, 1,
            1, .5, 2);

        private Element Fairy = new Element("Fairy",
            1, .5, 1, 1, 1,
            1, 2, .5, 1, 1,
            1, 1, 1, 1, 2,
            2, .5, 1);

        private Element MissingNo = new Element("MissingNo",
            1, 1, 1, 1, 1,
            1, 1, 1, 1, 1,
            1, 1, 1, 1, 1,
            1, 1, 1);
    }
}