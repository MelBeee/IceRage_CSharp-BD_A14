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
    public partial class FormGestion : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private Point basePanel = new Point(3, 27);
        public OracleConnection oraconnGestion = new OracleConnection();
        string commandesql;

        public FormGestion(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnGestion = oraconn; 
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {
            EnabledVisibleLesPanels();
            this.Location = Properties.Settings.Default.PosFormGestion;
            if (Properties.Settings.Default.ModifierAjouter)  // True = modifier  false = ajouter
            {
                LB_Division.Text = "Modifier";
                LB_Equipe.Text = "Modifier";
                LB_Joueurs.Text = "Modifier";
                LB_Match.Text = "Modifier";
            }
            UpdateControl();
            RemplirComboBoxEquipe();
        }
        private void FormGestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormGestion = this.Location;
            Properties.Settings.Default.Save();
        }
        private void BTN_Date_Click(object sender, EventArgs e)
        {
            FormDate dlg = new FormDate();

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                LB_DateDivision.Text = Properties.Settings.Default.DateChoisi.ToString("dd-MM-yy");
                LB_DateEquipe.Text = Properties.Settings.Default.DateChoisi.ToString("dd-MM-yy");
                LB_DateJ.Text = Properties.Settings.Default.DateChoisi.ToString("dd-MM-yy");
            }
        }
        
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
                    CB_ChoixEquipeJ.Items.Add(oraRead.GetString(1).ToString());
                    CB_EVisiteur.Items.Add(oraRead.GetString(1).ToString());
                    CB_EMaison.Items.Add(oraRead.GetString(1).ToString());
                }

                oraRead.Close();
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
            }
        }
        
        // MATCHS
        private void AjoutMatch()
        {
            commandesql = "insert into matchs values(1,"+ CB_EVisiteur.Text 
                                                        + ", "      + CB_EMaison.Text 
                                                        + ", '"     + DTP_DateMatch.Text 
                                                        + "', '"    + TB_Endroit 
                                                        + "', "     + NUD_PMaison.Value 
                                                        + ", "      + NUD_PVisiteur.Value + ")";
            try
            {
                // la requête SQLajout est paramétrée. Elle a 4 paramètres.
                //les paramètres pour Oracle et C # sont précédés de deux points : 
                string sqlajout = " insert into matchs " +
                "(NUMMATCH, NUMEQUIPEVIS, NUMEQUIPEMAI, DATEHEURE, LIEU, POINTAGEMAISON, POINTAGEVISITEUR) values " +
                "(:NumMatch,:NumEquipeVis,:NumEquipeMai,:DateHeure,:Lieu,:PointageMaison, :PointageVisiteur)";
                // On déclare les paramètres pour chaque paramètre de la requête
                OracleParameter oraNum = new OracleParameter(":NumMatch", OracleDbType.Int32);
                OracleParameter oraNumVis = new OracleParameter(":NumEquipeVis", OracleDbType.Int32);
                OracleParameter oraNumMai = new OracleParameter(":NumEquipeMai", OracleDbType.Int32);
                OracleParameter oraDate = new OracleParameter(":DateHeure", OracleDbType.Date);
                OracleParameter oraLieu = new OracleParameter(":Lieu", OracleDbType.Varchar2, 30);
                OracleParameter oraPointMai = new OracleParameter(":PointageMaison", OracleDbType.Int32);
                OracleParameter oraPointVis = new OracleParameter(":PointageVisiteur)", OracleDbType.Int32);
                // on affecte les valeurs aux paramètres.
                oraNum.Value = 1;
                oraNumVis.Value = CB_Invisible.Text;
                oraNumMai.Value = CB_Invisible.Text;
                oraDate.Value = Properties.Settings.Default.DateChoisi;
                oraLieu.Value = TB_Endroit.Text;
                oraPointMai.Value = NUD_PMaison.Value;
                oraPointVis.Value = NUD_PVisiteur.Value;
                
                // En crée un Objet OracleCommand pour passer la requête à la bD 
                OracleCommand oraAjout = new OracleCommand(sqlajout, oraconnGestion);
                oraAjout.CommandType = CommandType.Text;
                // En utilisant la propriété Paramètres de OracleCommand, on spécifie les 
                // Paramètre de la requête SQLajout.

                oraAjout.Parameters.Add(oraNum);
                oraAjout.Parameters.Add(oraNumVis);
                oraAjout.Parameters.Add(oraNumMai);
                oraAjout.Parameters.Add(oraDate);
                oraAjout.Parameters.Add(oraLieu);
                oraAjout.Parameters.Add(oraPointMai);
                oraAjout.Parameters.Add(oraPointVis);
                // on execute la requete 
                oraAjout.ExecuteNonQuery();
                MessageBox.Show("Execution reussi");
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
            }
        }
        private void ModifierMatch()
        {
            commandesql = "";
        }
        // EQUIPES
        private void AjoutEquipe()
        {
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
                oraNum.Value = 1;
                oraNom.Value = TB_NomEquipe.Text;
                //oraLogo.Value = PicToByte();
                oraVille.Value = TB_Endroit.Text;
                oraDivision.Value = CB_DivisionEquipe.Text;
                oraDate.Value = Convert.ToDateTime(Properties.Settings.Default.DateChoisi);
                //on fait du streaming (lecture en continue du fichier BLOB 

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
                MessageBox.Show("Execution reussi");
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
            }
        }
        private void ModifierEquipe()
        {
            commandesql = "";
        }
        // DIVISIONS
        private void AjoutDivision()
        {
            try
            {
                // la requête SQLajout est paramétrée. Elle a 4 paramètres.
                //les paramètres pour Oracle et C # sont précédés de deux points : 
                string sqlajout = " insert into divisions " +
                "(NUMDIVISION, NOM, DATECREATION) values " +
                "(:NumDivision,:Nom,:DateValue)";
                // On déclare les paramètres pour chaque paramètre de la requête
                OracleParameter oraNum = new OracleParameter(":NumDivision", OracleDbType.Int32);
                OracleParameter oraNom = new OracleParameter(":Nom", OracleDbType.Varchar2, 50);
                OracleParameter oraDate = new OracleParameter(":DateValue", OracleDbType.Date);
                // on affecte les valeurs aux paramètres.
                oraNum.Value = 1;
                oraNom.Value = TB_NomDivision.Text;
                oraDate.Value = Convert.ToDateTime(Properties.Settings.Default.DateChoisi);

                // En crée un Objet OracleCommand pour passer la requête à la bD 
                OracleCommand oraAjout = new OracleCommand(sqlajout, oraconnGestion);
                oraAjout.CommandType = CommandType.Text;
                // En utilisant la propriété Paramètres de OracleCommand, on spécifie les 
                // Paramètre de la requête SQLajout.

                oraAjout.Parameters.Add(oraNum);
                oraAjout.Parameters.Add(oraNom);
                oraAjout.Parameters.Add(oraDate);
                // on execute la requete 
                oraAjout.ExecuteNonQuery();
                MessageBox.Show("Execution reussi");
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
            }
        }
        private void ModifierDivision()
        {
            commandesql = "";
        }
        // JOUEURS
        private void AjoutJoueur()
        {
            commandesql = "insert into joueurs values(1, '" + TB_NomJ.Text 
                                                            + "', '" + TB_PrenomJ.Text 
                                                            + "', '" + LB_DateJ.Text 
                                                            + "', " + TB_NumeroJ.Text 
                                                            + ", '" + CB_PositionJ.Text 
                                                            + "', '" + TB_PhotoJ.Text 
                                                            + "', " + CB_ChoixEquipeJ + ")";
        }
        private void ModifierJoueur()
        {
            commandesql = "";
        }

        // Gestion des erreurs
        private void SwitchException(OracleException ex)
        {
            string CodeErreur = ex.Number.ToString();
            string DescriptionErreur;
            switch (ex.Number)
            {
                case 2292:
                    DescriptionErreur = "Tentative de suppression d'une clé lié à une clé étrangère";
                    break;
                case 1407:
                    DescriptionErreur = "Vous ne pouvez pas mettre a jour une colonne avec une valeur null";
                    break;
                case 1400:
                    DescriptionErreur = "Vous ne pouvez pas ajouter une colonne avec une valeur null";
                    break;
                case 1:
                    DescriptionErreur = "Le numero d'employé doit être unique";
                    break;
                case 1410:
                    DescriptionErreur = "Vous ne pouvez pas mettre de valeur null";
                    break;
                case 1017:
                    DescriptionErreur = "Mot de passe ou nom d'utilisateur invalide, connection non établi";
                    break;
                case 12170:
                    DescriptionErreur = "La base de données est indisponible, réessayer plus tard";
                    break;
                case 12543:
                    DescriptionErreur = "Connexion impossible. Vérifiez votre connection internet";
                    break;
                case 12533:
                    DescriptionErreur = "Connexion impossible. Le parametre de connexion d'adresse est invalide";
                    break;
                case 12504:
                    DescriptionErreur = "Connexion impossible. Le nom d'instance Oracle est invalide";
                    break;
                case 12541:
                    DescriptionErreur = "Connexion impossible. La destination est invalide ou pas rejoignable";
                    break;
                default:
                    DescriptionErreur = ex.Message;
                    break;
            }
            Properties.Settings.Default.CodeErreur = CodeErreur;
            Properties.Settings.Default.DescriptionErreur = DescriptionErreur;
            Properties.Settings.Default.Save();

            AfficherErreur();
        }
        private void AfficherErreur()
        {
            FormErreur dlg = new FormErreur();

            if (dlg.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        // Event et methode pour updater les flashbuttons
        private void UpdateControl()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Équipes":
                    FB_AppliquerEquipe.Enabled = (TB_NomEquipe.Text == "" || TB_LieuxEquipe.Text == "" || CB_DivisionEquipe.Text == "" || LB_DateEquipe.Text == "Date" ) ? false : true;
                    break;
                case "Joueurs":
                    FB_AppliquerJoueur.Enabled = (TB_NomJ.Text == "" || TB_PrenomJ.Text == "" || TB_NumeroJ.Text == "" || TB_PhotoJ.Text == "" || CB_ChoixEquipeJ.Text == "" || CB_PositionJ.Text == "" || LB_DateJ.Text == "Date") ? false : true;
                    break;
                case "Division":
                    FB_AppliquerDivision.Enabled = (TB_NomDivision.Text == "" || LB_DateDivision.Text == "Date") ? false : true;
                    break;
                case "Matchs":
                    FB_AppliquerMatch.Enabled = (CB_EMaison.Text == "" || CB_EVisiteur.Text == "" || TB_Endroit.Text == "" ) ? false : true;
                    break;
            }
        }
        private void TB_TextChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }
        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControl();
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
                    LB_Text.Text = "Gestion des équipes";
                    break;
                case "Joueurs":
                    PN_Joueurs.Parent = this;
                    PN_Joueurs.Visible = true;
                    PN_Joueurs.Enabled = true;
                    PN_Joueurs.Location = basePanel;
                    LB_Text.Text = "Gestion des joueurs";
                    break;
                case "Division":
                    PN_Division.Parent = this;
                    PN_Division.Visible = true;
                    PN_Division.Enabled = true;
                    PN_Division.Location = basePanel;
                    LB_Text.Text = "Gestion des divisions";
                    break;
                case "Matchs":
                    PN_Matchs.Parent = this;
                    PN_Matchs.Visible = true;
                    PN_Matchs.Enabled = true;
                    PN_Matchs.Location = basePanel;
                    LB_Text.Text = "Gestion des matchs";
                    break;
            }
        }

        // Events pour pouvoir faire bouger le form 
        private void FormGestion_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }
        private void FormGestion_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void FormGestion_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
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
            if(!Properties.Settings.Default.ModifierAjouter)
            {
                AjoutMatch();
            }
            else
            {
                ModifierMatch();
            }
        }

        private void FB_AppliquerDivision_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.ModifierAjouter)
            {
                AjoutDivision();

            }
            else
            {
                ModifierMatch();
            }
        }


    }
}
