namespace Flappy_Bird_Windows_Form
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ustBoru = new System.Windows.Forms.PictureBox();
            this.altBoru = new System.Windows.Forms.PictureBox();
            this.kus = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.puanMetni = new System.Windows.Forms.Label();
            this.oyunZamani = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ustBoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altBoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // ustBoru
            // 
            this.ustBoru.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipedown;
            this.ustBoru.Location = new System.Drawing.Point(489, -66);
            this.ustBoru.Name = "ustBoru";
            this.ustBoru.Size = new System.Drawing.Size(100, 266);
            this.ustBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustBoru.TabIndex = 0;
            this.ustBoru.TabStop = false;
            // 
            // altBoru
            // 
            this.altBoru.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipe;
            this.altBoru.Location = new System.Drawing.Point(337, 456);
            this.altBoru.Name = "altBoru";
            this.altBoru.Size = new System.Drawing.Size(109, 286);
            this.altBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.altBoru.TabIndex = 1;
            this.altBoru.TabStop = false;
            // 
            // kus
            // 
            this.kus.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.bird;
            this.kus.Location = new System.Drawing.Point(19, 228);
            this.kus.Name = "kus";
            this.kus.Size = new System.Drawing.Size(82, 69);
            this.kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kus.TabIndex = 2;
            this.kus.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.ground;
            this.zemin.Location = new System.Drawing.Point(-16, 633);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(834, 126);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // puanMetni
            // 
            this.puanMetni.AutoSize = true;
            this.puanMetni.BackColor = System.Drawing.Color.Moccasin;
            this.puanMetni.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puanMetni.ForeColor = System.Drawing.Color.Black;
            this.puanMetni.Location = new System.Drawing.Point(12, 667);
            this.puanMetni.Name = "puanMetni";
            this.puanMetni.Size = new System.Drawing.Size(135, 37);
            this.puanMetni.TabIndex = 4;
            this.puanMetni.Text = "Puan: 0";
            // 
            // oyunZamani
            // 
            this.oyunZamani.Enabled = true;
            this.oyunZamani.Interval = 20;
            this.oyunZamani.Tick += new System.EventHandler(this.oyunZamaniEtkinlik);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 761);
            this.Controls.Add(this.puanMetni);
            this.Controls.Add(this.kus);
            this.Controls.Add(this.ustBoru);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.altBoru);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tusBasildi);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tusBirakildi);
            ((System.ComponentModel.ISupportInitialize)(this.ustBoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altBoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ustBoru;
        private System.Windows.Forms.PictureBox altBoru;
        private System.Windows.Forms.PictureBox kus;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label puanMetni;
        private System.Windows.Forms.Timer oyunZamani;
    }
}
