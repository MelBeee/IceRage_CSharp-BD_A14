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
            this.FB_ChoisirDate = new FlashButton.FlashButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_ChoixDivision = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PN_Equipe = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.PN_Joueurs = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CB_Equipes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PN_Matchs = new System.Windows.Forms.Panel();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.PN_Division.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PN_Equipe.SuspendLayout();
            this.PN_Joueurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PN_Matchs.SuspendLayout();
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
            this.PN_Division.Controls.Add(this.FB_ChoisirDate);
            this.PN_Division.Controls.Add(this.textBox1);
            this.PN_Division.Controls.Add(this.label6);
            this.PN_Division.Controls.Add(this.label1);
            this.PN_Division.Controls.Add(this.CB_ChoixDivision);
            this.PN_Division.Controls.Add(this.pictureBox1);
            this.PN_Division.Controls.Add(this.FB_Fermer);
            this.PN_Division.Controls.Add(this.label4);
            this.PN_Division.Controls.Add(this.label3);
            this.PN_Division.Enabled = false;
            this.PN_Division.Location = new System.Drawing.Point(4, 36);
            this.PN_Division.Margin = new System.Windows.Forms.Padding(4);
            this.PN_Division.Name = "PN_Division";
            this.PN_Division.Size = new System.Drawing.Size(835, 443);
            this.PN_Division.TabIndex = 7;
            this.PN_Division.Visible = false;
            // 
            // FB_ChoisirDate
            // 
            this.FB_ChoisirDate.BackgroundImage = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.FB_ChoisirDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_ChoisirDate.ImageClick = global::HockeyIce.Properties.Resources.ChoisirDateClick;
            this.FB_ChoisirDate.ImageDisable = global::HockeyIce.Properties.Resources.ChoisirDateDisable;
            this.FB_ChoisirDate.ImageNeutral = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.FB_ChoisirDate.ImageOver = global::HockeyIce.Properties.Resources.ChoisirDateNormal;
            this.FB_ChoisirDate.Location = new System.Drawing.Point(143, 198);
            this.FB_ChoisirDate.Margin = new System.Windows.Forms.Padding(4);
            this.FB_ChoisirDate.Name = "FB_ChoisirDate";
            this.FB_ChoisirDate.Size = new System.Drawing.Size(101, 20);
            this.FB_ChoisirDate.TabIndex = 14;
            this.FB_ChoisirDate.Click += new System.EventHandler(this.BTN_Date_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 11.25F);
            this.label6.Location = new System.Drawing.Point(123, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Supprimer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ajouter et Modifier";
            // 
            // CB_ChoixDivision
            // 
            this.CB_ChoixDivision.FormattingEnabled = true;
            this.CB_ChoixDivision.Location = new System.Drawing.Point(100, 278);
            this.CB_ChoixDivision.Margin = new System.Windows.Forms.Padding(4);
            this.CB_ChoixDivision.Name = "CB_ChoixDivision";
            this.CB_ChoixDivision.Size = new System.Drawing.Size(160, 24);
            this.CB_ChoixDivision.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::HockeyIce.Properties.Resources.Baton_de_Hockey2;
            this.pictureBox1.Location = new System.Drawing.Point(29, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FB_Fermer
            // 
            this.FB_Fermer.BackgroundImage = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fermer.ImageClick = global::HockeyIce.Properties.Resources.FermerClick;
            this.FB_Fermer.ImageDisable = global::HockeyIce.Properties.Resources.FermerDisable;
            this.FB_Fermer.ImageNeutral = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_Fermer.ImageOver = global::HockeyIce.Properties.Resources.FermerHover;
            this.FB_Fermer.Location = new System.Drawing.Point(688, 411);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(5);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(136, 23);
            this.FB_Fermer.TabIndex = 6;
            this.FB_Fermer.Click += new System.EventHandler(this.FB_Fermer_Click);
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
            this.PN_Equipe.Controls.Add(this.label12);
            this.PN_Equipe.Controls.Add(this.PN_Joueurs);
            this.PN_Equipe.Controls.Add(this.comboBox1);
            this.PN_Equipe.Controls.Add(this.label11);
            this.PN_Equipe.Controls.Add(this.label10);
            this.PN_Equipe.Controls.Add(this.label9);
            this.PN_Equipe.Controls.Add(this.label8);
            this.PN_Equipe.Controls.Add(this.label7);
            this.PN_Equipe.Controls.Add(this.button1);
            this.PN_Equipe.Controls.Add(this.textBox4);
            this.PN_Equipe.Controls.Add(this.textBox3);
            this.PN_Equipe.Controls.Add(this.textBox2);
            this.PN_Equipe.Controls.Add(this.CB_Equipes);
            this.PN_Equipe.Controls.Add(this.label5);
            this.PN_Equipe.Controls.Add(this.label2);
            this.PN_Equipe.Controls.Add(this.pictureBox2);
            this.PN_Equipe.Enabled = false;
            this.PN_Equipe.Location = new System.Drawing.Point(0, 1);
            this.PN_Equipe.Margin = new System.Windows.Forms.Padding(4);
            this.PN_Equipe.Name = "PN_Equipe";
            this.PN_Equipe.Size = new System.Drawing.Size(835, 443);
            this.PN_Equipe.TabIndex = 8;
            this.PN_Equipe.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Nom :";
            // 
            // PN_Joueurs
            // 
            this.PN_Joueurs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Joueurs.Controls.Add(this.label14);
            this.PN_Joueurs.Controls.Add(this.label13);
            this.PN_Joueurs.Controls.Add(this.pictureBox3);
            this.PN_Joueurs.Enabled = false;
            this.PN_Joueurs.Location = new System.Drawing.Point(0, 0);
            this.PN_Joueurs.Margin = new System.Windows.Forms.Padding(4);
            this.PN_Joueurs.Name = "PN_Joueurs";
            this.PN_Joueurs.Size = new System.Drawing.Size(835, 443);
            this.PN_Joueurs.TabIndex = 8;
            this.PN_Joueurs.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Kristen ITC", 11.25F);
            this.label14.Location = new System.Drawing.Point(361, 208);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 27);
            this.label14.TabIndex = 14;
            this.label14.Text = "Supprimer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(312, 208);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 27);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ajouter et Modifier";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::HockeyIce.Properties.Resources.sl_yog_winter_icehockey;
            this.pictureBox3.Location = new System.Drawing.Point(27, 34);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(584, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 345);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 229);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Nom :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ville :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Logo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 319);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 348);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Division :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(148, 255);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 284);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 225);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 16;
            // 
            // CB_Equipes
            // 
            this.CB_Equipes.FormattingEnabled = true;
            this.CB_Equipes.Location = new System.Drawing.Point(147, 151);
            this.CB_Equipes.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Equipes.Name = "CB_Equipes";
            this.CB_Equipes.Size = new System.Drawing.Size(132, 24);
            this.CB_Equipes.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 11.25F);
            this.label5.Location = new System.Drawing.Point(85, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Selectionner équipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ajouter et Modifier";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::HockeyIce.Properties.Resources.ImageGEquipe;
            this.pictureBox2.Location = new System.Drawing.Point(29, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(584, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // PN_Matchs
            // 
            this.PN_Matchs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PN_Matchs.Controls.Add(this.PN_Equipe);
            this.PN_Matchs.Enabled = false;
            this.PN_Matchs.Location = new System.Drawing.Point(4, 36);
            this.PN_Matchs.Margin = new System.Windows.Forms.Padding(4);
            this.PN_Matchs.Name = "PN_Matchs";
            this.PN_Matchs.Size = new System.Drawing.Size(835, 443);
            this.PN_Matchs.TabIndex = 9;
            this.PN_Matchs.Visible = false;
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
            this.FB_Quitter.Location = new System.Drawing.Point(812, 2);
            this.FB_Quitter.Margin = new System.Windows.Forms.Padding(5);
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
            this.ClientSize = new System.Drawing.Size(844, 481);
            this.Controls.Add(this.PN_Division);
            this.Controls.Add(this.PN_Matchs);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.PN_Joueurs.ResumeLayout(false);
            this.PN_Joueurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PN_Matchs.ResumeLayout(false);
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
        private FlashButton.FlashButton FB_Fermer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CB_ChoixDivision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox CB_Equipes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FlashButton.FlashButton FB_ChoisirDate;
    }
}