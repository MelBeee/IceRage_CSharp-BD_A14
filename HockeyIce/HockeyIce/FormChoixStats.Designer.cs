namespace HockeyIce
{
    partial class FormChoixStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoixStats));
            this.LB_NomApp = new System.Windows.Forms.Label();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_Equipe = new System.Windows.Forms.ComboBox();
            this.RB_JoueurEquipe = new System.Windows.Forms.RadioButton();
            this.FB_Ok = new FlashButton.FlashButton();
            this.FB_Annuler = new FlashButton.FlashButton();
            this.RB_TousJoueurs = new System.Windows.Forms.RadioButton();
            this.RB_AjouterStats = new System.Windows.Forms.RadioButton();
            this.CB_Invisible = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_NomApp
            // 
            this.LB_NomApp.AutoSize = true;
            this.LB_NomApp.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NomApp.ForeColor = System.Drawing.Color.White;
            this.LB_NomApp.Location = new System.Drawing.Point(32, 2);
            this.LB_NomApp.Name = "LB_NomApp";
            this.LB_NomApp.Size = new System.Drawing.Size(129, 28);
            this.LB_NomApp.TabIndex = 4;
            this.LB_NomApp.Text = "Statistiques";
            this.LB_NomApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormGestionStatistiqueJ_MouseDown);
            this.LB_NomApp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormGestionStatistiqueJ_MouseMove);
            this.LB_NomApp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormGestionStatistiqueJ_MouseUp);
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.PB_Logo.Location = new System.Drawing.Point(4, 4);
            this.PB_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(29, 26);
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
            this.FB_Fermer.Location = new System.Drawing.Point(551, 4);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(5);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(27, 26);
            this.FB_Fermer.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.CB_Equipe);
            this.panel1.Controls.Add(this.RB_JoueurEquipe);
            this.panel1.Controls.Add(this.FB_Ok);
            this.panel1.Controls.Add(this.FB_Annuler);
            this.panel1.Controls.Add(this.RB_TousJoueurs);
            this.panel1.Controls.Add(this.RB_AjouterStats);
            this.panel1.Location = new System.Drawing.Point(4, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 143);
            this.panel1.TabIndex = 7;
            // 
            // CB_Equipe
            // 
            this.CB_Equipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Equipe.Enabled = false;
            this.CB_Equipe.FormattingEnabled = true;
            this.CB_Equipe.Location = new System.Drawing.Point(269, 60);
            this.CB_Equipe.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Equipe.Name = "CB_Equipe";
            this.CB_Equipe.Size = new System.Drawing.Size(143, 24);
            this.CB_Equipe.TabIndex = 10;
            this.CB_Equipe.Visible = false;
            this.CB_Equipe.SelectedIndexChanged += new System.EventHandler(this.CB_Equipe_SelectedIndexChanged);
            this.CB_Equipe.TextChanged += new System.EventHandler(this.CB_Equipe_TextChanged);
            // 
            // RB_JoueurEquipe
            // 
            this.RB_JoueurEquipe.AutoSize = true;
            this.RB_JoueurEquipe.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_JoueurEquipe.Location = new System.Drawing.Point(12, 94);
            this.RB_JoueurEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.RB_JoueurEquipe.Name = "RB_JoueurEquipe";
            this.RB_JoueurEquipe.Size = new System.Drawing.Size(252, 28);
            this.RB_JoueurEquipe.TabIndex = 9;
            this.RB_JoueurEquipe.TabStop = true;
            this.RB_JoueurEquipe.Text = "Afficher Joueurs/Équipes";
            this.RB_JoueurEquipe.UseVisualStyleBackColor = true;
            this.RB_JoueurEquipe.CheckedChanged += new System.EventHandler(this.RB_JoueurEquipe_CheckedChanged);
            // 
            // FB_Ok
            // 
            this.FB_Ok.BackgroundImage = global::HockeyIce.Properties.Resources.ContinuerNormal;
            this.FB_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ok.ImageClick = global::HockeyIce.Properties.Resources.ContinuerClick;
            this.FB_Ok.ImageDisable = global::HockeyIce.Properties.Resources.ContinuerDisable;
            this.FB_Ok.ImageNeutral = global::HockeyIce.Properties.Resources.ContinuerNormal;
            this.FB_Ok.ImageOver = global::HockeyIce.Properties.Resources.ContinuerHover;
            this.FB_Ok.Location = new System.Drawing.Point(427, 42);
            this.FB_Ok.Margin = new System.Windows.Forms.Padding(5);
            this.FB_Ok.Name = "FB_Ok";
            this.FB_Ok.Size = new System.Drawing.Size(136, 27);
            this.FB_Ok.TabIndex = 8;
            this.FB_Ok.Click += new System.EventHandler(this.FB_Ok_Click);
            // 
            // FB_Annuler
            // 
            this.FB_Annuler.BackgroundImage = global::HockeyIce.Properties.Resources.AnnulerNormal;
            this.FB_Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Annuler.ImageClick = global::HockeyIce.Properties.Resources.AnnulerClick;
            this.FB_Annuler.ImageDisable = global::HockeyIce.Properties.Resources.AnnulerDisable;
            this.FB_Annuler.ImageNeutral = global::HockeyIce.Properties.Resources.AnnulerNormal;
            this.FB_Annuler.ImageOver = global::HockeyIce.Properties.Resources.AnnulerHover;
            this.FB_Annuler.Location = new System.Drawing.Point(427, 77);
            this.FB_Annuler.Margin = new System.Windows.Forms.Padding(5);
            this.FB_Annuler.Name = "FB_Annuler";
            this.FB_Annuler.Size = new System.Drawing.Size(136, 25);
            this.FB_Annuler.TabIndex = 7;
            this.FB_Annuler.Click += new System.EventHandler(this.FB_Annuler_Click);
            // 
            // RB_TousJoueurs
            // 
            this.RB_TousJoueurs.AutoSize = true;
            this.RB_TousJoueurs.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_TousJoueurs.Location = new System.Drawing.Point(12, 58);
            this.RB_TousJoueurs.Margin = new System.Windows.Forms.Padding(4);
            this.RB_TousJoueurs.Name = "RB_TousJoueurs";
            this.RB_TousJoueurs.Size = new System.Drawing.Size(249, 28);
            this.RB_TousJoueurs.TabIndex = 1;
            this.RB_TousJoueurs.TabStop = true;
            this.RB_TousJoueurs.Text = "Afficher tous les Joueurs";
            this.RB_TousJoueurs.UseVisualStyleBackColor = true;
            this.RB_TousJoueurs.CheckedChanged += new System.EventHandler(this.RB_Afficher_CheckedChanged);
            // 
            // RB_AjouterStats
            // 
            this.RB_AjouterStats.AutoSize = true;
            this.RB_AjouterStats.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_AjouterStats.Location = new System.Drawing.Point(12, 24);
            this.RB_AjouterStats.Margin = new System.Windows.Forms.Padding(4);
            this.RB_AjouterStats.Name = "RB_AjouterStats";
            this.RB_AjouterStats.Size = new System.Drawing.Size(239, 28);
            this.RB_AjouterStats.TabIndex = 0;
            this.RB_AjouterStats.TabStop = true;
            this.RB_AjouterStats.Text = "Ajouter des Statistiques";
            this.RB_AjouterStats.UseVisualStyleBackColor = true;
            this.RB_AjouterStats.CheckedChanged += new System.EventHandler(this.RB_Ajouter_CheckedChanged);
            // 
            // CB_Invisible
            // 
            this.CB_Invisible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Invisible.Enabled = false;
            this.CB_Invisible.FormattingEnabled = true;
            this.CB_Invisible.Location = new System.Drawing.Point(274, 92);
            this.CB_Invisible.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Invisible.Name = "CB_Invisible";
            this.CB_Invisible.Size = new System.Drawing.Size(143, 24);
            this.CB_Invisible.TabIndex = 11;
            this.CB_Invisible.Visible = false;
            // 
            // FormChoixStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(582, 178);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_NomApp);
            this.Controls.Add(this.CB_Invisible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChoixStats";
            this.Text = "FormChoixStats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChoixStats_FormClosing);
            this.Load += new System.EventHandler(this.FormChoixStats_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormGestionStatistiqueJ_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormGestionStatistiqueJ_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormGestionStatistiqueJ_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Label LB_NomApp;
        private FlashButton.FlashButton FB_Fermer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RB_TousJoueurs;
        private System.Windows.Forms.RadioButton RB_AjouterStats;
        private FlashButton.FlashButton FB_Ok;
        private FlashButton.FlashButton FB_Annuler;
        private System.Windows.Forms.ComboBox CB_Equipe;
        private System.Windows.Forms.RadioButton RB_JoueurEquipe;
        private System.Windows.Forms.ComboBox CB_Invisible;
    }
}