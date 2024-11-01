namespace toolUses
{
    partial class Form2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mardin", "Diyarbakır", "Muş", "Hakkari", "Batman", "Niğde" });
            comboBox1.Location = new Point(75, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 27);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(75, 110);
            button1.Name = "button1";
            button1.Size = new Size(128, 66);
            button1.TabIndex = 1;
            button1.Text = "Add City";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(75, 324);
            button2.Name = "button2";
            button2.Size = new Size(109, 51);
            button2.TabIndex = 2;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 286);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 3;
            //textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(75, 248);
            label1.Name = "label1";
            label1.Size = new Size(182, 23);
            label1.TabIndex = 4;
            label1.Text = "Please add your city:";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Corbel", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Items.AddRange(new object[] { "Teacher", "Doctor", "Engineer", "Pilot", "Lawyer" });
            listBox1.Location = new Point(593, 76);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 118);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(593, 219);
            button3.Name = "button3";
            button3.Size = new Size(140, 57);
            button3.TabIndex = 6;
            button3.Text = "Add Job";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(593, 302);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 7;
            label2.Text = "Jobb:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(666, 302);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 27);
            textBox2.TabIndex = 8;
            //textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(680, 346);
            button4.Name = "button4";
            button4.Size = new Size(102, 46);
            button4.TabIndex = 9;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1109, 554);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Tool Uses 2";
            //Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private Button button4;
    }
}