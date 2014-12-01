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
            this.CJoueurs = new System.Windows.Forms.Label();
            this.PN_3Joueurs = new System.Windows.Forms.Panel();
            this.LB_Gold = new System.Windows.Forms.Label();
            this.PB_Podium = new System.Windows.Forms.PictureBox();
            this.PN_CEquipe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.LB_Bronze = new System.Windows.Forms.Label();
            this.LB_Silver = new System.Windows.Forms.Label();
            this.PN_CJoueurs.SuspendLayout();
            this.PN_3Joueurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Podium)).BeginInit();
            this.PN_CEquipe.SuspendLayout();
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
            this.PN_CJoueurs.Margin = new System.Windows.Forms.Padding(2);
            this.PN_CJoueurs.Name = "PN_CJoueurs";
            this.PN_CJoueurs.Size = new System.Drawing.Size(673, 397);
            this.PN_CJoueurs.TabIndex = 10;
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
            // PN_3Joueurs
            // 
            this.PN_3Joueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_3Joueurs.Controls.Add(this.LB_Silver);
            this.PN_3Joueurs.Controls.Add(this.LB_Bronze);
            this.PN_3Joueurs.Controls.Add(this.LB_Gold);
            this.PN_3Joueurs.Controls.Add(this.PB_Podium);
            this.PN_3Joueurs.Controls.Add(this.PN_CEquipe);
            this.PN_3Joueurs.Location = new System.Drawing.Point(4, 29);
            this.PN_3Joueurs.Margin = new System.Windows.Forms.Padding(2);
            this.PN_3Joueurs.Name = "PN_3Joueurs";
            this.PN_3Joueurs.Size = new System.Drawing.Size(673, 397);
            this.PN_3Joueurs.TabIndex = 12;
            // 
            // LB_Gold
            // 
            this.LB_Gold.AutoSize = true;
            this.LB_Gold.BackColor = System.Drawing.Color.Gold;
            this.LB_Gold.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Gold.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LB_Gold.Location = new System.Drawing.Point(284, 133);
            this.LB_Gold.Name = "LB_Gold";
            this.LB_Gold.Size = new System.Drawing.Size(214, 22);
            this.LB_Gold.TabIndex = 13;
            this.LB_Gold.Text = "Bryan Prustwerawrawreawr";
            this.LB_Gold.Click += new System.EventHandler(this.label2_Click);
            // 
            // PB_Podium
            // 
            this.PB_Podium.Image = global::HockeyIce.Properties.Resources.podium;
            this.PB_Podium.Location = new System.Drawing.Point(51, 16);
            this.PB_Podium.Name = "PB_Podium";
            this.PB_Podium.Size = new System.Drawing.Size(568, 148);
            this.PB_Podium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Podium.TabIndex = 12;
            this.PB_Podium.TabStop = false;
            this.PB_Podium.Click += new System.EventHandler(this.PB_Podium_Click);
            this.PB_Podium.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Podium_Paint);
            // 
            // PN_CEquipe
            // 
            this.PN_CEquipe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_CEquipe.Controls.Add(this.label1);
            this.PN_CEquipe.Location = new System.Drawing.Point(0, 244);
            this.PN_CEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.PN_CEquipe.Name = "PN_CEquipe";
            this.PN_CEquipe.Size = new System.Drawing.Size(673, 397);
            this.PN_CEquipe.TabIndex = 11;
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
            this.FB_Quitter.Location = new System.Drawing.Point(658, 4);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(19, 20);
            this.FB_Quitter.TabIndex = 11;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // LB_Bronze
            // 
            this.LB_Bronze.AutoSize = true;
            this.LB_Bronze.Font = new System.Drawing.Font("Kristen ITC", 11.25F);
            this.LB_Bronze.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LB_Bronze.Location = new System.Drawing.Point(482, 133);
            this.LB_Bronze.Name = "LB_Bronze";
            this.LB_Bronze.Size = new System.Drawing.Size(92, 22);
            this.LB_Bronze.TabIndex = 14;
            this.LB_Bronze.Text = "PK Subban";
            // 
            // LB_Silver
            // 
            this.LB_Silver.AutoSize = true;
            this.LB_Silver.BackColor = System.Drawing.Color.Gold;
            this.LB_Silver.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Silver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LB_Silver.Location = new System.Drawing.Point(94, 133);
            this.LB_Silver.Name = "LB_Silver";
            this.LB_Silver.Size = new System.Drawing.Size(98, 22);
            this.LB_Silver.TabIndex = 15;
            this.LB_Silver.Text = "Bryan Prust";
            // 
            // FormClassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(681, 431);
            this.Controls.Add(this.PN_3Joueurs);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.PN_CJoueurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.PB_Podium)).EndInit();
            this.PN_CEquipe.ResumeLayout(false);
            this.PN_CEquipe.PerformLayout();
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
        private System.Windows.Forms.PictureBox PB_Podium;
        private System.Windows.Forms.Label LB_Gold;
        private System.Windows.Forms.Label LB_Bronze;
        private System.Windows.Forms.Label LB_Silver;
    }
}