using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GérerMission.Metier;
using GérerMission.Dao;


namespace GérerMission
{
    public partial class AfficherDétails : Form
    {
        public AfficherDétails()
        {
           
            InitializeComponent();
        }

        public AfficherDétails(int IdEntreprise)
        {
            InitializeComponent();
        }
        //TODO Dao + Exception + Controles + datagrid...

        private void textBoxPrecision_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPrecision.Text != string.Empty)
            {

            }
        }

        private void AfficherDétails_Load(object sender, EventArgs e)
        {
            AlimenterQualifs();
            comboBoxQualification.SelectedItem = null;
            AlimenterConsultants();
            comboBoxConsultant.SelectedItem = null;
        }

        // Validation des champs saisis

        // Méthodes binding
        public void AlimenterQualifs()
        {
            qualificationBindingSource.DataSource = DaoMission.GetAllQualifications();
        }
        public void AlimenterConsultants()
        {
            consultantBindingSource.DataSource = DaoMission.GetAllConsultants();
        }

        //Gestion du bouton annuler
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
