using System;
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
    public partial class FormRecherche : Form
    {
        public FormRecherche()
        {
            InitializeComponent();
        }

        private void FormRecherche_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PosFormRecherche;
        }

        private void FormRecherche_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PosFormRecherche = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
