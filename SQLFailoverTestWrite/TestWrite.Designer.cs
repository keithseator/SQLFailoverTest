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
            this.btnFillTextBox = new System.Windows.Forms.Button();
            this.btnClearTimes = new System.Windows.Forms.Button();
            this.btnTestShit = new System.Windows.Forms.Button();
            this.btnDoNotPress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // latestDBWritesListBox
            // 
            this.latestDBWritesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestDBWritesListBox.FormattingEnabled = true;
            this.latestDBWritesListBox.ItemHeight = 29;
            this.latestDBWritesListBox.Location = new System.Drawing.Point(12, 57);
            this.latestDBWritesListBox.Name = "latestDBWritesListBox";
            this.latestDBWritesListBox.Size = new System.Drawing.Size(308, 497);
            this.latestDBWritesListBox.TabIndex = 0;
            // 
            // btn_InsertToDatabase
            // 
            this.btn_InsertToDatabase.Location = new System.Drawing.Point(12, 12);
            this.btn_InsertToDatabase.Name = "btn_InsertToDatabase";
            this.btn_InsertToDatabase.Size = new System.Drawing.Size(152, 23);
            this.btn_InsertToDatabase.TabIndex = 1;
            this.btn_InsertToDatabase.Text = "Start Insert Into Database";
            this.btn_InsertToDatabase.UseVisualStyleBackColor = true;
            this.btn_InsertToDatabase.Click += new System.EventHandler(this.btn_InsertToDatabase_Click);
            // 
            // btnStopInsert
            // 
            this.btnStopInsert.Location = new System.Drawing.Point(170, 12);
            this.btnStopInsert.Name = "btnStopInsert";
            this.btnStopInsert.Size = new System.Drawing.Size(150, 23);
            this.btnStopInsert.TabIndex = 2;
            this.btnStopInsert.Text = "Stop Insert Into Database";
            this.btnStopInsert.UseVisualStyleBackColor = true;
            this.btnStopInsert.Click += new System.EventHandler(this.btnStopInsert_Click);
            // 
            // btnFillTextBox
            // 
            this.btnFillTextBox.Location = new System.Drawing.Point(337, 57);
            this.btnFillTextBox.Name = "btnFillTextBox";
            this.btnFillTextBox.Size = new System.Drawing.Size(93, 23);
            this.btnFillTextBox.TabIndex = 3;
            this.btnFillTextBox.Text = "Fill Text Box";
            this.btnFillTextBox.UseVisualStyleBackColor = true;
            this.btnFillTextBox.Click += new System.EventHandler(this.btnFillTextBox_Click);
            // 
            // btnClearTimes
            // 
            this.btnClearTimes.Location = new System.Drawing.Point(337, 120);
            this.btnClearTimes.Name = "btnClearTimes";
            this.btnClearTimes.Size = new System.Drawing.Size(93, 23);
            this.btnClearTimes.TabIndex = 4;
            this.btnClearTimes.Text = "Clear All Times";
            this.btnClearTimes.UseVisualStyleBackColor = true;
            this.btnClearTimes.Click += new System.EventHandler(this.btnClearTimes_Click);
            // 
            // btnTestShit
            // 
            this.btnTestShit.Location = new System.Drawing.Point(337, 183);
            this.btnTestShit.Name = "btnTestShit";
            this.btnTestShit.Size = new System.Drawing.Size(93, 23);
            this.btnTestShit.TabIndex = 5;
            this.btnTestShit.Text = "Test Shit";
            this.btnTestShit.UseVisualStyleBackColor = true;
            // 
            // btnDoNotPress
            // 
            this.btnDoNotPress.Location = new System.Drawing.Point(337, 246);
            this.btnDoNotPress.Name = "btnDoNotPress";
            this.btnDoNotPress.Size = new System.Drawing.Size(93, 23);
            this.btnDoNotPress.TabIndex = 6;
            this.btnDoNotPress.Text = "Do Not Press!";
            this.btnDoNotPress.UseVisualStyleBackColor = true;
            this.btnDoNotPress.Click += new System.EventHandler(this.btnDoNotPress_Click);
            // 
            // TestWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 564);
            this.Controls.Add(this.btnDoNotPress);
            this.Controls.Add(this.btnTestShit);
            this.Controls.Add(this.btnClearTimes);
            this.Controls.Add(this.btnFillTextBox);
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
        private System.Windows.Forms.Button btnFillTextBox;
        private System.Windows.Forms.Button btnClearTimes;
        private System.Windows.Forms.Button btnTestShit;
        private System.Windows.Forms.Button btnDoNotPress;
    }
}

