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
//      FORM OPTIONS
//      Fait par Melissa Boucher et Xavier Brosseau
//      15 Decembre 2014
//      Produit pour le cours de Base de Données et Developpement d'Interfaces
//
//      Utilisé pour faire un choix pour modifier/supprimer/ajouter un element dans une des 4 tables de la BD 
//      soit Divisions, Equipes, Joueurs ou Match
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace HockeyIce
{
    public partial class FormOptionJoueurs : Form
    {
        // bool savoir si on est entrain de deplacer le form
        private bool _dragging = false;
        // emmagasine la position du curseur lors d'un deplacement de form
        private Point _start_point = new Point(0, 0);
        // variable contenant la connection a la bd 
        public OracleConnection oraconnOptionJ = new OracleConnection();
        // string contentenat les différentes commandes voulu
        string sqlcommande;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONSTRUCTEUR
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public FormOptionJoueurs(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnOptionJ = oraconn;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD ET CLOSING
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormOptionJoueurs_Load(object sender, EventArgs e)
        {
            // loading de la position sauvegardé antérieurement 
            this.Location = Properties.Settings.Default.PosFormOptionJ;
            // enable/disable les controls
            UpdateControl();
            RemplirComboBox();
        }
        private void FormOptionJoueurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Enregistre la localisation du form pour utilisation prochaine
            Properties.Settings.Default.PosFormOptionJ = this.Location;
            Properties.Settings.Default.Save();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      DEPLACEMENT DU FORM
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormOptions_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // Enregistre que l'utilisateur a selectionner la form
            _start_point = new Point(e.X, e.Y); // Enregistre le point actuelle du form 
        }
        private void FormOptions_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging) // si l'utilisateur a selectionner le form
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void FormOptions_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; // Enregistre que l'utilisateur a "lacher le form"
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
//      LOAD DU COMBOBOX
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // remplissage du combobox 
        private void RemplirComboBox()
        {
            sqlcommande = "select numequipe, nom from equipes";
            try
            {
                OracleCommand orcd = new OracleCommand(sqlcommande, oraconnOptionJ);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while (oraRead.Read())
                {
                    CB_Invisible.Items.Add(oraRead.GetInt32(0));
                    CB_Value.Items.Add(oraRead.GetString(1));
                }
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      SUPPRIMER OU MODIFIER OU AJOUTER 
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // ouverture du form Recherche
        private void AfficherRecherche()
        {
            FormRecherche dlg = new FormRecherche(oraconnOptionJ);

            dlg.ShowDialog();
        }
        // Verifie et fait en conséquence du choix du radiobutton
        private void VerifierRadioButton()
        {
           if(RB_Ajouter.Checked)
           {
               Properties.Settings.Default.ModifierAjouter = false;
               Properties.Settings.Default.Save();
               AfficherRecherche();
           }
           else
           {
               Properties.Settings.Default.NumValue = CB_Invisible.Text;
               Properties.Settings.Default.ModifierAjouter = true;
               Properties.Settings.Default.Save();
               AfficherRecherche();
           }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      EVENTS DE CHANGEMENT DE SELECTION
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void CB_Value_TextChanged(object sender, EventArgs e)
        {
            CB_Invisible.SelectedIndex = CB_Value.SelectedIndex;
            UpdateControl();
        }
        private void CB_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Invisible.SelectedIndex = CB_Value.SelectedIndex;
            UpdateControl();
        }
        private void RB_Ajouter_CheckedChanged(object sender, EventArgs e)
        {
            CB_Value.Enabled = false;
            CB_Value.Visible = false;
            UpdateControl();
        }
        private void RB_Modifier_CheckedChanged(object sender, EventArgs e)
        {
            CB_Value.Enabled = true;
            CB_Value.Visible = true;
            UpdateControl();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      EVENTS DE FLASHBUTTON 
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_Ok_Click(object sender, EventArgs e)
        {
            VerifierRadioButton();
        }
        private void UpdateControl()
        {
            FB_Ok.Enabled = false;
            if (RB_Ajouter.Checked)
            {
                FB_Ok.Enabled = true;
            }
            else if (RB_Modifier.Checked)
            {
                if (CB_Value.Text != "")
                {
                    FB_Ok.Enabled = true;
                }
            }
        }
    }
}
