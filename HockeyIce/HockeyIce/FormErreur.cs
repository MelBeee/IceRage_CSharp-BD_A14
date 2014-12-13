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
//      FORM ERREUR
//      Fait par Melissa Boucher et Xavier Brosseau
//      15 Decembre 2014
//      Produit pour le cours de Base de Données et Developpement d'Interfaces
//
//      Utilisé pour afficher les exceptions dans l'execution du programme
//      Description des exceptions : http://www.techonthenet.com/oracle/errors/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace HockeyIce
{
    public partial class FormErreur : Form
    {
        // garde l'erreur a gerer 
        OracleException ExceptionATraiter;
        // bool savoir si on est entrain de deplacer le form
        private bool _dragging = false;
        // emmagasine la position du curseur lors d'un deplacement de form
        private Point _start_point = new Point(0, 0);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONSTRUCTEUR
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public FormErreur(OracleException ExceptionAGerer)
        {
            InitializeComponent();
            // Traite l'exception passé en construction lors de l'appel d'un autre form
            ExceptionATraiter = ExceptionAGerer;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      FORM LOAD ET CLOSING 
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormErreur_Load(object sender, EventArgs e)
        {
            // loading de la position sauvegardé antérieurement 
            this.Location = Properties.Settings.Default.PosFormErreur;
            // appel de la fonction qui va traiter l'exception
            SwitchException(ExceptionATraiter);
        }
        private void FormErreur_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Enregistre la localisation du form pour utilisation prochaine
            Properties.Settings.Default.PosFormErreur = this.Location;
            Properties.Settings.Default.Save();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      DEPLACEMENT DU FORM
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormErreur_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // Enregistre que l'utilisateur a selectionner la form
            _start_point = new Point(e.X, e.Y); // Enregistre le point actuelle du form 
        }
        private void FormErreur_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; // Enregistre que l'utilisateur a "lacher le form"
        }
        private void FormErreur_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging) // si l'utilisateur a selectionner le form
            {
                Point p = PointToScreen(e.Location); 
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      EVENTS DE FLASHBUTTON
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_Continuer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      SWITCH EXCEPTION
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Traite l'exception lancé
        private void SwitchException(OracleException ex)
        {
            string DescriptionErreur;
            // Va chercher l'erreur lancé et set la description dans un string 
            switch (ex.Number)
            {
                case 00001:
                    DescriptionErreur = "Erreur de valeur unique.";
                    break;
                case 00904:
                    DescriptionErreur = "Nom de colonne invalide ou manquante.";
                    break;
                case 00933:
                    DescriptionErreur = "Commande SQL invalide.";
                    break;
                case 00936:
                    DescriptionErreur = "La commande sql exécuté est incorrecte.";
                    break;
                case 00947:
                    DescriptionErreur = "Il manque des informations dans la commande sql exécuté.";
                    break;
                case 01017:
                    DescriptionErreur = "Mot de passe ou nom d'utilisateur invalide. \nConnection non établi.";
                    break;
                case 01036:
                    DescriptionErreur = "Nom de variable invalide ou manquante";
                    break;
                case 01400:
                    DescriptionErreur = "Vous ne pouvez pas ajouter une colonne avec une valeur null.";
                    break;
                case 01407:
                    DescriptionErreur = "Vous ne pouvez pas mettre a jour une colonne avec une valeur null.";
                    break;
                case 01410:
                    DescriptionErreur = "Vous ne pouvez pas mettre de valeur null.";
                    break;
                case 02292:
                    DescriptionErreur = "Tentative de suppression d'une clé lié à une clé étrangère.";
                    break;
                case 12170:
                    DescriptionErreur = "La base de données est indisponible, réessayer plus tard.";
                    break;
                case 12504:
                    DescriptionErreur = "Connexion impossible. \nLe nom d'instance Oracle est invalide.";
                    break;
                case 12533:
                    DescriptionErreur = "Connexion impossible. \nLe parametre de connexion d'adresse est invalide.";
                    break;
                case 12541:
                    DescriptionErreur = "Connexion impossible. \nLa destination est invalide ou pas rejoignable.";
                    break;
                case 12543:
                    DescriptionErreur = "Connexion impossible. \nVérifiez votre connection internet.";
                    break;
                default:
                    DescriptionErreur = ex.Message;
                    break;
            }
            // Change le contenu des labels selon l'exception géré ou non géré
            LB_Text.Text += " " + ex.Number.ToString();
            LB_Description.Text = DescriptionErreur;
        }

    }
}

/*
 * 01747
 * 03224
 
 */