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
using System.IO;
using System.Collections.Specialized;
using System.Net;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      FORM GESTION
//      Fait par Melissa Boucher et Xavier Brosseau
//      15 Decembre 2014
//      Produit pour le cours de Base de Données et Developpement d'Interfaces
//
//      Utilisé pour faire la gestion (Supprimer/Modifier/Ajouter) d'une/un equipe/division/joueurs/matchs
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace HockeyIce
{
    public partial class FormGestion : Form
    {
        string nomFichier, commandesql;
        // bool savoir si on est entrain de deplacer le form
        private bool _dragging = false;
        // emmagasine la position du curseur lors d'un deplacement de form
        private Point _start_point = new Point(0, 0);

        private Point Position = new Point(4, 33);
        // variable contenant la connection a la bd 
        public OracleConnection oraconnGestion = new OracleConnection();
        // variable pour les ajouts primarykey
        int base_ = 1;
        // variable utilisé lors des tests de keypress
        const char BACKSPACE = '\b';
        //private Point basePanel = new Point(3, 27);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONSTRUCTEUR
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public FormGestion(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnGestion = oraconn;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD ET CLOSING
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormGestion_Load(object sender, EventArgs e)
        {
            EnabledVisibleLesPanels();
            this.Location = Properties.Settings.Default.PosFormGestion;
            if (Properties.Settings.Default.ModifierAjouter)  // True = modifier  false = ajouter
            {
                RemplirInformation();
                LB_Division.Text = "Modifier";
                LB_Equipe.Text = "Modifier";
                LB_Joueurs.Text = "Modifier";
                LB_Match.Text = "Modifier";
            }
            UpdateControl();
            RemplirComboBoxEquipe();
            RemplirComboBoxDivision();
            TT_LogoEquipe.SetToolTip(this.PB_LogoE, "Clicker pour modifier le Logo!");
            TT_PhotoJoueur.SetToolTip(this.TB_PhotoJ, "100 caractères maximum");
        }
        private void FormGestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormGestion = this.Location;
            Properties.Settings.Default.Save();
        }
        private void EnabledVisibleLesPanels()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Équipes":
                    PN_Equipe.Parent = this;
                    PN_Equipe.Visible = true;
                    PN_Equipe.Enabled = true;
                    PN_Equipe.Location = Position;
                    LB_Text.Text = "Gestion des équipes";
                    break;
                case "Joueurs":
                    PN_Joueurs.Parent = this;
                    PN_Joueurs.Visible = true;
                    PN_Joueurs.Enabled = true;
                    PN_Joueurs.Location = Position;
                    LB_Text.Text = "Gestion des joueurs";
                    break;
                case "Division":
                    PN_Division.Parent = this;
                    PN_Division.Visible = true;
                    PN_Division.Enabled = true;
                    PN_Division.Location = Position;
                    LB_Text.Text = "Gestion des divisions";
                    break;
                case "Matchs":
                    PN_Matchs.Parent = this;
                    PN_Matchs.Visible = true;
                    PN_Matchs.Enabled = true;
                    PN_Matchs.Location = Position;
                    LB_Text.Text = "Gestion des matchs";
                    break;
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      EVENTS DE FLASHBUTTON
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_AppliquerMatch_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.ModifierAjouter)
            {
                AjoutMatch();
            }
            else
            {
                ModifierMatch();
            }
            this.Close();
        }
        private void FB_AppliquerDivision_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.ModifierAjouter)
            {
                AjoutDivision();
            }
            else
            {
                ModifierDivision();
            }
            this.Close();
        }
        private void FB_AppliquerEquipe_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.ModifierAjouter)
            {
                AjoutEquipe();
            }
            else
            {
                ModifierEquipe();
            }
            this.Close();
        }
        private void FB_AppliquerJoueur_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.ModifierAjouter)
            {
                AjoutJoueur();
            }
            else
            {
                ModifierJoueur();
            }
            this.Close();
        }
        private void UpdateControl()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Équipes":
                    if (!Properties.Settings.Default.ModifierAjouter)
                        FB_AppliquerEquipe.Enabled = (TB_NomEquipe.Text == "" ||
                                                        TB_LieuxEquipe.Text == "" ||
                                                        CB_DivisionEquipe.Text == "" ||
                                                        LB_DateEquipe.Text == "Date") ? false : true;
                    else
                        FB_AppliquerEquipe.Enabled = (TB_NomEquipe.Text == "" ||
                                                        TB_LieuxEquipe.Text == "" ||
                                                        LB_DateEquipe.Text == "Date") ? false : true;
                    break;
                case "Joueurs":
                    if (!Properties.Settings.Default.ModifierAjouter)
                        FB_AppliquerJoueur.Enabled = (TB_NomJ.Text == "" ||
                                                        TB_PrenomJ.Text == "" ||
                                                        TB_NumeroJ.Text == "" ||
                                                        TB_PhotoJ.Text == "" ||
                                                        CB_ChoixEquipeJ.Text == "" ||
                                                        CB_PositionJ.Text == "" ||
                                                        LB_DateJ.Text == "Date") ? false : true;
                    else
                        FB_AppliquerJoueur.Enabled = (TB_NomJ.Text == "" ||
                                                        TB_PrenomJ.Text == "" ||
                                                        TB_NumeroJ.Text == "" ||
                                                        TB_PhotoJ.Text == "" ||
                                                        LB_DateJ.Text == "Date") ? false : true;
                    break;
                case "Division":
                    FB_AppliquerDivision.Enabled = (TB_NomDivision.Text == "" ||
                                                    LB_DateDivision.Text == "Date") ? false : true;
                    break;
                case "Matchs":
                    if (!Properties.Settings.Default.ModifierAjouter)
                        FB_AppliquerMatch.Enabled = (CB_EMaison.Text == "" ||
                                                        CB_EVisiteur.Text == "" ||
                                                        TB_Endroit.Text == "") ? false : true;
                    else
                        FB_AppliquerMatch.Enabled = (TB_Endroit.Text == "") ? false : true;
                    break;
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      DEPLACEMENT DU FORM
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormGestion_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // Enregistre que l'utilisateur a selectionner la form
            _start_point = new Point(e.X, e.Y); // Enregistre le point actuelle du form 
        }
        private void FormGestion_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging) // si l'utilisateur a selectionner le form
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void FormGestion_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; // Enregistre que l'utilisateur a "lacher le form"
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      DATE
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void BTN_Date_Click(object sender, EventArgs e)
        {
            FormDate dlg = new FormDate();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LB_DateDivision.Text = Properties.Settings.Default.DateChoisi.ToString("dd-MM-yyyy");
                LB_DateEquipe.Text = Properties.Settings.Default.DateChoisi.ToString("dd-MM-yyyy");
                LB_DateJ.Text = Properties.Settings.Default.DateChoisi.ToString("dd-MM-yyyy");
                LB_DateMatch.Text = Properties.Settings.Default.DateChoisi.ToString("dd-MM-yyyy");
                DTP_invisi.Value = Properties.Settings.Default.DateChoisi;
            }
        }
        private void TraiterHeureLoad()
        {
            string words = LB_HeureInvis.Text;

            string[] split = words.Split(new Char[] { ' ', ',', '.', ':', '\t' });

            NUD_Heure.Text = split[0].ToString();
            NUD_Minute.Text = split[1].ToString();
        }
        private string TraiterHeureAjoutModif()
        {
            if(NUD_Minute.Value <= 9)
            {
                return NUD_Heure.Value.ToString() + ":" + "0" + NUD_Minute.Value.ToString();
            }

            return NUD_Heure.Value.ToString() + ":" + NUD_Minute.Value.ToString();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      REMPLISSAGE COMBOBOX
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void RemplirComboBoxEquipe()
        {
            string sqlremplir = "select numequipe, nom from equipes";

            try
            {
                OracleCommand orcd = new OracleCommand(sqlremplir, oraconnGestion);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while (oraRead.Read())
                {
                    CB_Invisible.Items.Add(oraRead.GetInt32(0).ToString());
                    CB_Invisible2.Items.Add(oraRead.GetInt32(0).ToString());
                    CB_ChoixEquipeJ.Items.Add(oraRead.GetString(1).ToString());
                    CB_EVisiteur.Items.Add(oraRead.GetString(1).ToString());
                    CB_EMaison.Items.Add(oraRead.GetString(1).ToString());
                }

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void RemplirComboBoxDivision()
        {
            string sqlremplir = "select numdivision, nom from divisions";

            try
            {
                OracleCommand orcd = new OracleCommand(sqlremplir, oraconnGestion);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while (oraRead.Read())
                {
                    CB_InvisibleDiv.Items.Add(oraRead.GetInt32(0));
                    CB_DivisionEquipe.Items.Add(oraRead.GetString(1));
                }
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void RemplirInformation()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Équipes":
                    LoadInfoEquipe();
                    break;
                case "Joueurs":
                    LoadInfoJoueur();
                    break;
                case "Division":
                    LoadInfoDivision();
                    break;
                case "Matchs":
                    LoadInfoMatch();
                    break;
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      GESTION DES MATCHS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ExecuteCommandeMatch()
        {
            bool reussi = true;
            try
            {
                // on affecte les valeurs aux paramètres.
                OracleParameter oranummatch = new OracleParameter(":NumMatch", OracleDbType.Int32);
                OracleParameter oranumevis = new OracleParameter(":NumEquipeVis", OracleDbType.Int32);
                OracleParameter oranumemai = new OracleParameter(":NumEquipeMai", OracleDbType.Int32);
                OracleParameter oradate = new OracleParameter(":DateHeure", OracleDbType.Date);
                OracleParameter oraheure = new OracleParameter(":Heure", OracleDbType.Varchar2);
                OracleParameter oralieu = new OracleParameter(":Lieu", OracleDbType.Varchar2, 20);
                OracleParameter orapointmai = new OracleParameter(":PointageMaison", OracleDbType.Int32);
                OracleParameter orapointvis = new OracleParameter(":PointageVisiteur", OracleDbType.Int32);
                // lalblablabla
                OracleCommand oraModif = new OracleCommand(commandesql, oraconnGestion);
                oraModif.CommandType = CommandType.Text;

                oranummatch.Value = Properties.Settings.Default.NumValue;
                oranumevis.Value = Int32.Parse(CB_Invisible.Text);
                oranumemai.Value = Int32.Parse(CB_Invisible2.Text);
                oradate.Value = DTP_invisi.Value;
                oraheure.Value = TraiterHeureAjoutModif();
                oralieu.Value = TB_Endroit.Text;
                orapointmai.Value = NUD_PMaison.Value;
                orapointvis.Value = NUD_PVisiteur.Value;
                // En utilisant la propriété Paramètres de OracleCommand, on spécifie les paramètres de la requête SQL.
                oraModif.Parameters.Add(oranummatch);
                oraModif.Parameters.Add(oranumevis);
                oraModif.Parameters.Add(oranumemai);
                oraModif.Parameters.Add(oradate);
                oraModif.Parameters.Add(oraheure);
                oraModif.Parameters.Add(oralieu);
                oraModif.Parameters.Add(orapointmai);
                oraModif.Parameters.Add(orapointvis);
                // on exécute la requête
                oraModif.ExecuteNonQuery();
                // on appelle la fonction dissocier pour pouvoir insérer une deuxième fois.
            }
            catch (OracleException ex)
            {
                reussi = false;
                AfficherErreur(ex);
            }
            if(reussi)
                MessageBox.Show("Application reussite");
            else
                MessageBox.Show("Application non reussite");
        }
        private void AjoutMatch()
        {
            commandesql = " insert into matchs " +
            "(NUMMATCH, NUMEQUIPEVIS, NUMEQUIPEMAI, DATEHEURE, HEURE, LIEU, POINTAGEMAISON, POINTAGEVISITEUR) values " +
            "(:NumMatch,:NumEquipeVis,:NumEquipeMai,:DateHeure,:Heure, :Lieu,:PointageMaison, :PointageVisiteur)";
            Properties.Settings.Default.NumValue = base_.ToString();
            ExecuteCommandeMatch();
        }
        private void ModifierMatch()
        {
            commandesql = "update matchs set nummatch = :NumMatch," +
                                        " numequipevis = :NumEquipeVis, " +
                                        " numequipemai = :NumEquipeMai, " +
                                        " dateheure = :DateHeure," +
                                        " heure = :Heure, " +
                                        " lieu = :Lieu, " +
                                        " pointagemaison = :PointageMaison, " +
                                        " pointagevisiteur = :PointageVisiteur " +
                                        " where nummatch = " + Properties.Settings.Default.NumValue;
            ExecuteCommandeMatch();
        }
        private void LoadInfoMatch()
        {
            commandesql = "select ev.nom, em.nom, dateheure, heure, lieu, pointagemaison, pointagevisiteur, numequipevis, numequipemai " +
                           "from matchs m " +
                           "inner join EQUIPES ev on ev.NUMEQUIPE = m.NUMEQUIPEVIS " +
                           "inner join EQUIPES em on em.NUMEQUIPE = m.NUMEQUIPEMAI " +
                           "where nummatch = " + Properties.Settings.Default.NumValue;
            try
            {
                OracleCommand orcd = new OracleCommand(commandesql, oraconnGestion);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                oraRead.Read();
                SetSelectedIndexVisiteur(oraRead.GetString(0));
                SetSelectedIndexMaison(oraRead.GetString(1));
                DTP_invisi.Value = oraRead.GetDateTime(2);
                LB_DateMatch.Text = DTP_invisi.Value.ToString();
                //LB_DateMatch.Text = oraRead.GetDateTime(2).ToString();
                LB_HeureInvis.Text = oraRead.GetString(3);
                TraiterHeureLoad();
                TB_Endroit.Text = oraRead.GetString(4);
                NUD_PMaison.Value = oraRead.GetInt32(5);
                NUD_PVisiteur.Value = oraRead.GetInt32(6);
                CB_Invisible.Text = oraRead.GetInt32(7).ToString();
                CB_Invisible2.Text = oraRead.GetInt32(8).ToString();

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void SetSelectedIndexMaison(string equipe)
        {
            CB_EMaison.Visible = false;
            CB_EMaison.Enabled = false;
            LB_EMaison.Visible = true;
            LB_EMaison.Text = equipe;
        }
        private void SetSelectedIndexVisiteur(string equipe)
        {
            CB_EVisiteur.Visible = false;
            CB_EVisiteur.Enabled = false;
            LB_EVisiteur.Visible = true;
            LB_EVisiteur.Text = equipe;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      GESTION DES EQUIPES
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AjoutEquipe()
        {
            Properties.Settings.Default.NumValue = base_.ToString();
            try
            {
                // la requête SQLajout est paramétrée. Elle a 4 paramètres.
                //les paramètres pour Oracle et C # sont précédés de deux points : 
                string sqlajout = " insert into EQUIPES " +
                "(NUMEQUIPE, NOM, LOGO, VILLE, NUMDIVISION, DATEINTRODUCTION) values " +
                "(:Numequipe,:nom,:Logo,:Ville,:NumDivision,:DateValue)";
                // On déclare les paramètres pour chaque paramètre de la requête
                OracleParameter oraNum = new OracleParameter(":Numequipe", OracleDbType.Int32);
                OracleParameter oraNom = new OracleParameter(":nom", OracleDbType.Varchar2, 50);
                OracleParameter oraLogo = new OracleParameter(":Logo", OracleDbType.Blob);
                OracleParameter oraVille = new OracleParameter(":Ville", OracleDbType.Varchar2, 30);
                OracleParameter oraDivision = new OracleParameter(":NumDivision", OracleDbType.Int32);
                OracleParameter oraDate = new OracleParameter(":DateValue", OracleDbType.Date);
                // on affecte les valeurs aux paramètres.
                oraNum.Value = Properties.Settings.Default.NumValue;
                oraNom.Value = TB_NomEquipe.Text;
                if (nomFichier != null)
                {
                    oraLogo.Value = PicToByte(nomFichier);
                }
                else
                {
                    oraLogo.Value = URLToByte("http://i.imgur.com/NuDKmK7.png");//Adresse web de l'image de base
                                            //Ancien Logo de base"http://i.imgur.com/V4Xf1Cg.png"
                }
                oraVille.Value = TB_LieuxEquipe.Text;
                oraDivision.Value = CB_InvisibleDiv.Text;
                oraDate.Value = Convert.ToDateTime(Properties.Settings.Default.DateChoisi);

                // En crée un Objet OracleCommand pour passer la requête à la bD 
                OracleCommand oraAjout = new OracleCommand(sqlajout, oraconnGestion);
                oraAjout.CommandType = CommandType.Text;
                // En utilisant la propriété Paramètres de OracleCommand, on spécifie les 
                // Paramètre de la requête SQLajout.

                oraAjout.Parameters.Add(oraNum);
                oraAjout.Parameters.Add(oraNom);
                oraAjout.Parameters.Add(oraLogo);
                oraAjout.Parameters.Add(oraVille);
                oraAjout.Parameters.Add(oraDivision);
                oraAjout.Parameters.Add(oraDate);
                // on execute la requete 
                oraAjout.ExecuteNonQuery();
                MessageBox.Show("Insertion reussi");
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void ModifierEquipe()
        {

            try
            {
                // la requête SQLajout est paramétrée. Elle a 4 paramètres.
                //les paramètres pour Oracle et C # sont précédés de deux points : 
                string commandesql = " update EQUIPES set " +
                "NOM=:nom, VILLE=:Ville, " +
                "NUMDIVISION=:NumDivision, " +
                "DATEINTRODUCTION=:DateValue " +
                "where NUMEQUIPE = " + Properties.Settings.Default.NumValue.ToString();
                string commandesql2 = " update EQUIPES set " +
                "Logo=:Logo " +
                "where NUMEQUIPE = " + Properties.Settings.Default.NumValue.ToString();

                // On déclare les paramètres pour chaque paramètre de la requête
                OracleParameter oraNom = new OracleParameter(":nom", OracleDbType.Varchar2, 50);
                OracleParameter oraVille = new OracleParameter(":Ville", OracleDbType.Varchar2, 30);
                OracleParameter oraDivision = new OracleParameter(":NumDivision", OracleDbType.Int32);
                OracleParameter oraDate = new OracleParameter(":DateValue", OracleDbType.Date);
                // on affecte les valeurs aux paramètres.                

                oraNom.Value = TB_NomEquipe.Text;
                oraVille.Value = TB_LieuxEquipe.Text;
                oraDivision.Value = LB_Invisible.Text;
                oraDate.Value = Convert.ToDateTime(Properties.Settings.Default.DateChoisi);

                // En crée un Objet OracleCommand pour passer la requête à la bD 
                OracleCommand oraAjout = new OracleCommand(commandesql, oraconnGestion);
                oraAjout.CommandType = CommandType.Text;

                // En utilisant la propriété Paramètres de OracleCommand, on spécifie les 
                // Paramètre de la requête SQLajout.
                oraAjout.Parameters.Add(oraNom);
                oraAjout.Parameters.Add(oraVille);
                oraAjout.Parameters.Add(oraDivision);
                oraAjout.Parameters.Add(oraDate);
                // on execute la requete 
                oraAjout.ExecuteNonQuery();

                if (nomFichier != null)
                {
                    //Logo Maintenent
                    OracleParameter oraLogo = new OracleParameter(":Logo", OracleDbType.Blob);
                    OracleCommand oraAjout2 = new OracleCommand(commandesql2, oraconnGestion);
                    oraAjout2.CommandType = CommandType.Text;
                    oraLogo.Value = PicToByte(nomFichier);
                    oraAjout2.Parameters.Add(oraLogo);
                    oraAjout2.ExecuteNonQuery();
                }
                MessageBox.Show("Modification reussi");
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void LoadInfoEquipe()
        {
            commandesql = "select e.*, d.nom from equipes e " +
                          "inner join divisions d on d.numdivision = e.numdivision " +
                          "where numequipe = " + Properties.Settings.Default.NumValue;

            try
            {
                OracleCommand orcd = new OracleCommand(commandesql, oraconnGestion);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                oraRead.Read();
                TB_NomEquipe.Text = oraRead.GetString(1);
                PB_LogoE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                PB_LogoE.Image = Image.FromStream(oraRead.GetOracleBlob(2));
                PB_LogoE.BackgroundImage = PB_LogoE.Image;
                TB_LieuxEquipe.Text = oraRead.GetString(3);
                LB_Invisible.Text = oraRead.GetInt32(4).ToString();
                LB_DateEquipe.Text = oraRead.GetDateTime(5).ToString();
                CB_DivisionEquipe.DropDownStyle = ComboBoxStyle.DropDown;
                CB_DivisionEquipe.Text = oraRead.GetString(6).ToString();

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      GESTION DES DIVISIONS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ExecuteCommandeDivision()
        {
            try
            {
                // On déclare les paramètres pour chaque paramètre de la requête
                OracleParameter oraNum = new OracleParameter(":NumDivision", OracleDbType.Int32);
                OracleParameter oraNom = new OracleParameter(":Nom", OracleDbType.Varchar2, 50);
                OracleParameter oraDate = new OracleParameter(":DateValue", OracleDbType.Date);
                // on affecte les valeurs aux paramètres.
                oraNum.Value = Properties.Settings.Default.NumValue;
                oraNom.Value = TB_NomDivision.Text;
                oraDate.Value = Properties.Settings.Default.DateChoisi;

                // En crée un Objet OracleCommand pour passer la requête à la bD 
                OracleCommand oraAjout = new OracleCommand(commandesql, oraconnGestion);
                oraAjout.CommandType = CommandType.Text;
                // En utilisant la propriété Paramètres de OracleCommand, on spécifie les 
                // Paramètre de la requête SQLajout.

                oraAjout.Parameters.Add(oraNum);
                oraAjout.Parameters.Add(oraNom);
                oraAjout.Parameters.Add(oraDate);
                // on execute la requete 
                oraAjout.ExecuteNonQuery();
                MessageBox.Show("Application reussie");

            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void AjoutDivision()
        {
            commandesql = " insert into divisions " +
                          "(NUMDIVISION, NOM, DATECREATION) values " +
                          "(:NumDivision,:Nom,:DateValue)";
            Properties.Settings.Default.NumValue = base_.ToString();
            ExecuteCommandeDivision();
        }
        private void ModifierDivision()
        {
            commandesql = "update divisions set " +
                          "numdivision = :NumDivision, " +
                          "NOM = :Nom, " +
                          "DATECREATION = :DateValue " +
                          "where numdivision = " + Properties.Settings.Default.NumValue;
            ExecuteCommandeDivision();
        }
        private void LoadInfoDivision()
        {
            commandesql = "select * from divisions where numdivision = " + Properties.Settings.Default.NumValue;

            try
            {
                OracleCommand orcd = new OracleCommand(commandesql, oraconnGestion);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                oraRead.Read();
                TB_NomDivision.Text = oraRead.GetString(1);
                LB_DateDivision.Text = oraRead.GetDateTime(2).ToString();

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      GESTION DES JOUEURS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ExecuteCommandeJoueur()
        {
            try
            {
                // On déclare les paramètres pour chaque paramètre de la requête
                OracleParameter oraNum = new OracleParameter(":NumJoueur", OracleDbType.Int32);
                OracleParameter oraNom = new OracleParameter(":Nom", OracleDbType.Varchar2, 20);
                OracleParameter oraPrenom = new OracleParameter(":Prenom", OracleDbType.Varchar2, 20);
                OracleParameter oraNaissance = new OracleParameter(":Naissance", OracleDbType.Date);
                OracleParameter oraNumMaillot = new OracleParameter(":NumMaillot", OracleDbType.Int32);
                OracleParameter oraTypeJoueur = new OracleParameter(":TypeJoueur", OracleDbType.Varchar2, 15);
                OracleParameter oraPhoto = new OracleParameter(":Photo", OracleDbType.Varchar2, 100);
                OracleParameter oraNumEquipe = new OracleParameter(":NumEquipe", OracleDbType.Int32);
                // on affecte les valeurs aux paramètres.
                oraNum.Value = Properties.Settings.Default.NumValue;
                oraNom.Value = TB_NomJ.Text;
                oraPrenom.Value = TB_PrenomJ.Text;
                oraNaissance.Value = Properties.Settings.Default.DateChoisi;
                oraNumMaillot.Value = Int32.Parse(TB_NumeroJ.Text);
                oraTypeJoueur.Value = CB_PositionJ.Text;
                oraPhoto.Value = TB_PhotoJ.Text;
                oraNumEquipe.Value = Int32.Parse(CB_Invisible.Text);

                // En crée un Objet OracleCommand pour passer la requête à la bD 
                OracleCommand oraAjout = new OracleCommand(commandesql, oraconnGestion);
                oraAjout.CommandType = CommandType.Text;
                // En utilisant la propriété Paramètres de OracleCommand, on spécifie les 
                // Paramètre de la requête SQLajout.

                oraAjout.Parameters.Add(oraNum);
                oraAjout.Parameters.Add(oraNom);
                oraAjout.Parameters.Add(oraPrenom);
                oraAjout.Parameters.Add(oraNaissance);
                oraAjout.Parameters.Add(oraNumMaillot);
                oraAjout.Parameters.Add(oraTypeJoueur);
                oraAjout.Parameters.Add(oraPhoto);
                oraAjout.Parameters.Add(oraNumEquipe);
                // on execute la requete 
                oraAjout.ExecuteNonQuery();
                MessageBox.Show("Application reussie");
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void AjoutJoueur()
        {
            commandesql = "insert into joueurs " +
                          "(NUMJOUEUR, NOM, PRENOM, NAISSANCE, NUMEROMAILLOT, TYPEJOUEUR, PHOTO, NUMEQUIPE) values " +
                          "(:NumJoueur, :Nom, :Prenom, :Naissance, :NumMaillot, :TypeJoueur, :Photo, :NumEquipe)";
            Properties.Settings.Default.NumValue = base_.ToString();

            ExecuteCommandeJoueur();
        }
        private void ModifierJoueur()
        {
            commandesql = "update joueurs set " +
                          "NUMJOUEUR = :NumJoueur, " +
                          "NOM = :Nom, " +
                          "PRENOM = :Prenom, " +
                          "NAISSANCE = :Naissance, " +
                          "NUMEROMAILLOT = :NumMaillot, " +
                          "TYPEJOUEUR = :TypeJoueur, " +
                          "PHOTO = :Photo, " +
                          "NUMEQUIPE = :NumEquipe " +
                          "where NUMJOUEUR = " + Properties.Settings.Default.NumValue;
            ExecuteCommandeJoueur();
        }
        private void LoadInfoJoueur()
        {
            commandesql = "select j.*, e.nom from joueurs j " +
                            "inner join equipes e on e.NUMEQUIPE = j.numequipe " +
                            "where j.numjoueur = " + Properties.Settings.Default.NumValue;

            try
            {
                OracleCommand orcd = new OracleCommand(commandesql, oraconnGestion);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                oraRead.Read();
                TB_NomJ.Text = oraRead.GetString(1);
                TB_PrenomJ.Text = oraRead.GetString(2);
                LB_DateJ.Text = oraRead.GetDateTime(3).ToString();
                TB_NumeroJ.Text = oraRead.GetInt32(4).ToString();
                CB_PositionJ.DropDownStyle = ComboBoxStyle.DropDown;
                CB_PositionJ.Text = oraRead.GetString(5);
                TB_PhotoJ.Text = oraRead.GetString(6);
                CB_Invisible.Text = oraRead.GetInt32(7).ToString();
                CB_ChoixEquipeJ.DropDownStyle = ComboBoxStyle.DropDown;
                CB_ChoixEquipeJ.Text = oraRead.GetString(8).ToString();

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
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
//      EVENT DE CHANGEMENT DE TEXTBOX/COMBOBOX
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Event pour updater les control lors d'un changement dans n'importe quel textbox
        private void TB_TextChanged(object sender, EventArgs e)
        {
            UpdateControl();
            pictureBox5.ImageLocation = TB_PhotoJ.Text;
        }
        // Selected Index changed dans les combobox d'equipe
        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControl();
            CB_Invisible2.SelectedIndex = CB_EMaison.SelectedIndex;
        }
        private void CB_EVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControl();
            CB_Invisible.SelectedIndex = CB_EVisiteur.SelectedIndex;
        }
        private void CB_ChoixEquipeJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControl();
            CB_Invisible.SelectedIndex = CB_ChoixEquipeJ.SelectedIndex;
        }
        private void CB_DivisionEquipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControl();
            CB_InvisibleDiv.SelectedIndex = CB_DivisionEquipe.SelectedIndex;
            LB_Invisible.Text = CB_InvisibleDiv.Text;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      VERIFICATION DES CARACTERES ENTRÉS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        bool EstChiffre(char c)
        {
            String chiffres = "0123456789";
            return (chiffres.IndexOf(c.ToString()) != -1);
        }
        bool EstAlpha(char c)
        {
            String alpha = "abcdefghijklmnopqrstuvwxzyzàâäéèêëìîïòôöùûüç -_";
            String car = c.ToString();
            car = car.ToLower();
            return (alpha.IndexOf(car) != -1);
        }
        private void TB_NumeroJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != BACKSPACE)
                e.Handled = !EstChiffre(e.KeyChar);
        }
        private void TB_NomEquipe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != BACKSPACE)
                e.Handled = !EstAlpha(e.KeyChar);
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      GESTION DES IMAGES
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
        private void ParcourirImage()
        {
            nomFichier = RechercherFichier();
            if (nomFichier != null)
            {
                PB_LogoE.Image = System.Drawing.Image.FromFile(nomFichier);
                PB_LogoE.BackgroundImage = PB_LogoE.Image;
                PB_LogoE.ImageLocation = nomFichier;
            }
        }
        private string RechercherFichier()
        {
            OpenFileDialog fImage = new OpenFileDialog();
            fImage.Title = "sélectionner une image";
            fImage.CheckFileExists = true;
            fImage.InitialDirectory = @":C\";
            //fImage.InitialDirectory = Application.StartupPath;
            fImage.Filter = "Fichiers images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG;|All files (*.*)|*.*";
            fImage.FilterIndex = 1;
            fImage.RestoreDirectory = true;
            if (fImage.ShowDialog() == DialogResult.OK)
            {
                nomFichier = fImage.FileName;
                Bitmap bitmap1 = new Bitmap(nomFichier);
            }
            else
            {
                nomFichier = null;
            }
            return nomFichier;
        }
        private byte[] URLToByte(string pathfile)
        {
            // le résultat on le met dans une variable de type byte (octets).
            if (pathfile != null)
            {
                MemoryStream ms = new MemoryStream();
                GetImageFromUrl(pathfile).Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
            return null;
        }
        private byte[] PicToByte( string pathfile )
        {
            // le résultat on le met dans une variable de type byte (octets).
            if (pathfile != null)
            {
                FileStream Streamp = new FileStream(pathfile, FileMode.Open, FileAccess.Read);
                byte[] buffer1 = new byte[Streamp.Length];
                Streamp.Read(buffer1, 0, System.Convert.ToInt32(Streamp.Length));
                Streamp.Close();
                return buffer1;
            }
            return null;
        }
        private void PB_LogoE_Click(object sender, EventArgs e)
        {
            ParcourirImage();
        }

    }
}
