using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.BusinessLayer
{
    public class Element
    {
        public Element(string Name, 
            double Normal, double Fire, double Water, double Electric, double Grass, 
            double Ice, double Fight, double Poison, double Ground, double Flying,
            double Psychic, double Bug, double Rock, double Ghost, double Dragon,
            double Dark, double Steel, double Fairy)
        {
            ElementName = Name;

            DamageToNormal = Normal;
            DamageToFire = Fire;
            DamageToWater = Water;
            DamageToElectric = Electric;
            DamageToGrass = Grass;

            DamageToIce = Ice;
            DamageToFight = Fight;
            DamageToPoison = Poison;
            DamageToGround = Ground;
            DamageToFlying = Flying;

            DamageToPsychic = Psychic;
            DamageToBug = Bug;
            DamageToRock = Rock;
            DamageToGhost = Ghost;
            DamageToDragon = Dragon;

            DamageToDark = Dark;
            DamageToSteel = Steel;
            DamageToFairy = Fairy;
        }

        public Element(Element e)
        {
            ElementName = e.ElementName;

            DamageToNormal = e.DamageToNormal;
            DamageToFire = e.DamageToFire;
            DamageToWater = e.DamageToWater;
            DamageToElectric = e.DamageToElectric;
            DamageToGrass = e.DamageToGrass;

            DamageToIce = e.DamageToIce;
            DamageToFight = e.DamageToFight;
            DamageToPoison = e.DamageToPoison;
            DamageToGround = e.DamageToGround;
            DamageToFlying = e.DamageToFlying;

            DamageToPsychic = e.DamageToPsychic;
            DamageToBug = e.DamageToBug;
            DamageToRock = e.DamageToRock;
            DamageToGhost = e.DamageToGhost;
            DamageToDragon = e.DamageToDragon;

            DamageToDark = e.DamageToDark;
            DamageToSteel = e.DamageToSteel;
            DamageToFairy = e.DamageToFairy;
        }

        public double GetDamage(int ElementIndex)
        {
            switch (ElementIndex)
            {
                case 1:
                    return DamageToNormal;
                case 2:
                    return DamageToFire;
                case 3:
                    return DamageToWater;
                case 4:
                    return DamageToElectric;
                case 5:
                    return DamageToGrass;
                case 6:
                    return DamageToIce;
                case 7:
                    return DamageToFight;
                case 8:
                    return DamageToPoison;
                case 9:
                    return DamageToGround;
                case 10:
                    return DamageToFlying;
                case 11:
                    return DamageToPsychic;
                case 12:
                    return DamageToBug;
                case 13:
                    return DamageToRock;
                case 14:
                    return DamageToGhost;
                case 15:
                    return DamageToDragon;
                case 16:
                    return DamageToDark;
                case 17:
                    return DamageToSteel;
                case 18:
                    return DamageToFairy;
                default:
                    return 1;
            }
        }

        public double GetDamage(string ElementName)
        {
            switch (ElementName)
            {
                case "Normal":
                    return DamageToNormal;
                case "Fire":
                    return DamageToFire;
                case "Water":
                    return DamageToWater;
                case "Electric":
                    return DamageToElectric;
                case "Grass":
                    return DamageToGrass;
                case "Ice":
                    return DamageToIce;
                case "Fight":
                    return DamageToFight;
                case "Poison":
                    return DamageToPoison;
                case "Ground":
                    return DamageToGround;
                case "Flying":
                    return DamageToFlying;
                case "Psychic":
                    return DamageToPsychic;
                case "Bug":
                    return DamageToBug;
                case "Rock":
                    return DamageToRock;
                case "Ghost":
                    return DamageToGhost;
                case "Dragon":
                    return DamageToDragon;
                case "Dark":
                    return DamageToDark;
                case "Steel":
                    return DamageToSteel;
                case "Fairy":
                    return DamageToFairy;
                default:
                    return 1;
            }
        }

        public string ElementName { get; set; }

        public double DamageToNormal { get; set; }
        public double DamageToFire { get; set; }
        public double DamageToWater { get; set; }
        public double DamageToElectric { get; set; }
        public double DamageToGrass { get; set; }

        public double DamageToIce { get; set; }
        public double DamageToFight { get; set; }
        public double DamageToPoison { get; set; }
        public double DamageToGround { get; set; }
        public double DamageToFlying { get; set; }

        public double DamageToPsychic { get; set; }
        public double DamageToBug { get; set; }
        public double DamageToRock { get; set; }
        public double DamageToGhost { get; set; }
        public double DamageToDragon { get; set; }

        public double DamageToDark { get; set; }
        public double DamageToSteel { get; set; }
        public double DamageToFairy { get; set; }

    }
}