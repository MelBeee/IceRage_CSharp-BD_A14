using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyIce
{
    public partial class FormErreur : Form
    {
        public FormErreur()
        {
            InitializeComponent();
            
        }

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void FormErreur_Load(object sender, EventArgs e)
        {
            LB_Text.Text += " " + Properties.Settings.Default.CodeErreur;
            LB_Description.Text = Properties.Settings.Default.DescriptionErreur;
            this.Location = Properties.Settings.Default.PosFormErreur;
        }

        private void FormErreur_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void FormErreur_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }

        private void FormErreur_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void LB_Text_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void LB_Text_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void LB_Text_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }

        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FB_Continuer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormErreur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormErreur = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
