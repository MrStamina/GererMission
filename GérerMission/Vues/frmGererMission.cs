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
        private Mission newMiss = null;
        
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
                AlimenterQualif();
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
        
        
        //Gestion de la combobox
        private void comboBoxChoixEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nombresMission = 0;
            
            if (comboBoxChoixEntreprise.SelectedItem != null)
            {
                missionBindingSource.DataSource = DaoMission.GetAllMissions(((Entreprise)comboBoxChoixEntreprise.SelectedItem).IdEntreprise);
                nombresMission = DaoMission.GetAllMissions(((Entreprise)comboBoxChoixEntreprise.SelectedItem).IdEntreprise).Count;
                if (nombresMission == 0)
                {
                    labelMessage.ForeColor = Color.Red;
                    labelMessage.Text = "Aucune mission disponible pour cette entreprise";
                    dataGridViewMissions.Visible = false;

                }
                else
                {
                    dataGridViewMissions.Visible = true;
                    labelMessage.ResetText();
                }
                buttonCreer.Enabled = true;
                
            }
           
        }

        //Gestion de la datagridView
        private void dataGridViewMissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if(e.ColumnIndex == dataGridViewMissions.Columns["Details"].Index && e.RowIndex >= 0 )
            {
                AfficherDétails affdet = new AfficherDétails((Mission)dataGridViewMissions.CurrentRow.DataBoundItem, OuiNon = false, ((Entreprise)comboBoxChoixEntreprise.SelectedItem).IdEntreprise);
                affdet.Show();
                         
            }
            else if(e.ColumnIndex == dataGridViewMissions.Columns["Modifier"].Index && e.RowIndex >= 0)
            {
                AfficherDétails affdet = new AfficherDétails((Mission)dataGridViewMissions.CurrentRow.DataBoundItem, OuiNon = true, ((Entreprise)comboBoxChoixEntreprise.SelectedItem).IdEntreprise);
                affdet.Show();
                

            }
            else if(e.ColumnIndex == dataGridViewMissions.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {
                int nombresMission = 0;
                newMiss = (dataGridViewMissions.Rows[e.RowIndex].DataBoundItem) as Mission;
                string message = "Etes-vous sûr de vouloir supprimer";
                string caption = "Suppression d'une mission";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {                        
                        if (DaoMission.DelMission(newMiss) == true)
                        {
                            missionBindingSource.Remove(newMiss);
                            missionBindingSource.ResetBindings(false);
                        }
                    }
                    catch(DaoExceptionAfficheMessage def)
                    {
                        MessageBox.Show(def.Message);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                nombresMission = DaoMission.GetAllMissions(((Entreprise)comboBoxChoixEntreprise.SelectedItem).IdEntreprise).Count;
                if (nombresMission == 0)
                {
                    labelMessage.ForeColor = Color.Red;
                    labelMessage.Text = "Aucune mission disponible pour cette entreprise";
                    dataGridViewMissions.Visible = false;

                }
                else
                {
                    dataGridViewMissions.Visible = true;
                    labelMessage.ResetText();
                }

            }
            dataGridViewMissions.Refresh();
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
            
            
            AfficherDétails affcreate = new AfficherDétails(((Entreprise)comboBoxChoixEntreprise.SelectedItem).IdEntreprise, this);
            
            affcreate.Show();
            
                       
        }


        //Méthode pour rafraichir la dgw
        public void RefreshDataGridView(Mission miss)
        {

            dataGridViewMissions.Refresh();
            missionBindingSource.Add(miss);
        }
                    

    }
}
