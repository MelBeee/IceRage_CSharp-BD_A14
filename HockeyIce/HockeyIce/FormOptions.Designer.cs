namespace HockeyIce
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.RB_Ajouter = new System.Windows.Forms.RadioButton();
            this.RB_Modifier = new System.Windows.Forms.RadioButton();
            this.RB_Supprimer = new System.Windows.Forms.RadioButton();
            this.CB_Invisible = new System.Windows.Forms.ComboBox();
            this.CB_Value = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FB_Ok = new FlashButton.FlashButton();
            this.FB_Annuler = new FlashButton.FlashButton();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.LB_Text = new System.Windows.Forms.Label();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // RB_Ajouter
            // 
            this.RB_Ajouter.AutoSize = true;
            this.RB_Ajouter.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Ajouter.Location = new System.Drawing.Point(12, 14);
            this.RB_Ajouter.Name = "RB_Ajouter";
            this.RB_Ajouter.Size = new System.Drawing.Size(86, 26);
            this.RB_Ajouter.TabIndex = 0;
            this.RB_Ajouter.TabStop = true;
            this.RB_Ajouter.Text = "Ajouter";
            this.RB_Ajouter.UseVisualStyleBackColor = true;
            this.RB_Ajouter.CheckedChanged += new System.EventHandler(this.RB_Ajouter_CheckedChanged);
            // 
            // RB_Modifier
            // 
            this.RB_Modifier.AutoSize = true;
            this.RB_Modifier.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Modifier.Location = new System.Drawing.Point(12, 37);
            this.RB_Modifier.Name = "RB_Modifier";
            this.RB_Modifier.Size = new System.Drawing.Size(93, 26);
            this.RB_Modifier.TabIndex = 1;
            this.RB_Modifier.TabStop = true;
            this.RB_Modifier.Text = "Modifier";
            this.RB_Modifier.UseVisualStyleBackColor = true;
            this.RB_Modifier.CheckedChanged += new System.EventHandler(this.RB_Modifier_CheckedChanged);
            // 
            // RB_Supprimer
            // 
            this.RB_Supprimer.AutoSize = true;
            this.RB_Supprimer.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Supprimer.Location = new System.Drawing.Point(12, 60);
            this.RB_Supprimer.Name = "RB_Supprimer";
            this.RB_Supprimer.Size = new System.Drawing.Size(103, 26);
            this.RB_Supprimer.TabIndex = 2;
            this.RB_Supprimer.TabStop = true;
            this.RB_Supprimer.Text = "Supprimer";
            this.RB_Supprimer.UseVisualStyleBackColor = true;
            this.RB_Supprimer.CheckedChanged += new System.EventHandler(this.RB_Supprimer_CheckedChanged);
            // 
            // CB_Invisible
            // 
            this.CB_Invisible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Invisible.FormattingEnabled = true;
            this.CB_Invisible.Location = new System.Drawing.Point(64, 49);
            this.CB_Invisible.Name = "CB_Invisible";
            this.CB_Invisible.Size = new System.Drawing.Size(133, 21);
            this.CB_Invisible.TabIndex = 3;
            // 
            // CB_Value
            // 
            this.CB_Value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Value.Enabled = false;
            this.CB_Value.FormattingEnabled = true;
            this.CB_Value.Location = new System.Drawing.Point(132, 38);
            this.CB_Value.Name = "CB_Value";
            this.CB_Value.Size = new System.Drawing.Size(133, 21);
            this.CB_Value.TabIndex = 4;
            this.CB_Value.Visible = false;
            this.CB_Value.SelectedIndexChanged += new System.EventHandler(this.CB_Value_SelectedIndexChanged);
            this.CB_Value.TextChanged += new System.EventHandler(this.CB_Value_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.FB_Ok);
            this.panel1.Controls.Add(this.FB_Annuler);
            this.panel1.Controls.Add(this.CB_Value);
            this.panel1.Controls.Add(this.RB_Ajouter);
            this.panel1.Controls.Add(this.RB_Supprimer);
            this.panel1.Controls.Add(this.RB_Modifier);
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 102);
            this.panel1.TabIndex = 5;
            // 
            // FB_Ok
            // 
            this.FB_Ok.BackgroundImage = global::HockeyIce.Properties.Resources.ContinuerNormal;
            this.FB_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Ok.ImageClick = global::HockeyIce.Properties.Resources.ContinuerClick;
            this.FB_Ok.ImageDisable = global::HockeyIce.Properties.Resources.ContinuerDisable;
            this.FB_Ok.ImageNeutral = global::HockeyIce.Properties.Resources.ContinuerNormal;
            this.FB_Ok.ImageOver = global::HockeyIce.Properties.Resources.ContinuerHover;
            this.FB_Ok.Location = new System.Drawing.Point(289, 23);
            this.FB_Ok.Name = "FB_Ok";
            this.FB_Ok.Size = new System.Drawing.Size(106, 26);
            this.FB_Ok.TabIndex = 6;
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
            this.FB_Annuler.Location = new System.Drawing.Point(289, 55);
            this.FB_Annuler.Name = "FB_Annuler";
            this.FB_Annuler.Size = new System.Drawing.Size(106, 26);
            this.FB_Annuler.TabIndex = 5;
            this.FB_Annuler.Click += new System.EventHandler(this.FB_Annuler_Click);
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.PB_Logo.Location = new System.Drawing.Point(3, 2);
            this.PB_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(22, 21);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 7;
            this.PB_Logo.TabStop = false;
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(28, 2);
            this.LB_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(65, 23);
            this.LB_Text.TabIndex = 6;
            this.LB_Text.Text = "Option";
            this.LB_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseDown);
            this.LB_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseMove);
            this.LB_Text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseUp);
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
            this.FB_Quitter.Location = new System.Drawing.Point(385, 2);
            this.FB_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(20, 21);
            this.FB_Quitter.TabIndex = 8;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(409, 130);
            this.Controls.Add(this.FB_Quitter);
            this.Controls.Add(this.PB_Logo);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CB_Invisible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOptions";
            this.Text = "FormOptions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOptions_FormClosing);
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormOptions_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormOptions_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormOptions_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_Ajouter;
        private System.Windows.Forms.RadioButton RB_Modifier;
        private System.Windows.Forms.RadioButton RB_Supprimer;
        private System.Windows.Forms.ComboBox CB_Invisible;
        private System.Windows.Forms.ComboBox CB_Value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Label LB_Text;
        private FlashButton.FlashButton FB_Quitter;
        private FlashButton.FlashButton FB_Annuler;
        private FlashButton.FlashButton FB_Ok;
    }
}