using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace HockeyIce
{
    public partial class FormChoixStats : Form
    {
        private OracleConnection oraconnChoixStats = new OracleConnection();
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public FormChoixStats(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnChoixStats = oraconn; 
        }

        private void FB_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FB_Ok_Click(object sender, EventArgs e)
        {
            if(RB_Afficher.Checked)
            {
                FormRecherche dlg = new FormRecherche(oraconnChoixStats);
                
                Properties.Settings.Default.FenetreAOuvrir = "Joueurs";
                Properties.Settings.Default.Save();

                dlg.ShowDialog();
            }
            else
            {
                FormGestionStatistiqueJ dlg = new FormGestionStatistiqueJ(oraconnChoixStats);

                dlg.ShowDialog();
            }
            this.Close();
        }

        private void UpdateControl()
        {
            FB_Ok.Enabled = (RB_Afficher.Checked || RB_Ajouter.Checked) ? true : false;
        }

        private void FormChoixStats_Load(object sender, EventArgs e)
        {
            UpdateControl();
            this.Location = Properties.Settings.Default.PosFormChoixStats;
        }

        private void RB_Ajouter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }

        private void RB_Afficher_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }

        private void FormGestionStatistiqueJ_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }
        private void FormGestionStatistiqueJ_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void FormGestionStatistiqueJ_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void FormChoixStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormChoixStats = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
