namespace HockeyIce
{
    partial class FormGestionStatistiqueJ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionStatistiqueJ));
            this.LB_Text = new System.Windows.Forms.Label();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Buts = new System.Windows.Forms.TextBox();
            this.TB_Passes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Punition = new System.Windows.Forms.TextBox();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.FB_Ajouter = new FlashButton.FlashButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Joueur = new System.Windows.Forms.ComboBox();
            this.CB_Match = new System.Windows.Forms.ComboBox();
            this.CB_Invisible = new System.Windows.Forms.ComboBox();
            this.CB_InvisibleJ = new System.Windows.Forms.ComboBox();
            this.TT_Punition = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(27, 0);
            this.LB_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(104, 23);
            this.LB_Text.TabIndex = 6;
            this.LB_Text.Text = "Statistiques";
            this.LB_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseDown);
            this.LB_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseMove);
            this.LB_Text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseUp);
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.PB_Logo.Location = new System.Drawing.Point(2, 3);
            this.PB_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(26, 19);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 7;
            this.PB_Logo.TabStop = false;
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
            this.FB_Quitter.Location = new System.Drawing.Point(221, 2);
            this.FB_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(20, 21);
            this.FB_Quitter.TabIndex = 8;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TB_Buts);
            this.panel1.Controls.Add(this.TB_Passes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_Punition);
            this.panel1.Controls.Add(this.FB_Fermer);
            this.panel1.Controls.Add(this.FB_Ajouter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_Joueur);
            this.panel1.Controls.Add(this.CB_Match);
            this.panel1.Location = new System.Drawing.Point(2, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 226);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "sec.";
            // 
            // TB_Buts
            // 
            this.TB_Buts.Location = new System.Drawing.Point(117, 115);
            this.TB_Buts.MaxLength = 2;
            this.TB_Buts.Name = "TB_Buts";
            this.TB_Buts.Size = new System.Drawing.Size(64, 19);
            this.TB_Buts.TabIndex = 13;
            this.TB_Buts.TextChanged += new System.EventHandler(this.TB_Buts_TextChanged);
            this.TB_Buts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Buts_KeyPress);
            // 
            // TB_Passes
            // 
            this.TB_Passes.Location = new System.Drawing.Point(117, 139);
            this.TB_Passes.MaxLength = 2;
            this.TB_Passes.Name = "TB_Passes";
            this.TB_Passes.Size = new System.Drawing.Size(64, 19);
            this.TB_Passes.TabIndex = 12;
            this.TB_Passes.TextChanged += new System.EventHandler(this.TB_Passes_TextChanged);
            this.TB_Passes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Buts_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Punition :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Passes :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buts :";
            // 
            // TB_Punition
            // 
            this.TB_Punition.Location = new System.Drawing.Point(117, 163);
            this.TB_Punition.MaxLength = 5;
            this.TB_Punition.Name = "TB_Punition";
            this.TB_Punition.Size = new System.Drawing.Size(64, 19);
            this.TB_Punition.TabIndex = 8;
            this.TB_Punition.TextChanged += new System.EventHandler(this.TB_Punition_TextChanged);
            this.TB_Punition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Buts_KeyPress);
            // 
            // FB_Fermer
            // 
            this.FB_Fermer.BackgroundImage = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fermer.ImageClick = global::HockeyIce.Properties.Resources.FermerClick;
            this.FB_Fermer.ImageDisable = global::HockeyIce.Properties.Resources.FermerDisable;
            this.FB_Fermer.ImageNeutral = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_Fermer.ImageOver = global::HockeyIce.Properties.Resources.FermerHover;
            this.FB_Fermer.Location = new System.Drawing.Point(124, 192);
            this.FB_Fermer.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(102, 20);
            this.FB_Fermer.TabIndex = 7;
            this.FB_Fermer.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // FB_Ajouter
            // 
            this.FB_Ajouter.BackgroundImage = global::HockeyIce.Properties.Resources.AjouterNormal;
            this.FB_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ajouter.ImageClick = global::HockeyIce.Properties.Resources.AjouterClick;
            this.FB_Ajouter.ImageDisable = global::HockeyIce.Properties.Resources.AjouterDisable;
            this.FB_Ajouter.ImageNeutral = global::HockeyIce.Properties.Resources.AjouterNormal;
            this.FB_Ajouter.ImageOver = global::HockeyIce.Properties.Resources.AjouterHover;
            this.FB_Ajouter.Location = new System.Drawing.Point(14, 192);
            this.FB_Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Ajouter.Name = "FB_Ajouter";
            this.FB_Ajouter.Size = new System.Drawing.Size(104, 20);
            this.FB_Ajouter.TabIndex = 6;
            this.FB_Ajouter.Click += new System.EventHandler(this.FB_Ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choisir Joueur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisir Match";
            // 
            // CB_Joueur
            // 
            this.CB_Joueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Joueur.FormattingEnabled = true;
            this.CB_Joueur.Location = new System.Drawing.Point(47, 79);
            this.CB_Joueur.Name = "CB_Joueur";
            this.CB_Joueur.Size = new System.Drawing.Size(140, 20);
            this.CB_Joueur.TabIndex = 1;
            this.CB_Joueur.SelectedIndexChanged += new System.EventHandler(this.CB_Joueur_SelectedIndexChanged);
            this.CB_Joueur.TextChanged += new System.EventHandler(this.CB_Joueur_TextChanged);
            // 
            // CB_Match
            // 
            this.CB_Match.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Match.FormattingEnabled = true;
            this.CB_Match.Location = new System.Drawing.Point(29, 32);
            this.CB_Match.Name = "CB_Match";
            this.CB_Match.Size = new System.Drawing.Size(186, 20);
            this.CB_Match.TabIndex = 0;
            this.CB_Match.SelectedIndexChanged += new System.EventHandler(this.CB_Match_SelectedIndexChanged);
            this.CB_Match.TextChanged += new System.EventHandler(this.CB_Match_TextChanged);
            // 
            // CB_Invisible
            // 
            this.CB_Invisible.FormattingEnabled = true;
            this.CB_Invisible.Location = new System.Drawing.Point(62, 43);
            this.CB_Invisible.Name = "CB_Invisible";
            this.CB_Invisible.Size = new System.Drawing.Size(121, 20);
            this.CB_Invisible.TabIndex = 14;
            this.CB_Invisible.Visible = false;
            // 
            // CB_InvisibleJ
            // 
            this.CB_InvisibleJ.FormattingEnabled = true;
            this.CB_InvisibleJ.Location = new System.Drawing.Point(62, 86);
            this.CB_InvisibleJ.Name = "CB_InvisibleJ";
            this.CB_InvisibleJ.Size = new System.Drawing.Size(121, 20);
            this.CB_InvisibleJ.TabIndex = 15;
            this.CB_InvisibleJ.Visible = false;
            // 
            // TT_Punition
            // 
            this.TT_Punition.AutoPopDelay = 5000;
            this.TT_Punition.InitialDelay = 1;
            this.TT_Punition.ReshowDelay = 100;
            // 
            // FormGestionStatistiqueJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(244, 253);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.CB_Invisible);
            this.Controls.Add(this.CB_InvisibleJ);
            this.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionStatistiqueJ";
            this.Text = "FormGestionStatistiqueJ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestionStatistiqueJ_FormClosing);
            this.Load += new System.EventHandler(this.FormGestionStatistiqueJ_Load);
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
        private System.Windows.Forms.Label LB_Text;
        private FlashButton.FlashButton FB_Quitter;
        private System.Windows.Forms.Panel panel1;
        private FlashButton.FlashButton FB_Fermer;
        private FlashButton.FlashButton FB_Ajouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Joueur;
        private System.Windows.Forms.ComboBox CB_Match;
        private System.Windows.Forms.TextBox TB_Punition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Buts;
        private System.Windows.Forms.TextBox TB_Passes;
        private System.Windows.Forms.ComboBox CB_Invisible;
        private System.Windows.Forms.ComboBox CB_InvisibleJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip TT_Punition;
    }
}