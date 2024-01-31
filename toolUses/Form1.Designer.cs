namespace toolUses
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
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(66, 111);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(172, 56);
            button1.TabIndex = 0;
            button1.Text = "Press!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(66, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Corbel", 14F, FontStyle.Bold);
            button2.Location = new Point(66, 61);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(99, 42);
            button2.TabIndex = 2;
            button2.Text = "Print";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 12F, FontStyle.Bold);
            label2.Location = new Point(177, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 24);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Font = new Font("Corbel", 11F);
            button3.Location = new Point(682, 151);
            button3.Name = "button3";
            button3.Size = new Size(175, 82);
            button3.TabIndex = 4;
            button3.Text = "Bring Information";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F);
            label3.Location = new Point(661, 36);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 5;
            label3.Text = "Name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F);
            label4.Location = new Point(633, 71);
            label4.Name = "label4";
            label4.Size = new Size(97, 24);
            label4.TabIndex = 6;
            label4.Text = "Surname:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F);
            label5.Location = new Point(682, 111);
            label5.Name = "label5";
            label5.Size = new Size(48, 24);
            label5.TabIndex = 7;
            label5.Text = "Job:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F);
            label6.Location = new Point(752, 36);
            label6.Name = "label6";
            label6.Size = new Size(64, 24);
            label6.TabIndex = 8;
            label6.Text = "label6";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F);
            label7.Location = new Point(752, 71);
            label7.Name = "label7";
            label7.Size = new Size(63, 24);
            label7.TabIndex = 9;
            label7.Text = "label7";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 12F);
            label8.Location = new Point(750, 111);
            label8.Name = "label8";
            label8.Size = new Size(65, 24);
            label8.TabIndex = 10;
            label8.Text = "label8";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(975, 485);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Corbel", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Tool Uses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
