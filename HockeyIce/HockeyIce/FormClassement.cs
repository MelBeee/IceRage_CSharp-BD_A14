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
using System.Collections.Specialized;
using System.Net;
using System.IO;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      FORM CLASSEMENT
//      Fait par Melissa Boucher et Xavier Brosseau
//      15 Decembre 2014
//      Produit pour le cours de Base de Données et Developpement d'Interfaces
//
//      Utilisé afficher un classement des équipes par division / du top 3 des joueurs ainsi qu'un classement de tous les joueurs
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace HockeyIce
{
    public partial class FormClassement : Form
    {
        // bool savoir si on est entrain de deplacer le form
        private bool _dragging = false;
        // emmagasine la position du curseur lors d'un deplacement de form
        private Point _start_point = new Point(0, 0);
        // position des panels
        private Point basePanel = new Point(3, 24);
        // variable contenant la connection a la bd 
        public OracleConnection oraconnClassement { set; get; }
        // commande pour classement joueurs
        string Sql = "select cj.Prenom, cj.Nom, j.numeromaillot, j.typejoueur, j.Photo, e.Logo, cj.point from ClassementJoueur cj " +
                     "inner join joueurs j on j.NUMJOUEUR = cj.NUMJOUEUR " +
                     "inner join EQUIPES e on e.NUMEQUIPE = cj.NUMEQUIPE " +
                     "where point >=0";

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONSTRUCTEUR
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public FormClassement(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnClassement = oraconn;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD ET CLOSING
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormClassement_Load(object sender, EventArgs e)
        {
            EnabledVisibleLesPanels();
            this.Location = Properties.Settings.Default.PosFormClassement;
            CouleurLoadDGV();
        }
        private void FormClassement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormClassement = this.Location;
            Properties.Settings.Default.Save();
        }
        private void EnabledVisibleLesPanels()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Equipes": //classement d'équipe par division
                    PN_CEquipe.Parent = this;
                    PN_CEquipe.Visible = true;
                    PN_CEquipe.Enabled = true;
                    PN_CEquipe.Location = basePanel;
                    LB_Text.Text = "Classement des équipes";
                    InitComboBoxEquipe();
                    break;
                case "Top3": //classement des 3 meileurs joueurs
                    PN_3Joueurs.Parent = this;
                    PN_3Joueurs.Visible = true;
                    PN_3Joueurs.Enabled = true;
                    PN_3Joueurs.Location = basePanel;
                    LB_Text.Text = "Trois meilleurs joueurs";
                    InitClassementBestJoueurs();
                    break;
                case "Joueurs": //classement des meileurs joueurs
                    PN_CJoueurs.Parent = this;
                    PN_CJoueurs.Visible = true;
                    PN_CJoueurs.Enabled = true;
                    PN_CJoueurs.Location = basePanel;
                    LB_Text.Text = "Classement des joueurs";
                    InitListJoueur();
                    break;
            }
        }
        // couleur alterné du DGV du classement de joueurs
        private void CouleurLoadDGV() 
        {
            int compteur = 0;
            foreach (DataGridViewRow dgvr in DGV_JoueurList.Rows)
            {
                if (compteur % 2 == 0)
                    dgvr.DefaultCellStyle.BackColor = Color.FromArgb(180, 213, 239);
                else
                    dgvr.DefaultCellStyle.BackColor = Color.FromArgb(182, 225, 252);

                compteur++;
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      GESTION DES IMAGES
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Telecharge l'image de l'URL fournit pour les images de joueur!
        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }
        // resize l'image passer en paramettre et ces nouvelles dimension
        // pour les faire bien fiter au colonnes et lignes
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      EQUIPE
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void InitComboBoxEquipe()
        {
            try
            {
                string Sql3 = "select NOM from divisions";
                OracleCommand orcd = new OracleCommand(Sql3, oraconnClassement);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                //Selection pour afficher tout les équipes
                //elle est mis en pos 0 du CB
                CB_Division.Items.Add("Tous les équipes");

                while (oraRead.Read())
                {
                    //on remplit le CB des Division existent
                    CB_Division.Items.Add(oraRead.GetString(0));
                }
                oraRead.Close();

                //on place la selection du CB par défaut a la position 0 (All Teams)
                CB_Division.SelectedIndex = 0;
            }
            catch (OracleException ex)
            {
                FormErreur dlg = new FormErreur(ex);

                if (dlg.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
        private void InitDivisionEquipe()
        {
            string Sql2 = "select e.LOGO, ce.NOM, e.VILLE, e.DATEINTRODUCTION, d.NOM, ce.POINTS " +
                          "from ClassementEquipe ce " +
                          "inner join equipes e on e.NUMEQUIPE = ce.NUMEQUIPE " +
                          "inner join divisions d on d.NUMDIVISION = ce.NUMDIVISION ";
            if (CB_Division.SelectedItem.ToString() != "Tous les équipes")
            {
                // si l'item du combo box n'est pas d'afficher tout les équipes,
                //on ajoute la condition WHERE suivente a la chaine SQL
                Sql2 += "where d.NOM = '" + CB_Division.SelectedItem.ToString() + "'";
            }

            try
            {
                OracleCommand orcd = new OracleCommand(Sql2, oraconnClassement);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();
                DGV_Divison.Rows.Clear();
                
                while (oraRead.Read())
                {
                    Image Logo = Image.FromStream(oraRead.GetOracleBlob(0));
                    Logo = resizeImage(Logo, new Size(50, 45));
                    
                    DGV_Divison.Rows.Add(Logo,  //Logo equipe
                        oraRead.GetString(1),   //Nom équipe
                        oraRead.GetString(2),   //Ville
                        oraRead.GetDateTime(3).ToShortDateString(), // Date de fondation
                        oraRead.GetString(4),   //Nom de la division
                        oraRead.GetInt32(5));   //Pointage 
                }

                //classement desc par la colonnes de point du DGV.
                //la façons "Order by" rend le pointage null autrement
                DGV_Divison.Sort(DGV_Divison.Columns[5], ListSortDirection.Descending);
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                FormErreur dlg = new FormErreur(ex);

                if (dlg.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
        private void DGV_Divison_SelectionChanged(object sender, EventArgs e)
        {
            DGV_Divison.ClearSelection();
        }
        private void CB_Division_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitDivisionEquipe();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      JOUEURS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void InitListJoueur()
        {
            try
            {
                OracleCommand orcd = new OracleCommand(Sql, oraconnClassement);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while (oraRead.Read())
                {
                    // transforme une adresse URL en type image
                    Image Photo = GetImageFromUrl(oraRead.GetString(4));
                    // transforme un tableau de Bytes en type image
                    Image Logo = Image.FromStream(oraRead.GetOracleBlob(5));

                    //on Resize les images pour qu'il fitent bien dans le DGV
                    Photo = resizeImage(Photo, new Size(50, 75));
                    Logo = resizeImage(Logo, new Size(50, 45));

                    DGV_JoueurList.Rows.Add(Photo,  //Photo du joueur
                    oraRead.GetString(0),           //Prénom
                    oraRead.GetString(1),           //Nom
                    "Numéro " + oraRead.GetInt32(2).ToString(),//# Maillot
                    oraRead.GetString(3),           //Position
                    oraRead.GetInt32(6).ToString() + " Points",//Pointage
                    Logo);                          //Logo d'équipe
                }
                oraRead.Close();
            }
            catch (OracleException exsqlajout)
            {
                MessageBox.Show(exsqlajout.Message.ToString());
            }
        }
        private void DGV_JoueurList_SelectionChanged(object sender, EventArgs e)
        {
            DGV_JoueurList.ClearSelection();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      TOP 3 JOUEURS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void InitClassementBestJoueurs()
        {
            try
            {
                OracleCommand orcd = new OracleCommand(Sql, oraconnClassement);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                //Joueur #1
                oraRead.Read(); //Lire le 1er joueur du classement
                LB_PrenomGold.Text = oraRead.GetString(0);                      //Prénom
                LB_NomGold.Text = oraRead.GetString(1);                         //Nom
                LB_NumeroGold.Text = "Numéro " + oraRead.GetInt32(2).ToString();//# Maillot
                LB_PositionGold.Text = oraRead.GetString(3);                    //Type de joueur
                PB_Photo_Gold.ImageLocation = oraRead.GetString(4);             //Photo joueur
                PB_Photo_Gold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;//Resize la photo
                PB_EquipeGold.Image = Image.FromStream(oraRead.GetOracleBlob(5));//Logo équipe
                PB_EquipeGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;//Resize le Logo
                LB_PointsGold.Text = oraRead.GetInt32(6).ToString() + " Points";//Pointage

                //Joueur #2
                oraRead.Read(); //Lire le 2iem joueur du classement
                LB_PrenomSilver.Text = oraRead.GetString(0);
                LB_NomSilver.Text = oraRead.GetString(1);
                LB_NumeroSilver.Text = "Numéro " + oraRead.GetInt32(2).ToString();
                LB_PositionSilver.Text = oraRead.GetString(3);
                PB_Photo_Silver.ImageLocation = oraRead.GetString(4);
                PB_Photo_Silver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                PB_EquipeSilver.Image = Image.FromStream(oraRead.GetOracleBlob(5));
                PB_EquipeSilver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                LB_PointsSilver.Text = oraRead.GetInt32(6).ToString() + " Points";

                //Joueur #3
                oraRead.Read(); //Lire le 3iem joueur du classement
                LB_PrenomBronze.Text = oraRead.GetString(0);
                LB_NomBronze.Text = oraRead.GetString(1);
                LB_NumeroBronze.Text = "Numéro " + oraRead.GetInt32(2).ToString();
                LB_PositionBronze.Text = oraRead.GetString(3);
                PB_Photo_Bronze.ImageLocation = oraRead.GetString(4);
                PB_Photo_Bronze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                PB_EquipeBronze.Image = Image.FromStream(oraRead.GetOracleBlob(5));
                PB_EquipeBronze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                LB_PointsBronze.Text = oraRead.GetInt32(6).ToString() + " Points";

                oraRead.Close();
            }
            catch (OracleException exsqlajout)
            {
                MessageBox.Show(exsqlajout.Message.ToString());
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      DEPLACEMENT DU FORM
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormClassement_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }
        private void FormClassement_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void FormClassement_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      EVENTS DE FLASHBUTTON
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
