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
    public partial class FormClassement : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private Point basePanel = new Point(4, 30);
        public OracleConnection oraconnClassement { set; get; }
        string Sql = "select j.prenom, j.nom, j.numeromaillot, j.typejoueur, j.photo, e.LOGO, s.NBREBUTS*2 + s.NBREPASSES as Score " +
                     "from joueurs j inner join equipes e on j.NUMEQUIPE = e.NUMEQUIPE " +
                     "inner join STATISTIQUESJOUEURS s on j.NUMJOUEUR = s.NUMJOUEUR " +
                     "where s.NBREBUTS*2 + s.NBREPASSES  is not null " +
                     "order by Score desc";

        public FormClassement(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnClassement = oraconn;
        }

        private void FormClassement_Load(object sender, EventArgs e)
        {
            EnabledVisibleLesPanels();
            this.Location = Properties.Settings.Default.PosFormClassement;
        }

        private void InitListJoueur()
        {
            try
            {
                OracleCommand orcd = new OracleCommand(Sql, oraconnClassement);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                //Joueur #1
                while (oraRead.Read())
                {
                    //Image Photo = new Image(Image.FromFile(oraRead.GetString(4)));
                    
                    DGV_JoueurList.Rows.Add(
                    Image.FromFile(oraRead.GetString(4)),
                    oraRead.GetString(0),
                    oraRead.GetString(1),
                    "Numéro " + oraRead.GetInt32(2).ToString(),
                    oraRead.GetString(3),                    
                    oraRead.GetInt32(6).ToString() + " Points",
                    Image.FromStream(oraRead.GetOracleBlob(5)));
                }
                oraRead.Close();
            }
            catch (OracleException exsqlajout)
            {
                MessageBox.Show(exsqlajout.Message.ToString());
            }
        }

        private void InitClassementBestJoueurs()
        {
            try
            {
                OracleCommand orcd = new OracleCommand(Sql, oraconnClassement);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                //Joueur #1
                oraRead.Read();
                LB_PrenomGold.Text = oraRead.GetString(0);
                LB_NomGold.Text = oraRead.GetString(1);
                LB_NumeroGold.Text = "Numéro " + oraRead.GetInt32(2).ToString();
                LB_PositionGold.Text = oraRead.GetString(3);
                PB_Photo_Gold.ImageLocation = oraRead.GetString(4);
                PB_Photo_Gold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                PB_EquipeGold.Image = Image.FromStream(oraRead.GetOracleBlob(5));
                PB_EquipeGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                LB_PointsGold.Text = oraRead.GetInt32(6).ToString() + " Points";

                //Joueur #2
                oraRead.Read();
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
                oraRead.Read();
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

        private void EnabledVisibleLesPanels()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Equipes":
                    PN_CEquipe.Parent = this;
                    PN_CEquipe.Visible = true;
                    PN_CEquipe.Enabled = true;
                    PN_CEquipe.Location = basePanel;
                    LB_Text.Text = "Classement des équipes";
                    break;
                case "Top3":
                    PN_3Joueurs.Parent = this;
                    PN_3Joueurs.Visible = true;
                    PN_3Joueurs.Enabled = true;
                    PN_3Joueurs.Location = basePanel;
                    LB_Text.Text = "Trois meilleurs joueurs";
                    InitClassementBestJoueurs();
                    break;
                case "Joueurs":
                    PN_CJoueurs.Parent = this;
                    PN_CJoueurs.Visible = true;
                    PN_CJoueurs.Enabled = true;
                    PN_CJoueurs.Location = basePanel;
                    LB_Text.Text = "Classement des joueurs";
                    InitListJoueur();
                    break;
            }
        }

        // Events pour pouvoir faire bouger le form 
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

        private void FormClassement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormClassement = this.Location;
            Properties.Settings.Default.Save();
        }

    }
}
