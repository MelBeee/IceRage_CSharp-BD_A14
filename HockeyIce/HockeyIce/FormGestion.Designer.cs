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
            this.PN_Division = new System.Windows.Forms.Panel();
            this.FB_DateDivision = new FlashButton.FlashButton();
            this.TB_NomDivision = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FB_FermerD = new FlashButton.FlashButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PN_Equipe = new System.Windows.Forms.Panel();
            this.FB_Parcourir = new FlashButton.FlashButton();
            this.FB_DateEquipe = new FlashButton.FlashButton();
            this.FB_FermerE = new FlashButton.FlashButton();
            this.CB_DivisionEquipe = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_LieuxEquipe = new System.Windows.Forms.TextBox();
            this.TB_NomEquipe = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PN_Joueurs = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.flashButton5 = new FlashButton.FlashButton();
            this.FB_FermerJ = new FlashButton.FlashButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PN_Matchs = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_DateMatch = new System.Windows.Forms.DateTimePicker();
            this.CB_EVisiteur = new System.Windows.Forms.ComboBox();
            this.CB_EMaison = new System.Windows.Forms.ComboBox();
            this.NUD_PMaison = new System.Windows.Forms.NumericUpDown();
            this.NUD_PVisiteur = new System.Windows.Forms.NumericUpDown();
            this.TB_Endroit = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.FB_FermerM = new FlashButton.FlashButton();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.PN_Division.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PN_Equipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PN_Joueurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PN_Matchs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PMaison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(32, 4);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(88, 28);
            this.LB_Text.TabIndex = 4;
            this.LB_Text.Text = "Gestion";
            this.LB_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseDown);
            this.LB_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseMove);
            this.LB_Text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseUp);
            // 
            // PN_Division
            // 
            this.PN_Division.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Division.Controls.Add(this.FB_DateDivision);
            this.PN_Division.Controls.Add(this.TB_NomDivision);
            this.PN_Division.Controls.Add(this.pictureBox1);
            this.PN_Division.Controls.Add(this.FB_FermerD);
            this.PN_Division.Controls.Add(this.label4);
            this.PN_Division.Controls.Add(this.label3);
            this.PN_Division.Enabled = false;
            this.PN_Division.Location = new System.Drawing.Point(841, 32);
            this.PN_Division.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PN_Division.Name = "PN_Division";
            this.PN_Division.Size = new System.Drawing.Size(835, 443);
            this.PN_Division.TabIndex = 7;
            this.PN_Division.Visible = false;
            // 
            // FB_DateDivision
            // 
            this.FB_DateDivision.BackgroundImage = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.FB_DateDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_DateDivision.ImageClick = global::HockeyIce.Properties.Resources.ChoisirDateClick;
            this.FB_DateDivision.ImageDisable = global::HockeyIce.Properties.Resources.ChoisirDateDisable;
            this.FB_DateDivision.ImageNeutral = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.FB_DateDivision.ImageOver = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.FB_DateDivision.Location = new System.Drawing.Point(143, 197);
            this.FB_DateDivision.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FB_DateDivision.Name = "FB_DateDivision";
            this.FB_DateDivision.Size = new System.Drawing.Size(135, 23);
            this.FB_DateDivision.TabIndex = 14;
            this.FB_DateDivision.Click += new System.EventHandler(this.BTN_Date_Click);
            // 
            // TB_NomDivision
            // 
            this.TB_NomDivision.Location = new System.Drawing.Point(143, 165);
            this.TB_NomDivision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_NomDivision.Name = "TB_NomDivision";
            this.TB_NomDivision.Size = new System.Drawing.Size(101, 22);
            this.TB_NomDivision.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::HockeyIce.Properties.Resources.Baton_de_Hockey2;
            this.pictureBox1.Location = new System.Drawing.Point(29, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FB_FermerD
            // 
            this.FB_FermerD.BackgroundImage = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_FermerD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_FermerD.ImageClick = global::HockeyIce.Properties.Resources.FermerClick;
            this.FB_FermerD.ImageDisable = global::HockeyIce.Properties.Resources.FermerDisable;
            this.FB_FermerD.ImageNeutral = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_FermerD.ImageOver = global::HockeyIce.Properties.Resources.FermerHover;
            this.FB_FermerD.Location = new System.Drawing.Point(693, 415);
            this.FB_FermerD.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FB_FermerD.Name = "FB_FermerD";
            this.FB_FermerD.Size = new System.Drawing.Size(136, 23);
            this.FB_FermerD.TabIndex = 6;
            this.FB_FermerD.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom : ";
            // 
            // PN_Equipe
            // 
            this.PN_Equipe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Equipe.Controls.Add(this.FB_Parcourir);
            this.PN_Equipe.Controls.Add(this.FB_DateEquipe);
            this.PN_Equipe.Controls.Add(this.FB_FermerE);
            this.PN_Equipe.Controls.Add(this.CB_DivisionEquipe);
            this.PN_Equipe.Controls.Add(this.label11);
            this.PN_Equipe.Controls.Add(this.label10);
            this.PN_Equipe.Controls.Add(this.label9);
            this.PN_Equipe.Controls.Add(this.label8);
            this.PN_Equipe.Controls.Add(this.label7);
            this.PN_Equipe.Controls.Add(this.TB_LieuxEquipe);
            this.PN_Equipe.Controls.Add(this.TB_NomEquipe);
            this.PN_Equipe.Controls.Add(this.pictureBox2);
            this.PN_Equipe.Enabled = false;
            this.PN_Equipe.Location = new System.Drawing.Point(4, 479);
            this.PN_Equipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PN_Equipe.Name = "PN_Equipe";
            this.PN_Equipe.Size = new System.Drawing.Size(835, 443);
            this.PN_Equipe.TabIndex = 8;
            this.PN_Equipe.Visible = false;
            // 
            // FB_Parcourir
            // 
            this.FB_Parcourir.BackgroundImage = global::HockeyIce.Properties.Resources.ParcourirNormal;
            this.FB_Parcourir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Parcourir.ImageClick = global::HockeyIce.Properties.Resources.ParcourirClick;
            this.FB_Parcourir.ImageDisable = global::HockeyIce.Properties.Resources.ParcourirDisable;
            this.FB_Parcourir.ImageNeutral = global::HockeyIce.Properties.Resources.ParcourirNormal;
            this.FB_Parcourir.ImageOver = global::HockeyIce.Properties.Resources.ParcourirHover;
            this.FB_Parcourir.Location = new System.Drawing.Point(260, 293);
            this.FB_Parcourir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FB_Parcourir.Name = "FB_Parcourir";
            this.FB_Parcourir.Size = new System.Drawing.Size(135, 23);
            this.FB_Parcourir.TabIndex = 29;
            // 
            // FB_DateEquipe
            // 
            this.FB_DateEquipe.BackgroundImage = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.FB_DateEquipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_DateEquipe.ImageClick = global::HockeyIce.Properties.Resources.ChoisirDateClick;
            this.FB_DateEquipe.ImageDisable = global::HockeyIce.Properties.Resources.ChoisirDateDisable;
            this.FB_DateEquipe.ImageNeutral = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.FB_DateEquipe.ImageOver = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.FB_DateEquipe.Location = new System.Drawing.Point(259, 325);
            this.FB_DateEquipe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FB_DateEquipe.Name = "FB_DateEquipe";
            this.FB_DateEquipe.Size = new System.Drawing.Size(135, 23);
            this.FB_DateEquipe.TabIndex = 28;
            // 
            // FB_FermerE
            // 
            this.FB_FermerE.BackgroundImage = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_FermerE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_FermerE.ImageClick = global::HockeyIce.Properties.Resources.FermerClick;
            this.FB_FermerE.ImageDisable = global::HockeyIce.Properties.Resources.FermerDisable;
            this.FB_FermerE.ImageNeutral = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_FermerE.ImageOver = global::HockeyIce.Properties.Resources.FermerHover;
            this.FB_FermerE.Location = new System.Drawing.Point(693, 415);
            this.FB_FermerE.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FB_FermerE.Name = "FB_FermerE";
            this.FB_FermerE.Size = new System.Drawing.Size(136, 23);
            this.FB_FermerE.TabIndex = 27;
            this.FB_FermerE.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // CB_DivisionEquipe
            // 
            this.CB_DivisionEquipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_DivisionEquipe.FormattingEnabled = true;
            this.CB_DivisionEquipe.Location = new System.Drawing.Point(259, 357);
            this.CB_DivisionEquipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_DivisionEquipe.Name = "CB_DivisionEquipe";
            this.CB_DivisionEquipe.Size = new System.Drawing.Size(132, 24);
            this.CB_DivisionEquipe.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(93, 229);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Nom :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(76, 261);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ville :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Logo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 319);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 348);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Division :";
            // 
            // TB_LieuxEquipe
            // 
            this.TB_LieuxEquipe.Location = new System.Drawing.Point(260, 261);
            this.TB_LieuxEquipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_LieuxEquipe.Name = "TB_LieuxEquipe";
            this.TB_LieuxEquipe.Size = new System.Drawing.Size(132, 22);
            this.TB_LieuxEquipe.TabIndex = 18;
            // 
            // TB_NomEquipe
            // 
            this.TB_NomEquipe.Location = new System.Drawing.Point(260, 229);
            this.TB_NomEquipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_NomEquipe.Name = "TB_NomEquipe";
            this.TB_NomEquipe.Size = new System.Drawing.Size(132, 22);
            this.TB_NomEquipe.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::HockeyIce.Properties.Resources.ImageGEquipe;
            this.pictureBox2.Location = new System.Drawing.Point(29, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(584, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // PN_Joueurs
            // 
            this.PN_Joueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Joueurs.Controls.Add(this.label28);
            this.PN_Joueurs.Controls.Add(this.label27);
            this.PN_Joueurs.Controls.Add(this.label26);
            this.PN_Joueurs.Controls.Add(this.label25);
            this.PN_Joueurs.Controls.Add(this.label24);
            this.PN_Joueurs.Controls.Add(this.label23);
            this.PN_Joueurs.Controls.Add(this.label22);
            this.PN_Joueurs.Controls.Add(this.textBox8);
            this.PN_Joueurs.Controls.Add(this.comboBox3);
            this.PN_Joueurs.Controls.Add(this.comboBox2);
            this.PN_Joueurs.Controls.Add(this.textBox7);
            this.PN_Joueurs.Controls.Add(this.textBox6);
            this.PN_Joueurs.Controls.Add(this.textBox5);
            this.PN_Joueurs.Controls.Add(this.flashButton5);
            this.PN_Joueurs.Controls.Add(this.FB_FermerJ);
            this.PN_Joueurs.Controls.Add(this.pictureBox3);
            this.PN_Joueurs.Enabled = false;
            this.PN_Joueurs.Location = new System.Drawing.Point(847, 479);
            this.PN_Joueurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PN_Joueurs.Name = "PN_Joueurs";
            this.PN_Joueurs.Size = new System.Drawing.Size(835, 443);
            this.PN_Joueurs.TabIndex = 8;
            this.PN_Joueurs.Visible = false;
            this.PN_Joueurs.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Joueurs_Paint);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(44, 348);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(108, 17);
            this.label28.TabIndex = 35;
            this.label28.Text = "Position :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(64, 316);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 17);
            this.label27.TabIndex = 34;
            this.label27.Text = "Équipe :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(24, 251);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(128, 17);
            this.label26.TabIndex = 33;
            this.label26.Text = "Lien photo :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(65, 222);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 17);
            this.label25.TabIndex = 30;
            this.label25.Text = "Numero :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(5, 286);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(148, 17);
            this.label24.TabIndex = 32;
            this.label24.Text = "Anniversaire :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(65, 190);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 17);
            this.label23.TabIndex = 31;
            this.label23.Text = "Prenom :";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(93, 158);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 17);
            this.label22.TabIndex = 30;
            this.label22.Text = "Nom :";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(161, 249);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(133, 22);
            this.textBox8.TabIndex = 21;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(161, 346);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 24);
            this.comboBox3.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(161, 313);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 24);
            this.comboBox2.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(161, 187);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(133, 22);
            this.textBox7.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(161, 218);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(133, 22);
            this.textBox6.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(161, 155);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(133, 22);
            this.textBox5.TabIndex = 17;
            // 
            // flashButton5
            // 
            this.flashButton5.BackgroundImage = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.flashButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton5.ImageClick = global::HockeyIce.Properties.Resources.ChoisirDateClick;
            this.flashButton5.ImageDisable = global::HockeyIce.Properties.Resources.ChoisirDateDisable;
            this.flashButton5.ImageNeutral = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.flashButton5.ImageOver = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.flashButton5.Location = new System.Drawing.Point(161, 281);
            this.flashButton5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flashButton5.Name = "flashButton5";
            this.flashButton5.Size = new System.Drawing.Size(135, 23);
            this.flashButton5.TabIndex = 16;
            // 
            // FB_FermerJ
            // 
            this.FB_FermerJ.BackgroundImage = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_FermerJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_FermerJ.ImageClick = global::HockeyIce.Properties.Resources.FermerClick;
            this.FB_FermerJ.ImageDisable = global::HockeyIce.Properties.Resources.FermerDisable;
            this.FB_FermerJ.ImageNeutral = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_FermerJ.ImageOver = global::HockeyIce.Properties.Resources.FermerHover;
            this.FB_FermerJ.Location = new System.Drawing.Point(693, 415);
            this.FB_FermerJ.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FB_FermerJ.Name = "FB_FermerJ";
            this.FB_FermerJ.Size = new System.Drawing.Size(136, 23);
            this.FB_FermerJ.TabIndex = 15;
            this.FB_FermerJ.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::HockeyIce.Properties.Resources.sl_yog_winter_icehockey;
            this.pictureBox3.Location = new System.Drawing.Point(27, 34);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(584, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // PN_Matchs
            // 
            this.PN_Matchs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Matchs.Controls.Add(this.label21);
            this.PN_Matchs.Controls.Add(this.label20);
            this.PN_Matchs.Controls.Add(this.label19);
            this.PN_Matchs.Controls.Add(this.label18);
            this.PN_Matchs.Controls.Add(this.label17);
            this.PN_Matchs.Controls.Add(this.label6);
            this.PN_Matchs.Controls.Add(this.DTP_DateMatch);
            this.PN_Matchs.Controls.Add(this.CB_EVisiteur);
            this.PN_Matchs.Controls.Add(this.CB_EMaison);
            this.PN_Matchs.Controls.Add(this.NUD_PMaison);
            this.PN_Matchs.Controls.Add(this.NUD_PVisiteur);
            this.PN_Matchs.Controls.Add(this.TB_Endroit);
            this.PN_Matchs.Controls.Add(this.pictureBox4);
            this.PN_Matchs.Controls.Add(this.FB_FermerM);
            this.PN_Matchs.Enabled = false;
            this.PN_Matchs.Location = new System.Drawing.Point(4, 32);
            this.PN_Matchs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PN_Matchs.Name = "PN_Matchs";
            this.PN_Matchs.Size = new System.Drawing.Size(835, 443);
            this.PN_Matchs.TabIndex = 9;
            this.PN_Matchs.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(41, 386);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(198, 17);
            this.label21.TabIndex = 28;
            this.label21.Text = "Pointage visiteur :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(63, 356);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(178, 17);
            this.label20.TabIndex = 27;
            this.label20.Text = "Pointage maison :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(84, 322);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 17);
            this.label19.TabIndex = 26;
            this.label19.Text = "Date et Heure :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(148, 290);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "Endroit :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(64, 258);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Équipe visiteur :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Équipe maison :";
            // 
            // DTP_DateMatch
            // 
            this.DTP_DateMatch.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_DateMatch.Location = new System.Drawing.Point(260, 318);
            this.DTP_DateMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTP_DateMatch.Name = "DTP_DateMatch";
            this.DTP_DateMatch.Size = new System.Drawing.Size(132, 22);
            this.DTP_DateMatch.TabIndex = 22;
            // 
            // CB_EVisiteur
            // 
            this.CB_EVisiteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_EVisiteur.FormattingEnabled = true;
            this.CB_EVisiteur.Location = new System.Drawing.Point(260, 254);
            this.CB_EVisiteur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_EVisiteur.Name = "CB_EVisiteur";
            this.CB_EVisiteur.Size = new System.Drawing.Size(132, 24);
            this.CB_EVisiteur.TabIndex = 21;
            // 
            // CB_EMaison
            // 
            this.CB_EMaison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_EMaison.FormattingEnabled = true;
            this.CB_EMaison.Location = new System.Drawing.Point(260, 220);
            this.CB_EMaison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_EMaison.Name = "CB_EMaison";
            this.CB_EMaison.Size = new System.Drawing.Size(133, 24);
            this.CB_EMaison.TabIndex = 20;
            // 
            // NUD_PMaison
            // 
            this.NUD_PMaison.Location = new System.Drawing.Point(260, 351);
            this.NUD_PMaison.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUD_PMaison.Name = "NUD_PMaison";
            this.NUD_PMaison.Size = new System.Drawing.Size(53, 22);
            this.NUD_PMaison.TabIndex = 19;
            // 
            // NUD_PVisiteur
            // 
            this.NUD_PVisiteur.Location = new System.Drawing.Point(260, 383);
            this.NUD_PVisiteur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUD_PVisiteur.Name = "NUD_PVisiteur";
            this.NUD_PVisiteur.Size = new System.Drawing.Size(53, 22);
            this.NUD_PVisiteur.TabIndex = 18;
            // 
            // TB_Endroit
            // 
            this.TB_Endroit.Location = new System.Drawing.Point(260, 286);
            this.TB_Endroit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Endroit.Name = "TB_Endroit";
            this.TB_Endroit.Size = new System.Drawing.Size(133, 22);
            this.TB_Endroit.TabIndex = 17;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::HockeyIce.Properties.Resources.hockey_wallpaper_hd_4_742195;
            this.pictureBox4.Location = new System.Drawing.Point(29, 26);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(582, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // FB_FermerM
            // 
            this.FB_FermerM.BackgroundImage = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_FermerM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_FermerM.ImageClick = global::HockeyIce.Properties.Resources.FermerClick;
            this.FB_FermerM.ImageDisable = global::HockeyIce.Properties.Resources.FermerDisable;
            this.FB_FermerM.ImageNeutral = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_FermerM.ImageOver = global::HockeyIce.Properties.Resources.FermerHover;
            this.FB_FermerM.Location = new System.Drawing.Point(693, 415);
            this.FB_FermerM.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FB_FermerM.Name = "FB_FermerM";
            this.FB_FermerM.Size = new System.Drawing.Size(136, 23);
            this.FB_FermerM.TabIndex = 7;
            this.FB_FermerM.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // FB_Quitter
            // 
            this.FB_Quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FB_Quitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_Quitter.BackgroundImage")));
            this.FB_Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Quitter.ImageClick = ((System.Drawing.Image)(resources.GetObject("FB_Quitter.ImageClick")));
            this.FB_Quitter.ImageDisable = ((System.Drawing.Image)(resources.GetObject("FB_Quitter.ImageDisable")));
            this.FB_Quitter.ImageNeutral = ((System.Drawing.Image)(resources.GetObject("FB_Quitter.ImageNeutral")));
            this.FB_Quitter.ImageOver = ((System.Drawing.Image)(resources.GetObject("FB_Quitter.ImageOver")));
            this.FB_Quitter.Location = new System.Drawing.Point(812, 4);
            this.FB_Quitter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(27, 26);
            this.FB_Quitter.TabIndex = 6;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
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
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1699, 912);
            this.Controls.Add(this.PN_Equipe);
            this.Controls.Add(this.PN_Division);
            this.Controls.Add(this.PN_Joueurs);
            this.Controls.Add(this.PN_Matchs);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGestion";
            this.Text = "FormGestion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestion_FormClosing);
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseUp);
            this.PN_Division.ResumeLayout(false);
            this.PN_Division.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PN_Equipe.ResumeLayout(false);
            this.PN_Equipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PN_Joueurs.ResumeLayout(false);
            this.PN_Joueurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PN_Matchs.ResumeLayout(false);
            this.PN_Matchs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PMaison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Label LB_Text;
        private FlashButton.FlashButton FB_Quitter;
        private System.Windows.Forms.Panel PN_Division;
        private System.Windows.Forms.Panel PN_Equipe;
        private System.Windows.Forms.Panel PN_Joueurs;
        private System.Windows.Forms.Panel PN_Matchs;
        private FlashButton.FlashButton FB_FermerD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_NomDivision;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TB_LieuxEquipe;
        private System.Windows.Forms.TextBox TB_NomEquipe;
        private System.Windows.Forms.ComboBox CB_DivisionEquipe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FlashButton.FlashButton FB_DateDivision;
        private FlashButton.FlashButton flashButton5;
        private FlashButton.FlashButton FB_DateEquipe;
        private FlashButton.FlashButton FB_FermerE;
        private FlashButton.FlashButton FB_FermerJ;
        private FlashButton.FlashButton FB_FermerM;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown NUD_PMaison;
        private System.Windows.Forms.NumericUpDown NUD_PVisiteur;
        private System.Windows.Forms.TextBox TB_Endroit;
        private System.Windows.Forms.DateTimePicker DTP_DateMatch;
        private System.Windows.Forms.ComboBox CB_EVisiteur;
        private System.Windows.Forms.ComboBox CB_EMaison;
        private FlashButton.FlashButton FB_Parcourir;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
    }
}