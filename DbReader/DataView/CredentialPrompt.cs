using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbReader.DataView
{
    public partial class CredentialPrompt : Form
    {
        // Used for clearing textBox
        private bool focus = false;

        // User entered string
        // Public property determined by the get/set methods
        // get/set freely modifiable to change behavior
        public string PassWord
        {
            get
            {
                return validate.Text;
            }
            set
            {
                validate.Text = value;
            }
        }

        public CredentialPrompt()
        {
            InitializeComponent();
        }

        /**
         * Clear hint text from textBox when entering password;
         * Set password char to * for privacy (or use system characters)
         */
        private void validate_Focus(object sender, EventArgs e)
        {
            if (!focus)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                validate.ForeColor = System.Drawing.SystemColors.WindowText;
                //validate.PasswordChar = '*';        // Specify character for password privacy
                validate.UseSystemPasswordChar = true;    // Use system privacy characters
                focus = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /**
         * When pressing confirm (or "ok"), save textBox string into
         * public "PassWord" variable.
         */
        private void confirm_Click(object sender, EventArgs e)
        {
            if (focus)
            {
                PassWord = validate.Text;
                Close();
            }
            else
            {
                MessageBox.Show("No password given, please enter a password or press \"Cancel\".");
            }
        }
    }
}
