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
//      FORM PRINCIPALE
//      Fait par Melissa Boucher et Xavier Brosseau
//      15 Decembre 2014
//      Produit pour le cours de Base de Données et Developpement d'Interfaces
//
//      Utilisé comme page d'ouverture / menu
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace HockeyIce
{
    public partial class FormPrincipale : Form
    {
        // bool savoir si on est entrain de deplacer le form
        private bool _dragging = false;
        // emmagasine la position du curseur lors d'un deplacement de form
        private Point _start_point = new Point(0, 0);
        // boolean pour stocker si le form est connecté ou non
        public bool connection = false;
        // variable contenant la connection a la bd 
        private OracleConnection oraconn = new OracleConnection();

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONSTRUCTEUR
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public FormPrincipale()
        {
            InitializeComponent();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD ET CLOSING
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            // loading de la position sauvegardé antérieurement 
            this.Location = Properties.Settings.Default.PosFormPrincipale;
            // appel de fct pour ouvrir la connection
            Connection();
            if (!connection) // si pas de connection 
            {
                PasDeConnection();
            }
        }
        private void FormPrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Enregistre la localisation du form pour utilisation prochaine
            Properties.Settings.Default.PosFormPrincipale = this.Location;
            Properties.Settings.Default.Save();
            // Ferme la connection
            oraconn.Close();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONNECTION
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Fait pour disable les flashbuttons quand il n'y a pas de connection
        private void PasDeConnection()
        {
            PN_PasDeConnection.BringToFront();
            PN_PasDeConnection.Enabled = true;
            PN_PasDeConnection.Visible = true;
            FB_Fermer.Enabled = false;
            FB_APropos.Enabled = false;
            FB_3MeilleursJs.Enabled = false;
            FB_CEquipe.Enabled = false;
            FB_CJoueurs.Enabled = false;
            FB_ADivision.Enabled = false;
            FB_AEquipe.Enabled = false;
            FB_AJoueurs.Enabled = false;
            FB_AMatchs.Enabled = false;
            FB_TrouverEquipe.Enabled = false;
            FB_TrouverJoueur.Enabled = false;
            FB_TrouverMatch.Enabled = false; 
        }
        // Tente la connection
        private void Connection()
        {
            if (!connection)
            {
                //Remplit le DSource
                string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                    "(HOST=205.237.244.251)(PORT=1521)))" +
                    "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
                string user = "BROSSEAU";
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
                    AfficherErreur(ex);
                    connection = false;
                }
            }
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
//      DEPLACEMENT DU FORM
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      GESTION TOUCHES DU CLAVIER
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      EVENTS DE FLASHBUTTON GENERAL
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_QuitterPDC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      OUVERTURE FORM A PROPOS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_APropos_Click(object sender, EventArgs e)
        {
            AfficherAPropos();
        }
        private void AfficherAPropos()
        {
            FormAPropos dlg = new FormAPropos();

            dlg.ShowDialog();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      OUVERTURE FORM CLASSEMENT
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_CJoueurs_Click(object sender, EventArgs e)
        {
            AfficherClassement("Joueurs");
        }
        private void FB_CEquipe_Click(object sender, EventArgs e)
        {
            AfficherClassement("Equipes");
        }
        private void FB_3MeilleursJs_Click(object sender, EventArgs e)
        {
            AfficherClassement("Top3");
        }
        private void AfficherClassement(string Classement)
        {
            Properties.Settings.Default.FenetreAOuvrir = Classement;
            Properties.Settings.Default.Save();
            FormClassement dlg = new FormClassement(oraconn);

            dlg.ShowDialog();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      OUVERTURE FORM GESTION
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_AEquipe_Click(object sender, EventArgs e)
        {
            AfficherGestion("Équipes");
        }
        private void FB_AJoueurs_Click(object sender, EventArgs e)
        {
            AfficherGestion("Joueurs");
        }
        private void FB_AMatchs_Click(object sender, EventArgs e)
        {
            AfficherGestion("Matchs");
        }
        private void FB_ADivision_Click(object sender, EventArgs e)
        {
            AfficherGestion("Division");
        }
        private void AfficherGestion(string Gestion)
        {
            Properties.Settings.Default.FenetreAOuvrir = Gestion;
            Properties.Settings.Default.Save();

            FormOptions dlg = new FormOptions(oraconn);

            dlg.ShowDialog();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      OUVERTURE FORM RECHERCHE
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_TrouverEquipe_Click(object sender, EventArgs e)
        {
            AfficherRecherche("Équipes");
        }
        private void FB_TrouverMatch_Click(object sender, EventArgs e)
        {
            AfficherRecherche("Matchs");
        }
        private void FB_TrouverJoueur_Click(object sender, EventArgs e)
        {
            FormChoixStats dlg = new FormChoixStats(oraconn);

            dlg.ShowDialog();
        }
        private void AfficherRecherche(string Recherche)
        {
            Properties.Settings.Default.FenetreAOuvrir = Recherche;
            Properties.Settings.Default.Save();

            FormRecherche dlg = new FormRecherche(oraconn);

            dlg.ShowDialog();
        }

    }
}

//      PB_Photo_Silver.ImageLocation = "http://i.imgur.com/RrZajkb.jpg";
//      PB_Photo_Silver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//      oraRead.GetDataTypeName(4).ToString();
//      label1.Text = (Int32.Parse(TB_ChiffreUn.Text) + Int32.Parse(TB_Chiffre2.Text)).ToString(); 

/*  Erreurs à gérer

 */