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
    public partial class FormOptions : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        public OracleConnection oraconnGestion = new OracleConnection();
        string sqlcommande, nomtable, primarykey;

        public FormOptions(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnGestion = oraconn;
        }
        private void FormOptions_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PosFormOptions;
            SwitchCommandeComboBox();
            FB_Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            FB_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        }

        private void SwitchCommandeComboBox()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Équipes":
                    sqlcommande = "select numequipe, nom from equipes";
                    nomtable = "equipes";
                    primarykey = "numequipe";
                    LB_Text.Text = "Équipes";
                    break;
                case "Joueurs":
                    sqlcommande = "select numjoueur, prenom, nom from joueurs";
                    nomtable = "joueurs";
                    primarykey = "numjoueur";
                    LB_Text.Text = "Joueurs";
                    break;
                case "Division":
                    sqlcommande = "select numdivision, nom from divisions";
                    nomtable = "divisions";
                    primarykey = "numdivision";
                    LB_Text.Text = "Divisions";
                    break;
                case "Matchs":
                    sqlcommande = "select m.nummatch, ev.nom, em.nom from matchs m " +
                                  "inner join equipes ev on ev.numequipe = m.numequipevis " +
                                  "inner join equipes em on em.numequipe = m.numequipemai ";
                    nomtable = "matchs";
                    primarykey = "nummatch";
                    LB_Text.Text = "Matchs";
                    break;
            }
            RemplirComboBox();
        }

        private void RemplirComboBox()
        {
            try
            {
                OracleCommand orcd = new OracleCommand(sqlcommande, oraconnGestion);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while (oraRead.Read())
                {
                    CB_Invisible.Items.Add(oraRead.GetInt32(0).ToString());
                    switch (Properties.Settings.Default.FenetreAOuvrir)
                    {
                        case "Équipes":
                            CB_Value.Items.Add(oraRead.GetString(1).ToString());
                            break;
                        case "Joueurs":
                            CB_Value.Items.Add(oraRead.GetString(1).ToString() + " " + oraRead.GetString(2).ToString());
                            break;
                        case "Division":
                            CB_Value.Items.Add(oraRead.GetString(1).ToString());
                            break;
                        case "Matchs":
                            CB_Value.Items.Add(oraRead.GetString(1).ToString() + " vs " + oraRead.GetString(2).ToString());
                            break;
                    }
                }
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
            }
        }

        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FB_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Events pour pouvoir faire bouger le form 
        private void FormOptions_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }
        private void FormOptions_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void FormOptions_MouseUp(object sender, MouseEventArgs e)
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
        // Execption
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

        private void FB_Ok_Click(object sender, EventArgs e)
        {
            if (RB_Supprimer.Checked)
            {
                sqlcommande = "delete from " + nomtable + " where " + primarykey + " = " + CB_Invisible.Text;
                if(DeleteThing())
                {
                    MessageBox.Show("Suppression réussi");
                }
                CB_Invisible.Items.Clear();
                CB_Value.Items.Clear();
                SwitchCommandeComboBox();
            }
            else if (RB_Modifier.Checked)
            {
                Properties.Settings.Default.ModifierAjouter = true;
                Properties.Settings.Default.NumValue = CB_Invisible.Text;
                Properties.Settings.Default.Save();
                AfficherGestion();
                this.Close();
            }
            else
            {
                Properties.Settings.Default.ModifierAjouter = false;
                Properties.Settings.Default.Save();
                AfficherGestion();
                this.Close();
            }
        }

        private bool DeleteThing()
        {
            bool reussi = true; 
            OracleCommand orcd = new OracleCommand(sqlcommande, oraconnGestion);
            try
            {
                orcd.CommandType = CommandType.Text;
                orcd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                SwitchException(ex);
                reussi = false;
            }
            return reussi;
        }

        private void AfficherGestion()
        {
            FormGestion dlg = new FormGestion(oraconnGestion);

            dlg.ShowDialog();
        }

        private void CB_Value_TextChanged(object sender, EventArgs e)
        {
            CB_Invisible.SelectedIndex = CB_Value.SelectedIndex;
            UpdateControl();
        }

        private void CB_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Invisible.SelectedIndex = CB_Value.SelectedIndex;
            UpdateControl();
        }

        private void RB_Ajouter_CheckedChanged(object sender, EventArgs e)
        {
            CB_Value.Enabled = false;
            CB_Value.Visible = false;
            UpdateControl();
        }

        private void RB_Modifier_CheckedChanged(object sender, EventArgs e)
        {
            CB_Value.Enabled = true;
            CB_Value.Visible = true;
            UpdateControl();
        }

        private void RB_Supprimer_CheckedChanged(object sender, EventArgs e)
        {
            CB_Value.Enabled = true;
            CB_Value.Visible = true;
            UpdateControl();
        }

        private void UpdateControl()
        {
            FB_Ok.Enabled = false;
            if (RB_Ajouter.Checked)
            {
                FB_Ok.Enabled = true; 
            }
            else if(RB_Modifier.Checked || RB_Supprimer.Checked)
            {
                if (CB_Value.Text != "")
                {
                    FB_Ok.Enabled = true;
                }
            }
        }

        private void FormOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormOptions = this.Location;
        }
    }
}
