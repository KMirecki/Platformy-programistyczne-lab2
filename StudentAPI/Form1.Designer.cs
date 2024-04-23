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
            listBoxCoctails = new ListBox();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            textBoxDatabaseCount = new TextBox();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxSource = new TextBox();
            label8 = new Label();
            label9 = new Label();
            listBoxIngredients = new ListBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // listBoxCoctails
            // 
            listBoxCoctails.FormattingEnabled = true;
            listBoxCoctails.ItemHeight = 15;
            listBoxCoctails.Location = new Point(49, 55);
            listBoxCoctails.Margin = new Padding(2);
            listBoxCoctails.Name = "listBoxCoctails";
            listBoxCoctails.Size = new Size(204, 184);
            listBoxCoctails.TabIndex = 2;
            listBoxCoctails.SelectedIndexChanged += listBoxCoctails_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(624, 350);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Random";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 287);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(502, 144);
            textBox1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(624, 437);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(624, 408);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(668, 84);
            button4.Name = "button4";
            button4.Size = new Size(59, 23);
            button4.TabIndex = 9;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxDatabaseCount
            // 
            textBoxDatabaseCount.Location = new Point(624, 55);
            textBoxDatabaseCount.Name = "textBoxDatabaseCount";
            textBoxDatabaseCount.ReadOnly = true;
            textBoxDatabaseCount.Size = new Size(75, 23);
            textBoxDatabaseCount.TabIndex = 10;
            // 
            // button5
            // 
            button5.Location = new Point(601, 84);
            button5.Name = "button5";
            button5.Size = new Size(61, 23);
            button5.TabIndex = 11;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(601, 390);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 12;
            label1.Text = "Search By First Letter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(616, 323);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 13;
            label2.Text = "Random coctail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 241);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 14;
            label3.Text = "Search By Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(614, 259);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(624, 288);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(49, 241);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 17;
            label4.Text = "Instruction:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(49, 12);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 18;
            label5.Text = "Matching coctails:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(601, 9);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 19;
            label6.Text = "Debug tools/info";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(624, 37);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 20;
            label7.Text = "Items count:";
            // 
            // textBoxSource
            // 
            textBoxSource.Location = new Point(624, 140);
            textBoxSource.Name = "textBoxSource";
            textBoxSource.ReadOnly = true;
            textBoxSource.Size = new Size(75, 23);
            textBoxSource.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(608, 122);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 22;
            label8.Text = "Recent data source:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(589, 210);
            label9.Name = "label9";
            label9.Size = new Size(138, 20);
            label9.TabIndex = 23;
            label9.Text = "Search for a Coctail";
            // 
            // listBoxIngredients
            // 
            listBoxIngredients.FormattingEnabled = true;
            listBoxIngredients.ItemHeight = 15;
            listBoxIngredients.Location = new Point(335, 55);
            listBoxIngredients.Name = "listBoxIngredients";
            listBoxIngredients.SelectionMode = SelectionMode.None;
            listBoxIngredients.Size = new Size(216, 184);
            listBoxIngredients.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(335, 12);
            label10.Name = "label10";
            label10.Size = new Size(111, 25);
            label10.TabIndex = 25;
            label10.Text = "Ingredients:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 472);
            Controls.Add(label10);
            Controls.Add(listBoxIngredients);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBoxSource);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(textBoxDatabaseCount);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(listBoxCoctails);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Cocktails";
            Load += Form1_Load;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
            PerformLayout();
            AutoSize = true;
        }

        #endregion
        private ListBox listBoxCoctails;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private TextBox textBoxDatabaseCount;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxSource;
        private Label label8;
        private Label label9;
        private ListBox listBoxIngredients;
        private Label label10;
    }
}
