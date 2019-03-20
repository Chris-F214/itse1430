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
    public partial class NewCharacter : Form
    {
        public NewCharacter()
        {
            InitializeComponent();
        }
        public Character Character { get; set; }

        //private void _addStrength_Click( object sender, EventArgs e )
        //{
        //    if (Character.Strength < 100 & Character.UnusedStats > 0)
        //    {
        //         Character.Strength++;
        //         Character.UnusedStats--;
        //         _displayStrength.Text = Character.Strength.ToString();
        //         DisplayUnusedStats();
        //    }
        //}

        //private void _removeStrength_Click( object sender, EventArgs e )
        //{
        //    if (Character.Strength > 1 & Character.UnusedStats < 100)
        //    {
        //        Character.Strength--;
        //        Character.UnusedStats++;
        //        _displayStrength.Text = Character.Strength.ToString();
        //        DisplayUnusedStats();
        //    }
        //}

        private void _addIntelligence_Click( object sender, EventArgs e )
        {
            if (Character.Intelligence < 100 & Character.UnusedStats>0)
            {
                Character.Intelligence++;
                Character.UnusedStats--;
                _displayIntelligence.Text = Character.Intelligence.ToString();
                DisplayUnusedStats();
            }
        }

        public void DisplayUnusedStats()
        {
            _displayUnusedStatPoints.Text = Character.UnusedStats.ToString();
        }

        private void _removeIntelligence_Click( object sender, EventArgs e )
        {
            if (Character.Intelligence > 1 & Character.UnusedStats < 100)
            {
                Character.Intelligence--;
                Character.UnusedStats++;
                _displayIntelligence.Text = Character.Intelligence.ToString();
                DisplayUnusedStats();
            }
        }

        private void _addAgility_Click( object sender, EventArgs e )
        {
            if (Character.Agility < 100 & Character.UnusedStats > 0)
            {
                Character.Agility++;
                Character.UnusedStats--;
                _displayAgility.Text = Character.Agility.ToString();
                DisplayUnusedStats();
            }
        }

        private void _removeAgility_Click( object sender, EventArgs e )
        {
            if (Character.Agility > 1 & Character.UnusedStats < 100)
            {
                Character.Agility--;
                Character.UnusedStats++;
                _displayAgility.Text = Character.Agility.ToString();
                DisplayUnusedStats();
            }
        }

        private void _addConstitution_Click( object sender, EventArgs e )
        {
            if (Character.Constitution < 100 & Character.UnusedStats > 0)
            {
                Character.Constitution++;
                Character.UnusedStats--;
                _displayConstitution.Text = Character.Constitution.ToString();
                DisplayUnusedStats();
            }
        }

        private void _removeConstitution_Click( object sender, EventArgs e )
        {
            if (Character.Constitution > 1 & Character.UnusedStats < 100)
            {
                Character.Constitution--;
                Character.UnusedStats++;
                _displayConstitution.Text = Character.Constitution.ToString();
                DisplayUnusedStats();
            }
        }

        private void _addCharisma_Click( object sender, EventArgs e )
        {
            if (Character.Charisma < 100 & Character.UnusedStats > 0)
            {
                Character.Charisma++;
                Character.UnusedStats--;
                _displayCharisma.Text = Character.Charisma.ToString();
                DisplayUnusedStats();
            }
        }

        private void _removeCharisma_Click( object sender, EventArgs e )
        {
            if (Character.Charisma > 1 & Character.UnusedStats < 100)
            {
                Character.Charisma--;
                Character.UnusedStats++;
                _displayCharisma.Text = Character.Charisma.ToString();
                DisplayUnusedStats();
            }
        }

        private void _onCancel_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
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
                MessageBox.Show("Character not valid.", "Error", MessageBoxButtons.OK);
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
            character.Strength = ReadDecimal(_textBoxStrength);
            //_strength = ReadDecimal(_displayStrength);

            return character;
        }

        private decimal ReadDecimal ( TextBox control )
        {
            if (control.Text.Length == 0)
                return 0;
            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }
        //private decimal _strength = Character.Strength;
        //private decimal ReadDecimal ( Label control)
        //{
        //    if (control.Text.Length == 0)
        //        return 0;
        //    if (Decimal.TryParse(control.Text, out var value))
        //        return value;
        //    return -1;
        //}

        private void OnValidateName( object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Please input a name.");
                e.Cancel = true;
            }else
            {
                _errors.SetError(tb, "");
            }
        }

        private void OnValidateStats( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            //var unusedstats = ReadDecimal(_displayUnusedStatPoints);
            //if (unusedstats > 0)
            //{
            //    _errors.SetError(tb, "You have unused stat points.");
            //    e.Cancel = true;
            //} else
            //{
            //    _errors.SetError(tb, "");
            //}
        }
    }
}
