using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
        private string _name = "";
        public bool Fighter { get; set; }
        public bool Hunter = false;
        public bool Priest = false;
        public bool Rogue = false;
        public bool Wizard = false;
        public bool Dwarf = false;
        public bool Elf = false;
        public bool Gnome = false;
        public bool HalfElf = false;
        public bool Human = false;
        public static decimal Strength = 10;
        public static decimal Intelligence = 10;
        public static decimal Agility = 10;
        public static decimal Constitution = 10;
        public static decimal Charisma = 10;
        public static decimal UnusedStats = 50;
    }
}
