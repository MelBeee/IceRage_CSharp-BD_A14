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

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      FORM GESTION STATISTIQUES
//      Fait par Melissa Boucher et Xavier Brosseau
//      15 Decembre 2014
//      Produit pour le cours de Base de Données et Developpement d'Interfaces
//
//      Utilisé pour ajouter des statistiques de matchs aux joueurs
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace HockeyIce
{
    public partial class FormGestionStatistiqueJ : Form
    {
        // bool savoir si on est entrain de deplacer le form
        private bool _dragging = false;
        // emmagasine la position du curseur lors d'un deplacement de form
        private Point _start_point = new Point(0, 0);
        // variable contenant la connection a la bd 
        private OracleConnection oraconnStats;
        // variable utilisé pour la verification dans les textboxs
        const char BACKSPACE = '\b';

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONSTRUCTEUR
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public FormGestionStatistiqueJ(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnStats = oraconn;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD ET CLOSING
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormGestionStatistiqueJ_Load(object sender, EventArgs e)
        {
            // loading de la position sauvegardé antérieurement 
            this.Location = Properties.Settings.Default.PosFormGestStat;
            // rempli le combo box de tout les matchs 
            RempliComboBoxMatch();
            // initialise les tooltips
            TT_Punition.SetToolTip(this.TB_Punition, "Le temps en seconde !");
            TT_CB_Joueur.SetToolTip(this.CB_Joueur, "Affiche seulement les joueurs n'ayant aucune statistiques");
            FB_Ajouter.Enabled = false;
        }
        private void FormGestionStatistiqueJ_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Enregistre la localisation du form pour utilisation prochaine
            Properties.Settings.Default.PosFormGestStat = this.Location;
            Properties.Settings.Default.Save();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      VERIFICATION DES CARACTERES
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // lorsqu'on veut seulement un chiffre
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

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      DEPLACEMENT DU FORM
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormGestionStatistiqueJ_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // Enregistre que l'utilisateur a selectionner la form
            _start_point = new Point(e.X, e.Y); // Enregistre le point actuelle du form 
        }
        private void FormGestionStatistiqueJ_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging) // si l'utilisateur a selectionner le form
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void FormGestionStatistiqueJ_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; // Enregistre que l'utilisateur a "lacher le form"
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      EVENTS DE FLASHBUTTON
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void UpdateControl()
        {
            if (LB_Invisible.Text == "Gardien")
            {
                FB_Ajouter.Enabled = (CB_Joueur.Text == "" ||
                                      CB_Match.Text == "" ||
                                      TB_Punition.Text == "" ||
                                      TB_Buts.Enabled ||
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
                MessageBox.Show("Insertion réussite");
            }
            else
            {
                MessageBox.Show("Insertion non réussite");
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      ERREURS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AfficherErreur(OracleException ex)
        {
            FormErreur dlg = new FormErreur(ex);

            if (dlg.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      VERIFICATION TEXT QUI CHANGE CB/TB
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void CB_Match_TextChanged(object sender, EventArgs e)
        {
            CB_Invisible.SelectedIndex = CB_Match.SelectedIndex;
            CB_InvisibleJ.Items.Clear();
            CB_Joueur.Items.Clear();
            RempliComboBoxJoueur();
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

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      REMPLISSAGE DES COMBOBOX
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
                AfficherErreur(ex);
            }
        }
        private void RempliComboBoxJoueur()
        {
            string Sql = "(SELECT J.* FROM JOUEURS J " +
                            "INNER JOIN EQUIPES E ON J.NUMEQUIPE = E.NUMEQUIPE " +
                            "INNER JOIN MATCHS MV ON MV.NUMEQUIPEVIS = E.NUMEQUIPE " +
                            "WHERE MV.NUMMATCH = " + CB_Invisible.Text +
                            "UNION " +
                            "SELECT J.* FROM JOUEURS J " +
                            "INNER JOIN EQUIPES E ON J.NUMEQUIPE = E.NUMEQUIPE " +
                            "INNER JOIN MATCHS MM ON MM.NUMEQUIPEMAI = E.NUMEQUIPE " +
                            "WHERE MM.NUMMATCH = " + CB_Invisible.Text + ") " +
                            "MINUS " +
                            "SELECT J.* FROM STATISTIQUESJOUEURS S  " +
                            "INNER JOIN JOUEURS J ON J.NUMJOUEUR = S.NUMJOUEUR  " +
                            "WHERE S.NUMMATCH = " + CB_Invisible.Text;
  
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
                AfficherErreur(ex);
            }
        }
        // vérifie si le joueur choisi est un gardien, si oui, disable les buts/passes
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

                while (oraRead.Read())
                {
                    LB_Invisible.Text = oraRead.GetString(0).ToString();
                }

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }

            if (LB_Invisible.Text == "Gardien")
            {
                TB_Buts.Enabled = false;
                TB_Passes.Enabled = false;
                TB_Buts.BackColor = Color.FromArgb(95, 124, 143);
                TB_Passes.BackColor = Color.FromArgb(95, 124, 143);
                TB_Buts.Text = null;
                TB_Passes.Text = null;
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      AJOUT DES STATS DANS BD
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
                AfficherErreur(ex);
                reussi = false;
            }
            return reussi;
        }

    }
}
