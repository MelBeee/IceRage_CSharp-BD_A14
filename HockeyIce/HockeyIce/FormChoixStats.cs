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
        }
        private void FormChoixStats_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Enregistre la localisation du form pour utilisation prochaine
            Properties.Settings.Default.PosFormChoixStats = this.Location;
            Properties.Settings.Default.Save();
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
//      RADIOBUTTONS 
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Verifier et faire en consequence du choix du radiobutton choisi
        private void VerifierRadioButton()
        {
            if (RB_Afficher.Checked)
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
        // Update selon le radiobutton choisi
        private void UpdateControl()
        {
            FB_Ok.Enabled = (RB_Afficher.Checked || RB_Ajouter.Checked) ? true : false;
        }
        private void RB_Ajouter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }
        private void RB_Afficher_CheckedChanged(object sender, EventArgs e)
        {
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
