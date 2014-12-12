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
            this.FB_Ok = new FlashButton.FlashButton();
            this.FB_Annuler = new FlashButton.FlashButton();
            this.RB_Afficher = new System.Windows.Forms.RadioButton();
            this.RB_Ajouter = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_NomApp
            // 
            this.LB_NomApp.AutoSize = true;
            this.LB_NomApp.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NomApp.ForeColor = System.Drawing.Color.White;
            this.LB_NomApp.Location = new System.Drawing.Point(24, 2);
            this.LB_NomApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_NomApp.Name = "LB_NomApp";
            this.LB_NomApp.Size = new System.Drawing.Size(104, 23);
            this.LB_NomApp.TabIndex = 4;
            this.LB_NomApp.Text = "Statistiques";
            this.LB_NomApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormGestionStatistiqueJ_MouseDown);
            this.LB_NomApp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormGestionStatistiqueJ_MouseMove);
            this.LB_NomApp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormGestionStatistiqueJ_MouseUp);
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
            this.FB_Fermer.Location = new System.Drawing.Point(333, 3);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(20, 21);
            this.FB_Fermer.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.FB_Ok);
            this.panel1.Controls.Add(this.FB_Annuler);
            this.panel1.Controls.Add(this.RB_Afficher);
            this.panel1.Controls.Add(this.RB_Ajouter);
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 80);
            this.panel1.TabIndex = 7;
            // 
            // FB_Ok
            // 
            this.FB_Ok.BackgroundImage = global::HockeyIce.Properties.Resources.ContinuerNormal;
            this.FB_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ok.ImageClick = global::HockeyIce.Properties.Resources.ContinuerClick;
            this.FB_Ok.ImageDisable = global::HockeyIce.Properties.Resources.ContinuerDisable;
            this.FB_Ok.ImageNeutral = global::HockeyIce.Properties.Resources.ContinuerNormal;
            this.FB_Ok.ImageOver = global::HockeyIce.Properties.Resources.ContinuerHover;
            this.FB_Ok.Location = new System.Drawing.Point(238, 16);
            this.FB_Ok.Name = "FB_Ok";
            this.FB_Ok.Size = new System.Drawing.Size(102, 22);
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
            this.FB_Annuler.Location = new System.Drawing.Point(238, 45);
            this.FB_Annuler.Name = "FB_Annuler";
            this.FB_Annuler.Size = new System.Drawing.Size(102, 20);
            this.FB_Annuler.TabIndex = 7;
            this.FB_Annuler.Click += new System.EventHandler(this.FB_Annuler_Click);
            // 
            // RB_Afficher
            // 
            this.RB_Afficher.AutoSize = true;
            this.RB_Afficher.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Afficher.Location = new System.Drawing.Point(9, 42);
            this.RB_Afficher.Name = "RB_Afficher";
            this.RB_Afficher.Size = new System.Drawing.Size(154, 22);
            this.RB_Afficher.TabIndex = 1;
            this.RB_Afficher.TabStop = true;
            this.RB_Afficher.Text = "Afficher les joueurs";
            this.RB_Afficher.UseVisualStyleBackColor = true;
            this.RB_Afficher.CheckedChanged += new System.EventHandler(this.RB_Afficher_CheckedChanged);
            // 
            // RB_Ajouter
            // 
            this.RB_Ajouter.AutoSize = true;
            this.RB_Ajouter.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Ajouter.Location = new System.Drawing.Point(9, 15);
            this.RB_Ajouter.Name = "RB_Ajouter";
            this.RB_Ajouter.Size = new System.Drawing.Size(180, 22);
            this.RB_Ajouter.TabIndex = 0;
            this.RB_Ajouter.TabStop = true;
            this.RB_Ajouter.Text = "Ajouter des statistiques";
            this.RB_Ajouter.UseVisualStyleBackColor = true;
            this.RB_Ajouter.CheckedChanged += new System.EventHandler(this.RB_Ajouter_CheckedChanged);
            // 
            // FormChoixStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(356, 108);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_NomApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.RadioButton RB_Afficher;
        private System.Windows.Forms.RadioButton RB_Ajouter;
        private FlashButton.FlashButton FB_Ok;
        private FlashButton.FlashButton FB_Annuler;
    }
}