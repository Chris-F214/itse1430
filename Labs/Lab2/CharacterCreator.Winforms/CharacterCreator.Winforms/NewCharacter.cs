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

        private void _addStrength_Click( object sender, EventArgs e )
        {
            if (Character.Strength<100 & Character.UnusedStats>0)
            {
                Character.Strength++;
                Character.UnusedStats--;
                _displayStrength.Text = Character.Strength.ToString();
                DisplayUnusedStats();
            }
        }

        private void _removeStrength_Click( object sender, EventArgs e )
        {
            if (Character.Strength > 1 & Character.UnusedStats < 100)
            {
                Character.Strength--;
                Character.UnusedStats++;
                _displayStrength.Text = Character.Strength.ToString();
                DisplayUnusedStats();
            }
        }

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
    }
}
