using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GérerMission.Utilitaires;

namespace GérerMission
{
    public partial class frmLogin : Form
    {
        private bool result;
        public frmLogin()
        {
            InitializeComponent();
        }

        private frmAccueil frmMere;

        // Pour se loguer le nom et le mot de passe doivent être identiques
        private void btnOK_Click(object sender, EventArgs e)
        {
            result = Affichage.TestLogin(txtLogin.Text, txtPwd.Text);
            if (result == true)
            {
                frmMere = (frmAccueil)this.MdiParent;
                frmMere.RendreEnable();

                MessageBox.Show("Bienvenue " + txtLogin.Text, "Bienvenue");
                this.Close();
            }
            else
            {
                MessageBox.Show("Recommencez !");
                txtLogin.Focus();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
