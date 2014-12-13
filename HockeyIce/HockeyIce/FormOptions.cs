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
    public partial class FormOptions : Form
    {
        // bool savoir si on est entrain de deplacer le form
        private bool _dragging = false;
        // emmagasine la position du curseur lors d'un deplacement de form
        private Point _start_point = new Point(0, 0);
        // variable contenant la connection a la bd 
        public OracleConnection oraconnGestion = new OracleConnection();
        // string contentenat les différentes commandes voulu
        string sqlcommande, sqlcommandedelete;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONSTRUCTEUR
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public FormOptions(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnGestion = oraconn;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD ET CLOSING
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormOptions_Load(object sender, EventArgs e)
        {
            // loading de la position sauvegardé antérieurement 
            this.Location = Properties.Settings.Default.PosFormOptions;
            // Remplis le combobox 
            SwitchCommandeComboBox();
            // enable/disable les controls
            UpdateControl();
        }
        private void FormOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Enregistre la localisation du form pour utilisation prochaine
            Properties.Settings.Default.PosFormOptions = this.Location;
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
//      SUPPRIMER
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // selon le choix fait, va utiliser la commande demandé
        private void WhattoDelete()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Équipes":
                    sqlcommandedelete = "delete from equipes where numequipe =" + CB_Invisible.Text;
                    break;
                case "Joueurs":
                    sqlcommandedelete = "delete from joueurs where numjoueur =" + CB_Invisible.Text;
                    break;
                case "Division":
                    sqlcommandedelete = "delete from divisions where numdivision =" + CB_Invisible.Text;
                    break;
                case "Matchs":
                    sqlcommandedelete = "delete from matchs where nummatch =" + CB_Invisible.Text;
                    break;
            }
        }
        // execute la commande de suppression
        private bool DeleteThing()
        {
            WhattoDelete();
            bool reussi = true;
            OracleCommand orcd = new OracleCommand(sqlcommandedelete, oraconnGestion);
            try
            {
                orcd.CommandType = CommandType.Text;
                orcd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
                reussi = false;
            }
            return reussi;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD DU COMBOBOX
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Choisi le bon choix selon la fenetre a ouvrir
        private void SwitchCommandeComboBox()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Équipes":
                    sqlcommande = "select numequipe, nom from equipes order by nom";
                    LB_Text.Text = "Équipes";
                    break;
                case "Joueurs":
                    sqlcommande = "select numjoueur, prenom, nom from joueurs order by prenom";
                    LB_Text.Text = "Joueurs";
                    break;
                case "Division":
                    sqlcommande = "select numdivision, nom from divisions order by nom";
                    LB_Text.Text = "Divisions";
                    break;
                case "Matchs":
                    sqlcommande = "select m.nummatch, ev.nom, em.nom from matchs m " +
                                  "inner join equipes ev on ev.numequipe = m.numequipevis " +
                                  "inner join equipes em on em.numequipe = m.numequipemai " + " order by ev.nom ";
                    LB_Text.Text = "Matchs";
                    break;
            }
            RemplirComboBox();
        }
        // remplissage du combobox selon la fenetre a ouvrir
        private void RemplirComboBox()
        {
            try
            {
                OracleCommand orcd = new OracleCommand(sqlcommande, oraconnGestion);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while (oraRead.Read())
                {
                    CB_Invisible.Items.Add(oraRead.GetInt32(0).ToString());
                    switch (Properties.Settings.Default.FenetreAOuvrir)
                    {
                        case "Équipes":
                            CB_Value.Items.Add(oraRead.GetString(1).ToString());
                            break;
                        case "Joueurs":
                            CB_Value.Items.Add(oraRead.GetString(1).ToString() + " " + oraRead.GetString(2).ToString());
                            break;
                        case "Division":
                            CB_Value.Items.Add(oraRead.GetString(1).ToString());
                            break;
                        case "Matchs":
                            CB_Value.Items.Add(oraRead.GetString(1).ToString() + " vs " + oraRead.GetString(2).ToString());
                            break;
                    }
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
        // ouverture du form Gestion
        private void AfficherGestion()
        {
            FormGestion dlg = new FormGestion(oraconnGestion);

            dlg.ShowDialog();
        }
        // Verifie et fait en conséquence du choix du radiobutton
        private void VerifierRadioButton()
        {
            if (RB_Supprimer.Checked)
            {
                if (DeleteThing())
                {
                    MessageBox.Show("Suppression réussi");
                }
                else
                {
                    MessageBox.Show("Suppression non réussi");
                }
                this.Close();
            }
            else if (RB_Modifier.Checked)
            {
                Properties.Settings.Default.ModifierAjouter = true;
                Properties.Settings.Default.NumValue = CB_Invisible.Text;
                Properties.Settings.Default.Save();
                AfficherGestion();
                this.Close();
            }
            else
            {
                Properties.Settings.Default.ModifierAjouter = false;
                Properties.Settings.Default.NumValue = "1";
                Properties.Settings.Default.Save();
                AfficherGestion();
                this.Close();
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
        private void RB_Supprimer_CheckedChanged(object sender, EventArgs e)
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
            else if (RB_Modifier.Checked || RB_Supprimer.Checked)
            {
                if (CB_Value.Text != "")
                {
                    FB_Ok.Enabled = true;
                }
            }
        }
    }
}
