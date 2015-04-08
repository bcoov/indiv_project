namespace DbReader
{
    partial class ReaderMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectTo = new System.Windows.Forms.Button();
            this.formQuit = new System.Windows.Forms.Button();
            this.dbName = new System.Windows.Forms.TextBox();
            this.dbSelect = new System.Windows.Forms.Button();
            this.resultList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // connectTo
            // 
            this.connectTo.Location = new System.Drawing.Point(162, 138);
            this.connectTo.Name = "connectTo";
            this.connectTo.Size = new System.Drawing.Size(75, 23);
            this.connectTo.TabIndex = 0;
            this.connectTo.Text = "Connect";
            this.connectTo.UseVisualStyleBackColor = true;
            this.connectTo.Click += new System.EventHandler(this.connectTo_Click);
            // 
            // formQuit
            // 
            this.formQuit.Location = new System.Drawing.Point(289, 138);
            this.formQuit.Name = "formQuit";
            this.formQuit.Size = new System.Drawing.Size(75, 23);
            this.formQuit.TabIndex = 1;
            this.formQuit.Text = "Quit";
            this.formQuit.UseVisualStyleBackColor = true;
            this.formQuit.Click += new System.EventHandler(this.formQuit_Click);
            // 
            // dbName
            // 
            this.dbName.Enabled = false;
            this.dbName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dbName.Location = new System.Drawing.Point(162, 91);
            this.dbName.Name = "dbName";
            this.dbName.ReadOnly = true;
            this.dbName.Size = new System.Drawing.Size(202, 20);
            this.dbName.TabIndex = 2;
            // 
            // dbSelect
            // 
            this.dbSelect.Location = new System.Drawing.Point(162, 48);
            this.dbSelect.Name = "dbSelect";
            this.dbSelect.Size = new System.Drawing.Size(75, 23);
            this.dbSelect.TabIndex = 3;
            this.dbSelect.Text = "Browse...";
            this.dbSelect.UseVisualStyleBackColor = true;
            this.dbSelect.Click += new System.EventHandler(this.dbSelect_Click);
            // 
            // resultList
            // 
            this.resultList.Location = new System.Drawing.Point(12, 167);
            this.resultList.Name = "resultList";
            this.resultList.ReadOnly = true;
            this.resultList.Size = new System.Drawing.Size(512, 254);
            this.resultList.TabIndex = 5;
            this.resultList.Text = "";
            // 
            // ReaderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 433);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.dbSelect);
            this.Controls.Add(this.dbName);
            this.Controls.Add(this.formQuit);
            this.Controls.Add(this.connectTo);
            this.Name = "ReaderMain";
            this.Text = "Database Reader v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectTo;
        private System.Windows.Forms.Button formQuit;
        private System.Windows.Forms.TextBox dbName;
        private System.Windows.Forms.Button dbSelect;
        private System.Windows.Forms.RichTextBox resultList;
    }
}

