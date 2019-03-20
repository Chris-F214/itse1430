using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        public int Id { get; set; }

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
        private string _name = "";

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description = "";

        public decimal Strength { get; set; }
        
        public static decimal Intelligence  = 10;

        public static decimal Agility  = 10;

        public static decimal Constitution = 10;

        public static  decimal Charisma  = 10;

        public static decimal UnusedStats = 50;

        public override string ToString()
        {
            return Name;
        }

        public bool Validate()
        {
            if (String.IsNullOrEmpty(Name))
                return false;

            return true;
        }
    }
}
