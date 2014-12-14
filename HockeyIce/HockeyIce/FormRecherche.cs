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
//      FORM RECHERCHE
//      Fait par Melissa Boucher et Xavier Brosseau
//      15 Decembre 2014
//      Produit pour le cours de Base de Données et Developpement d'Interfaces
//
//      Utilisé pour afficher les joueurs/matchs/equipes
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace HockeyIce
{
    public partial class FormRecherche : Form
    {
        // bool savoir si on est entrain de deplacer le form
        private bool _dragging = false;
        // emmagasine la position du curseur lors d'un deplacement de form
        private Point _start_point = new Point(0, 0);
        // position des panels
        private Point basePanel = new Point(3, 28);
        // variable contenant la connection a la bd 
        private OracleConnection oraconnRecherche = new OracleConnection();
        // Data set utilisé pour afficher les joueurs/equipe
        private DataSet monDataSet = new DataSet();
        private DataSet monDataSet2 = new DataSet();
        private DataSet monDataSet3 = new DataSet();

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONSTRUCTEUR
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public FormRecherche(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnRecherche = oraconn;
            LabelTransparent();
        }
        // Rend le label du numero du joueur plus voyant
        private void LabelTransparent()
        {
            Point pos = new Point(105, 220);
            pos = PB_Joueur.PointToClient(pos);
            LB_Mailot.Parent = PB_Joueur;
            LB_Mailot.Location = pos;
            LB_Mailot.BackColor = Color.FromArgb(125, 0, 0, 0);
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD ET CLOSING
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormRecherche_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PosFormRecherche;
            EnabledVisibleLesPanels();
        }
        private void EnabledVisibleLesPanels()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Équipes":
                    PN_Equipe.Parent = this;
                    PN_Equipe.Visible = true;
                    PN_Equipe.Enabled = true;
                    PN_Equipe.Location = basePanel;
                    LB_Text.Text = "Équipes";
                    InitEquipe();
                    FB_BackEquipe.Enabled = false;
                    break;
                case "Joueurs":
                    PN_Joueurs.Parent = this;
                    PN_Joueurs.Visible = true;
                    PN_Joueurs.Enabled = true;
                    PN_Joueurs.Location = basePanel;
                    FB_Back.Enabled = false;
                    LB_Text.Text = "Joueurs";
                    InitJoueur(VerifierQuelCommande());
                    ChangerLogoEquipe();
                    ChangerStatistiques();
                    break;
                case "Matchs":
                    PN_Matchs.Parent = this;
                    PN_Matchs.Visible = true;
                    PN_Matchs.Enabled = true;
                    PN_Matchs.Location = basePanel;
                    DateTime bl = new DateTime(2014, 01, 01);
                    DTP_APartir.Value = bl;
                    LB_Text.Text = "Matchs";
                    InitMatch(VerifierQuelCommandeMatch());
                    break;
            }
        }
        private void FormRecherche_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormRecherche = this.Location;
            Properties.Settings.Default.Save();
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
//      DEPLACEMENT DU FORM
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        private void FormRecherche_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // Enregistre que l'utilisateur a selectionner la form
            _start_point = new Point(e.X, e.Y); // Enregistre le point actuelle du form 
        }
        private void FormRecherche_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; // Enregistre que l'utilisateur a "lacher le form"
        }
        private void FormRecherche_MouseMove(object sender, MouseEventArgs e)
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
        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_FermerD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fermer_equipe(object sender, EventArgs e)
        {
            this.Close();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      EQUIPES
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
        private void InitEquipe()
        {
            try
            {
                string sql2 = "select * from equipes";

                OracleDataAdapter Adapter2 = new OracleDataAdapter(sql2, oraconnRecherche);
                if (monDataSet2.Tables.Contains("equipes"))
                {
                    monDataSet2.Tables["equipes"].Clear();
                }

                Adapter2.Fill(monDataSet2, "equipes");
                Adapter2.Dispose();
                // on apelle la fonction lier pour faire
                // la liaison des données du DataSet avec les zones de text.
                LierEquipe();
                AffichageEquipe();

                if (this.BindingContext[monDataSet2, "equipes"].Count <= 1)
                {
                    FB_BackEquipe.Enabled = false;
                    FB_NextEquipe.Enabled = false;
                }
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void LierEquipe()
        {
            LB_NomEquipe.DataBindings.Add("text", monDataSet2, "equipes.nom");
            LB_VilleEquipe.DataBindings.Add("text", monDataSet2, "equipes.ville");
            LB_DivisionNumInvisible.DataBindings.Add("text", monDataSet2, "equipes.numDivision");
            DTP_Tempo.DataBindings.Add("text", monDataSet2, "equipes.DateIntroduction");
            LB_NumEquipeGhost.DataBindings.Add("text", monDataSet2, "equipes.NumEquipe");
        }
        private void AffichageEquipe()
        {
            LB_DateEquipe.Text = DTP_Tempo.Text;

            string commandesql = " select e.logo, d.nom " +
                                 "from equipes e " +
                                 "inner join Divisions d on e.numdivision = d.numdivision " +
                                 "where e.numequipe = " + LB_NumEquipeGhost.Text;

            try
            {
                OracleCommand orcd = new OracleCommand(commandesql, oraconnRecherche);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                oraRead.Read();
                //**************************************************************
                PB_LogoEquipe.Image = Image.FromStream(oraRead.GetOracleBlob(0));
                LB_DivisionNomEquipe.Text = oraRead.GetString(1);
                //**************************************************************
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void ProchaineEquipe()
        {
            FB_BackEquipe.Enabled = true;
            this.BindingContext[monDataSet2, "equipes"].Position += 1;
            if (this.BindingContext[monDataSet2, "equipes"].Position.ToString() == (this.BindingContext[monDataSet2, "equipes"].Count - 1).ToString())
            {
                FB_NextEquipe.Enabled = false;
            }
            AffichageEquipe();
        }
        private void EquipePrecedente()
        {
            FB_NextEquipe.Enabled = true;
            this.BindingContext[monDataSet2, "equipes"].Position -= 1;
            if (this.BindingContext[monDataSet2, "equipes"].Position.ToString() == "0")
            {
                FB_BackEquipe.Enabled = false;
            }
            AffichageEquipe();
        }
        private void Next_equipe(object sender, EventArgs e)
        {
            if (this.BindingContext[monDataSet2, "equipes"].Count > 1)
                ProchaineEquipe();
            else
            {
                FB_BackEquipe.Enabled = false;
                FB_NextEquipe.Enabled = false;
            }
        }
        private void Back_Equipe(object sender, EventArgs e)
        {
            if (this.BindingContext[monDataSet2, "equipes"].Count > 1)
                EquipePrecedente();
            else
            {
                FB_BackEquipe.Enabled = false;
                FB_NextEquipe.Enabled = false;
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      MATCHS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
        private void InitMatch(string commande)
        {
            try
            {
                OracleDataAdapter Adapter3 = new OracleDataAdapter(commande, oraconnRecherche);
                if (monDataSet3.Tables.Contains("matchs"))
                {
                    monDataSet3.Tables["matchs"].Clear();
                }

                Adapter3.Fill(monDataSet3, "matchs");
                Adapter3.Dispose();
                // on apelle la fonction lier pour faire
                // la liaison des données du DataSet avec les zones de text.
                LierMatch();
                AfficherMatch();

                if (this.BindingContext[monDataSet3, "matchs"].Count <= 1)
                {
                    FB_LastMatch.Enabled = false;
                    FB_NextMatch.Enabled = false;
                }
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private string VerifierQuelCommandeMatch()
        {
            string commande;

            string Date = DTP_APartir.Value.ToString("yyyy-MM-dd");

            if(CB_Equipe.Text == "Tous les Matchs" || CB_Equipe.Text == "")
            {
                commande = " select * from matchs " +
                           " where DateHeure >= '" + Date + "'";
            }
            else 
            {
                commande =  " select * from matchs " +
                            " where (numequipevis = " + CB_Invisible.Text +
                            " OR numequipemai = " + CB_Invisible.Text +
                            ") AND DateHeure >= '" + Date + "'";
            }

            return commande;
        }
        private void RemplirCBEquipe()
        {
            string sqlremplir = "select numequipe, nom from equipes";

            try
            {
                OracleCommand orcd = new OracleCommand(sqlremplir, oraconnRecherche);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while (oraRead.Read())
                {
                    CB_Invisible.Items.Add(oraRead.GetInt32(0).ToString());
                    CB_Equipe.Items.Add(oraRead.GetString(1).ToString());
                }

                CB_Equipe.Items.Add("Tous les Matchs");

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void LierMatch()
        {
            LB_NumVis.DataBindings.Add("text", monDataSet3, "matchs.numequipevis");
            LB_NumMai.DataBindings.Add("text", monDataSet3, "matchs.numequipemai");
            DTP_Match.DataBindings.Add("text", monDataSet3, "matchs.dateheure");
            LB_Ville.DataBindings.Add("text", monDataSet3, "matchs.lieu");
            LB_PointMM.DataBindings.Add("text", monDataSet3, "matchs.pointagemaison");
            LB_PointVM.DataBindings.Add("text", monDataSet3, "matchs.pointagevisiteur");
            LB_HeureM.DataBindings.Add("text", monDataSet3, "matchs.heure");
        }
        private void AfficherMatch()
        {
            LB_HeureDate.Text = DTP_Match.Value.ToString() + " à " + LB_HeureM.Text;
            LB_Score.Text = LB_PointMM.Text + " à " + LB_PointVM.Text;
            RemplirAutreInfo();
        }
        private void RemplirAutreInfo()
        {
            string logovis = "select logo from equipes where numequipe = " + LB_NumVis.Text;
            string logomai = "select logo from equipes where numequipe = " + LB_NumMai.Text;

            string joueurvis = "select prenom,nom from joueurs where numequipe = " + LB_NumVis.Text;
            string joueurmai = "select prenom,nom from joueurs where numequipe = " + LB_NumMai.Text;

            ChangerLogoMatchs(logovis, "visiteur");
            ChangerLogoMatchs(logomai, "receveur");

            ChangerJoueurs(joueurvis, "visiteur");
            ChangerJoueurs(joueurmai, "receveur");
        }
        private void ChangerLogoMatchs(string commandesql, string equipe)
        {
            try
            {
                OracleCommand orcd = new OracleCommand(commandesql, oraconnRecherche);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                oraRead.Read();
                if(equipe == "visiteur")
                {
                    PB_Visiteur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    PB_Visiteur.Image = Image.FromStream(oraRead.GetOracleBlob(0));
                }
                else
                {
                    PB_Receveur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    PB_Receveur.Image = Image.FromStream(oraRead.GetOracleBlob(0));
                }
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void ChangerJoueurs(string commandesql, string equipe)
        {
            try
            {
                OracleCommand orcd = new OracleCommand(commandesql, oraconnRecherche);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while(oraRead.Read())
                {
                    if (equipe == "visiteur")
                    {
                        LB_NomVisiteur.Text =  oraRead.GetString(0) + " " + oraRead.GetString(1) + "\n";
                    }
                    else
                    {
                        LB_NomReceveur.Text = oraRead.GetString(0) + " " + oraRead.GetString(1) + "\n";
                    }
                }
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void FB_DateMatchs_Click(object sender, EventArgs e)
        {
            FormDate dlg = new FormDate();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DTP_APartir.Value = Properties.Settings.Default.DateChoisi;
                LB_Date.Text = "À partir du " + DTP_APartir.Value.ToString();
            }
            else
            {
                DateTime dt = new DateTime(2014, 01, 01);
                DTP_APartir.Value = dt;
                LB_Date.Text = "À partir du " + dt.ToString();
            }
        }

        private void FB_LastMatch_Click(object sender, EventArgs e)
        {
            MatchPrecedent();
        }
        private void FB_NextMatch_Click(object sender, EventArgs e)
        {
            ProchainMatch();
        }
        private void ProchainMatch()
        {
            FB_LastMatch.Enabled = true;
            this.BindingContext[monDataSet3, "matchs"].Position += 1;
            if (this.BindingContext[monDataSet3, "matchs"].Position.ToString() == (this.BindingContext[monDataSet3, "matchs"].Count - 1).ToString())
            {
                FB_NextMatch.Enabled = false;
            }
            AfficherMatch();
        }
        private void MatchPrecedent()
        {
            FB_NextMatch.Enabled = true;
            this.BindingContext[monDataSet3, "matchs"].Position -= 1;
            if (this.BindingContext[monDataSet3, "matchs"].Position.ToString() == "0")
            {
                FB_LastMatch.Enabled = false;
            }
            AfficherMatch();
        }
        
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      JOUEURS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
        // Verifie si on affiche tous les joueurs ou seulement les joueurs d'une equipe choisi
        private string VerifierQuelCommande()
        {
            string sqlcommande;
            if (!Properties.Settings.Default.ModifierAjouter)
            {
                sqlcommande = "select * from joueurs";
            }
            else
            {
                sqlcommande = "select * from joueurs where numequipe = " + Properties.Settings.Default.NumValue;
            }
            return sqlcommande;
        }
        // Load les joueurs dans le data binding
        private void InitJoueur(string sqlcommande)
        {
            try
            {
                OracleDataAdapter Adapter2 = new OracleDataAdapter(sqlcommande, oraconnRecherche);
                if (monDataSet.Tables.Contains("joueurs"))
                {
                    monDataSet.Tables["joueurs"].Clear();
                }

                Adapter2.Fill(monDataSet, "joueurs");
                Adapter2.Dispose();
                // on apelle la fonction lier pour faire
                // la liaison des données du DataSet avec les zones de text.
                LierJoueur();
                AffichageJoueur();

                if (this.BindingContext[monDataSet, "joueurs"].Count <= 1)
                {
                    FB_Back.Enabled = false;
                    FB_Next.Enabled = false;
                }
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void LierJoueur()
        {
            LB_Nom.DataBindings.Add("text", monDataSet, "joueurs.nom");
            LB_Prenom.DataBindings.Add("text", monDataSet, "joueurs.prenom");
            LB_Type.DataBindings.Add("text", monDataSet, "joueurs.typejoueur");
            LB_Tempo.DataBindings.Add("text", monDataSet, "joueurs.numeromaillot");
            LB_Tempo2.DataBindings.Add("text", monDataSet, "joueurs.photo");
            LB_NumJoueur.DataBindings.Add("text", monDataSet, "joueurs.numjoueur");
            DTP_Tempo.DataBindings.Add("text", monDataSet, "joueurs.Naissance");
        }
        private void ChangerLogoEquipe()
        {
            string commandesql = "select e.logo from equipes e inner join joueurs j on j.NUMEQUIPE = e.NUMEQUIPE where j.numjoueur = " + LB_NumJoueur.Text;
            try
            {
                OracleCommand orcd = new OracleCommand(commandesql, oraconnRecherche);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                oraRead.Read();
                PB_Equipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                PB_Equipe.Image = Image.FromStream(oraRead.GetOracleBlob(0));

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void ChangerStatistiques()
        {
            string commandesql = " select TO_CHAR(sum(NbreButs)), TO_CHAR(sum(NbrePasses)), TO_CHAR(sum(TO_NUMBER(TempsPunition))) " +
                                  " from StatistiquesJoueurs " +
                                  " where numjoueur = " + LB_NumJoueur.Text;
            try
            {
                OracleCommand orcd = new OracleCommand(commandesql, oraconnRecherche);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                oraRead.Read();

                if (!oraRead.IsDBNull(0))
                    LB_But.Text = oraRead.GetString(0);
                else
                    LB_But.Text = "0";
                if (!oraRead.IsDBNull(1))
                    LB_Passe.Text = oraRead.GetString(1);
                else
                    LB_Passe.Text = "0";
                if (!oraRead.IsDBNull(2))
                    LB_Punition.Text = oraRead.GetString(2) + " secondes";
                else
                    LB_Punition.Text = "0 secondes";

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
            }
        }
        private void AffichageJoueur()
        {
            LB_Mailot.Text = "#" + LB_Tempo.Text;
            PB_Joueur.ImageLocation = LB_Tempo2.Text;
            LB_DateNais.Text = DTP_Tempo.Text;
        }
        private void ProchainJoueur()
        {
            FB_Back.Enabled = true;
            this.BindingContext[monDataSet, "joueurs"].Position += 1;
            if (this.BindingContext[monDataSet, "joueurs"].Position.ToString() == (this.BindingContext[monDataSet, "joueurs"].Count - 1).ToString())
            {
                FB_Next.Enabled = false;
            }
            AffichageJoueur();
            ChangerLogoEquipe();
            ChangerStatistiques();
        }
        private void JoueurPrecedent()
        {
            FB_Next.Enabled = true;
            this.BindingContext[monDataSet, "joueurs"].Position -= 1;
            if (this.BindingContext[monDataSet, "joueurs"].Position.ToString() == "0")
            {
                FB_Back.Enabled = false;
            }
            AffichageJoueur();
            ChangerLogoEquipe();
            ChangerStatistiques();
        }
        private void FB_Next_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[monDataSet, "joueurs"].Count > 1)
                ProchainJoueur();
            else
            {
                FB_Back.Enabled = false;
                FB_Next.Enabled = false;
            }
        }
        private void FB_Back_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[monDataSet, "joueurs"].Count > 1)
                JoueurPrecedent();
            else
            {
                FB_Back.Enabled = false;
                FB_Next.Enabled = false;
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      GESTION TOUCHES DU CLAVIER
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (Properties.Settings.Default.FenetreAOuvrir == "Joueurs")
                        JoueurPrecedent();
                    else if (Properties.Settings.Default.FenetreAOuvrir == "Équipes")
                        EquipePrecedente();
                    else
                        MatchPrecedent();
                    break;
                case Keys.Right:
                    if (Properties.Settings.Default.FenetreAOuvrir == "Joueurs")
                        ProchainJoueur();
                    else if (Properties.Settings.Default.FenetreAOuvrir == "Équipes")
                        ProchaineEquipe();
                    else
                        ProchainMatch();
                    break;
            }
            bool result = base.ProcessCmdKey(ref msg, keyData);
            return result;
        }

 

    }
}
