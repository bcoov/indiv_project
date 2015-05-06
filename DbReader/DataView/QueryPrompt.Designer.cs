namespace DbReader.DataView
{
    partial class QueryPrompt
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
            this.allTables = new System.Windows.Forms.Button();
            this.allTrain = new System.Windows.Forms.Button();
            this.specifyTrain = new System.Windows.Forms.Button();
            this.FName_specify = new System.Windows.Forms.TextBox();
            this.LName_specify = new System.Windows.Forms.TextBox();
            this.LName_label = new System.Windows.Forms.Label();
            this.FName_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allTables
            // 
            this.allTables.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.allTables.Location = new System.Drawing.Point(29, 195);
            this.allTables.Name = "allTables";
            this.allTables.Size = new System.Drawing.Size(139, 23);
            this.allTables.TabIndex = 0;
            this.allTables.Text = "Display Table Names";
            this.allTables.UseVisualStyleBackColor = true;
            this.allTables.Click += new System.EventHandler(this.allTables_Click);
            // 
            // allTrain
            // 
            this.allTrain.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.allTrain.Location = new System.Drawing.Point(29, 166);
            this.allTrain.Name = "allTrain";
            this.allTrain.Size = new System.Drawing.Size(139, 23);
            this.allTrain.TabIndex = 1;
            this.allTrain.Text = "Display Trainee Names";
            this.allTrain.UseVisualStyleBackColor = true;
            this.allTrain.Click += new System.EventHandler(this.allTrain_Click);
            // 
            // specifyTrain
            // 
            this.specifyTrain.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.specifyTrain.Location = new System.Drawing.Point(29, 137);
            this.specifyTrain.Name = "specifyTrain";
            this.specifyTrain.Size = new System.Drawing.Size(139, 23);
            this.specifyTrain.TabIndex = 2;
            this.specifyTrain.Text = "Display Specified Trainee";
            this.specifyTrain.UseVisualStyleBackColor = true;
            this.specifyTrain.Click += new System.EventHandler(this.specifyTrain_Click);
            // 
            // FName_specify
            // 
            this.FName_specify.Location = new System.Drawing.Point(29, 64);
            this.FName_specify.Name = "FName_specify";
            this.FName_specify.Size = new System.Drawing.Size(139, 20);
            this.FName_specify.TabIndex = 3;
            // 
            // LName_specify
            // 
            this.LName_specify.Location = new System.Drawing.Point(29, 111);
            this.LName_specify.Name = "LName_specify";
            this.LName_specify.Size = new System.Drawing.Size(139, 20);
            this.LName_specify.TabIndex = 4;
            // 
            // LName_label
            // 
            this.LName_label.AutoSize = true;
            this.LName_label.Location = new System.Drawing.Point(29, 95);
            this.LName_label.Name = "LName_label";
            this.LName_label.Size = new System.Drawing.Size(58, 13);
            this.LName_label.TabIndex = 5;
            this.LName_label.Text = "Last Name";
            // 
            // FName_label
            // 
            this.FName_label.AutoSize = true;
            this.FName_label.Location = new System.Drawing.Point(29, 48);
            this.FName_label.Name = "FName_label";
            this.FName_label.Size = new System.Drawing.Size(57, 13);
            this.FName_label.TabIndex = 6;
            this.FName_label.Text = "First Name";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(29, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(126, 13);
            this.title_label.TabIndex = 7;
            this.title_label.Text = "Specify Action to Perform";
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(12, 228);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // QueryPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 263);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.FName_label);
            this.Controls.Add(this.LName_label);
            this.Controls.Add(this.LName_specify);
            this.Controls.Add(this.FName_specify);
            this.Controls.Add(this.specifyTrain);
            this.Controls.Add(this.allTrain);
            this.Controls.Add(this.allTables);
            this.Name = "QueryPrompt";
            this.Text = "QueryPrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allTables;
        private System.Windows.Forms.Button allTrain;
        private System.Windows.Forms.Button specifyTrain;
        private System.Windows.Forms.TextBox FName_specify;
        private System.Windows.Forms.TextBox LName_specify;
        private System.Windows.Forms.Label LName_label;
        private System.Windows.Forms.Label FName_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button cancel;

    }
}