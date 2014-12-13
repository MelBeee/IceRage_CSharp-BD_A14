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

namespace HockeyIce
{
    public partial class FormClassement : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private Point basePanel = new Point(4, 30);
        public OracleConnection oraconnClassement { set; get; }
        string Sql = "select cj.Prenom, cj.Nom, j.numeromaillot, j.typejoueur, j.Photo, e.Logo, cj.point from ClassementJoueur cj " +
                     "inner join joueurs j on j.NUMJOUEUR = cj.NUMJOUEUR " +
                     "inner join EQUIPES e on e.NUMEQUIPE = cj.NUMEQUIPE " +
                     "where point >=0";

        public FormClassement(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnClassement = oraconn;
        }

        private void FormClassement_Load(object sender, EventArgs e)
        {
            EnabledVisibleLesPanels();
            this.Location = Properties.Settings.Default.PosFormClassement;
            CouleurLoadDGV();
        }

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

        // Telecharge l'image de l'URL fournit
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

        //resize l'image passer en paramettre et ces nouvelles dimension
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void InitDivisionEquipe()
        {
            try
            {
                OracleCommand orcd = new OracleCommand(Sql, oraconnClassement);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                //Joueur #1
                while (oraRead.Read())
                {
                    Image Photo = GetImageFromUrl(oraRead.GetString(4));
                    Photo = resizeImage(Photo, new Size(50, 75));
                    Image Logo = Image.FromStream(oraRead.GetOracleBlob(5));
                    Logo = resizeImage(Logo, new Size(50, 45));
                    //0,1,2,3,4
                    DGV_Divison.Rows.Add();
                }

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

                    Image Photo = GetImageFromUrl(oraRead.GetString(4));
                    Photo = resizeImage(Photo, new Size(50, 75));
                    Image Logo = Image.FromStream(oraRead.GetOracleBlob(5));
                    Logo = resizeImage(Logo, new Size(50, 45));

                    DGV_JoueurList.Rows.Add(
                    Photo,
                    oraRead.GetString(0),
                    oraRead.GetString(1),
                    "Numéro " + oraRead.GetInt32(2).ToString(),
                    oraRead.GetString(3),
                    oraRead.GetInt32(6).ToString() + " Points",
                    Logo);
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
                    InitDivisionEquipe();
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

        private void DGV_JoueurList_SelectionChanged(object sender, EventArgs e)
        {
            DGV_JoueurList.ClearSelection();
        }
    }
}
