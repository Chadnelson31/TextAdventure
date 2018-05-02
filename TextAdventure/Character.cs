using System;

namespace TextAdventure
{
    public abstract class Character
    {
        //getter setter
        public string Name { get; set; }
        public string Race { get; set; }
        public string Sex { get; set; }
        public string Class { get; set; }
        public int Health { get; set; }
        public int Melee { get; set;}
        public int Range { get; set; }
        public int Magic { get; set; }
        


        //custom character constructor
        protected Character( string name, string race, 
            string sex, string characterClass, int health, int melee, int range, int magic)
        {
            Name = name;
            Race = race;
            Sex = sex;
            Class = characterClass;
            Health = health;
            Melee = melee;
            Range = range;
            Magic = magic;

        }

        //default character constructor
        protected Character (string name, string race, 
            string sex, string characterClass)
        {
            Name = name;
            Race = race;
            Sex = sex;
            Class = characterClass;
            Health = 0;
            Melee = 0;
            Range = 0;
            Magic = 0;
        }
    }
}