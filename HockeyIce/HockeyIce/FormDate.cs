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
    public partial class FormDate : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public FormDate()
        {
            InitializeComponent();
        }

        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDate_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PosFormDate;
            MC_Date.SelectionRange.Start = Properties.Settings.Default.DateChoisi;
        }

        private void FormDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormDate = this.Location;
            Properties.Settings.Default.Save();
        }

        // Events pour pouvoir faire bouger le form 
        private void FormDate_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }
        private void FormDate_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void FormDate_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Properties.Settings.Default.DateChoisi = MC_Date.SelectionRange.Start;
            Properties.Settings.Default.Save();
        }

        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
