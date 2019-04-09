using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
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

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            BindList();
        }

        private void BindList()
        {
            _listContacts.Items.Clear();
            _listContacts.DisplayMember = nameof(Business_Layer.Contact.Name);

            _listContacts.Items.AddRange(_contact.GetAll().ToArray());
        }

        private Business_Layer.IContactDatabase _contact = new Business_Layer.ContactDatabase();

        private void OnContactsAdd_Click( object sender, EventArgs e )
        {
            var form = new ContactForm();
            form.ShowDialog();

            BindList();
        }
    }
}
