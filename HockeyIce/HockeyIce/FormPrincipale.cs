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
    public partial class FormPrincipale : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        public bool connection = false;
        private OracleConnection oraconn = new OracleConnection();

        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            Connection();
            FB_Retour.Enabled = false;
            if (!connection)
            {
                PasDeConnection();
            }
        }

        private void PasDeConnection()
        {
            PN_PasDeConnection.Enabled = true;
            PN_PasDeConnection.Visible = true;
            FB_Fermer.Enabled = false;
            FB_APropos.Enabled = false; 
        }

        private void Connection()
        {
            if (!connection)
            {
                //Remplit le DSource
                string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                    "(HOST=205.237.244.251)(PORT=1521)))" +
                    "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
                string user = "boucherm";
                string passwd = "ORACLE1";

                string chaineconnection = "Data Source = " + Dsource + ";User Id =" + user + "; Password =" + passwd;
                connection = true;
                try
                {
                    oraconn.ConnectionString = chaineconnection;
                    oraconn.Open();
                }
                catch (OracleException ex)
                {
                    SwitchException(ex);
                    connection = false;
                }
            }
        }

        private void SwitchException(OracleException ex)
        {
            string CodeErreur;
            string DescriptionErreur;
            switch (ex.Number)
            {
                case 2292:
                    CodeErreur = ex.Number.ToString();
                    DescriptionErreur = "Tentative de suppression d'une clé lié à une clé étrangère "; 
                    break;
                case 1407:
                    CodeErreur = ex.Number.ToString();
                    DescriptionErreur = "Vous ne pouvez pas mettre a jour une colonne avec une valeur null";
                    break;
                case 1400:
                    CodeErreur = ex.Number.ToString();
                    DescriptionErreur = "Vous ne pouvez pas ajouter une colonne avec une valeur null";
                    break;
                case 1:
                    CodeErreur = ex.Number.ToString();
                    DescriptionErreur = "Le numero d'employé doit être unique";
                    break;
                case 1410:
                    CodeErreur = ex.Number.ToString();
                    DescriptionErreur = "Vous ne pouvez pas mettre de valeur null";
                    break;
                case 1017:
                    CodeErreur = ex.Number.ToString();
                    DescriptionErreur = "Mot de passe ou nom d'utilisateur invalide, connection non établi";
                    break;
                case 12170:
                    CodeErreur = ex.Number.ToString();
                    DescriptionErreur = "La base de données est indisponible, réessayer plus tard";
                    break;
                case 12543:
                    CodeErreur = ex.Number.ToString();
                    DescriptionErreur = "Connexion impossible,Vérifiez votre connection internet";
                    break;
                default:
                    CodeErreur = ex.Number.ToString();
                    DescriptionErreur = ex.Message; 
                    break;
            }
            Properties.Settings.Default.CodeErreur = CodeErreur;
            Properties.Settings.Default.DescriptionErreur = DescriptionErreur;
            Properties.Settings.Default.Save();

            AfficherErreur();
        }

        private void AfficherErreur()
        {
            FormErreur dlg = new FormErreur();

            dlg.ShowDialog();
        }
      
        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LB_NomApp_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void LB_NomApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void LB_NomApp_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }

        private void FormPrincipale_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void FormPrincipale_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }

        private void FormPrincipale_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void FB_QuitterPDC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FB_APropos_Click(object sender, EventArgs e)
        {
            AfficherAPropos();
        }

        private void AfficherAPropos()
        {
            FormAPropos dlg = new FormAPropos();

            dlg.ShowDialog();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    AfficherAPropos();
                    break;
                case (Keys.Control | Keys.Q):
                    this.Close();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
            bool result = base.ProcessCmdKey(ref msg, keyData);
            return result;
        }
    }
}

