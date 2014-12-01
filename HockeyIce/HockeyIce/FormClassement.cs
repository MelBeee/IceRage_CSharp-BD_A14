﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyIce
{
    public partial class FormClassement : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public FormClassement()
        {
            InitializeComponent();
        }

        private void FB_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClassement_Load(object sender, EventArgs e)
        {
            switch(Properties.Settings.Default.Classement)
            {
                case "CEquipes":
                    PN_CEquipe.Parent = this; 
                    PN_CEquipe.Visible = true;
                    PN_CEquipe.Enabled = true;
                    PN_3Joueurs.Visible = false;
                    PN_3Joueurs.Enabled = false;
                    PN_CJoueurs.Visible = false;
                    PN_CJoueurs.Enabled = false;
                    LB_Text.Text = "Classement des équipes"; 
                    break;
                case "C3J":
                    PN_CEquipe.Visible = false;
                    PN_CEquipe.Enabled = false;
                    PN_3Joueurs.Parent = this; 
                    PN_3Joueurs.Visible = true;
                    PN_3Joueurs.Enabled = true;
                    PN_CJoueurs.Visible = false;
                    PN_CJoueurs.Enabled = false;
                    LB_Text.Text = "Trois meilleurs joueurs"; 
                    break;
                case "CJoueurs":
                    PN_CEquipe.Visible = false;
                    PN_CEquipe.Enabled = false;
                    PN_3Joueurs.Visible = false;
                    PN_3Joueurs.Enabled = false;                    
                    PN_CJoueurs.Parent = this; 
                    PN_CJoueurs.Visible = true;
                    PN_CJoueurs.Enabled = true;
                    LB_Text.Text = "Classement des joueurs"; 
                    break;
            }
        }

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
    }
}