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
        public decimal Intelligence { get; set; }
        public decimal Agility { get; set; }
        public decimal Constitution { get; set; }
        public decimal Charisma { get; set; }

        public bool Validate ()
        {
            //Name
            if (String.IsNullOrEmpty(Name))
                return false;

            //Attributes
            if (Strength < 1)
                return false;

            if (Strength > 100)
                return false;

            if (Intelligence < 1)
                return false;

            if (Intelligence > 100)
                return false;

            if (Agility < 1)
                return false;

            if (Agility > 100)
                return false;

            if (Constitution < 1)
                return false;

            if (Constitution > 100)
                return false;

            if (Charisma < 1)
                return false;

            if (Charisma > 100)
                return false;

            return true;
        }
    }
}
