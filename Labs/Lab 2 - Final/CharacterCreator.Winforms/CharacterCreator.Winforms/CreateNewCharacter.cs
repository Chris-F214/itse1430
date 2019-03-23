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

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _comboBoxRace.SelectedIndex = 0;
            _comboBoxProfession.SelectedIndex = 0;

            if (Character != null)
                LoadData(Character);
            ValidateChildren();
        }

        private void LoadData( Character character)
        {
            _textName.Text = character.Name;
            _textDescription.Text = character.Description;
            _comboBoxProfession.SelectedItem = character.Profession;
            _comboBoxRace.SelectedItem = character.Race;
            _textStrength.Text = character.Strength.ToString();
            _textIntelligence.Text = character.Intelligence.ToString();
            _textAgility.Text = character.Agility.ToString();
            _textConstitution.Text = character.Constitution.ToString();
            _textCharisma.Text = character.Charisma.ToString();

        }

        private Character SaveData ()
        {
            var character = new Character();
            {
                character.Name = _textName.Text;
                character.Profession = _comboBoxProfession.SelectedItem.ToString();
                character.Race = _comboBoxRace.SelectedItem.ToString();
                character.Description = _textDescription.Text;
                character.Strength = ReadDecimal(_textStrength);
                character.Intelligence = ReadDecimal(_textIntelligence);
                character.Agility = ReadDecimal(_textAgility);
                character.Constitution = ReadDecimal(_textConstitution);
                character.Charisma = ReadDecimal(_textCharisma);
            }

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

        //private void OnValidateName( object sender, CancelEventArgs e )
        //{
        //    var tb = sender as TextBox;

        //    if (tb.Text.Length == 0)
        //    {
        //        _errors.SetError(tb, "Please name your character.");
        //        e.Cancel = true;
        //    } else
        //    {
        //        _errors.SetError(tb, "");
        //    }
        //}

        //private void OnValidateStrength( object sender, CancelEventArgs e )
        //{
        //    var tb = sender as TextBox;

        //    var strength = ReadDecimal(tb);
        //    if (strength < 1)
        //    {
        //        _errors.SetError(tb, "price must be ")
        //    }
        //}

        //private void OnValidateIntelligence( object sender, CancelEventArgs e )

        //private void OnValidateAgility( object sender, CancelEventArgs e )

        //private void OnValidateConstitution( object sender, CancelEventArgs e )

        //private void OnValidateCharisma( object sender, CancelEventArgs e )

    }
}
