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
using GérerMission.Utilitaires;



namespace GérerMission
{
    public partial class AfficherDétails : Form
    {
        private Mission mission;
        private bool modifOrNot;
        private bool motifDateFin;
        private int codeEntreprise;
        private DateTime dateDebut;
        private DateTime? dateFin;
        sbyte? duree;
        decimal? remu;       
        private GererMission frmMere;
      
        



        public AfficherDétails(Mission miss, bool OuiNon, int code)
        {
           
            Demarrage(miss);
            if (OuiNon == true)
            {
                if (miss.Motif == null )
                {
                    ChangerEnabledTrueOrFalse(OuiNon);
                   
                }
                else
                {
                    ChangerEnabledTrueOrFalse(!OuiNon);
                    
                    MessageBox.Show("Cette mission est cloturée, la modification est désormais impossible");
                    buttonAnnuler.Enabled = true;
                   
                }
            }
            else if (OuiNon == false)
            {
                ChangerEnabledTrueOrFalse(OuiNon);
               
                buttonValider.Enabled = false;
                buttonAnnuler.Enabled = true;

            }
            modifOrNot = true;
            codeEntreprise = code;
        }
        public AfficherDétails(int code, GererMission gm)
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
            modifOrNot = false;
            codeEntreprise = code;
            frmMere = gm;
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
            if(miss.NiveauDemande == null)
            {
                comboBoxNiveau.SelectedIndex = -1;
            }
                  
            
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

       // Méthode enable
        public void ChangerEnabledTrueOrFalse(bool trueFalse)
        {

            textBoxPrecision.Enabled = trueFalse;
            textBoxRemuneration.Enabled = trueFalse;
            numericUpDownDuree.Enabled = trueFalse;
            comboBoxQualification.Enabled = trueFalse;
            comboBoxConsultant.Enabled = trueFalse;
            comboBoxNiveau.Enabled = trueFalse;
            maskedTextBoxDateFin.Enabled = trueFalse;
            comboBoxMotif.Enabled = trueFalse;
            buttonValider.Enabled = trueFalse;
           
        }

        //Gestion de la validation

        private void buttonValider_Click(object sender, EventArgs e)
        {
            VerifsEtGestionDate();

            if (comboBoxConsultant.SelectedItem != null && comboBoxQualification.SelectedItem != null && motifDateFin == true)
            {
                int codeMiss = 0;
                Mission oMission = new Mission(codeMiss, codeEntreprise, (MotifFin)comboBoxMotif.SelectedItem, (Qualification)comboBoxQualification.SelectedItem,
                    (Niveau)comboBoxNiveau.SelectedItem, (Consultant)comboBoxConsultant.SelectedItem,
                    dateDebut, dateFin, remu, textBoxPrecision.Text, duree);
                if (comboBoxMotif.SelectedItem == null)                
                    oMission.Motif = null;
                if (comboBoxNiveau.SelectedItem == null)                    
                    oMission.NiveauDemande = null;
                                      
                    if (modifOrNot == true)
                    {
                        try
                        {
                            if (DaoMission.UpdMission(oMission) == true)
                            {
                                codeMiss = mission.IdMission;
                                missionBindingSource.ResumeBinding();
                            }
                        }
                        catch (DaoExceptionAfficheMessage def)
                        {
                            MessageBox.Show(def.Message);
                        }
                        catch (Exception se)
                        {
                            MessageBox.Show(se.Message);
                        }
                    }
                    else if (modifOrNot == false)
                    {
                        try
                        {
                            if (DaoMission.AddMission(oMission, out codeMiss) == true)
                            {
                                oMission.IdMission = codeMiss;
                                frmMere.RefreshDataGridView(oMission);
                            }

                        }
                        catch (DaoExceptionAfficheMessage def)
                        {
                            MessageBox.Show(def.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    this.Close();                   
                }        
            else
            {
                if (comboBoxConsultant.SelectedItem == null || comboBoxQualification.SelectedItem == null)
                {
                    labelMessageUtilis.ForeColor = Color.Red;
                    labelMessageUtilis.Text = "Veuillez renseigner les champs obligatoires";
                }
                else if (motifDateFin == false)
                {
                    labelMessageUtilis.ForeColor = Color.Red;
                    labelMessageUtilis.Text = "La date de fin et le motif de clôture sont indissociables";
                }

            }

        }

        // Gestion des erreurs de dates et autres
        private void VerifsEtGestionDate()
        {
           
            dateDebut = Convert.ToDateTime(dateTimePickerDateOuv.Text);
            if (maskedTextBoxDateFin.Text == "  /  /")
                dateFin = null;
            else
            {
                   dateFin = Convert.ToDateTime(maskedTextBoxDateFin.Text);
                    if (dateFin <= dateDebut)
                    {

                        errorProviderDateFin.SetError(maskedTextBoxDateFin, "Attention la date de fin doit être ultèrieure à la date de début");
                        maskedTextBoxDateFin.Focus();

                    }
                    
            }
            if (numericUpDownDuree.Value == 0)
                 duree = null;
            else
                duree = (sbyte)(numericUpDownDuree.Value);


            if (textBoxRemuneration.Text == string.Empty)
                remu = null;                      
            else
                remu = Convert.ToDecimal(textBoxRemuneration.Text);

           

           // motif et date de fin indissociable

            if (dateFin != null && comboBoxMotif.SelectedIndex == -1)
                motifDateFin = false;
            else if (dateFin == null && comboBoxMotif.SelectedIndex != -1)
                motifDateFin = false;
            else
                motifDateFin = true;


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
