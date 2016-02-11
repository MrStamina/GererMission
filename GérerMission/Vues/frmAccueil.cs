using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GérerMission
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        public void RendreEnable()
        {
            gererMissionToolStripMenuItem.Enabled = true;
            fenetresToolStripMenuItem.Enabled = true;
        }

        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Identification();
        }

        // s'identifier

        private void Identification()
        {
            frmLogin frmfille = new frmLogin();
            frmfille.MdiParent = this;
            frmfille.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Etes-vous sûr de vouloir quitter ?";
            const string caption = "QUITTER";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void GestionMission()
        {
            GererMission frmfille = new GererMission();
            frmfille.MdiParent = this;
            frmfille.Show();
        }

        private void gérerMissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GestionMission();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void frmAccueil_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatuslblDate.Text = DateTime.Now.ToString();
        }
    }
}
