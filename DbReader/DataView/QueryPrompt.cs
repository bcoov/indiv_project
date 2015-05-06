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
    public partial class QueryPrompt : Form
    {
        public int choice { get; set; }

        public string fName
        {
            get
            {
                return FName_specify.Text;
            }
            set
            {
                FName_specify.Text = value;
            }
        }

        public string lName
        {
            get
            {
                return LName_specify.Text;
            }
            set
            {
                LName_specify.Text = value;
            }
        }

        public QueryPrompt()
        {
            InitializeComponent();
        }

        private void specifyTrain_Click(object sender, EventArgs e)
        {
            if (FName_specify.Text.Length > 0 && LName_specify.Text.Length > 0)
            {
                fName = FName_specify.Text;
                lName = LName_specify.Text;
                choice = 0;
                Close();
            }
            else
            {
                MessageBox.Show("Please specify a Trainee");
            }
        }

        private void allTrain_Click(object sender, EventArgs e)
        {
            choice = 1;
            Close();
        }

        private void allTables_Click(object sender, EventArgs e)
        {
            choice = 2;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
