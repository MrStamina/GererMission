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
using System.Text.RegularExpressions;



namespace GérerMission
{
    public partial class AfficherDétails : Form
    {
        private Mission mission;
        private bool ModifOrNot;
        private int codeEntreprise;
        private DateTime dateDebut;
        private DateTime dateFin;
        
        
        public AfficherDétails(Mission miss, bool OuiNon)
        {
           
            Demarrage(miss);
            if (OuiNon == true)
            {
                if (miss.Motif == null || miss.Motif.IdMotif !=2)
                {
                    ChangerEnabledTrueOrFalse(OuiNon);
                    

                }
                else
                {
                    ChangerEnabledTrueOrFalse(!OuiNon);
                    MessageBox.Show("Cette mission est cloturée, la modification est désormais impossible");
                    buttonValider.Enabled = false;
                   
                }
            }
            else if (OuiNon == false)
            {
                ChangerEnabledTrueOrFalse(OuiNon);
                buttonValider.Enabled = false;

            }
            ModifOrNot = true;
        }
        public AfficherDétails(int code)
        {
            InitializeComponent();
            AlimenterConsultants();
            AlimenterMotif();
            AlimenterNiveau();
            AlimenterQualifs();
            comboBoxConsultant.SelectedItem = null;
            comboBoxQualification.SelectedItem = null;
            comboBoxMotif.SelectedItem = null;
            comboBoxNiveau.SelectedItem = null;
            ModifOrNot = false;
            codeEntreprise = code;
            dateTimePickerDateOuv.Enabled = true;
        }

        public AfficherDétails()
        {
            InitializeComponent();
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
            mission = miss;
            if (miss.Motif == null)
            {
                comboBoxMotif.SelectedIndex = -1;
            }
          
           
            
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
            missionBindingSource.ResetCurrentItem();
            this.Close();
        }

        //Méthode enable 
        private void ChangerEnabledTrueOrFalse(bool trueFalse)
        {
            
            textBoxPrecision.Enabled = trueFalse;
            textBoxRemuneration.Enabled = trueFalse;
            numericUpDownDuree.Enabled = trueFalse;
            comboBoxQualification.Enabled = trueFalse;
            comboBoxConsultant.Enabled = trueFalse;
            comboBoxNiveau.Enabled = trueFalse;
            maskedTextBoxDateFin.Enabled = trueFalse;
            comboBoxMotif.Enabled = trueFalse;

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (ModifOrNot == true)
            {
                if (comboBoxMotif.SelectedIndex == -1)
                    mission.Motif = null;
                if (DaoMission.UpdMission(mission) == true)
                {
                    missionBindingSource.ResumeBinding();
                }
                else
                    MessageBox.Show("Mise à jour non effectuée");
            }
            else if(ModifOrNot == false)
            {
                int codeMiss = 0;
                Mission oMission = new Mission(codeMiss, codeEntreprise,(MotifFin)comboBoxMotif.SelectedItem, (Qualification)comboBoxQualification.SelectedItem,
                    (Niveau)comboBoxNiveau.SelectedItem, (Consultant)comboBoxConsultant.SelectedItem,
                    dateTimePickerDateOuv.Value, Convert.ToDateTime(maskedTextBoxDateFin.Text),
                    Convert.ToDecimal(textBoxRemuneration.Text), textBoxPrecision.Text, Convert.ToSByte(numericUpDownDuree.Value));

                if(DaoMission.AddMission(oMission, out codeMiss) == true)
                {
                    oMission.IdMission = codeMiss;
                    missionBindingSource.Add(oMission);
                }

            }
            this.Close();
                
        }

        private void maskedTextBoxDateFin_Validating(object sender, CancelEventArgs e)
        {
            
            if (DateTime.TryParse(maskedTextBoxDateFin.Text, out dateFin))
            {

                
                if (dateFin <= dateDebut)
                {
                    
                    errorProviderDateFin.SetError(maskedTextBoxDateFin,"Attention la date de fin doit être ultèrieure à la date de début");
                    maskedTextBoxDateFin.Focus();

                }
                
            }
            else
            {
               
                errorProviderDateFin.SetError(maskedTextBoxDateFin, "Veuillez entrer une date au format valide");
                maskedTextBoxDateFin.Focus();
            }
        }

        private void dateTimePickerDateOuv_Validating(object sender, CancelEventArgs e)
        {
            dateDebut = Convert.ToDateTime(dateTimePickerDateOuv.Value);
        }

      // On empeche les erreurs de saisies

        private void textBoxPrecision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & e.KeyChar != (char)Keys.Back & e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void textBoxRemuneration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }
    }
}
