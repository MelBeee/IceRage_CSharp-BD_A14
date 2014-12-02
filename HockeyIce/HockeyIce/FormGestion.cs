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

        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {
            EnabledVisibleLesPanels();
        }

        private void EnabledVisibleLesPanels()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Equipe":
                    PN_Equipe.Parent = this;
                    PN_Equipe.Visible = true;
                    PN_Equipe.Enabled = true;
                    PN_Equipe.Location = basePanel;

                    PN_Joueurs.Visible = false;
                    PN_Joueurs.Enabled = false;

                    PN_GestionDivision.Visible = false;
                    PN_GestionDivision.Enabled = false;
                   
                    LB_Text.Text = "Gestion des équipes";
                    break;
                case "Joueur":
                    PN_Equipe.Visible = false;
                    PN_Equipe.Enabled = false;

                    PN_Joueurs.Parent = this;
                    PN_Joueurs.Visible = true;
                    PN_Joueurs.Enabled = true;
                    PN_Joueurs.Location = basePanel;

                    PN_GestionDivision.Visible = false;
                    PN_GestionDivision.Enabled = false;
                    
                    LB_Text.Text = "Gestion des joueurs";
                    break;
                case "Division":
                    PN_Equipe.Visible = false;
                    PN_Equipe.Enabled = false;

                    PN_Joueurs.Visible = false;
                    PN_Joueurs.Enabled = false;

                    PN_GestionDivision.Parent = this;
                    PN_GestionDivision.Visible = true;
                    PN_GestionDivision.Enabled = true;
                    PN_GestionDivision.Location = basePanel;
                    LB_Text.Text = "Gestion des divisions";
                    break;
            }
        }
    }
}
