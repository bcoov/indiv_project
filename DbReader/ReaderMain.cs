﻿using System;
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

namespace DbReader
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
         * Method to connect to the given Database
         */
        private void connectDB(string DataBase, string PassWord)
        {
            Data someData = new Data(DataBase, PassWord);
            Employee thisGuy = someData.find_employees("Diehl", "Todd");
            if (!thisGuy.lastName.Equals(null))
            {
                resultList.Text += (thisGuy.firstName + thisGuy.lastName + System.Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Error: Null reference");
            }
            // "Database" and "Password" obtained from Forms (i.e. User input)
            //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + DataBase + "; Jet OLEDB:Database Password=" + PassWord;
            //string query = "Select * from [TRAINEES]";
            //OleDbConnection conn = new OleDbConnection(connectionString);
            //ConnectionFactory connecter = ConnectionFactory.new_instance(DataBase, PassWord);
            /*using (OleDbConnection conn = connecter.create_connection())
            {
                try
                {
                    conn.Open();

                    using (OleDbCommand command = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resultList.Text += (reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + System.Environment.NewLine);
                            }
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
            }*/
            //try
            //{
                // Following based from http://my.execpc.com/~gopalan/dotnet/ado_net/ado.net_retrieving_database_metadata.html
                //DataTable tables = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //DataTable columns = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, null);

                /*conn.Open();
                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultList.Text += (reader[1].ToString() + ", " + reader[2].ToString() + System.Environment.NewLine);
                        }
                    }
                }*/

                /*foreach (DataColumn col in tables.Columns)
                {
                    resultList.Text += (col + System.Environment.NewLine);      // Table MetaData
                }

                resultList.Text += ("-----" + System.Environment.NewLine);      // Visual divider
                
                foreach (DataRow row in tables.Rows)
                {
                   resultList.Text += (row["TABLE_NAME"] + System.Environment.NewLine); // Tables
                }

                resultList.Text += ("-----" + System.Environment.NewLine);

                foreach (DataColumn col in columns.Columns)
                {
                    resultList.Text += (col.ColumnName + System.Environment.NewLine);      // Columns MetaData
                }

                resultList.Text += ("-----" + System.Environment.NewLine);

                foreach (DataRow row in columns.Rows)
                {
                    resultList.Text += (row["TABLE_NAME"] + ":" + row["COLUMN_NAME"] + System.Environment.NewLine);    // Columns
                }*/

                /*MessageBox.Show("Connection Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect: " + ex.Message);
            }
            finally     // Ensure connection is fully closed
            {
                conn.Close();
            }*/
        }

        private void formQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tester_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a testing button");
        }

        // Obsolete with dbName disabled (non-interactive)
        /*private void dbName_Focus(object sender, EventArgs e)           // Clear text within TextBox when activating box (i.e., entering text)
        {
            if (!hasBeenClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                dbName.ForeColor = System.Drawing.SystemColors.WindowText;
                hasBeenClicked = true;
            }
        }*/
    }
}
