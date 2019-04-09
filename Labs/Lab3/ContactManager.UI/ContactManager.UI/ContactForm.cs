using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        public Business_Layer.Contact Contact { get; set; }

        private void OnCancel_Click( object sender, EventArgs e )
        {
            Close();
        }

        private void OnSave_Click( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var contact = SaveData();

            try
            {
                new Business_Layer.ValidateEntry().Validate(contact);
            }catch (ValidationException)
            {
                MessageBox.Show(this, "Contact not valid.", "Error", MessageBoxButtons.OK);
                return;
            }

            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();
        }

        private Business_Layer.Contact SaveData()
        {
            var contact = new Business_Layer.Contact();
            contact.Name = _textName.Text;
            contact.Email = _textEmail.Text;

            return contact;
        }

        private void OnValidateName(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Name required.");
                e.Cancel = true;
            }else
            {
                _errors.SetError(tb, "");
            }
        }

        private void OnValidateEmail(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            if(tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Email is required.");
                e.Cancel = true;
            }else
            {
                _errors.SetError(tb, "");
            }
        }

    }
}
