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
            this.PN_3Joueurs = new System.Windows.Forms.Panel();
            this.CJoueurs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PN_CEquipe = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PN_CJoueurs.SuspendLayout();
            this.PN_3Joueurs.SuspendLayout();
            this.PN_CEquipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(27, 4);
            this.LB_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(99, 23);
            this.LB_Text.TabIndex = 13;
            this.LB_Text.Text = "Classement";
            this.LB_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseDown);
            this.LB_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseMove);
            this.LB_Text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseUp);
            // 
            // PN_CJoueurs
            // 
            this.PN_CJoueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_CJoueurs.Controls.Add(this.CJoueurs);
            this.PN_CJoueurs.Location = new System.Drawing.Point(4, 30);
            this.PN_CJoueurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PN_CJoueurs.Name = "PN_CJoueurs";
            this.PN_CJoueurs.Size = new System.Drawing.Size(586, 345);
            this.PN_CJoueurs.TabIndex = 10;
            // 
            // PN_3Joueurs
            // 
            this.PN_3Joueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_3Joueurs.Controls.Add(this.label2);
            this.PN_3Joueurs.Controls.Add(this.pictureBox1);
            this.PN_3Joueurs.Controls.Add(this.PN_CEquipe);
            this.PN_3Joueurs.Location = new System.Drawing.Point(4, 29);
            this.PN_3Joueurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PN_3Joueurs.Name = "PN_3Joueurs";
            this.PN_3Joueurs.Size = new System.Drawing.Size(586, 345);
            this.PN_3Joueurs.TabIndex = 12;
            // 
            // CJoueurs
            // 
            this.CJoueurs.AutoSize = true;
            this.CJoueurs.Location = new System.Drawing.Point(197, 132);
            this.CJoueurs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CJoueurs.Name = "CJoueurs";
            this.CJoueurs.Size = new System.Drawing.Size(51, 13);
            this.CJoueurs.TabIndex = 0;
            this.CJoueurs.Text = "CJoueurs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEquipe";
            // 
            // PN_CEquipe
            // 
            this.PN_CEquipe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_CEquipe.Controls.Add(this.label1);
            this.PN_CEquipe.Location = new System.Drawing.Point(2, 250);
            this.PN_CEquipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PN_CEquipe.Name = "PN_CEquipe";
            this.PN_CEquipe.Size = new System.Drawing.Size(586, 345);
            this.PN_CEquipe.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HockeyIce.Properties.Resources.podium;
            this.pictureBox1.Location = new System.Drawing.Point(56, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 21);
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
            this.FB_Quitter.Location = new System.Drawing.Point(571, 4);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(19, 20);
            this.FB_Quitter.TabIndex = 11;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bryan Prust";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormClassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(594, 379);
            this.Controls.Add(this.PN_3Joueurs);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.PN_CJoueurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormClassement";
            this.Text = "FormClassement";
            this.Load += new System.EventHandler(this.FormClassement_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormClassement_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormClassement_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormClassement_MouseUp);
            this.PN_CJoueurs.ResumeLayout(false);
            this.PN_CJoueurs.PerformLayout();
            this.PN_3Joueurs.ResumeLayout(false);
            this.PN_3Joueurs.PerformLayout();
            this.PN_CEquipe.ResumeLayout(false);
            this.PN_CEquipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel PN_3Joueurs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}