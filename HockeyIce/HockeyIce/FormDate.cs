using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      FORM DATE
//      Fait par Melissa Boucher et Xavier Brosseau
//      15 Decembre 2014
//      Produit pour le cours de Base de Données et Developpement d'Interfaces
//
//      Utilisé pour choisir une date 
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace HockeyIce
{
    public partial class FormDate : Form
    {
        // bool savoir si on est entrain de deplacer le form
        private bool _dragging = false;
        // emmagasine la position du curseur lors d'un deplacement de form
        private Point _start_point = new Point(0, 0);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      CONSTRUCTEUR
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public FormDate()
        {
            InitializeComponent();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      LOAD ET CLOSING
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormDate_Load(object sender, EventArgs e)
        {
            // loading de la position sauvegardé antérieurement 
            this.Location = Properties.Settings.Default.PosFormDate;
            // set la date de depart a la date "loader"
            MC_Date.SelectionRange.Start = Properties.Settings.Default.DateChoisi;
        }
        private void FormDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Enregistre la localisation du form pour utilisation prochaine
            Properties.Settings.Default.PosFormDate = this.Location ;
            Properties.Settings.Default.Save();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      DEPLACEMENT DU FORM
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FormDate_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // Enregistre que l'utilisateur a selectionner la form
            _start_point = new Point(e.X, e.Y); // Enregistre le point actuelle du form 
        }
        private void FormDate_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging) // si l'utilisateur a selectionner le form
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void FormDate_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; // Enregistre que l'utilisateur a "lacher le form"
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      EVENTS DE FLASHBUTTON
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FB_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FB_Appliquer_Click(object sender, EventArgs e)
        {
            // Save la date choisi
            Properties.Settings.Default.DateChoisi = MC_Date.SelectionRange.Start;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }
        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
