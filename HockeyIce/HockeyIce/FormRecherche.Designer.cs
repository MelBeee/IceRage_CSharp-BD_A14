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
            this.LB_Text = new System.Windows.Forms.Label();
            this.PN_Equipe = new System.Windows.Forms.Panel();
            this.PN_Matchs = new System.Windows.Forms.Panel();
            this.PN_Joueurs = new System.Windows.Forms.Panel();
            this.LB_Type = new System.Windows.Forms.Label();
            this.LB_DateNais = new System.Windows.Forms.Label();
            this.LB_Prenom = new System.Windows.Forms.Label();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.FB_Next = new FlashButton.FlashButton();
            this.FB_Back = new FlashButton.FlashButton();
            this.FB_FermerD = new FlashButton.FlashButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_But = new System.Windows.Forms.Label();
            this.LB_Punition = new System.Windows.Forms.Label();
            this.LB_Passe = new System.Windows.Forms.Label();
            this.csadf56 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.f4g5d = new System.Windows.Forms.Label();
            this.sascfer = new System.Windows.Forms.Label();
            this.PB_Equipe = new System.Windows.Forms.PictureBox();
            this.LB_Mailot = new System.Windows.Forms.Label();
            this.PB_Joueur = new System.Windows.Forms.PictureBox();
            this.labrlds = new System.Windows.Forms.Label();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.LB_Tempo = new System.Windows.Forms.Label();
            this.DTP_Tempo = new System.Windows.Forms.DateTimePicker();
            this.LB_Tempo2 = new System.Windows.Forms.Label();
            this.LB_NumJoueur = new System.Windows.Forms.Label();
            this.PN_Joueurs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Joueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(28, 3);
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
            this.PN_Equipe.Enabled = false;
            this.PN_Equipe.Location = new System.Drawing.Point(377, 28);
            this.PN_Equipe.Margin = new System.Windows.Forms.Padding(2);
            this.PN_Equipe.Name = "PN_Equipe";
            this.PN_Equipe.Size = new System.Drawing.Size(371, 255);
            this.PN_Equipe.TabIndex = 8;
            this.PN_Equipe.Visible = false;
            // 
            // PN_Matchs
            // 
            this.PN_Matchs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Matchs.Enabled = false;
            this.PN_Matchs.Location = new System.Drawing.Point(2, 287);
            this.PN_Matchs.Margin = new System.Windows.Forms.Padding(2);
            this.PN_Matchs.Name = "PN_Matchs";
            this.PN_Matchs.Size = new System.Drawing.Size(371, 255);
            this.PN_Matchs.TabIndex = 9;
            this.PN_Matchs.Visible = false;
            // 
            // PN_Joueurs
            // 
            this.PN_Joueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Joueurs.Controls.Add(this.LB_Type);
            this.PN_Joueurs.Controls.Add(this.LB_DateNais);
            this.PN_Joueurs.Controls.Add(this.LB_Prenom);
            this.PN_Joueurs.Controls.Add(this.LB_Nom);
            this.PN_Joueurs.Controls.Add(this.FB_Next);
            this.PN_Joueurs.Controls.Add(this.FB_Back);
            this.PN_Joueurs.Controls.Add(this.FB_FermerD);
            this.PN_Joueurs.Controls.Add(this.groupBox1);
            this.PN_Joueurs.Controls.Add(this.sascfer);
            this.PN_Joueurs.Controls.Add(this.PB_Equipe);
            this.PN_Joueurs.Controls.Add(this.LB_Mailot);
            this.PN_Joueurs.Controls.Add(this.PB_Joueur);
            this.PN_Joueurs.Controls.Add(this.labrlds);
            this.PN_Joueurs.Enabled = false;
            this.PN_Joueurs.Location = new System.Drawing.Point(2, 26);
            this.PN_Joueurs.Margin = new System.Windows.Forms.Padding(2);
            this.PN_Joueurs.Name = "PN_Joueurs";
            this.PN_Joueurs.Size = new System.Drawing.Size(371, 255);
            this.PN_Joueurs.TabIndex = 9;
            this.PN_Joueurs.Visible = false;
            // 
            // LB_Type
            // 
            this.LB_Type.AutoSize = true;
            this.LB_Type.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Type.Location = new System.Drawing.Point(249, 102);
            this.LB_Type.Name = "LB_Type";
            this.LB_Type.Size = new System.Drawing.Size(76, 18);
            this.LB_Type.TabIndex = 17;
            this.LB_Type.Text = "Attaquant";
            // 
            // LB_DateNais
            // 
            this.LB_DateNais.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DateNais.Location = new System.Drawing.Point(249, 79);
            this.LB_DateNais.Name = "LB_DateNais";
            this.LB_DateNais.Size = new System.Drawing.Size(111, 18);
            this.LB_DateNais.TabIndex = 16;
            this.LB_DateNais.Text = "3 fevrier 1923";
            // 
            // LB_Prenom
            // 
            this.LB_Prenom.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Prenom.Location = new System.Drawing.Point(244, 13);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(116, 18);
            this.LB_Prenom.TabIndex = 15;
            this.LB_Prenom.Text = "Jaroslav";
            // 
            // LB_Nom
            // 
            this.LB_Nom.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nom.Location = new System.Drawing.Point(244, 35);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(116, 18);
            this.LB_Nom.TabIndex = 14;
            this.LB_Nom.Text = "Halak";
            // 
            // FB_Next
            // 
            this.FB_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Next.BackgroundImage = global::HockeyIce.Properties.Resources.RetourNormalDoite;
            this.FB_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Next.ImageClick = global::HockeyIce.Properties.Resources.RetourClickDoite;
            this.FB_Next.ImageDisable = global::HockeyIce.Properties.Resources.RetourDisableDoite;
            this.FB_Next.ImageNeutral = global::HockeyIce.Properties.Resources.RetourNormalDoite;
            this.FB_Next.ImageOver = global::HockeyIce.Properties.Resources.RetourHoverDoite;
            this.FB_Next.Location = new System.Drawing.Point(85, 226);
            this.FB_Next.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Next.Name = "FB_Next";
            this.FB_Next.Size = new System.Drawing.Size(20, 21);
            this.FB_Next.TabIndex = 13;
            this.FB_Next.Click += new System.EventHandler(this.FB_Next_Click);
            // 
            // FB_Back
            // 
            this.FB_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Back.BackgroundImage = global::HockeyIce.Properties.Resources.RetourNormal;
            this.FB_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Back.ImageClick = global::HockeyIce.Properties.Resources.RetourClick;
            this.FB_Back.ImageDisable = global::HockeyIce.Properties.Resources.RetourDisable;
            this.FB_Back.ImageNeutral = global::HockeyIce.Properties.Resources.RetourNormal;
            this.FB_Back.ImageOver = global::HockeyIce.Properties.Resources.RetourHover;
            this.FB_Back.Location = new System.Drawing.Point(57, 226);
            this.FB_Back.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Back.Name = "FB_Back";
            this.FB_Back.Size = new System.Drawing.Size(20, 21);
            this.FB_Back.TabIndex = 10;
            this.FB_Back.Click += new System.EventHandler(this.FB_Back_Click);
            // 
            // FB_FermerD
            // 
            this.FB_FermerD.BackgroundImage = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_FermerD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_FermerD.ImageClick = global::HockeyIce.Properties.Resources.FermerClick;
            this.FB_FermerD.ImageDisable = global::HockeyIce.Properties.Resources.FermerDisable;
            this.FB_FermerD.ImageNeutral = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_FermerD.ImageOver = global::HockeyIce.Properties.Resources.FermerHover;
            this.FB_FermerD.Location = new System.Drawing.Point(258, 227);
            this.FB_FermerD.Margin = new System.Windows.Forms.Padding(4);
            this.FB_FermerD.Name = "FB_FermerD";
            this.FB_FermerD.Size = new System.Drawing.Size(102, 19);
            this.FB_FermerD.TabIndex = 12;
            this.FB_FermerD.Click += new System.EventHandler(this.FB_FermerD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_But);
            this.groupBox1.Controls.Add(this.LB_Punition);
            this.groupBox1.Controls.Add(this.LB_Passe);
            this.groupBox1.Controls.Add(this.csadf56);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.f4g5d);
            this.groupBox1.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(160, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 86);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistiques";
            // 
            // LB_But
            // 
            this.LB_But.AutoSize = true;
            this.LB_But.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_But.Location = new System.Drawing.Point(79, 23);
            this.LB_But.Name = "LB_But";
            this.LB_But.Size = new System.Drawing.Size(16, 18);
            this.LB_But.TabIndex = 11;
            this.LB_But.Text = "0";
            // 
            // LB_Punition
            // 
            this.LB_Punition.AutoSize = true;
            this.LB_Punition.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Punition.Location = new System.Drawing.Point(79, 60);
            this.LB_Punition.Name = "LB_Punition";
            this.LB_Punition.Size = new System.Drawing.Size(78, 18);
            this.LB_Punition.TabIndex = 13;
            this.LB_Punition.Text = "0 secondes";
            // 
            // LB_Passe
            // 
            this.LB_Passe.AutoSize = true;
            this.LB_Passe.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Passe.Location = new System.Drawing.Point(79, 41);
            this.LB_Passe.Name = "LB_Passe";
            this.LB_Passe.Size = new System.Drawing.Size(16, 18);
            this.LB_Passe.TabIndex = 12;
            this.LB_Passe.Text = "0";
            // 
            // csadf56
            // 
            this.csadf56.AutoSize = true;
            this.csadf56.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csadf56.Location = new System.Drawing.Point(6, 23);
            this.csadf56.Name = "csadf56";
            this.csadf56.Size = new System.Drawing.Size(39, 18);
            this.csadf56.TabIndex = 4;
            this.csadf56.Text = "But :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Punition :";
            // 
            // f4g5d
            // 
            this.f4g5d.AutoSize = true;
            this.f4g5d.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4g5d.Location = new System.Drawing.Point(6, 41);
            this.f4g5d.Name = "f4g5d";
            this.f4g5d.Size = new System.Drawing.Size(51, 18);
            this.f4g5d.TabIndex = 5;
            this.f4g5d.Text = "Passe :";
            // 
            // sascfer
            // 
            this.sascfer.AutoSize = true;
            this.sascfer.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sascfer.Location = new System.Drawing.Point(156, 102);
            this.sascfer.Name = "sascfer";
            this.sascfer.Size = new System.Drawing.Size(69, 18);
            this.sascfer.TabIndex = 8;
            this.sascfer.Text = "Position :";
            // 
            // PB_Equipe
            // 
            this.PB_Equipe.Image = global::HockeyIce.Properties.Resources._1280px_Montreal_Canadiens_svg;
            this.PB_Equipe.Location = new System.Drawing.Point(156, 10);
            this.PB_Equipe.Name = "PB_Equipe";
            this.PB_Equipe.Size = new System.Drawing.Size(87, 51);
            this.PB_Equipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Equipe.TabIndex = 9;
            this.PB_Equipe.TabStop = false;
            // 
            // LB_Mailot
            // 
            this.LB_Mailot.AutoSize = true;
            this.LB_Mailot.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Mailot.ForeColor = System.Drawing.Color.White;
            this.LB_Mailot.Location = new System.Drawing.Point(91, 184);
            this.LB_Mailot.Name = "LB_Mailot";
            this.LB_Mailot.Size = new System.Drawing.Size(59, 36);
            this.LB_Mailot.TabIndex = 7;
            this.LB_Mailot.Text = "#21";
            // 
            // PB_Joueur
            // 
            this.PB_Joueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Joueur.ErrorImage = global::HockeyIce.Properties.Resources.no_photo_available;
            this.PB_Joueur.Image = global::HockeyIce.Properties.Resources.Burns;
            this.PB_Joueur.InitialImage = global::HockeyIce.Properties.Resources.no_photo_available;
            this.PB_Joueur.Location = new System.Drawing.Point(10, 10);
            this.PB_Joueur.Name = "PB_Joueur";
            this.PB_Joueur.Size = new System.Drawing.Size(140, 210);
            this.PB_Joueur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Joueur.TabIndex = 1;
            this.PB_Joueur.TabStop = false;
            // 
            // labrlds
            // 
            this.labrlds.AutoSize = true;
            this.labrlds.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labrlds.Location = new System.Drawing.Point(156, 79);
            this.labrlds.Name = "labrlds";
            this.labrlds.Size = new System.Drawing.Size(98, 18);
            this.labrlds.TabIndex = 6;
            this.labrlds.Text = "Anniversaire :";
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.PB_Logo.Location = new System.Drawing.Point(2, 4);
            this.PB_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(22, 21);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 7;
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
            this.FB_Fermer.Location = new System.Drawing.Point(353, 3);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(20, 22);
            this.FB_Fermer.TabIndex = 5;
            this.FB_Fermer.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // LB_Tempo
            // 
            this.LB_Tempo.AutoSize = true;
            this.LB_Tempo.Location = new System.Drawing.Point(29, 98);
            this.LB_Tempo.Name = "LB_Tempo";
            this.LB_Tempo.Size = new System.Drawing.Size(35, 13);
            this.LB_Tempo.TabIndex = 18;
            this.LB_Tempo.Text = "label2";
            // 
            // DTP_Tempo
            // 
            this.DTP_Tempo.Location = new System.Drawing.Point(24, 75);
            this.DTP_Tempo.Name = "DTP_Tempo";
            this.DTP_Tempo.Size = new System.Drawing.Size(92, 20);
            this.DTP_Tempo.TabIndex = 19;
            // 
            // LB_Tempo2
            // 
            this.LB_Tempo2.AutoSize = true;
            this.LB_Tempo2.Location = new System.Drawing.Point(29, 59);
            this.LB_Tempo2.Name = "LB_Tempo2";
            this.LB_Tempo2.Size = new System.Drawing.Size(35, 13);
            this.LB_Tempo2.TabIndex = 20;
            this.LB_Tempo2.Text = "label2";
            // 
            // LB_NumJoueur
            // 
            this.LB_NumJoueur.AutoSize = true;
            this.LB_NumJoueur.Location = new System.Drawing.Point(24, 43);
            this.LB_NumJoueur.Name = "LB_NumJoueur";
            this.LB_NumJoueur.Size = new System.Drawing.Size(35, 13);
            this.LB_NumJoueur.TabIndex = 21;
            this.LB_NumJoueur.Text = "label2";
            // 
            // FormRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(377, 286);
            this.Controls.Add(this.PN_Matchs);
            this.Controls.Add(this.PN_Joueurs);
            this.Controls.Add(this.PN_Equipe);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.LB_NumJoueur);
            this.Controls.Add(this.LB_Tempo2);
            this.Controls.Add(this.DTP_Tempo);
            this.Controls.Add(this.LB_Tempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRecherche";
            this.Text = "FormRecherche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRecherche_FormClosing);
            this.Load += new System.EventHandler(this.FormRecherche_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRecherche_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormRecherche_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormRecherche_MouseUp);
            this.PN_Joueurs.ResumeLayout(false);
            this.PN_Joueurs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Joueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
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
        private System.Windows.Forms.PictureBox PB_Joueur;
        private System.Windows.Forms.Label sascfer;
        private System.Windows.Forms.Label LB_Mailot;
        private System.Windows.Forms.Label labrlds;
        private System.Windows.Forms.Label csadf56;
        private System.Windows.Forms.Label f4g5d;
        private System.Windows.Forms.PictureBox PB_Equipe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private FlashButton.FlashButton FB_Back;
        private FlashButton.FlashButton FB_FermerD;
        private FlashButton.FlashButton FB_Next;
        private System.Windows.Forms.Label LB_Type;
        private System.Windows.Forms.Label LB_DateNais;
        private System.Windows.Forms.Label LB_Prenom;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Label LB_But;
        private System.Windows.Forms.Label LB_Punition;
        private System.Windows.Forms.Label LB_Passe;
        private System.Windows.Forms.Label LB_Tempo;
        private System.Windows.Forms.DateTimePicker DTP_Tempo;
        private System.Windows.Forms.Label LB_Tempo2;
        private System.Windows.Forms.Label LB_NumJoueur;
    }
}