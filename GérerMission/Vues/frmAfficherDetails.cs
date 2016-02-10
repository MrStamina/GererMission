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
using GérerMission.Exceptions;



namespace GérerMission
{
    public partial class AfficherDétails : Form
    {
        
        
        public AfficherDétails(Mission miss, bool OuiNon)
        {
           
            Demarrage(miss);
            ChangerEnabledTrueOrFalse(OuiNon);
        }
        public AfficherDétails()
        {
            Demarrage(null);
        }

        private void Demarrage (Mission miss)
        {
            InitializeComponent();
            try
            {
               missionBindingSource.ResumeBinding();
               missionBindingSource.DataSource = miss;
            }
            catch (DaoExceptionFinApplication defa)
            {
                MessageBox.Show(defa.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AlimenterMotif();
            AlimenterNiveau();
            AlimenterQualifs();
            AlimenterConsultants();
           ;
            
        }
       

        private void textBoxPrecision_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPrecision.Text != string.Empty)
            {

            }
        }

        private void AfficherDétails_Load(object sender, EventArgs e)
        {
            //AlimenterQualifs();
            //comboBoxQualification.SelectedItem = null;
            //AlimenterConsultants();
            //comboBoxConsultant.SelectedItem = null;
        }

        // Validation des champs saisis

        // Méthodes binding
        #region Chargement binding
        public void AlimenterQualifs()
        {
            try
            {
                qualificationBindingSource.DataSource = DaoMission.GetAllQualifications();
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
        public void AlimenterConsultants()
        {
            try
            {
                consultantBindingSource.DataSource = DaoMission.GetAllConsultants();
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

        public void AlimenterMotif()
        {
            try
            {
                motifBindingSource.DataSource = DaoMission.GetAllMotif();
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

        private void AlimenterNiveau()
        {
            try
            {
                niveauBindingSource.DataSource = DaoMission.GetAllNiveau();
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
        #endregion

        //Gestion du bouton annuler
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Méthode enable 
        private void ChangerEnabledTrueOrFalse(bool trueFalse)
        {
            dateTimePicker1.Enabled = trueFalse;
            textBoxPrecision.Enabled = trueFalse;
            textBoxRemuneration.Enabled = trueFalse;
            numericUpDownDuree.Enabled = trueFalse;
            comboBoxQualification.Enabled = trueFalse;
            comboBoxConsultant.Enabled = trueFalse;
            comboBoxNiveau.Enabled = trueFalse;
            maskedTextBox1.Enabled = trueFalse;
            comboBoxMotif.Enabled = trueFalse;

        }
    }
}
