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
        string sqlcommande, sqlcommandedelete;

        public FormOptions(OracleConnection oraconn)
        {
            InitializeComponent();
            oraconnGestion = oraconn;
        }

        // Form loading et closing
        private void FormOptions_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PosFormOptions;
            SwitchCommandeComboBox();
            FB_Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            FB_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            UpdateControl();
        }
        private void FormOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormOptions = this.Location;
            Properties.Settings.Default.Save();
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

        // Exception
        private void AfficherErreur(OracleException ex)
        {
            FormErreur dlg = new FormErreur(ex);

            if (dlg.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        // Fonctions Ajout/Remplissage
        private void SwitchCommandeComboBox()
        {
            switch (Properties.Settings.Default.FenetreAOuvrir)
            {
                case "Équipes":
                    sqlcommande = "select numequipe, nom from equipes order by nom";
                    sqlcommandedelete = "delete from equipes where numequipe =";
                    LB_Text.Text = "Équipes";
                    break;
                case "Joueurs":
                    sqlcommande = "select numjoueur, prenom, nom from joueurs order by prenom";
                    sqlcommandedelete = "delete from joueurs where numjoueur =";
                    LB_Text.Text = "Joueurs";
                    break;
                case "Division":
                    sqlcommande = "select numdivision, nom from divisions order by nom";
                    sqlcommandedelete = "delete from division where numdivision =";
                    LB_Text.Text = "Divisions";
                    break;
                case "Matchs":
                    sqlcommande = "select m.nummatch, ev.nom, em.nom from matchs m " +
                                  "inner join equipes ev on ev.numequipe = m.numequipevis " +
                                  "inner join equipes em on em.numequipe = m.numequipemai " + " order by ev.nom ";
                    sqlcommandedelete = "delete from matchs where nummatch =";
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
                AfficherErreur(ex);
            }
        }

        private bool DeleteThing()
        {
            bool reussi = true;
            OracleCommand orcd = new OracleCommand(sqlcommandedelete, oraconnGestion);
            try
            {
                orcd.CommandType = CommandType.Text;
                orcd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                AfficherErreur(ex);
                reussi = false;
            }
            return reussi;
        }

        private void AfficherGestion()
        {
            FormGestion dlg = new FormGestion(oraconnGestion);

            dlg.ShowDialog();
        }

        private void UpdateControl()
        {
            FB_Ok.Enabled = false;
            if (RB_Ajouter.Checked)
            {
                FB_Ok.Enabled = true;
            }
            else if (RB_Modifier.Checked || RB_Supprimer.Checked)
            {
                if (CB_Value.Text != "")
                {
                    FB_Ok.Enabled = true;
                }
            }
        }
        private void VerifierRadioButton()
        {
            if (RB_Supprimer.Checked)
            {
                if (DeleteThing())
                {
                    MessageBox.Show("Suppression réussi");
                }
                else
                {
                    MessageBox.Show("Suppression non réussi");
                }
                this.Close();
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
                Properties.Settings.Default.NumValue = "1";
                Properties.Settings.Default.Save();
                AfficherGestion();
                this.Close();
            }
        }

        private void FB_Ok_Click(object sender, EventArgs e)
        {
            VerifierRadioButton();
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
        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
