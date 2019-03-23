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

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            BindList();
        }

        private void OnHelpAbout_Click( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void OnCharacterNew_Click( object sender, EventArgs e )
        {
            var form = new CreateNewCharacter();
            
            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            _characters.Add(form.Character);

            BindList();
        }

        private void BindList()
        {
            _listCharacters.Items.Clear();
            _listCharacters.DisplayMember = nameof(Character.Name);

            _listCharacters.Items.AddRange(_characters.GetAll());
        }

        private CharacterDatabase _characters = new CharacterDatabase();

        private void OnCharacterEdit_Click( object sender, EventArgs e )
        {
            var form = new CreateNewCharacter();

            var character = GetSelectedCharacter();

            if (character == null)
                return;

            form.Character = character;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    _characters.Update(character.Id, form.Character);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                }
            }

            BindList();

        }

        private Character GetSelectedCharacter()
        {
            var value = _listCharacters.SelectedItem;

            var character = value as Character;

            return _listCharacters.SelectedItem as Character;
        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
