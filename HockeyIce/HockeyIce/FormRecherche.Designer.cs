namespace HockeyIce
{
    partial class FormRecherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecherche));
            this.FB_Fermer = new FlashButton.FlashButton();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.LB_Text = new System.Windows.Forms.Label();
            this.PN_Equipe = new System.Windows.Forms.Panel();
            this.PN_Matchs = new System.Windows.Forms.Panel();
            this.PN_Joueurs = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.PN_Equipe.SuspendLayout();
            this.PN_Matchs.SuspendLayout();
            this.PN_Joueurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // FB_Fermer
            // 
            this.FB_Fermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Fermer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_Fermer.BackgroundImage")));
            this.FB_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fermer.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_Fermer.ImageClick")));
            this.FB_Fermer.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_Fermer.ImageDisable")));
            this.FB_Fermer.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_Fermer.ImageNeutral")));
            this.FB_Fermer.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_Fermer.ImageOver")));
            this.FB_Fermer.Location = new System.Drawing.Point(519, 4);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(20, 21);
            this.FB_Fermer.TabIndex = 5;
            this.FB_Fermer.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.PB_Logo.Location = new System.Drawing.Point(2, 4);
            this.PB_Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(22, 21);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 7;
            this.PB_Logo.TabStop = false;
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(23, 2);
            this.LB_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(96, 23);
            this.LB_Text.TabIndex = 6;
            this.LB_Text.Text = "Recherche";
            this.LB_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseDown);
            this.LB_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseMove);
            this.LB_Text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseUp);
            // 
            // PN_Equipe
            // 
            this.PN_Equipe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Equipe.Controls.Add(this.PN_Matchs);
            this.PN_Equipe.Enabled = false;
            this.PN_Equipe.Location = new System.Drawing.Point(2, 29);
            this.PN_Equipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PN_Equipe.Name = "PN_Equipe";
            this.PN_Equipe.Size = new System.Drawing.Size(537, 403);
            this.PN_Equipe.TabIndex = 8;
            this.PN_Equipe.Visible = false;
            // 
            // PN_Matchs
            // 
            this.PN_Matchs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Matchs.Controls.Add(this.PN_Joueurs);
            this.PN_Matchs.Enabled = false;
            this.PN_Matchs.Location = new System.Drawing.Point(6, 6);
            this.PN_Matchs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PN_Matchs.Name = "PN_Matchs";
            this.PN_Matchs.Size = new System.Drawing.Size(537, 403);
            this.PN_Matchs.TabIndex = 9;
            this.PN_Matchs.Visible = false;
            // 
            // PN_Joueurs
            // 
            this.PN_Joueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Joueurs.Controls.Add(this.button1);
            this.PN_Joueurs.Enabled = false;
            this.PN_Joueurs.Location = new System.Drawing.Point(6, 6);
            this.PN_Joueurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PN_Joueurs.Name = "PN_Joueurs";
            this.PN_Joueurs.Size = new System.Drawing.Size(537, 403);
            this.PN_Joueurs.TabIndex = 9;
            this.PN_Joueurs.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(542, 435);
            this.Controls.Add(this.PN_Equipe);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.FB_Fermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRecherche";
            this.Text = "FormRecherche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRecherche_FormClosing);
            this.Load += new System.EventHandler(this.FormRecherche_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRecherche_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormRecherche_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormRecherche_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.PN_Equipe.ResumeLayout(false);
            this.PN_Matchs.ResumeLayout(false);
            this.PN_Joueurs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlashButton.FlashButton FB_Fermer;
        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Label LB_Text;
        private System.Windows.Forms.Panel PN_Equipe;
        private System.Windows.Forms.Panel PN_Matchs;
        private System.Windows.Forms.Panel PN_Joueurs;
        private System.Windows.Forms.Button button1;
    }
}