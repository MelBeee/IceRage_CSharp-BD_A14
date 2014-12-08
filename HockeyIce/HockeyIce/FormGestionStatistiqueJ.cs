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
    public partial class FormGestionStatistiqueJ : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private OracleConnection oraconnStats;

        public FormGestionStatistiqueJ(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnStats = oraconn;
        }
        // Load et Closing
        private void FormGestionStatistiqueJ_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PosFormGestStat;
            RempliComboBoxMatch();

            FB_Ajouter.Enabled = false;


        }
        private void UpdateControl()
        {
            if(TB_Punition.Text == null)
            {

            }
        }

        private bool ElementRempli()
        {
            return (TB_Punition.Text == null &&
                    NUD_Buts.Value == null &&
                    NUD_Passes.Value == null);
        }
        private void FormGestionStatistiqueJ_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormGestStat = this.Location;
        }
        // Form movable
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

        private void RempliComboBoxMatch()
        {
            string Sql = "select nummatch from matchs"; 

            try
            {
                OracleCommand orcd = new OracleCommand(Sql, oraconnStats);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while(oraRead.Read())
                {
                    CB_Match.Items.Add(oraRead.GetInt32(0));
                }

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
            }
        }

        private void RempliComboBoxJoueur()
        {
            string Sql = "  select j.prenom, j.nom from joueurs j " +
                           " inner join equipes e on e.numequipe = j.numequipe " + 
                           " inner join matchs m on e.numequipe = m.numequipemai " +
                           " where m.nummatch = " + CB_Match.Text +
                           " union " +
                           " select j.prenom, j.nom from joueurs j " +
                           " inner join equipes e on e.numequipe = j.numequipe  " +
                           " inner join matchs m on e.numequipe = m.numequipevis " +
                           " where m.nummatch = " + CB_Match.Text;
            try
            {
                OracleCommand orcd = new OracleCommand(Sql, oraconnStats);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraReadJ = orcd.ExecuteReader();

                while (oraReadJ.Read())
                {
                    CB_Joueur.Items.Add(oraReadJ.GetString(0) + " " + oraReadJ.GetString(1));
                }

                oraReadJ.Close();
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
            }
        }

        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Gestion des erreurs
        private void SwitchException(OracleException ex)
        {
            string CodeErreur = ex.Number.ToString();
            string DescriptionErreur;
            switch (ex.Number)
            {
                case 2292:
                    DescriptionErreur = "Tentative de suppression d'une clé lié à une clé étrangère";
                    break;
                case 1407:
                    DescriptionErreur = "Vous ne pouvez pas mettre a jour une colonne avec une valeur null";
                    break;
                case 1400:
                    DescriptionErreur = "Vous ne pouvez pas ajouter une colonne avec une valeur null";
                    break;
                case 1:
                    DescriptionErreur = "Le numero d'employé doit être unique";
                    break;
                case 1410:
                    DescriptionErreur = "Vous ne pouvez pas mettre de valeur null";
                    break;
                case 1017:
                    DescriptionErreur = "Mot de passe ou nom d'utilisateur invalide, connection non établi";
                    break;
                case 12170:
                    DescriptionErreur = "La base de données est indisponible, réessayer plus tard";
                    break;
                case 12543:
                    DescriptionErreur = "Connexion impossible. Vérifiez votre connection internet";
                    break;
                case 12533:
                    DescriptionErreur = "Connexion impossible. Le parametre de connexion d'adresse est invalide";
                    break;
                case 12504:
                    DescriptionErreur = "Connexion impossible. Le nom d'instance Oracle est invalide";
                    break;
                case 12541:
                    DescriptionErreur = "Connexion impossible. La destination est invalide ou pas rejoignable";
                    break;
                default:
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

            if (dlg.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void CB_Match_TextChanged(object sender, EventArgs e)
        {
            CB_Joueur.Items.Clear();
            RempliComboBoxJoueur();
        }

        private void flashButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
