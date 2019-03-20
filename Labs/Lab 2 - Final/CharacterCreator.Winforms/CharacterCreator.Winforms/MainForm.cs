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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFileExit_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout_Click( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void OnCharacterNew_Click( object sender, EventArgs e )
        {
            var form = new CreateNewCharacter();
            
            while(true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;
                BindList();
            }
        }

        private void BindList()
        {
            _characterRoster.Items.Clear();
            _characterRoster.DisplayMember = nameof(Character.Name);

            _characterRoster.Items.AddRange(_character.GetAll());
        }

        private CharacterDatabase _character = new CharacterDatabase();
    }
}
