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
    public partial class FormRecherche : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private Point basePanel = new Point(3, 28);
        private OracleConnection oraconnRecherche = new OracleConnection();
        private DataSet monDataSet = new DataSet();
        private DataSet monDataSet2 = new DataSet();

        public FormRecherche(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnRecherche = oraconn;
            LabelTransparent();
        }



        private void LabelTransparent()
        {
            Point pos = new Point(105, 220);
            pos = PB_Joueur.PointToClient(pos);
            LB_Mailot.Parent = PB_Joueur;
            LB_Mailot.Location = pos;
            //LB_Mailot.BackColor = Color.Transparent;
            LB_Mailot.BackColor = Color.FromArgb(125, 0, 0, 0);
        }

        private void FormRecherche_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PosFormRecherche;
            EnabledVisibleLesPanels();
        }

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
            catch (OracleException exsql2)
            {
                MessageBox.Show(exsql2.Message.ToString());
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
                    LB_Text.Text = "Matchs";
                    break;
            }
        }

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

        // Events pour pouvoir faire bouger le form 
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
        private void FormRecherche_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void FormRecherche_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        private void FormRecherche_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void FormRecherche_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormRecherche = this.Location;
            Properties.Settings.Default.Save();
        }

        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (Properties.Settings.Default.FenetreAOuvrir == "Joueurs")
                        JoueurPrecedent();
                    else if (Properties.Settings.Default.FenetreAOuvrir == "Équipes")
                        EquipePrecedente();
                    break;
                case Keys.Right:
                    if (Properties.Settings.Default.FenetreAOuvrir == "Joueurs")
                        ProchainJoueur();
                    else if (Properties.Settings.Default.FenetreAOuvrir == "Équipes")
                        ProchaineEquipe();
                    break;
            }
            bool result = base.ProcessCmdKey(ref msg, keyData);
            return result;
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



        private void FB_FermerD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Gestion des erreurs
        private void AfficherErreur(OracleException ex)
        {
            FormErreur dlg = new FormErreur(ex);

            if (dlg.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void fermer_equipe(object sender, EventArgs e)
        {
            this.Close();
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


    }
}
