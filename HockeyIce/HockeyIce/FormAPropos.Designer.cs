namespace HockeyIce
{
    partial class FormAPropos
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
            this.LB_Text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FB_Continuer = new FlashButton.FlashButton();
            this.LB_Description = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(33, 4);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(104, 28);
            this.LB_Text.TabIndex = 9;
            this.LB_Text.Text = "À Propos";
            this.LB_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseDown);
            this.LB_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseMove);
            this.LB_Text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.FB_Continuer);
            this.panel1.Controls.Add(this.LB_Description);
            this.panel1.Location = new System.Drawing.Point(3, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 425);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "U-Puck";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HockeyIce.Properties.Resources.Hockey_Stick_Pin;
            this.pictureBox1.Location = new System.Drawing.Point(257, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FB_Continuer
            // 
            this.FB_Continuer.BackgroundImage = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_Continuer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Continuer.ImageClick = global::HockeyIce.Properties.Resources.FermerClick;
            this.FB_Continuer.ImageDisable = global::HockeyIce.Properties.Resources.FermerDisable;
            this.FB_Continuer.ImageNeutral = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_Continuer.ImageOver = global::HockeyIce.Properties.Resources.FermerHover;
            this.FB_Continuer.Location = new System.Drawing.Point(4, 401);
            this.FB_Continuer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FB_Continuer.Name = "FB_Continuer";
            this.FB_Continuer.Size = new System.Drawing.Size(100, 20);
            this.FB_Continuer.TabIndex = 3;
            this.FB_Continuer.Click += new System.EventHandler(this.FB_Continuer_Click);
            // 
            // LB_Description
            // 
            this.LB_Description.AutoSize = true;
            this.LB_Description.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.LB_Description.Location = new System.Drawing.Point(10, 48);
            this.LB_Description.Name = "LB_Description";
            this.LB_Description.Size = new System.Drawing.Size(343, 22);
            this.LB_Description.TabIndex = 1;
            this.LB_Description.Text = "Créé par Melissa Boucher et Xavier Brosseau";
            this.LB_Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FB_Quitter
            // 
            this.FB_Quitter.BackgroundImage = global::HockeyIce.Properties.Resources.CloseNormal;
            this.FB_Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Quitter.ImageClick = global::HockeyIce.Properties.Resources.CloseClick;
            this.FB_Quitter.ImageDisable = global::HockeyIce.Properties.Resources.CloseDisable;
            this.FB_Quitter.ImageNeutral = global::HockeyIce.Properties.Resources.CloseNormal;
            this.FB_Quitter.ImageOver = global::HockeyIce.Properties.Resources.CloseHover;
            this.FB_Quitter.Location = new System.Drawing.Point(441, 4);
            this.FB_Quitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(25, 25);
            this.FB_Quitter.TabIndex = 7;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Raccourcis Claviers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 80);
            this.label3.TabIndex = 7;
            this.label3.Text = "F1 - \r\nCtrl+Q - \r\nEscape - \r\nF2 - ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(96, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 80);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ouvrir fenêtre À Propos\r\nQuitter le programme\r\nQuitter le programme\r\nAfficher le " +
    "classement";
            // 
            // FormAPropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(469, 460);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAPropos";
            this.Text = "APropos";
            this.Load += new System.EventHandler(this.APropos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APropos_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APropos_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.APropos_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Text;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FlashButton.FlashButton FB_Quitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_Description;
        private FlashButton.FlashButton FB_Continuer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}