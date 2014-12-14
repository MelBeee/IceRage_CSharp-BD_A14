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
//      FORM CHOIX STATS
//      Fait par Melissa Boucher et Xavier Brosseau
//      15 Decembre 2014
//      Produit pour le cours de Base de Données et Developpement d'Interfaces
//
//      Utilisé pour faire un choix entre updaté des statistiques ou afficher les statistiques des joueurs
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace HockeyIce
{
    public partial class FormChoixStats : Form
    {
        // variable contenant la connection a la bd 
        private OracleConnection oraconnChoixStats = new OracleConnection();
        // bool savoir si on est entrain de deplacer le form
        private bool _dragging = false;
        // emmagasine la position du curseur lors d'un deplacement de form
        private Point _start_point = new Point(0, 0);
        // string contentenat les différentes commandes voulu
        string sqlcommande;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONSTRUCTEUR
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public FormChoixStats(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnChoixStats = oraconn;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD ET CLOSING
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormChoixStats_Load(object sender, EventArgs e)
        {
            // loading de la position sauvegardé antérieurement 
            this.Location = Properties.Settings.Default.PosFormChoixStats;
            UpdateControl();
            RemplirComboBox();
        }
        private void FormChoixStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Enregistre la localisation du form pour utilisation prochaine
            Properties.Settings.Default.PosFormChoixStats = this.Location;
            Properties.Settings.Default.Save();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      GESTION ERREURS
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
//      EVENTS DE FLASHBUTTON
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_Ok_Click(object sender, EventArgs e)
        {
            VerifierRadioButton();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD DU COMBOBOX
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // remplissage du combobox 
        private void RemplirComboBox()
        {
            sqlcommande = " select e.numequipe, e.nom from equipes e " +
                            " inner join joueurs j on j.numequipe = e.numequipe " +
                            " where (select count(numjoueur) from joueurs) > 0 " +
                            " group by e.numequipe, e.nom";
            try
            {
                OracleCommand orcd = new OracleCommand(sqlcommande, oraconnChoixStats);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while (oraRead.Read())
                {
                    CB_Invisible.Items.Add(oraRead.GetInt32(0));
                    CB_Equipe.Items.Add(oraRead.GetString(1));
                }
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      RADIOBUTTONS 
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Verifier et faire en consequence du choix du radiobutton choisi
        private void VerifierRadioButton()
        {
            if (RB_TousJoueurs.Checked)
            {
                Properties.Settings.Default.FenetreAOuvrir = "Joueurs";
                Properties.Settings.Default.ModifierAjouter = false;
                Properties.Settings.Default.Save();
                AfficherRecherche();
            }
            else if(RB_JoueurEquipe.Checked)
            {
                Properties.Settings.Default.FenetreAOuvrir = "Joueurs";
                Properties.Settings.Default.NumValue = CB_Invisible.Text;
                Properties.Settings.Default.ModifierAjouter = true;
                Properties.Settings.Default.Save();
                AfficherRecherche();
            }
            else
            {
                FormGestionStatistiqueJ dlg = new FormGestionStatistiqueJ(oraconnChoixStats);

                dlg.ShowDialog();
            }
            this.Close();
        }
        // ouverture du form Recherche
        private void AfficherRecherche()
        {
            FormRecherche dlg = new FormRecherche(oraconnChoixStats);

            dlg.ShowDialog();
        }
        // Update selon le radiobutton choisi
        private void UpdateControl()
        {
            FB_Ok.Enabled = (RB_TousJoueurs.Checked || RB_AjouterStats.Checked) ? true : false;
            if(RB_JoueurEquipe.Checked)
            {
                if(CB_Equipe.Text != "")
                {
                    FB_Ok.Enabled = true; 
                }
            }
        }
        private void RB_Ajouter_CheckedChanged(object sender, EventArgs e)
        {
            CB_Equipe.Enabled = false;
            CB_Equipe.Visible = false;
            UpdateControl();
        }
        private void RB_Afficher_CheckedChanged(object sender, EventArgs e)
        {
            CB_Equipe.Enabled = false;
            CB_Equipe.Visible = false;
            UpdateControl();
        }
        private void RB_JoueurEquipe_CheckedChanged(object sender, EventArgs e)
        {
            CB_Equipe.Enabled = true;
            CB_Equipe.Visible = true;
            UpdateControl();
        }
        private void CB_Equipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Invisible.SelectedIndex = CB_Equipe.SelectedIndex;
            UpdateControl();
        }
        private void CB_Equipe_TextChanged(object sender, EventArgs e)
        {
            CB_Invisible.SelectedIndex = CB_Equipe.SelectedIndex;
            UpdateControl();
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
    }
}
