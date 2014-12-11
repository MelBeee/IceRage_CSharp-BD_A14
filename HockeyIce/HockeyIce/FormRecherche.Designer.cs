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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.csadf56 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.f4g5d = new System.Windows.Forms.Label();
            this.sascfer = new System.Windows.Forms.Label();
            this.LB_Mailot = new System.Windows.Forms.Label();
            this.labrlds = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flashButton1 = new FlashButton.FlashButton();
            this.FB_FermerD = new FlashButton.FlashButton();
            this.PB_Equipe = new System.Windows.Forms.PictureBox();
            this.PB_Joueur = new System.Windows.Forms.PictureBox();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.flashButton2 = new FlashButton.FlashButton();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.LB_Prenom = new System.Windows.Forms.Label();
            this.LB_Type = new System.Windows.Forms.Label();
            this.LB_DateNais = new System.Windows.Forms.Label();
            this.LB_But = new System.Windows.Forms.Label();
            this.LB_Punition = new System.Windows.Forms.Label();
            this.LB_Passe = new System.Windows.Forms.Label();
            this.LB_Tempo = new System.Windows.Forms.Label();
            this.LB_Tempo2 = new System.Windows.Forms.Label();
            this.PN_Equipe.SuspendLayout();
            this.PN_Matchs.SuspendLayout();
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
            this.PN_Equipe.Location = new System.Drawing.Point(307, 385);
            this.PN_Equipe.Margin = new System.Windows.Forms.Padding(2);
            this.PN_Equipe.Name = "PN_Equipe";
            this.PN_Equipe.Size = new System.Drawing.Size(537, 403);
            this.PN_Equipe.TabIndex = 8;
            this.PN_Equipe.Visible = false;
            // 
            // PN_Matchs
            // 
            this.PN_Matchs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Matchs.Controls.Add(this.button1);
            this.PN_Matchs.Enabled = false;
            this.PN_Matchs.Location = new System.Drawing.Point(52, 37);
            this.PN_Matchs.Margin = new System.Windows.Forms.Padding(2);
            this.PN_Matchs.Name = "PN_Matchs";
            this.PN_Matchs.Size = new System.Drawing.Size(537, 403);
            this.PN_Matchs.TabIndex = 9;
            this.PN_Matchs.Visible = false;
            // 
            // PN_Joueurs
            // 
            this.PN_Joueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Joueurs.Controls.Add(this.LB_Tempo2);
            this.PN_Joueurs.Controls.Add(this.LB_Tempo);
            this.PN_Joueurs.Controls.Add(this.LB_Type);
            this.PN_Joueurs.Controls.Add(this.LB_DateNais);
            this.PN_Joueurs.Controls.Add(this.LB_Prenom);
            this.PN_Joueurs.Controls.Add(this.LB_Nom);
            this.PN_Joueurs.Controls.Add(this.flashButton2);
            this.PN_Joueurs.Controls.Add(this.flashButton1);
            this.PN_Joueurs.Controls.Add(this.FB_FermerD);
            this.PN_Joueurs.Controls.Add(this.groupBox1);
            this.PN_Joueurs.Controls.Add(this.sascfer);
            this.PN_Joueurs.Controls.Add(this.PB_Equipe);
            this.PN_Joueurs.Controls.Add(this.LB_Mailot);
            this.PN_Joueurs.Controls.Add(this.PB_Joueur);
            this.PN_Joueurs.Controls.Add(this.labrlds);
            this.PN_Joueurs.Enabled = false;
            this.PN_Joueurs.Location = new System.Drawing.Point(2, 29);
            this.PN_Joueurs.Margin = new System.Windows.Forms.Padding(2);
            this.PN_Joueurs.Name = "PN_Joueurs";
            this.PN_Joueurs.Size = new System.Drawing.Size(371, 255);
            this.PN_Joueurs.TabIndex = 9;
            this.PN_Joueurs.Visible = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flashButton1
            // 
            this.flashButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flashButton1.BackgroundImage = global::HockeyIce.Properties.Resources.RetourNormal;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton1.ImageClick = global::HockeyIce.Properties.Resources.RetourClick;
            this.flashButton1.ImageDisable = global::HockeyIce.Properties.Resources.RetourDisable;
            this.flashButton1.ImageNeutral = global::HockeyIce.Properties.Resources.RetourNormal;
            this.flashButton1.ImageOver = global::HockeyIce.Properties.Resources.RetourHover;
            this.flashButton1.Location = new System.Drawing.Point(57, 226);
            this.flashButton1.Margin = new System.Windows.Forms.Padding(4);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.Size = new System.Drawing.Size(20, 21);
            this.flashButton1.TabIndex = 10;
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
            // PB_Joueur
            // 
            this.PB_Joueur.Image = global::HockeyIce.Properties.Resources.Burns;
            this.PB_Joueur.Location = new System.Drawing.Point(10, 10);
            this.PB_Joueur.Name = "PB_Joueur";
            this.PB_Joueur.Size = new System.Drawing.Size(140, 210);
            this.PB_Joueur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Joueur.TabIndex = 1;
            this.PB_Joueur.TabStop = false;
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
            this.FB_Fermer.Location = new System.Drawing.Point(353, 4);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(20, 21);
            this.FB_Fermer.TabIndex = 5;
            this.FB_Fermer.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // flashButton2
            // 
            this.flashButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flashButton2.BackgroundImage = global::HockeyIce.Properties.Resources.RetourNormalDoite;
            this.flashButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton2.ImageClick = global::HockeyIce.Properties.Resources.RetourClickDoite;
            this.flashButton2.ImageDisable = global::HockeyIce.Properties.Resources.RetourDisableDoite;
            this.flashButton2.ImageNeutral = global::HockeyIce.Properties.Resources.RetourNormalDoite;
            this.flashButton2.ImageOver = global::HockeyIce.Properties.Resources.RetourHoverDoite;
            this.flashButton2.Location = new System.Drawing.Point(85, 226);
            this.flashButton2.Margin = new System.Windows.Forms.Padding(4);
            this.flashButton2.Name = "flashButton2";
            this.flashButton2.Size = new System.Drawing.Size(20, 21);
            this.flashButton2.TabIndex = 13;
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
            // LB_Prenom
            // 
            this.LB_Prenom.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Prenom.Location = new System.Drawing.Point(244, 13);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(116, 18);
            this.LB_Prenom.TabIndex = 15;
            this.LB_Prenom.Text = "Jaroslav";
            // 
            // LB_Type
            // 
            this.LB_Type.AutoSize = true;
            this.LB_Type.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Type.Location = new System.Drawing.Point(260, 102);
            this.LB_Type.Name = "LB_Type";
            this.LB_Type.Size = new System.Drawing.Size(76, 18);
            this.LB_Type.TabIndex = 17;
            this.LB_Type.Text = "Attaquant";
            // 
            // LB_DateNais
            // 
            this.LB_DateNais.AutoSize = true;
            this.LB_DateNais.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DateNais.Location = new System.Drawing.Point(260, 79);
            this.LB_DateNais.Name = "LB_DateNais";
            this.LB_DateNais.Size = new System.Drawing.Size(91, 18);
            this.LB_DateNais.TabIndex = 16;
            this.LB_DateNais.Text = "3 fevrier 1923";
            // 
            // LB_But
            // 
            this.LB_But.AutoSize = true;
            this.LB_But.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_But.Location = new System.Drawing.Point(79, 23);
            this.LB_But.Name = "LB_But";
            this.LB_But.Size = new System.Drawing.Size(21, 18);
            this.LB_But.TabIndex = 11;
            this.LB_But.Text = "12";
            // 
            // LB_Punition
            // 
            this.LB_Punition.AutoSize = true;
            this.LB_Punition.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Punition.Location = new System.Drawing.Point(79, 60);
            this.LB_Punition.Name = "LB_Punition";
            this.LB_Punition.Size = new System.Drawing.Size(89, 18);
            this.LB_Punition.TabIndex = 13;
            this.LB_Punition.Text = "324 secondes";
            // 
            // LB_Passe
            // 
            this.LB_Passe.AutoSize = true;
            this.LB_Passe.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Passe.Location = new System.Drawing.Point(79, 41);
            this.LB_Passe.Name = "LB_Passe";
            this.LB_Passe.Size = new System.Drawing.Size(20, 18);
            this.LB_Passe.TabIndex = 12;
            this.LB_Passe.Text = "14";
            // 
            // LB_Tempo
            // 
            this.LB_Tempo.AutoSize = true;
            this.LB_Tempo.Location = new System.Drawing.Point(260, 120);
            this.LB_Tempo.Name = "LB_Tempo";
            this.LB_Tempo.Size = new System.Drawing.Size(35, 13);
            this.LB_Tempo.TabIndex = 18;
            this.LB_Tempo.Text = "label2";
            // 
            // LB_Tempo2
            // 
            this.LB_Tempo2.AutoSize = true;
            this.LB_Tempo2.Location = new System.Drawing.Point(219, 118);
            this.LB_Tempo2.Name = "LB_Tempo2";
            this.LB_Tempo2.Size = new System.Drawing.Size(35, 13);
            this.LB_Tempo2.TabIndex = 19;
            this.LB_Tempo2.Text = "label2";
            // 
            // FormRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(999, 506);
            this.Controls.Add(this.PN_Joueurs);
            this.Controls.Add(this.PN_Equipe);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.FB_Fermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRecherche";
            this.Text = "FormRecherche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRecherche_FormClosing);
            this.Load += new System.EventHandler(this.FormRecherche_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRecherche_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormRecherche_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormRecherche_MouseUp);
            this.PN_Equipe.ResumeLayout(false);
            this.PN_Matchs.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PB_Joueur;
        private System.Windows.Forms.Label sascfer;
        private System.Windows.Forms.Label LB_Mailot;
        private System.Windows.Forms.Label labrlds;
        private System.Windows.Forms.Label csadf56;
        private System.Windows.Forms.Label f4g5d;
        private System.Windows.Forms.PictureBox PB_Equipe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private FlashButton.FlashButton flashButton1;
        private FlashButton.FlashButton FB_FermerD;
        private FlashButton.FlashButton flashButton2;
        private System.Windows.Forms.Label LB_Type;
        private System.Windows.Forms.Label LB_DateNais;
        private System.Windows.Forms.Label LB_Prenom;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Label LB_But;
        private System.Windows.Forms.Label LB_Punition;
        private System.Windows.Forms.Label LB_Passe;
        private System.Windows.Forms.Label LB_Tempo;
        private System.Windows.Forms.Label LB_Tempo2;
    }
}