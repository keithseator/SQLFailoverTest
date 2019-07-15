namespace SQLFailoverTestWrite
{
    partial class TestWrite
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
            this.latestDBWritesListBox = new System.Windows.Forms.ListBox();
            this.btn_InsertToDatabase = new System.Windows.Forms.Button();
            this.btnStopInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // latestDBWritesListBox
            // 
            this.latestDBWritesListBox.FormattingEnabled = true;
            this.latestDBWritesListBox.Location = new System.Drawing.Point(12, 68);
            this.latestDBWritesListBox.Name = "latestDBWritesListBox";
            this.latestDBWritesListBox.Size = new System.Drawing.Size(408, 264);
            this.latestDBWritesListBox.TabIndex = 0;
            // 
            // btn_InsertToDatabase
            // 
            this.btn_InsertToDatabase.Location = new System.Drawing.Point(13, 13);
            this.btn_InsertToDatabase.Name = "btn_InsertToDatabase";
            this.btn_InsertToDatabase.Size = new System.Drawing.Size(122, 23);
            this.btn_InsertToDatabase.TabIndex = 1;
            this.btn_InsertToDatabase.Text = "Insert Into Database";
            this.btn_InsertToDatabase.UseVisualStyleBackColor = true;
            this.btn_InsertToDatabase.Click += new System.EventHandler(this.btn_InsertToDatabase_Click);
            // 
            // btnStopInsert
            // 
            this.btnStopInsert.Location = new System.Drawing.Point(189, 12);
            this.btnStopInsert.Name = "btnStopInsert";
            this.btnStopInsert.Size = new System.Drawing.Size(75, 23);
            this.btnStopInsert.TabIndex = 2;
            this.btnStopInsert.Text = "Stop Insert";
            this.btnStopInsert.UseVisualStyleBackColor = true;
            this.btnStopInsert.Click += new System.EventHandler(this.btnStopInsert_Click);
            // 
            // TestWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopInsert);
            this.Controls.Add(this.btn_InsertToDatabase);
            this.Controls.Add(this.latestDBWritesListBox);
            this.Name = "TestWrite";
            this.Text = "Test SQL Write";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox latestDBWritesListBox;
        private System.Windows.Forms.Button btn_InsertToDatabase;
        private System.Windows.Forms.Button btnStopInsert;
    }
}

