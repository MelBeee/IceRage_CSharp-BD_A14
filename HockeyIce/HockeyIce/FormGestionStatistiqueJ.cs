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
        const char BACKSPACE = '\b';

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
            TT_Punition.SetToolTip(this.TB_Punition, "Le temps en seconde !");
            FB_Ajouter.Enabled = false;
        }
        private void FormGestionStatistiqueJ_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormGestStat = this.Location;
        }

        // Fonctions pour les chiffres seulement
        bool EstChiffre(char c)
        {
            String chiffres = "0123456789";
            return (chiffres.IndexOf(c.ToString()) != -1);
        }
        private void TB_Buts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != BACKSPACE)
                e.Handled = !EstChiffre(e.KeyChar);
        }

        // Change les boutons
        private void UpdateControl()
        {
            if(LB_Invisible.Text == "Gardien")
            {
                FB_Ajouter.Enabled = (CB_Joueur.Text == "" ||
                                      CB_Match.Text == "" ||
                                      TB_Punition.Text == "" ||
                                      TB_Buts.Enabled       ||
                                      TB_Passes.Enabled) ? false : true;
            }
            else
            {
                FB_Ajouter.Enabled = (CB_Joueur.Text == "" ||
                      CB_Match.Text == "" ||
                      TB_Punition.Text == "" ||
                      TB_Buts.Text == "" ||
                      TB_Passes.Text == "") ? false : true;
            }
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
            string Sql = "select m.nummatch, ev.nom, em.nom " +
                         "from matchs m " +
                         "inner join equipes ev on ev.numequipe = m.numequipevis " +
                         "inner join equipes em on em.numequipe = m.numequipemai " ; 
            try
            {
                OracleCommand orcd = new OracleCommand(Sql, oraconnStats);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while(oraRead.Read())
                {
                    CB_Invisible.Items.Add(oraRead.GetInt32(0).ToString());
                    CB_Match.Items.Add(oraRead.GetString(1).ToString() + " vs " + oraRead.GetString(2).ToString());
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
            string Sql = "  select j.numjoueur, j.prenom, j.nom from joueurs j " +
                           " inner join equipes e on e.numequipe = j.numequipe " + 
                           " inner join matchs m on e.numequipe = m.numequipemai " +
                           " where m.nummatch = " + CB_Invisible.Text +
                           " union " +
                           " select j.numjoueur, j.prenom, j.nom from joueurs j " +
                           " inner join equipes e on e.numequipe = j.numequipe  " +
                           " inner join matchs m on e.numequipe = m.numequipevis " +
                           " where m.nummatch = " + CB_Invisible.Text + " ";
            try
            {
                OracleCommand orcd = new OracleCommand(Sql, oraconnStats);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraReadJ = orcd.ExecuteReader();

                while (oraReadJ.Read())
                {
                    CB_InvisibleJ.Items.Add(oraReadJ.GetInt32(0).ToString());
                    CB_Joueur.Items.Add(oraReadJ.GetString(1) + " " + oraReadJ.GetString(2));
                }

                oraReadJ.Close();
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
            }
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
            CB_Invisible.SelectedIndex = CB_Match.SelectedIndex;
            CB_InvisibleJ.Items.Clear();
            CB_Joueur.Items.Clear();
            RempliComboBoxJoueur();
        }

        private bool AjoutStats()
        {
            bool reussi = true; 
            string sql = "Insert into StatistiquesJoueurs values(" + 
                CB_Invisible.Text + ", " +
                CB_InvisibleJ.Text + ", " +
                TB_Buts.Text + ", " +
                TB_Passes.Text + ", '" + 
                TB_Punition.Text + "') " ;
            OracleCommand orcd = new OracleCommand(sql, oraconnStats);
            try
            {
                orcd.CommandType = CommandType.Text;
                orcd.ExecuteNonQuery();
            }
            catch(OracleException ex)
            {
                SwitchException(ex);
                reussi = false;
            }
            return reussi;
        }

        private void TB_Punition_TextChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }

        private void TB_Buts_TextChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }

        private void TB_Passes_TextChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }

        private void CB_Match_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Invisible.SelectedIndex = CB_Match.SelectedIndex;
            UpdateControl();
        }

        private void CB_Joueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_InvisibleJ.SelectedIndex = CB_Joueur.SelectedIndex;
            UpdateControl();
            UpdateTextBox();
        }

        private void CB_Joueur_TextChanged(object sender, EventArgs e)
        {
            CB_InvisibleJ.SelectedIndex = CB_Joueur.SelectedIndex;
            UpdateControl();
        }

        private void UpdateTextBox()
        {
            TB_Buts.Enabled = true;
            TB_Passes.Enabled = true;
            TB_Buts.BackColor = SystemColors.Window;
            TB_Passes.BackColor = SystemColors.Window;
            string Sql = "select typejoueur from joueurs where numjoueur = " + CB_InvisibleJ.Text;
            try
            {
                OracleCommand orcd = new OracleCommand(Sql, oraconnStats);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while(oraRead.Read())
                {
                    LB_Invisible.Text = oraRead.GetString(0).ToString();
                }

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
            }

            if (LB_Invisible.Text == "Gardien")
            {
                TB_Buts.Enabled = false;
                TB_Passes.Enabled = false;
                TB_Buts.BackColor = Color.FromArgb(95,124,143);
                TB_Passes.BackColor = Color.FromArgb(95, 124, 143);
                TB_Buts.Text = null;
                TB_Passes.Text = null;
            }
        }

        // Events de closing
        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_Ajouter_Click(object sender, EventArgs e)
        {
            if (AjoutStats())
            {
                MessageBox.Show("Insertion réussi");
            }

        }
    }
}
