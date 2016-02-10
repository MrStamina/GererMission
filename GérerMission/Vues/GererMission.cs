using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GérerMission.Dao;
using GérerMission.Exceptions;
using GérerMission.Metier;

namespace GérerMission
{
    public partial class GererMission : Form
    {
        private Entreprise entrepriseEnCours;
        public GererMission()
        {
            InitializeComponent();
        }

        // On charge la combobox entreprise au chargement
        private void GererMission_Load(object sender, EventArgs e)
        {
            try
            {
                AlimenterEntreprise();
                qualificationBindingSource.DataSource = DaoMission.GetAllQualifications();
                comboBoxChoixEntreprise.SelectedItem = null;
                


            }
            catch(DaoExceptionFinApplication dfa)
            {
                MessageBox.Show(dfa.Message);
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite \n" + ex.Message);
            }
            
        }

        // Lorsqu'une entreprise est selectionnée on affiche ses missions


        // Binding Source
        public void AlimenterEntreprise()
        {
            entrepriseBindingSource.DataSource = DaoMission.GetAllEntreprises();
        }

        
        

        private void comboBoxChoixEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxChoixEntreprise.SelectedItem != null)
            {

                missionBindingSource.DataSource = DaoMission.GetAllMissions(((Entreprise)comboBoxChoixEntreprise.SelectedItem).IdEntreprise);
               
                dataGridViewMissions.Visible = true;
            }
        }

        private void dataGridViewMissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Gestion du bouton quitter
        #region Gestion de la fermeture
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GererMission_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Etes-vous sûr de vouloir quitter ?";
            const string caption = "QUITTER";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }
        #endregion


        //Gestion du bouton Créer
        private void buttonCreer_Click(object sender, EventArgs e)
        {
            AfficherDétails affdet = new AfficherDétails();
            affdet.Show();
        }
       

        // Rechercher et affichage des missions
        //    private void AfficherMissions()
        //    {
        //        List<Mission> mission = entrepriseEnCours.GetMissions();
        //        //if (mission.Count == 0)
        //        //{
        //            mission = DaoMission.GetAllMissions(entrepriseEnCours.IdEntreprise);
        //            entrepriseEnCours.SetMissions(mission);
        //        //}
        //        missionBindingSource.DataSource = mission;
        //        AffichageDataGridView(mission.Count);
        //    }

        //    private void AffichageDataGridView(int i)
        //    {
        //        if(i>0)
        //        {
        //            dataGridViewMissions.ClearSelection();
        //            dataGridViewMissions.Visible = true;
        //        }
        //        else
        //        {
        //            dataGridViewMissions.Visible = false;
        //        }
        //    }

    }
}
