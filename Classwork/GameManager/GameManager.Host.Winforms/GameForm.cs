using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Host.Winforms
{
    public partial class GameForm : Form
    {
        public GameForm() //: base()
        {
            InitializeComponent();
        }

        public Game Game { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            Game = SaveData();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private decimal ReadDecimal ( TextBox control)
        {
            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }

        private void LoadData ( Game game)
        {
            _txtName.Text = game.Name;
            _txtPublisher.Text = game.Publisher;
            _txtPrice.Text = game.Price.ToString();
            _CBOwned.Checked = game.Owned;
            _CBCompleted.Checked = game.Completed;
        }

        //saves UI into new game
        private Game SaveData ()
        {
            var game = new Game();
            game.Name = _txtName.Text;
            game.Publisher = _txtPublisher.Text;
            game.Price = ReadDecimal(_txtPrice);
            game.Owned = _CBOwned.Checked;
            game.Completed = _CBCompleted.Checked;

            //Demoing ctor
            var game2 = new Game(_txtName.Text, ReadDecimal(_txtPrice));

            return game;
        }

        //defined in type
        //Derived types may override and change it
        protected virtual void CanBeChanged() { }

        protected override void OnLoad( EventArgs e )
        {
            //this.OnLoad(e);
            base.OnLoad(e);

            //Init UI if editing  a game
            if (Game != null)
                LoadData(Game);
        }
    }
}
