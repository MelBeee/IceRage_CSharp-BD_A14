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
            this.DGV_JoueurList = new System.Windows.Forms.DataGridView();
            this.PN_3Joueurs = new System.Windows.Forms.Panel();
            this.PB_Photo_Bronze = new System.Windows.Forms.PictureBox();
            this.PB_Photo_Gold = new System.Windows.Forms.PictureBox();
            this.PB_Photo_Silver = new System.Windows.Forms.PictureBox();
            this.PB_EquipeSilver = new System.Windows.Forms.PictureBox();
            this.PB_EquipeGold = new System.Windows.Forms.PictureBox();
            this.LB_NomSilver = new System.Windows.Forms.Label();
            this.LB_NumeroSilver = new System.Windows.Forms.Label();
            this.LB_PointsSilver = new System.Windows.Forms.Label();
            this.LB_PositionSilver = new System.Windows.Forms.Label();
            this.LB_PrenomSilver = new System.Windows.Forms.Label();
            this.LB_NomGold = new System.Windows.Forms.Label();
            this.LB_NumeroGold = new System.Windows.Forms.Label();
            this.LB_PointsGold = new System.Windows.Forms.Label();
            this.LB_PositionGold = new System.Windows.Forms.Label();
            this.LB_PrenomGold = new System.Windows.Forms.Label();
            this.PB_EquipeBronze = new System.Windows.Forms.PictureBox();
            this.LB_NomBronze = new System.Windows.Forms.Label();
            this.LB_NumeroBronze = new System.Windows.Forms.Label();
            this.LB_PointsBronze = new System.Windows.Forms.Label();
            this.LB_PositionBronze = new System.Windows.Forms.Label();
            this.LB_PrenomBronze = new System.Windows.Forms.Label();
            this.PB_Podium = new System.Windows.Forms.PictureBox();
            this.PN_CEquipe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.PhotoJoueur = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMveste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pointage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipe = new System.Windows.Forms.DataGridViewImageColumn();
            this.PN_CJoueurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_JoueurList)).BeginInit();
            this.PN_3Joueurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo_Bronze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo_Gold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo_Silver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeBronze)).BeginInit();
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
            this.PN_CJoueurs.Controls.Add(this.DGV_JoueurList);
            this.PN_CJoueurs.Enabled = false;
            this.PN_CJoueurs.Location = new System.Drawing.Point(4, 30);
            this.PN_CJoueurs.Margin = new System.Windows.Forms.Padding(2);
            this.PN_CJoueurs.Name = "PN_CJoueurs";
            this.PN_CJoueurs.Size = new System.Drawing.Size(673, 397);
            this.PN_CJoueurs.TabIndex = 10;
            this.PN_CJoueurs.Visible = false;
            // 
            // DGV_JoueurList
            // 
            this.DGV_JoueurList.AllowUserToAddRows = false;
            this.DGV_JoueurList.AllowUserToDeleteRows = false;
            this.DGV_JoueurList.AllowUserToOrderColumns = true;
            this.DGV_JoueurList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_JoueurList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_JoueurList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_JoueurList.ColumnHeadersVisible = false;
            this.DGV_JoueurList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhotoJoueur,
            this.Nom,
            this.Prenom,
            this.NUMveste,
            this.TypePosition,
            this.Pointage,
            this.Equipe});
            this.DGV_JoueurList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_JoueurList.Location = new System.Drawing.Point(0, 0);
            this.DGV_JoueurList.Name = "DGV_JoueurList";
            this.DGV_JoueurList.ReadOnly = true;
            this.DGV_JoueurList.RowHeadersVisible = false;
            this.DGV_JoueurList.RowTemplate.Height = 50;
            this.DGV_JoueurList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_JoueurList.Size = new System.Drawing.Size(673, 397);
            this.DGV_JoueurList.TabIndex = 0;
            // 
            // PN_3Joueurs
            // 
            this.PN_3Joueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_3Joueurs.Controls.Add(this.PB_Photo_Bronze);
            this.PN_3Joueurs.Controls.Add(this.PB_Photo_Gold);
            this.PN_3Joueurs.Controls.Add(this.PB_Photo_Silver);
            this.PN_3Joueurs.Controls.Add(this.PB_EquipeSilver);
            this.PN_3Joueurs.Controls.Add(this.PB_EquipeGold);
            this.PN_3Joueurs.Controls.Add(this.LB_NomSilver);
            this.PN_3Joueurs.Controls.Add(this.LB_NumeroSilver);
            this.PN_3Joueurs.Controls.Add(this.LB_PointsSilver);
            this.PN_3Joueurs.Controls.Add(this.LB_PositionSilver);
            this.PN_3Joueurs.Controls.Add(this.LB_PrenomSilver);
            this.PN_3Joueurs.Controls.Add(this.LB_NomGold);
            this.PN_3Joueurs.Controls.Add(this.LB_NumeroGold);
            this.PN_3Joueurs.Controls.Add(this.LB_PointsGold);
            this.PN_3Joueurs.Controls.Add(this.LB_PositionGold);
            this.PN_3Joueurs.Controls.Add(this.LB_PrenomGold);
            this.PN_3Joueurs.Controls.Add(this.PB_EquipeBronze);
            this.PN_3Joueurs.Controls.Add(this.LB_NomBronze);
            this.PN_3Joueurs.Controls.Add(this.LB_NumeroBronze);
            this.PN_3Joueurs.Controls.Add(this.LB_PointsBronze);
            this.PN_3Joueurs.Controls.Add(this.LB_PositionBronze);
            this.PN_3Joueurs.Controls.Add(this.LB_PrenomBronze);
            this.PN_3Joueurs.Controls.Add(this.PB_Podium);
            this.PN_3Joueurs.Enabled = false;
            this.PN_3Joueurs.Location = new System.Drawing.Point(7, 2);
            this.PN_3Joueurs.Margin = new System.Windows.Forms.Padding(2);
            this.PN_3Joueurs.Name = "PN_3Joueurs";
            this.PN_3Joueurs.Size = new System.Drawing.Size(673, 397);
            this.PN_3Joueurs.TabIndex = 12;
            this.PN_3Joueurs.Visible = false;
            // 
            // PB_Photo_Bronze
            // 
            this.PB_Photo_Bronze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Photo_Bronze.Location = new System.Drawing.Point(439, 170);
            this.PB_Photo_Bronze.Name = "PB_Photo_Bronze";
            this.PB_Photo_Bronze.Size = new System.Drawing.Size(71, 111);
            this.PB_Photo_Bronze.TabIndex = 36;
            this.PB_Photo_Bronze.TabStop = false;
            // 
            // PB_Photo_Gold
            // 
            this.PB_Photo_Gold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Photo_Gold.Location = new System.Drawing.Point(246, 170);
            this.PB_Photo_Gold.Name = "PB_Photo_Gold";
            this.PB_Photo_Gold.Size = new System.Drawing.Size(71, 111);
            this.PB_Photo_Gold.TabIndex = 35;
            this.PB_Photo_Gold.TabStop = false;
            // 
            // PB_Photo_Silver
            // 
            this.PB_Photo_Silver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Photo_Silver.Location = new System.Drawing.Point(51, 170);
            this.PB_Photo_Silver.Name = "PB_Photo_Silver";
            this.PB_Photo_Silver.Size = new System.Drawing.Size(71, 111);
            this.PB_Photo_Silver.TabIndex = 34;
            this.PB_Photo_Silver.TabStop = false;
            // 
            // PB_EquipeSilver
            // 
            this.PB_EquipeSilver.Image = global::HockeyIce.Properties.Resources.Logo_Nashville;
            this.PB_EquipeSilver.Location = new System.Drawing.Point(51, 287);
            this.PB_EquipeSilver.Name = "PB_EquipeSilver";
            this.PB_EquipeSilver.Size = new System.Drawing.Size(179, 62);
            this.PB_EquipeSilver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_EquipeSilver.TabIndex = 33;
            this.PB_EquipeSilver.TabStop = false;
            // 
            // PB_EquipeGold
            // 
            this.PB_EquipeGold.Image = global::HockeyIce.Properties.Resources.Logo_Toronto;
            this.PB_EquipeGold.Location = new System.Drawing.Point(246, 287);
            this.PB_EquipeGold.Name = "PB_EquipeGold";
            this.PB_EquipeGold.Size = new System.Drawing.Size(179, 62);
            this.PB_EquipeGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_EquipeGold.TabIndex = 32;
            this.PB_EquipeGold.TabStop = false;
            // 
            // LB_NomSilver
            // 
            this.LB_NomSilver.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NomSilver.Location = new System.Drawing.Point(125, 198);
            this.LB_NomSilver.Name = "LB_NomSilver";
            this.LB_NomSilver.Size = new System.Drawing.Size(105, 15);
            this.LB_NomSilver.TabIndex = 31;
            this.LB_NomSilver.Text = "nom";
            // 
            // LB_NumeroSilver
            // 
            this.LB_NumeroSilver.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NumeroSilver.Location = new System.Drawing.Point(125, 216);
            this.LB_NumeroSilver.Name = "LB_NumeroSilver";
            this.LB_NumeroSilver.Size = new System.Drawing.Size(105, 18);
            this.LB_NumeroSilver.TabIndex = 30;
            this.LB_NumeroSilver.Text = "Num";
            // 
            // LB_PointsSilver
            // 
            this.LB_PointsSilver.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PointsSilver.Location = new System.Drawing.Point(125, 251);
            this.LB_PointsSilver.Name = "LB_PointsSilver";
            this.LB_PointsSilver.Size = new System.Drawing.Size(105, 18);
            this.LB_PointsSilver.TabIndex = 28;
            this.LB_PointsSilver.Text = "12 points";
            // 
            // LB_PositionSilver
            // 
            this.LB_PositionSilver.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PositionSilver.Location = new System.Drawing.Point(125, 234);
            this.LB_PositionSilver.Name = "LB_PositionSilver";
            this.LB_PositionSilver.Size = new System.Drawing.Size(105, 18);
            this.LB_PositionSilver.TabIndex = 27;
            this.LB_PositionSilver.Text = "position";
            // 
            // LB_PrenomSilver
            // 
            this.LB_PrenomSilver.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PrenomSilver.Location = new System.Drawing.Point(125, 182);
            this.LB_PrenomSilver.Name = "LB_PrenomSilver";
            this.LB_PrenomSilver.Size = new System.Drawing.Size(105, 15);
            this.LB_PrenomSilver.TabIndex = 26;
            this.LB_PrenomSilver.Text = "Prenom";
            // 
            // LB_NomGold
            // 
            this.LB_NomGold.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NomGold.Location = new System.Drawing.Point(320, 198);
            this.LB_NomGold.Name = "LB_NomGold";
            this.LB_NomGold.Size = new System.Drawing.Size(105, 15);
            this.LB_NomGold.TabIndex = 25;
            this.LB_NomGold.Text = "n";
            // 
            // LB_NumeroGold
            // 
            this.LB_NumeroGold.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NumeroGold.Location = new System.Drawing.Point(320, 216);
            this.LB_NumeroGold.Name = "LB_NumeroGold";
            this.LB_NumeroGold.Size = new System.Drawing.Size(105, 18);
            this.LB_NumeroGold.TabIndex = 24;
            this.LB_NumeroGold.Text = "num";
            // 
            // LB_PointsGold
            // 
            this.LB_PointsGold.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PointsGold.Location = new System.Drawing.Point(320, 251);
            this.LB_PointsGold.Name = "LB_PointsGold";
            this.LB_PointsGold.Size = new System.Drawing.Size(105, 18);
            this.LB_PointsGold.TabIndex = 22;
            this.LB_PointsGold.Text = "12 points";
            // 
            // LB_PositionGold
            // 
            this.LB_PositionGold.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PositionGold.Location = new System.Drawing.Point(320, 234);
            this.LB_PositionGold.Name = "LB_PositionGold";
            this.LB_PositionGold.Size = new System.Drawing.Size(105, 18);
            this.LB_PositionGold.TabIndex = 21;
            this.LB_PositionGold.Text = "pos";
            // 
            // LB_PrenomGold
            // 
            this.LB_PrenomGold.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PrenomGold.Location = new System.Drawing.Point(320, 182);
            this.LB_PrenomGold.Name = "LB_PrenomGold";
            this.LB_PrenomGold.Size = new System.Drawing.Size(105, 15);
            this.LB_PrenomGold.TabIndex = 20;
            this.LB_PrenomGold.Text = "p";
            // 
            // PB_EquipeBronze
            // 
            this.PB_EquipeBronze.Image = global::HockeyIce.Properties.Resources._1280px_Montreal_Canadiens_svg;
            this.PB_EquipeBronze.Location = new System.Drawing.Point(439, 287);
            this.PB_EquipeBronze.Name = "PB_EquipeBronze";
            this.PB_EquipeBronze.Size = new System.Drawing.Size(181, 62);
            this.PB_EquipeBronze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_EquipeBronze.TabIndex = 19;
            this.PB_EquipeBronze.TabStop = false;
            // 
            // LB_NomBronze
            // 
            this.LB_NomBronze.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NomBronze.Location = new System.Drawing.Point(513, 198);
            this.LB_NomBronze.Name = "LB_NomBronze";
            this.LB_NomBronze.Size = new System.Drawing.Size(107, 10);
            this.LB_NomBronze.TabIndex = 18;
            this.LB_NomBronze.Text = "n";
            // 
            // LB_NumeroBronze
            // 
            this.LB_NumeroBronze.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NumeroBronze.Location = new System.Drawing.Point(513, 216);
            this.LB_NumeroBronze.Name = "LB_NumeroBronze";
            this.LB_NumeroBronze.Size = new System.Drawing.Size(107, 10);
            this.LB_NumeroBronze.TabIndex = 17;
            this.LB_NumeroBronze.Text = "num";
            // 
            // LB_PointsBronze
            // 
            this.LB_PointsBronze.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PointsBronze.Location = new System.Drawing.Point(514, 251);
            this.LB_PointsBronze.Name = "LB_PointsBronze";
            this.LB_PointsBronze.Size = new System.Drawing.Size(107, 18);
            this.LB_PointsBronze.TabIndex = 15;
            this.LB_PointsBronze.Text = "12 points";
            // 
            // LB_PositionBronze
            // 
            this.LB_PositionBronze.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PositionBronze.Location = new System.Drawing.Point(513, 234);
            this.LB_PositionBronze.Name = "LB_PositionBronze";
            this.LB_PositionBronze.Size = new System.Drawing.Size(107, 17);
            this.LB_PositionBronze.TabIndex = 14;
            this.LB_PositionBronze.Text = "p";
            // 
            // LB_PrenomBronze
            // 
            this.LB_PrenomBronze.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PrenomBronze.Location = new System.Drawing.Point(513, 182);
            this.LB_PrenomBronze.Name = "LB_PrenomBronze";
            this.LB_PrenomBronze.Size = new System.Drawing.Size(107, 15);
            this.LB_PrenomBronze.TabIndex = 13;
            this.LB_PrenomBronze.Text = "p";
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
            // 
            // PN_CEquipe
            // 
            this.PN_CEquipe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_CEquipe.Controls.Add(this.PN_3Joueurs);
            this.PN_CEquipe.Controls.Add(this.label1);
            this.PN_CEquipe.Enabled = false;
            this.PN_CEquipe.Location = new System.Drawing.Point(4, 431);
            this.PN_CEquipe.Margin = new System.Windows.Forms.Padding(2);
            this.PN_CEquipe.Name = "PN_CEquipe";
            this.PN_CEquipe.Size = new System.Drawing.Size(673, 397);
            this.PN_CEquipe.TabIndex = 11;
            this.PN_CEquipe.Visible = false;
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
            this.FB_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(19, 20);
            this.FB_Quitter.TabIndex = 11;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // PhotoJoueur
            // 
            this.PhotoJoueur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.PhotoJoueur.Frozen = true;
            this.PhotoJoueur.HeaderText = "PhotoJoueur";
            this.PhotoJoueur.MinimumWidth = 50;
            this.PhotoJoueur.Name = "PhotoJoueur";
            this.PhotoJoueur.ReadOnly = true;
            this.PhotoJoueur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PhotoJoueur.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PhotoJoueur.Width = 50;
            // 
            // Nom
            // 
            this.Nom.FillWeight = 128F;
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 50;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nom.Width = 127;
            // 
            // Prenom
            // 
            this.Prenom.FillWeight = 128F;
            this.Prenom.Frozen = true;
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 50;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prenom.Width = 127;
            // 
            // NUMveste
            // 
            this.NUMveste.Frozen = true;
            this.NUMveste.HeaderText = "NUMveste";
            this.NUMveste.MinimumWidth = 50;
            this.NUMveste.Name = "NUMveste";
            this.NUMveste.ReadOnly = true;
            this.NUMveste.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TypePosition
            // 
            this.TypePosition.Frozen = true;
            this.TypePosition.HeaderText = "TypePosition";
            this.TypePosition.MinimumWidth = 50;
            this.TypePosition.Name = "TypePosition";
            this.TypePosition.ReadOnly = true;
            this.TypePosition.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TypePosition.Width = 99;
            // 
            // Pointage
            // 
            this.Pointage.Frozen = true;
            this.Pointage.HeaderText = "Pointage";
            this.Pointage.MinimumWidth = 50;
            this.Pointage.Name = "Pointage";
            this.Pointage.ReadOnly = true;
            this.Pointage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Pointage.Width = 99;
            // 
            // Equipe
            // 
            this.Equipe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Equipe.Frozen = true;
            this.Equipe.HeaderText = "Equipe";
            this.Equipe.MinimumWidth = 50;
            this.Equipe.Name = "Equipe";
            this.Equipe.ReadOnly = true;
            this.Equipe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Equipe.Width = 50;
            // 
            // FormClassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(683, 433);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.PN_CEquipe);
            this.Controls.Add(this.PN_CJoueurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormClassement";
            this.Text = "FormClassement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClassement_FormClosing);
            this.Load += new System.EventHandler(this.FormClassement_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormClassement_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormClassement_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormClassement_MouseUp);
            this.PN_CJoueurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_JoueurList)).EndInit();
            this.PN_3Joueurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo_Bronze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo_Gold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo_Silver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeBronze)).EndInit();
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
        private System.Windows.Forms.Panel PN_3Joueurs;
        private System.Windows.Forms.PictureBox PB_Podium;
        private System.Windows.Forms.Label LB_NomBronze;
        private System.Windows.Forms.Label LB_NumeroBronze;
        private System.Windows.Forms.Label LB_PointsBronze;
        private System.Windows.Forms.Label LB_PositionBronze;
        private System.Windows.Forms.Label LB_PrenomBronze;
        private System.Windows.Forms.PictureBox PB_EquipeBronze;
        private System.Windows.Forms.Label LB_NomSilver;
        private System.Windows.Forms.Label LB_NumeroSilver;
        private System.Windows.Forms.Label LB_PointsSilver;
        private System.Windows.Forms.Label LB_PositionSilver;
        private System.Windows.Forms.Label LB_PrenomSilver;
        private System.Windows.Forms.Label LB_NomGold;
        private System.Windows.Forms.Label LB_NumeroGold;
        private System.Windows.Forms.Label LB_PointsGold;
        private System.Windows.Forms.Label LB_PositionGold;
        private System.Windows.Forms.Label LB_PrenomGold;
        private System.Windows.Forms.PictureBox PB_EquipeSilver;
        private System.Windows.Forms.PictureBox PB_EquipeGold;
        private System.Windows.Forms.PictureBox PB_Photo_Bronze;
        private System.Windows.Forms.PictureBox PB_Photo_Gold;
        private System.Windows.Forms.PictureBox PB_Photo_Silver;
        private System.Windows.Forms.DataGridView DGV_JoueurList;
        private System.Windows.Forms.DataGridViewImageColumn PhotoJoueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMveste;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pointage;
        private System.Windows.Forms.DataGridViewImageColumn Equipe;
    }
}