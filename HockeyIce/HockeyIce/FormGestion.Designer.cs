namespace HockeyIce
{
    partial class FormGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestion));
            this.LB_Text = new System.Windows.Forms.Label();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.PN_GestionDivision = new System.Windows.Forms.Panel();
            this.PN_Equipe = new System.Windows.Forms.Panel();
            this.PN_Joueurs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.PN_GestionDivision.SuspendLayout();
            this.PN_Equipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(24, 3);
            this.LB_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(71, 23);
            this.LB_Text.TabIndex = 4;
            this.LB_Text.Text = "Gestion";
            this.LB_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseDown);
            this.LB_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseMove);
            this.LB_Text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseUp);
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.PB_Logo.Location = new System.Drawing.Point(3, 3);
            this.PB_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(22, 21);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 5;
            this.PB_Logo.TabStop = false;
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
            this.FB_Fermer.Location = new System.Drawing.Point(609, 2);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(20, 21);
            this.FB_Fermer.TabIndex = 6;
            this.FB_Fermer.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // PN_GestionDivision
            // 
            this.PN_GestionDivision.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_GestionDivision.Controls.Add(this.PN_Equipe);
            this.PN_GestionDivision.Location = new System.Drawing.Point(3, 27);
            this.PN_GestionDivision.Name = "PN_GestionDivision";
            this.PN_GestionDivision.Size = new System.Drawing.Size(626, 360);
            this.PN_GestionDivision.TabIndex = 7;
            // 
            // PN_Equipe
            // 
            this.PN_Equipe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Equipe.Controls.Add(this.PN_Joueurs);
            this.PN_Equipe.Location = new System.Drawing.Point(8, 8);
            this.PN_Equipe.Name = "PN_Equipe";
            this.PN_Equipe.Size = new System.Drawing.Size(626, 360);
            this.PN_Equipe.TabIndex = 8;
            // 
            // PN_Joueurs
            // 
            this.PN_Joueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Joueurs.Location = new System.Drawing.Point(8, 8);
            this.PN_Joueurs.Name = "PN_Joueurs";
            this.PN_Joueurs.Size = new System.Drawing.Size(626, 360);
            this.PN_Joueurs.TabIndex = 8;
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(633, 391);
            this.Controls.Add(this.PN_GestionDivision);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestion";
            this.Text = "FormGestion";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.PN_GestionDivision.ResumeLayout(false);
            this.PN_Equipe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Label LB_Text;
        private FlashButton.FlashButton FB_Fermer;
        private System.Windows.Forms.Panel PN_GestionDivision;
        private System.Windows.Forms.Panel PN_Equipe;
        private System.Windows.Forms.Panel PN_Joueurs;
    }
}