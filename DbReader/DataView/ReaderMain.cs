using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbReader.DataLogic;

namespace DbReader.DataView
{
    public partial class ReaderMain : Form
    {
        // String for database file path
        // See CredentialPrompt.PassWord for info
        // Possible to change this to regular property?
        // (Does anything else need to use this?)
        public string selectedFilePath
        {
            get
            {
                return dbName.Text;
            }
            set
            {
                dbName.Text = value;
            }
        }

        public ReaderMain()
        {
            InitializeComponent();
        }
                
        private void dbSelect_Click(object sender, EventArgs e)
        {
            loadDB();
        }

        /**
         * On click ("Connect"), will attempt to connect to the given
         * database file. If no file given (i.e., textBox is null or empty string),
         * "No file given" MessageBox is displayed.
         */
        private void connectTo_Click(object sender, EventArgs e)
        {
            if (selectedFilePath != null && selectedFilePath != "")
            {
                string pw = validateDB();
                if (pw != null)         // Check for Cancel button from password prompt
                {
                    connectDB(selectedFilePath, pw);
                }
            }
            else
            {
                MessageBox.Show("No file given");
            }
        }

        /**
         * Dialog box to browse for file
         * Credit to: http://www.dreamincode.net/forums/topic/241079-browsing-for-a-file-using-openfiledialog/
         * for the OpenFileDialog tutorial.
         */
        private void loadDB()
        {
            OpenFileDialog sel = new OpenFileDialog();
            string startFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sel.InitialDirectory = startFolder;         // Set initial folder to MyDocuments

            System.Windows.Forms.DialogResult res = sel.ShowDialog();
            if (res == DialogResult.OK)
            {
                selectedFilePath = sel.FileName;
            }
        }

        /**
         * Prompts user for password to the database
         */
        private string validateDB()
        {
            string pw;
            CredentialPrompt passWord = new CredentialPrompt();

            System.Windows.Forms.DialogResult res = passWord.ShowDialog();  // Displays the prompt
            pw = passWord.PassWord;

            if (passWord.DialogResult.Equals(DialogResult.Cancel))   // If Cancel button on prompt form, return null
            {
                return null;
            }
            else
            {
                return pw;
            }
        }

        private int getChoice(QueryPrompt prompt)
        {
            int choose;

            System.Windows.Forms.DialogResult res = prompt.ShowDialog();
            choose = prompt.choice;

            if (prompt.DialogResult.Equals(DialogResult.Cancel))
            {
                return -1;
            }
            else
            {
                return choose;
            }
        }

        /**
         * Method to connect to the given Database
         */
        private void connectDB(string DataBase, string PassWord)
        {
            ConnectionFactory connecter = ConnectionFactory.new_instance(DataBase, PassWord);
            Data myData = new Data(DataBase, PassWord);
            using (OleDbConnection conn = myData.connect_data())
            {
                try
                {
                    conn.Open();
                    QueryPrompt selectQuery = new QueryPrompt();
                    int choice = getChoice(selectQuery);
                    switch (choice)
                    {
                        case 0:
                            {
                                Employee specific = myData.find_an_employee(conn, selectQuery.fName, selectQuery.lName);
                                resultList.Text += (specific.firstName + " " + specific.midInit + ". " + specific.lastName);
                                break;
                            }
                        case 1:
                            {
                                List<Employee> trainees = myData.find_employees(conn);
                                foreach (Employee e in trainees)
                                {
                                    resultList.Text += (e.firstName + " " + e.midInit + ". " + e.lastName + System.Environment.NewLine);
                                }
                                break;
                            }
                        case 2:
                            {
                                List<String> tableNames = myData.get_tables(conn);
                                foreach (String s in tableNames)
                                {
                                    resultList.Text += (s + System.Environment.NewLine);
                                }
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void formQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tester_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a testing button");
        }
    }
}
