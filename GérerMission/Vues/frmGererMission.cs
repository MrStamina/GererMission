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
        private bool OuiNon;

        //private Entreprise entrepriseEnCours;

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
                AlimenterQualif();//plop
                
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
            try
            {
                entrepriseBindingSource.DataSource = DaoMission.GetAllEntreprises();
            }
            catch(DaoExceptionFinApplication defa)
            {
                MessageBox.Show(defa.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AlimenterQualif()
        {
            try
            {
                qualificationBindingSource.DataSource = DaoMission.GetAllQualifications();
            }
            catch (DaoExceptionFinApplication defa)
            {
                MessageBox.Show(defa.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        

        private void comboBoxChoixEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxChoixEntreprise.SelectedItem != null)
            {

                missionBindingSource.DataSource = DaoMission.GetAllMissions(((Entreprise)comboBoxChoixEntreprise.SelectedItem).IdEntreprise);
                dataGridViewMissions.Visible = true;
                //entrepriseEnCours = (Entreprise)comboBoxChoixEntreprise.SelectedItem;
                //AfficherMissions();

            }
        }

        private void dataGridViewMissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if(e.ColumnIndex == dataGridViewMissions.Columns["Details"].Index && e.RowIndex >= 0 )
            {
                AfficherDétails affdet = new AfficherDétails((Mission)dataGridViewMissions.CurrentRow.DataBoundItem, OuiNon = false);
                affdet.Show();
                         
            }
            else if(e.ColumnIndex == dataGridViewMissions.Columns["Modifier"].Index && e.RowIndex >= 0)
            {
                AfficherDétails affdet = new AfficherDétails((Mission)dataGridViewMissions.CurrentRow.DataBoundItem, OuiNon = true);
                affdet.Show();
            }
            else if(e.ColumnIndex == dataGridViewMissions.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {
                string message = "Etes-vous sûr de vouloir supprimer";
                string caption = "Suppression d'une prévision";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    
                }
            }
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

        public void EnableOrNot (bool OuiNon)
        {

        }

       // Rechercher et affichage des missions
        //    private void AfficherMissions()
        //{
        //    List<Mission> mission = entrepriseEnCours.GetMissions();
        //    if (mission.Count == 0)
        //    {
        //        mission = DaoMission.GetAllMissions(entrepriseEnCours.IdEntreprise);
        //        entrepriseEnCours.SetMissions(mission);
        //    }
        //    missionBindingSource.DataSource = mission;
        //    AffichageDataGridView(mission.Count);
        //}

        //private void AffichageDataGridView(int i)
        //{
        //    if (i > 0)
        //    {
        //        dataGridViewMissions.ClearSelection();
        //        dataGridViewMissions.Visible = true;
        //    }
        //    else
        //    {
        //        dataGridViewMissions.Visible = false;
        //    }
        //}

    }
}
