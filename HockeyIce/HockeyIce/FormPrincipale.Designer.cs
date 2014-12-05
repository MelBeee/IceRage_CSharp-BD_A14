namespace HockeyIce
{
    partial class FormPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            this.LB_NomApp = new System.Windows.Forms.Label();
            this.PN_PasDeConnection = new System.Windows.Forms.Panel();
            this.PN_Erreur = new System.Windows.Forms.Panel();
            this.LB_MsgErreur = new System.Windows.Forms.Label();
            this.FB_QuitterPDC = new FlashButton.FlashButton();
            this.FB_TrouverEquipe = new FlashButton.FlashButton();
            this.FB_TrouverJoueur = new FlashButton.FlashButton();
            this.FB_TrouverMatch = new FlashButton.FlashButton();
            this.FB_AMatchs = new FlashButton.FlashButton();
            this.FB_AJoueurs = new FlashButton.FlashButton();
            this.FB_AEquipe = new FlashButton.FlashButton();
            this.FB_ADivision = new FlashButton.FlashButton();
            this.FB_CJoueurs = new FlashButton.FlashButton();
            this.FB_CEquipe = new FlashButton.FlashButton();
            this.FB_3MeilleursJs = new FlashButton.FlashButton();
            this.FB_APropos = new FlashButton.FlashButton();
            this.PB_Jeune = new System.Windows.Forms.PictureBox();
            this.PN_Gardien = new System.Windows.Forms.PictureBox();
            this.PN_Dessin = new System.Windows.Forms.PictureBox();
            this.PN_Patin = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.PB_Fond = new System.Windows.Forms.PictureBox();
            this.PN_PasDeConnection.SuspendLayout();
            this.PN_Erreur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Jeune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PN_Gardien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PN_Dessin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PN_Patin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fond)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_NomApp
            // 
            this.LB_NomApp.AutoSize = true;
            this.LB_NomApp.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NomApp.ForeColor = System.Drawing.Color.White;
            this.LB_NomApp.Location = new System.Drawing.Point(31, 2);
            this.LB_NomApp.Name = "LB_NomApp";
            this.LB_NomApp.Size = new System.Drawing.Size(97, 28);
            this.LB_NomApp.TabIndex = 2;
            this.LB_NomApp.Text = "Ice Rage";
            this.LB_NomApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_NomApp_MouseDown);
            this.LB_NomApp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_NomApp_MouseMove);
            this.LB_NomApp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_NomApp_MouseUp);
            // 
            // PN_PasDeConnection
            // 
            this.PN_PasDeConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.PN_PasDeConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_PasDeConnection.Controls.Add(this.PN_Erreur);
            this.PN_PasDeConnection.Location = new System.Drawing.Point(339, 242);
            this.PN_PasDeConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PN_PasDeConnection.Name = "PN_PasDeConnection";
            this.PN_PasDeConnection.Size = new System.Drawing.Size(343, 124);
            this.PN_PasDeConnection.TabIndex = 15;
            this.PN_PasDeConnection.Visible = false;
            // 
            // PN_Erreur
            // 
            this.PN_Erreur.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Erreur.Controls.Add(this.LB_MsgErreur);
            this.PN_Erreur.Controls.Add(this.FB_QuitterPDC);
            this.PN_Erreur.Location = new System.Drawing.Point(3, 2);
            this.PN_Erreur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PN_Erreur.Name = "PN_Erreur";
            this.PN_Erreur.Size = new System.Drawing.Size(336, 117);
            this.PN_Erreur.TabIndex = 0;
            // 
            // LB_MsgErreur
            // 
            this.LB_MsgErreur.AutoSize = true;
            this.LB_MsgErreur.Font = new System.Drawing.Font("Kristen ITC", 7.8F);
            this.LB_MsgErreur.ForeColor = System.Drawing.Color.Black;
            this.LB_MsgErreur.Location = new System.Drawing.Point(19, 27);
            this.LB_MsgErreur.Name = "LB_MsgErreur";
            this.LB_MsgErreur.Size = new System.Drawing.Size(280, 19);
            this.LB_MsgErreur.TabIndex = 2;
            this.LB_MsgErreur.Text = "Aucune connection, réessayer plus tard";
            // 
            // FB_QuitterPDC
            // 
            this.FB_QuitterPDC.BackgroundImage = global::HockeyIce.Properties.Resources.QuitterNormal;
            this.FB_QuitterPDC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_QuitterPDC.ImageClick = global::HockeyIce.Properties.Resources.QuitterClick;
            this.FB_QuitterPDC.ImageDisable = global::HockeyIce.Properties.Resources.QuitterDisable;
            this.FB_QuitterPDC.ImageNeutral = global::HockeyIce.Properties.Resources.QuitterNormal;
            this.FB_QuitterPDC.ImageOver = global::HockeyIce.Properties.Resources.QuitterHover;
            this.FB_QuitterPDC.Location = new System.Drawing.Point(113, 89);
            this.FB_QuitterPDC.Margin = new System.Windows.Forms.Padding(5);
            this.FB_QuitterPDC.Name = "FB_QuitterPDC";
            this.FB_QuitterPDC.Size = new System.Drawing.Size(100, 20);
            this.FB_QuitterPDC.TabIndex = 0;
            this.FB_QuitterPDC.Click += new System.EventHandler(this.FB_QuitterPDC_Click);
            // 
            // FB_TrouverEquipe
            // 
            this.FB_TrouverEquipe.BackgroundImage = global::HockeyIce.Properties.Resources.TrouverEquipe_Normal;
            this.FB_TrouverEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_TrouverEquipe.ImageClick = global::HockeyIce.Properties.Resources.TrouverEquipe_Click;
            this.FB_TrouverEquipe.ImageDisable = global::HockeyIce.Properties.Resources.TrouverEquipe_Disable;
            this.FB_TrouverEquipe.ImageNeutral = global::HockeyIce.Properties.Resources.TrouverEquipe_Normal;
            this.FB_TrouverEquipe.ImageOver = global::HockeyIce.Properties.Resources.TrouverEquipe_Hover;
            this.FB_TrouverEquipe.Location = new System.Drawing.Point(311, 433);
            this.FB_TrouverEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.FB_TrouverEquipe.Name = "FB_TrouverEquipe";
            this.FB_TrouverEquipe.Size = new System.Drawing.Size(125, 119);
            this.FB_TrouverEquipe.TabIndex = 26;
            this.FB_TrouverEquipe.Click += new System.EventHandler(this.FB_TrouverEquipe_Click);
            // 
            // FB_TrouverJoueur
            // 
            this.FB_TrouverJoueur.BackgroundImage = global::HockeyIce.Properties.Resources.TrouverJoueur_Normal;
            this.FB_TrouverJoueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_TrouverJoueur.ImageClick = global::HockeyIce.Properties.Resources.TrouverJoueur_Click;
            this.FB_TrouverJoueur.ImageDisable = global::HockeyIce.Properties.Resources.TrouverJoueur_Disable;
            this.FB_TrouverJoueur.ImageNeutral = global::HockeyIce.Properties.Resources.TrouverJoueur_Normal;
            this.FB_TrouverJoueur.ImageOver = global::HockeyIce.Properties.Resources.TrouverJoueur_Hover;
            this.FB_TrouverJoueur.Location = new System.Drawing.Point(31, 309);
            this.FB_TrouverJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.FB_TrouverJoueur.Name = "FB_TrouverJoueur";
            this.FB_TrouverJoueur.Size = new System.Drawing.Size(133, 120);
            this.FB_TrouverJoueur.TabIndex = 25;
            this.FB_TrouverJoueur.Click += new System.EventHandler(this.FB_TrouverJoueur_Click);
            // 
            // FB_TrouverMatch
            // 
            this.FB_TrouverMatch.BackgroundImage = global::HockeyIce.Properties.Resources.TrouverMatch_Normal;
            this.FB_TrouverMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_TrouverMatch.ImageClick = global::HockeyIce.Properties.Resources.TrouverMatch_Click;
            this.FB_TrouverMatch.ImageDisable = global::HockeyIce.Properties.Resources.TrouverMatch_Disable;
            this.FB_TrouverMatch.ImageNeutral = global::HockeyIce.Properties.Resources.TrouverMatch_Normal;
            this.FB_TrouverMatch.ImageOver = global::HockeyIce.Properties.Resources.TrouverMatch_Hover;
            this.FB_TrouverMatch.Location = new System.Drawing.Point(31, 433);
            this.FB_TrouverMatch.Margin = new System.Windows.Forms.Padding(4);
            this.FB_TrouverMatch.Name = "FB_TrouverMatch";
            this.FB_TrouverMatch.Size = new System.Drawing.Size(273, 119);
            this.FB_TrouverMatch.TabIndex = 24;
            this.FB_TrouverMatch.Click += new System.EventHandler(this.FB_TrouverMatch_Click);
            // 
            // FB_AMatchs
            // 
            this.FB_AMatchs.BackgroundImage = global::HockeyIce.Properties.Resources.AMatchs_Normal;
            this.FB_AMatchs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_AMatchs.ImageClick = global::HockeyIce.Properties.Resources.AMatchs_Click;
            this.FB_AMatchs.ImageDisable = global::HockeyIce.Properties.Resources.AMatchs_Disable;
            this.FB_AMatchs.ImageNeutral = global::HockeyIce.Properties.Resources.AMatchs_Normal;
            this.FB_AMatchs.ImageOver = global::HockeyIce.Properties.Resources.AMatchs_Hover;
            this.FB_AMatchs.Location = new System.Drawing.Point(171, 57);
            this.FB_AMatchs.Margin = new System.Windows.Forms.Padding(4);
            this.FB_AMatchs.Name = "FB_AMatchs";
            this.FB_AMatchs.Size = new System.Drawing.Size(133, 119);
            this.FB_AMatchs.TabIndex = 23;
            this.FB_AMatchs.Click += new System.EventHandler(this.FB_AMatchs_Click);
            // 
            // FB_AJoueurs
            // 
            this.FB_AJoueurs.BackgroundImage = global::HockeyIce.Properties.Resources.AJoueurs_Normal;
            this.FB_AJoueurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_AJoueurs.ImageClick = global::HockeyIce.Properties.Resources.AJoueurs_Click;
            this.FB_AJoueurs.ImageDisable = global::HockeyIce.Properties.Resources.AJoueurs_Disable;
            this.FB_AJoueurs.ImageNeutral = global::HockeyIce.Properties.Resources.AJoueurs_Normal;
            this.FB_AJoueurs.ImageOver = global::HockeyIce.Properties.Resources.AJoueurs_Hover;
            this.FB_AJoueurs.Location = new System.Drawing.Point(443, 181);
            this.FB_AJoueurs.Margin = new System.Windows.Forms.Padding(4);
            this.FB_AJoueurs.Name = "FB_AJoueurs";
            this.FB_AJoueurs.Size = new System.Drawing.Size(261, 122);
            this.FB_AJoueurs.TabIndex = 22;
            this.FB_AJoueurs.Click += new System.EventHandler(this.FB_AJoueurs_Click);
            // 
            // FB_AEquipe
            // 
            this.FB_AEquipe.BackgroundImage = global::HockeyIce.Properties.Resources.AEquipes_Normal;
            this.FB_AEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_AEquipe.ImageClick = global::HockeyIce.Properties.Resources.AEquipes_Click;
            this.FB_AEquipe.ImageDisable = global::HockeyIce.Properties.Resources.AEquipes_Disable;
            this.FB_AEquipe.ImageNeutral = global::HockeyIce.Properties.Resources.AEquipes_Normal;
            this.FB_AEquipe.ImageOver = global::HockeyIce.Properties.Resources.AEquipes_Hover;
            this.FB_AEquipe.Location = new System.Drawing.Point(171, 181);
            this.FB_AEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.FB_AEquipe.Name = "FB_AEquipe";
            this.FB_AEquipe.Size = new System.Drawing.Size(265, 122);
            this.FB_AEquipe.TabIndex = 21;
            this.FB_AEquipe.Click += new System.EventHandler(this.FB_AEquipe_Click);
            // 
            // FB_ADivision
            // 
            this.FB_ADivision.BackgroundImage = global::HockeyIce.Properties.Resources.ADivision_Normal;
            this.FB_ADivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_ADivision.ImageClick = global::HockeyIce.Properties.Resources.ADivision_Click;
            this.FB_ADivision.ImageDisable = global::HockeyIce.Properties.Resources.ADivision_Disable;
            this.FB_ADivision.ImageNeutral = global::HockeyIce.Properties.Resources.ADivision_Normal;
            this.FB_ADivision.ImageOver = global::HockeyIce.Properties.Resources.ADivision_Hover;
            this.FB_ADivision.Location = new System.Drawing.Point(311, 57);
            this.FB_ADivision.Margin = new System.Windows.Forms.Padding(4);
            this.FB_ADivision.Name = "FB_ADivision";
            this.FB_ADivision.Size = new System.Drawing.Size(259, 118);
            this.FB_ADivision.TabIndex = 20;
            this.FB_ADivision.Click += new System.EventHandler(this.FB_ADivision_Click);
            // 
            // FB_CJoueurs
            // 
            this.FB_CJoueurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FB_CJoueurs.BackgroundImage = global::HockeyIce.Properties.Resources.CJoueursNormal;
            this.FB_CJoueurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_CJoueurs.ImageClick = global::HockeyIce.Properties.Resources.CJoueursClick;
            this.FB_CJoueurs.ImageDisable = global::HockeyIce.Properties.Resources.CJoueursDisable;
            this.FB_CJoueurs.ImageNeutral = global::HockeyIce.Properties.Resources.CJoueursNormal;
            this.FB_CJoueurs.ImageOver = global::HockeyIce.Properties.Resources.CJoueursHover;
            this.FB_CJoueurs.Location = new System.Drawing.Point(849, 57);
            this.FB_CJoueurs.Margin = new System.Windows.Forms.Padding(5);
            this.FB_CJoueurs.Name = "FB_CJoueurs";
            this.FB_CJoueurs.Size = new System.Drawing.Size(133, 372);
            this.FB_CJoueurs.TabIndex = 19;
            this.FB_CJoueurs.Click += new System.EventHandler(this.FB_CJoueurs_Click);
            // 
            // FB_CEquipe
            // 
            this.FB_CEquipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FB_CEquipe.BackgroundImage = global::HockeyIce.Properties.Resources.CEquipeNormal;
            this.FB_CEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_CEquipe.ImageClick = global::HockeyIce.Properties.Resources.CEquipeClick;
            this.FB_CEquipe.ImageDisable = global::HockeyIce.Properties.Resources.CEquipeDisable;
            this.FB_CEquipe.ImageNeutral = global::HockeyIce.Properties.Resources.CEquipeNormal;
            this.FB_CEquipe.ImageOver = global::HockeyIce.Properties.Resources.CEquipeHover;
            this.FB_CEquipe.Location = new System.Drawing.Point(577, 309);
            this.FB_CEquipe.Margin = new System.Windows.Forms.Padding(5);
            this.FB_CEquipe.Name = "FB_CEquipe";
            this.FB_CEquipe.Size = new System.Drawing.Size(265, 119);
            this.FB_CEquipe.TabIndex = 18;
            this.FB_CEquipe.Click += new System.EventHandler(this.FB_CEquipe_Click);
            // 
            // FB_3MeilleursJs
            // 
            this.FB_3MeilleursJs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FB_3MeilleursJs.BackgroundImage = global::HockeyIce.Properties.Resources._3JoueursNormal;
            this.FB_3MeilleursJs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_3MeilleursJs.ImageClick = global::HockeyIce.Properties.Resources._3JoueursClick;
            this.FB_3MeilleursJs.ImageDisable = global::HockeyIce.Properties.Resources._3JoueursDisable;
            this.FB_3MeilleursJs.ImageNeutral = global::HockeyIce.Properties.Resources._3JoueursNormal;
            this.FB_3MeilleursJs.ImageOver = global::HockeyIce.Properties.Resources._3JoueursHover;
            this.FB_3MeilleursJs.Location = new System.Drawing.Point(709, 433);
            this.FB_3MeilleursJs.Margin = new System.Windows.Forms.Padding(5);
            this.FB_3MeilleursJs.Name = "FB_3MeilleursJs";
            this.FB_3MeilleursJs.Size = new System.Drawing.Size(273, 119);
            this.FB_3MeilleursJs.TabIndex = 17;
            this.FB_3MeilleursJs.Click += new System.EventHandler(this.FB_3MeilleursJs_Click);
            // 
            // FB_APropos
            // 
            this.FB_APropos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FB_APropos.BackgroundImage = global::HockeyIce.Properties.Resources.AideNormal;
            this.FB_APropos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_APropos.ImageClick = global::HockeyIce.Properties.Resources.AideClick;
            this.FB_APropos.ImageDisable = global::HockeyIce.Properties.Resources.AideDisable;
            this.FB_APropos.ImageNeutral = global::HockeyIce.Properties.Resources.AideNormal;
            this.FB_APropos.ImageOver = global::HockeyIce.Properties.Resources.AideHover;
            this.FB_APropos.Location = new System.Drawing.Point(31, 57);
            this.FB_APropos.Margin = new System.Windows.Forms.Padding(5);
            this.FB_APropos.Name = "FB_APropos";
            this.FB_APropos.Size = new System.Drawing.Size(133, 246);
            this.FB_APropos.TabIndex = 16;
            this.FB_APropos.Click += new System.EventHandler(this.FB_APropos_Click);
            // 
            // PB_Jeune
            // 
            this.PB_Jeune.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PB_Jeune.Image = global::HockeyIce.Properties.Resources.hockeyjeune;
            this.PB_Jeune.Location = new System.Drawing.Point(171, 309);
            this.PB_Jeune.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_Jeune.Name = "PB_Jeune";
            this.PB_Jeune.Size = new System.Drawing.Size(399, 120);
            this.PB_Jeune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Jeune.TabIndex = 13;
            this.PB_Jeune.TabStop = false;
            // 
            // PN_Gardien
            // 
            this.PN_Gardien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PN_Gardien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_Gardien.Image = global::HockeyIce.Properties.Resources.gardien;
            this.PN_Gardien.Location = new System.Drawing.Point(443, 433);
            this.PN_Gardien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PN_Gardien.Name = "PN_Gardien";
            this.PN_Gardien.Size = new System.Drawing.Size(261, 119);
            this.PN_Gardien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PN_Gardien.TabIndex = 12;
            this.PN_Gardien.TabStop = false;
            // 
            // PN_Dessin
            // 
            this.PN_Dessin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PN_Dessin.BackColor = System.Drawing.Color.White;
            this.PN_Dessin.Image = global::HockeyIce.Properties.Resources.hockey_cosom7_9;
            this.PN_Dessin.Location = new System.Drawing.Point(709, 181);
            this.PN_Dessin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PN_Dessin.Name = "PN_Dessin";
            this.PN_Dessin.Size = new System.Drawing.Size(133, 122);
            this.PN_Dessin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PN_Dessin.TabIndex = 11;
            this.PN_Dessin.TabStop = false;
            // 
            // PN_Patin
            // 
            this.PN_Patin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PN_Patin.Image = global::HockeyIce.Properties.Resources.Hockey;
            this.PN_Patin.Location = new System.Drawing.Point(577, 57);
            this.PN_Patin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PN_Patin.Name = "PN_Patin";
            this.PN_Patin.Size = new System.Drawing.Size(265, 119);
            this.PN_Patin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PN_Patin.TabIndex = 10;
            this.PN_Patin.TabStop = false;
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
            this.FB_Fermer.Location = new System.Drawing.Point(983, 4);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(5);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(27, 26);
            this.FB_Fermer.TabIndex = 4;
            this.FB_Fermer.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.PB_Logo.Location = new System.Drawing.Point(3, 4);
            this.PB_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(29, 26);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 3;
            this.PB_Logo.TabStop = false;
            // 
            // PB_Fond
            // 
            this.PB_Fond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Fond.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PB_Fond.Location = new System.Drawing.Point(3, 33);
            this.PB_Fond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PB_Fond.Name = "PB_Fond";
            this.PB_Fond.Size = new System.Drawing.Size(1007, 542);
            this.PB_Fond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Fond.TabIndex = 1;
            this.PB_Fond.TabStop = false;
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 578);
            this.Controls.Add(this.FB_TrouverEquipe);
            this.Controls.Add(this.FB_TrouverJoueur);
            this.Controls.Add(this.FB_TrouverMatch);
            this.Controls.Add(this.FB_AMatchs);
            this.Controls.Add(this.FB_AJoueurs);
            this.Controls.Add(this.FB_AEquipe);
            this.Controls.Add(this.FB_ADivision);
            this.Controls.Add(this.PN_PasDeConnection);
            this.Controls.Add(this.FB_CJoueurs);
            this.Controls.Add(this.FB_CEquipe);
            this.Controls.Add(this.FB_3MeilleursJs);
            this.Controls.Add(this.FB_APropos);
            this.Controls.Add(this.PB_Jeune);
            this.Controls.Add(this.PN_Gardien);
            this.Controls.Add(this.PN_Dessin);
            this.Controls.Add(this.PN_Patin);
            this.Controls.Add(this.FB_Fermer);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_NomApp);
            this.Controls.Add(this.PB_Fond);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipale";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipale_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPrincipale_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPrincipale_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormPrincipale_MouseUp);
            this.PN_PasDeConnection.ResumeLayout(false);
            this.PN_Erreur.ResumeLayout(false);
            this.PN_Erreur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Jeune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PN_Gardien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PN_Dessin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PN_Patin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Fond;
        private System.Windows.Forms.Label LB_NomApp;
        private System.Windows.Forms.PictureBox PB_Logo;
        private FlashButton.FlashButton FB_Fermer;
        private System.Windows.Forms.PictureBox PN_Patin;
        private System.Windows.Forms.PictureBox PN_Dessin;
        private System.Windows.Forms.PictureBox PN_Gardien;
        private System.Windows.Forms.PictureBox PB_Jeune;
        private System.Windows.Forms.Panel PN_PasDeConnection;
        private System.Windows.Forms.Panel PN_Erreur;
        private FlashButton.FlashButton FB_QuitterPDC;
        private System.Windows.Forms.Label LB_MsgErreur;
        private FlashButton.FlashButton FB_APropos;
        private FlashButton.FlashButton FB_3MeilleursJs;
        private FlashButton.FlashButton FB_CEquipe;
        private FlashButton.FlashButton FB_CJoueurs;
        private FlashButton.FlashButton FB_ADivision;
        private FlashButton.FlashButton FB_AEquipe;
        private FlashButton.FlashButton FB_AJoueurs;
        private FlashButton.FlashButton FB_AMatchs;
        private FlashButton.FlashButton FB_TrouverMatch;
        private FlashButton.FlashButton FB_TrouverJoueur;
        private FlashButton.FlashButton FB_TrouverEquipe;

    }
}

