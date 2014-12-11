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
        private Point basePanel = new Point(3, 30);
        private OracleConnection oraconnRecherche = new OracleConnection();
        private DataSet monDataSet = new DataSet();

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
            LB_Mailot.BackColor = Color.Transparent;
        }

        private void FormRecherche_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PosFormRecherche;
            EnabledVisibleLesPanels();
        }

        private void InitJoueur()
        {
            try
            {
                string sql2 = "select * from joueurs";// inner join equipes e on joueurs.NUMEQUIPE = e.NUMEQUIPE";

                OracleDataAdapter Adapter2 = new OracleDataAdapter(sql2, oraconnRecherche);
                if (monDataSet.Tables.Contains("joueurs") /*&& monDataSet.Tables.Contains("equipes")*/)
                {
                    monDataSet.Tables["joueurs"].Clear();
                    /*monDataSet.Tables["equipes"].Clear();*/
                }

                Adapter2.Fill(monDataSet, "joueurs");
                Adapter2.Dispose();
                // on apelle la fonction lier pour faire
                // la liaison des données du DataSet avec les zones de text.
                Lier();
                AffichageJoueur();
            }
            catch (OracleException exsql2)
            {
                MessageBox.Show(exsql2.Message.ToString());
            }
        }

        private void Lier()
        {
            LB_Nom.DataBindings.Add("text", monDataSet, "joueurs.nom");
            LB_Prenom.DataBindings.Add("text", monDataSet, "joueurs.prenom");
            LB_Type.DataBindings.Add("text", monDataSet, "joueurs.typejoueur");
            LB_Tempo.DataBindings.Add("text", monDataSet, "joueurs.numeromaillot");
            LB_Tempo2.DataBindings.Add("text", monDataSet, "joueurs.photo");
            LB_Tempo3.DataBindings.Add("text", monDataSet, "joueurs.numjoueur");
            DTP_Tempo.DataBindings.Add("text", monDataSet, "joueurs.Naissance");
        }

        private void ChangerLogoEquipe()
        {
            string commandesql = "";
            try
            {
                OracleCommand orcd = new OracleCommand(commandesql, oraconnRecherche);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                oraRead.Read();


                oraRead.Close();
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
            }
        }
        private void ChangerStatistiques()
        {
            string commandesql = "";
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
                    break;
                case "Joueurs":
                    PN_Joueurs.Parent = this;
                    PN_Joueurs.Visible = true;
                    PN_Joueurs.Enabled = true;
                    PN_Joueurs.Location = basePanel;
                    LB_Text.Text = "Joueurs";
                    InitJoueur();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormGestionStatistiqueJ dlg = new FormGestionStatistiqueJ(oraconnRecherche);

            dlg.ShowDialog();
        }

        private void FB_Next_Click(object sender, EventArgs e)
        {
            this.BindingContext[monDataSet, "joueurs"].Position += 1;
            AffichageJoueur();
            ChangerLogoEquipe();
            ChangerStatistiques();
        }

        private void FB_Back_Click(object sender, EventArgs e)
        {
            this.BindingContext[monDataSet, "joueurs"].Position -= 1;
            AffichageJoueur();
            ChangerLogoEquipe();
            ChangerStatistiques();
        }

        private void FB_FermerD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
