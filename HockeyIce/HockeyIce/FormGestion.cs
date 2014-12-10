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
    public partial class FormGestion : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private Point basePanel = new Point(3, 27);
        public OracleConnection oraconnGestion = new OracleConnection();

        public FormGestion(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnGestion = oraconn; 
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {
            EnabledVisibleLesPanels();
            this.Location = Properties.Settings.Default.PosFormGestion;
            if (Properties.Settings.Default.ModifierAjouter)  // True = modifier  false = ajouter
            {
                LB_Division.Text = "Modifier";
                LB_Equipe.Text = "Modifier";
                LB_Joueurs.Text = "Modifier";
                LB_Match.Text = "Modifier";
            }
        }
        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnabledVisibleLesPanels()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Équipes":
                    PN_Equipe.Parent = this;
                    PN_Equipe.Visible = true;
                    PN_Equipe.Enabled = true;
                    PN_Equipe.Location = basePanel;
                    LB_Text.Text = "Gestion des équipes";
                    break;
                case "Joueurs":
                    PN_Joueurs.Parent = this;
                    PN_Joueurs.Visible = true;
                    PN_Joueurs.Enabled = true;
                    PN_Joueurs.Location = basePanel;
                    LB_Text.Text = "Gestion des joueurs";
                    break;
                case "Division":
                    PN_Division.Parent = this;
                    PN_Division.Visible = true;
                    PN_Division.Enabled = true;
                    PN_Division.Location = basePanel;
                    LB_Text.Text = "Gestion des divisions";
                    break;
                case "Matchs":
                    PN_Matchs.Parent = this;
                    PN_Matchs.Visible = true;
                    PN_Matchs.Enabled = true;
                    PN_Matchs.Location = basePanel;
                    LB_Text.Text = "Gestion des matchs";
                    break;
            }
        }

        // Events pour pouvoir faire bouger le form 
        private void FormGestion_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }
        private void FormGestion_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void FormGestion_MouseUp(object sender, MouseEventArgs e)
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

        private void FormGestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormGestion = this.Location;
            Properties.Settings.Default.Save();
        }

        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Date_Click(object sender, EventArgs e)
        {
            FormDate dlg = new FormDate();

            dlg.ShowDialog();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void PN_Joueurs_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
