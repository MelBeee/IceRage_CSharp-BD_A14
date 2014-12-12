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
    public partial class FormErreur : Form
    {
        OracleException ExceptionATraiter;

        public FormErreur(OracleException ExceptionAGerer)
        {
            InitializeComponent();
            ExceptionATraiter = ExceptionAGerer;
        }

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void FormErreur_Load(object sender, EventArgs e)
        {
            SwitchException(ExceptionATraiter);
            this.Location = Properties.Settings.Default.PosFormErreur;
        }

        // Events pour pouvoir faire bouger le form 
        private void FormErreur_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }
        private void FormErreur_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }
        private void FormErreur_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
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

        private void FormErreur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormErreur = this.Location;
            Properties.Settings.Default.Save();
        }

        private void SwitchException(OracleException ex)
        {
            string CodeErreur = ex.Number.ToString();
            string DescriptionErreur;
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
            LB_Text.Text += " " + CodeErreur;
            LB_Description.Text = DescriptionErreur;
        }
    }
}
/*  Erreurs à gérer http://www.techonthenet.com/oracle/errors/

 */
