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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionStatistiqueJ));
            this.LB_Text = new System.Windows.Forms.Label();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flashButton2 = new FlashButton.FlashButton();
            this.flashButton1 = new FlashButton.FlashButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Joueur = new System.Windows.Forms.ComboBox();
            this.CB_Match = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.FB_Quitter.Location = new System.Drawing.Point(218, 3);
            this.FB_Quitter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(23, 19);
            this.FB_Quitter.TabIndex = 8;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.flashButton2);
            this.panel1.Controls.Add(this.flashButton1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_Joueur);
            this.panel1.Controls.Add(this.CB_Match);
            this.panel1.Location = new System.Drawing.Point(2, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 247);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Punition :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Passes :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buts :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 19);
            this.textBox1.TabIndex = 8;
            // 
            // flashButton2
            // 
            this.flashButton2.BackgroundImage = global::HockeyIce.Properties.Resources.FermerNormal;
            this.flashButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton2.ImageClick = global::HockeyIce.Properties.Resources.FermerClick;
            this.flashButton2.ImageDisable = global::HockeyIce.Properties.Resources.FermerDisable;
            this.flashButton2.ImageNeutral = global::HockeyIce.Properties.Resources.FermerNormal;
            this.flashButton2.ImageOver = global::HockeyIce.Properties.Resources.FermerHover;
            this.flashButton2.Location = new System.Drawing.Point(122, 214);
            this.flashButton2.Name = "flashButton2";
            this.flashButton2.Size = new System.Drawing.Size(102, 20);
            this.flashButton2.TabIndex = 7;
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::HockeyIce.Properties.Resources.AjouterNormal;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton1.ImageClick = global::HockeyIce.Properties.Resources.AjouterClick;
            this.flashButton1.ImageDisable = global::HockeyIce.Properties.Resources.AjouterDisable;
            this.flashButton1.ImageNeutral = global::HockeyIce.Properties.Resources.AjouterNormal;
            this.flashButton1.ImageOver = global::HockeyIce.Properties.Resources.AjouterHover;
            this.flashButton1.Location = new System.Drawing.Point(12, 214);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.Size = new System.Drawing.Size(104, 20);
            this.flashButton1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(122, 147);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 19);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(122, 123);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 19);
            this.numericUpDown1.TabIndex = 4;
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
            this.CB_Joueur.FormattingEnabled = true;
            this.CB_Joueur.Location = new System.Drawing.Point(47, 79);
            this.CB_Joueur.Name = "CB_Joueur";
            this.CB_Joueur.Size = new System.Drawing.Size(140, 20);
            this.CB_Joueur.TabIndex = 1;
            // 
            // CB_Match
            // 
            this.CB_Match.FormattingEnabled = true;
            this.CB_Match.Location = new System.Drawing.Point(47, 32);
            this.CB_Match.Name = "CB_Match";
            this.CB_Match.Size = new System.Drawing.Size(142, 20);
            this.CB_Match.TabIndex = 0;
            // 
            // FormGestionStatistiqueJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(243, 274);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_Text);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Label LB_Text;
        private FlashButton.FlashButton FB_Quitter;
        private System.Windows.Forms.Panel panel1;
        private FlashButton.FlashButton flashButton2;
        private FlashButton.FlashButton flashButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Joueur;
        private System.Windows.Forms.ComboBox CB_Match;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}