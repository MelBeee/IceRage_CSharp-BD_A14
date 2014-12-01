namespace HockeyIce
{
    partial class FormClassement
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
            this.PN_CJoueurs = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.CJoueurs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PN_CEquipe = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PN_3Joueurs = new System.Windows.Forms.Panel();
            this.PN_CJoueurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PN_CEquipe.SuspendLayout();
            this.PN_3Joueurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(36, 5);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(122, 28);
            this.LB_Text.TabIndex = 13;
            this.LB_Text.Text = "Classement";
            this.LB_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseDown);
            this.LB_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseMove);
            this.LB_Text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseUp);
            // 
            // PN_CJoueurs
            // 
            this.PN_CJoueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_CJoueurs.Controls.Add(this.PN_3Joueurs);
            this.PN_CJoueurs.Controls.Add(this.CJoueurs);
            this.PN_CJoueurs.Location = new System.Drawing.Point(5, 37);
            this.PN_CJoueurs.Name = "PN_CJoueurs";
            this.PN_CJoueurs.Size = new System.Drawing.Size(781, 425);
            this.PN_CJoueurs.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
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
            this.FB_Quitter.Location = new System.Drawing.Point(761, 5);
            this.FB_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(25, 25);
            this.FB_Quitter.TabIndex = 11;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // CJoueurs
            // 
            this.CJoueurs.AutoSize = true;
            this.CJoueurs.Location = new System.Drawing.Point(263, 162);
            this.CJoueurs.Name = "CJoueurs";
            this.CJoueurs.Size = new System.Drawing.Size(68, 17);
            this.CJoueurs.TabIndex = 0;
            this.CJoueurs.Text = "CJoueurs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEquipe";
            // 
            // PN_CEquipe
            // 
            this.PN_CEquipe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_CEquipe.Controls.Add(this.label1);
            this.PN_CEquipe.Location = new System.Drawing.Point(5, 37);
            this.PN_CEquipe.Name = "PN_CEquipe";
            this.PN_CEquipe.Size = new System.Drawing.Size(781, 425);
            this.PN_CEquipe.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "C3Joueurs";
            // 
            // PN_3Joueurs
            // 
            this.PN_3Joueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_3Joueurs.Controls.Add(this.label2);
            this.PN_3Joueurs.Location = new System.Drawing.Point(5, 37);
            this.PN_3Joueurs.Name = "PN_3Joueurs";
            this.PN_3Joueurs.Size = new System.Drawing.Size(781, 425);
            this.PN_3Joueurs.TabIndex = 12;
            // 
            // FormClassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(792, 467);
            this.Controls.Add(this.PN_CEquipe);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.PN_CJoueurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClassement";
            this.Text = "FormClassement";
            this.Load += new System.EventHandler(this.FormClassement_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormClassement_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormClassement_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormClassement_MouseUp);
            this.PN_CJoueurs.ResumeLayout(false);
            this.PN_CJoueurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PN_CEquipe.ResumeLayout(false);
            this.PN_CEquipe.PerformLayout();
            this.PN_3Joueurs.ResumeLayout(false);
            this.PN_3Joueurs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Text;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FlashButton.FlashButton FB_Quitter;
        private System.Windows.Forms.Panel PN_CJoueurs;
        private System.Windows.Forms.Panel PN_CEquipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CJoueurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PN_3Joueurs;
    }
}