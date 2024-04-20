namespace StudentAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listBoxStudents = new ListBox();
            textBoxName = new TextBox();
            textBoxAverage = new TextBox();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            textBoxDatabaseCount = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(421, 144);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(40, 7);
            listBoxStudents.Margin = new Padding(2);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(500, 109);
            listBoxStudents.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(40, 141);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxAverage
            // 
            textBoxAverage.Location = new Point(219, 141);
            textBoxAverage.Name = "textBoxAverage";
            textBoxAverage.Size = new Size(100, 23);
            textBoxAverage.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(49, 437);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Random";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 270);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(429, 144);
            textBox1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(327, 437);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 437);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(667, 222);
            button4.Name = "button4";
            button4.Size = new Size(133, 23);
            button4.TabIndex = 9;
            button4.Text = "Clear Database";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxDatabaseCount
            // 
            textBoxDatabaseCount.Location = new Point(682, 193);
            textBoxDatabaseCount.Name = "textBoxDatabaseCount";
            textBoxDatabaseCount.ReadOnly = true;
            textBoxDatabaseCount.Size = new Size(100, 23);
            textBoxDatabaseCount.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 472);
            Controls.Add(textBoxDatabaseCount);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(textBoxAverage);
            Controls.Add(textBoxName);
            Controls.Add(listBoxStudents);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox listBoxStudents;
        private TextBox textBoxName;
        private TextBox textBoxAverage;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private TextBox textBoxDatabaseCount;
    }
}
