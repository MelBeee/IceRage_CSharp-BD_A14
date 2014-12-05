namespace HockeyIce
{
    partial class FormErreur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FB_Continuer = new FlashButton.FlashButton();
            this.LB_Description = new System.Windows.Forms.Label();
            this.LB_Text = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.FB_Fermer);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.FB_Continuer);
            this.panel1.Controls.Add(this.LB_Description);
            this.panel1.Location = new System.Drawing.Point(4, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 125);
            this.panel1.TabIndex = 0;
            // 
            // FB_Fermer
            // 
            this.FB_Fermer.BackgroundImage = global::HockeyIce.Properties.Resources.QuitterNormal;
            this.FB_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fermer.ImageClick = global::HockeyIce.Properties.Resources.QuitterClick;
            this.FB_Fermer.ImageDisable = global::HockeyIce.Properties.Resources.QuitterDisable;
            this.FB_Fermer.ImageNeutral = global::HockeyIce.Properties.Resources.QuitterNormal;
            this.FB_Fermer.ImageOver = global::HockeyIce.Properties.Resources.QuitterHover;
            this.FB_Fermer.Location = new System.Drawing.Point(166, 95);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(100, 20);
            this.FB_Fermer.TabIndex = 4;
            this.FB_Fermer.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HockeyIce.Properties.Resources.error;
            this.pictureBox1.Location = new System.Drawing.Point(18, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FB_Continuer
            // 
            this.FB_Continuer.BackgroundImage = global::HockeyIce.Properties.Resources.ContinuerNormal;
            this.FB_Continuer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Continuer.ImageClick = global::HockeyIce.Properties.Resources.ContinuerClick;
            this.FB_Continuer.ImageDisable = global::HockeyIce.Properties.Resources.ContinuerDisable;
            this.FB_Continuer.ImageNeutral = global::HockeyIce.Properties.Resources.ContinuerNormal;
            this.FB_Continuer.ImageOver = global::HockeyIce.Properties.Resources.ContinuerHover;
            this.FB_Continuer.Location = new System.Drawing.Point(58, 95);
            this.FB_Continuer.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Continuer.Name = "FB_Continuer";
            this.FB_Continuer.Size = new System.Drawing.Size(100, 20);
            this.FB_Continuer.TabIndex = 2;
            this.FB_Continuer.Click += new System.EventHandler(this.FB_Continuer_Click);
            // 
            // LB_Description
            // 
            this.LB_Description.AutoSize = true;
            this.LB_Description.Font = new System.Drawing.Font("Kristen ITC", 9F);
            this.LB_Description.Location = new System.Drawing.Point(79, 16);
            this.LB_Description.MaximumSize = new System.Drawing.Size(230, 75);
            this.LB_Description.Name = "LB_Description";
            this.LB_Description.Size = new System.Drawing.Size(140, 22);
            this.LB_Description.TabIndex = 1;
            this.LB_Description.Text = "Message d\'Erreur";
            this.LB_Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(33, 2);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(77, 28);
            this.LB_Text.TabIndex = 5;
            this.LB_Text.Text = "Erreur";
            this.LB_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseDown);
            this.LB_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseMove);
            this.LB_Text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
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
            this.FB_Quitter.Location = new System.Drawing.Point(300, 4);
            this.FB_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(25, 25);
            this.FB_Quitter.TabIndex = 1;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // FormErreur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(330, 160);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormErreur";
            this.Text = "FormErreur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormErreur_FormClosing);
            this.Load += new System.EventHandler(this.FormErreur_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormErreur_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormErreur_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormErreur_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FlashButton.FlashButton FB_Quitter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LB_Text;
        private System.Windows.Forms.Label LB_Description;
        private FlashButton.FlashButton FB_Continuer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlashButton.FlashButton FB_Fermer;
    }
}