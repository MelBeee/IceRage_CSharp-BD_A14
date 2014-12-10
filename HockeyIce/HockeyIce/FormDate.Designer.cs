namespace HockeyIce
{
    partial class FormDate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FB_Appliquer = new FlashButton.FlashButton();
            this.FB_Fermer = new FlashButton.FlashButton();
            this.MC_Date = new System.Windows.Forms.MonthCalendar();
            this.LB_Text = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FB_Quitter = new FlashButton.FlashButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.FB_Appliquer);
            this.panel1.Controls.Add(this.FB_Fermer);
            this.panel1.Controls.Add(this.MC_Date);
            this.panel1.Location = new System.Drawing.Point(2, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 232);
            this.panel1.TabIndex = 0;
            // 
            // FB_Appliquer
            // 
            this.FB_Appliquer.BackgroundImage = global::HockeyIce.Properties.Resources.AjouterNormal;
            this.FB_Appliquer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Appliquer.ImageClick = global::HockeyIce.Properties.Resources.AjouterClick;
            this.FB_Appliquer.ImageDisable = global::HockeyIce.Properties.Resources.AjouterDisable;
            this.FB_Appliquer.ImageNeutral = global::HockeyIce.Properties.Resources.AjouterNormal;
            this.FB_Appliquer.ImageOver = global::HockeyIce.Properties.Resources.AjouterHover;
            this.FB_Appliquer.Location = new System.Drawing.Point(34, 196);
            this.FB_Appliquer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FB_Appliquer.Name = "FB_Appliquer";
            this.FB_Appliquer.Size = new System.Drawing.Size(102, 20);
            this.FB_Appliquer.TabIndex = 35;
            this.FB_Appliquer.Click += new System.EventHandler(this.FB_Appliquer_Click);
            // 
            // FB_Fermer
            // 
            this.FB_Fermer.BackgroundImage = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_Fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Fermer.ImageClick = global::HockeyIce.Properties.Resources.FermerClick;
            this.FB_Fermer.ImageDisable = global::HockeyIce.Properties.Resources.FermerDisable;
            this.FB_Fermer.ImageNeutral = global::HockeyIce.Properties.Resources.FermerNormal;
            this.FB_Fermer.ImageOver = global::HockeyIce.Properties.Resources.FermerHover;
            this.FB_Fermer.Location = new System.Drawing.Point(145, 196);
            this.FB_Fermer.Name = "FB_Fermer";
            this.FB_Fermer.Size = new System.Drawing.Size(100, 20);
            this.FB_Fermer.TabIndex = 1;
            this.FB_Fermer.Click += new System.EventHandler(this.FB_Fermer_Click);
            // 
            // MC_Date
            // 
            this.MC_Date.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.MC_Date.Location = new System.Drawing.Point(26, 22);
            this.MC_Date.MaxSelectionCount = 1;
            this.MC_Date.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.MC_Date.Name = "MC_Date";
            this.MC_Date.ShowTodayCircle = false;
            this.MC_Date.TabIndex = 0;
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(27, 2);
            this.LB_Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(106, 23);
            this.LB_Text.TabIndex = 12;
            this.LB_Text.Text = "Choisir date";
            this.LB_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseDown);
            this.LB_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseMove);
            this.LB_Text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Text_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HockeyIce.Properties.Resources.HockeyIcon;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
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
            this.FB_Quitter.Location = new System.Drawing.Point(263, 2);
            this.FB_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.FB_Quitter.Name = "FB_Quitter";
            this.FB_Quitter.Size = new System.Drawing.Size(19, 20);
            this.FB_Quitter.TabIndex = 10;
            this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
            // 
            // FormDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.LB_Text);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FB_Quitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDate";
            this.Text = "FormDate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDate_FormClosing);
            this.Load += new System.EventHandler(this.FormDate_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDate_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_Text;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FlashButton.FlashButton FB_Quitter;
        private System.Windows.Forms.MonthCalendar MC_Date;
        private FlashButton.FlashButton FB_Fermer;
        private FlashButton.FlashButton FB_Appliquer;
    }
}