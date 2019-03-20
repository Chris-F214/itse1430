using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CreateNewCharacter : Form
    {
        public CreateNewCharacter()
        {
            InitializeComponent();
        }

        public Character Character { get; set; }

        private void _onCancel_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void _onSave_Click( object sender, EventArgs e )
        {
            if (!ValidateChildren())
            {
                return;
            }
            var character = SaveData();

            if (!character.Validate())
            {
                MessageBox.Show("Character is not valid.", "Error", MessageBoxButtons.OK);
                return;
            }

            Character = character;
            DialogResult = DialogResult.OK;
            Close();

        }

        private Character SaveData ()
        {
            var character = new Character();
            character.Name = _textName.Text;
            character.Description = _textDescription.Text;
            character.Strength = ReadDecimal(_textStrength);
            character.Intelligence = ReadDecimal(_textIntelligence);
            character.Agility = ReadDecimal(_textAgility);
            character.Constitution = ReadDecimal(_textConstitution);
            character.Charisma = ReadDecimal(_textCharisma);

            return character;
        }

        private decimal ReadDecimal (TextBox control)
        {
            if (control.Text.Length == 0)
                return 0;
            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }
    }
}
