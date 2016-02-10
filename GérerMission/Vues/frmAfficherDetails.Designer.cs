namespace GérerMission
{
    partial class AfficherDétails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxMission = new System.Windows.Forms.GroupBox();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.missionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxNiveau = new System.Windows.Forms.ComboBox();
            this.niveauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxRemuneration = new System.Windows.Forms.TextBox();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelMotif = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.maskedTextBoxDateFin = new System.Windows.Forms.MaskedTextBox();
            this.labelConsultant = new System.Windows.Forms.Label();
            this.labelQualif = new System.Windows.Forms.Label();
            this.labelDuree = new System.Windows.Forms.Label();
            this.labelRemuneration = new System.Windows.Forms.Label();
            this.labelPrécisions = new System.Windows.Forms.Label();
            this.labelDateOuverture = new System.Windows.Forms.Label();
            this.comboBoxConsultant = new System.Windows.Forms.ComboBox();
            this.consultantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxQualification = new System.Windows.Forms.ComboBox();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownDuree = new System.Windows.Forms.NumericUpDown();
            this.textBoxPrecision = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOuv = new System.Windows.Forms.DateTimePicker();
            this.buttonValider = new System.Windows.Forms.Button();
            this.groupBoxMission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuree)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMission
            // 
            this.groupBoxMission.Controls.Add(this.comboBoxMotif);
            this.groupBoxMission.Controls.Add(this.comboBoxNiveau);
            this.groupBoxMission.Controls.Add(this.textBoxRemuneration);
            this.groupBoxMission.Controls.Add(this.labelNiveau);
            this.groupBoxMission.Controls.Add(this.buttonAnnuler);
            this.groupBoxMission.Controls.Add(this.labelMotif);
            this.groupBoxMission.Controls.Add(this.labelDateFin);
            this.groupBoxMission.Controls.Add(this.maskedTextBoxDateFin);
            this.groupBoxMission.Controls.Add(this.labelConsultant);
            this.groupBoxMission.Controls.Add(this.labelQualif);
            this.groupBoxMission.Controls.Add(this.labelDuree);
            this.groupBoxMission.Controls.Add(this.labelRemuneration);
            this.groupBoxMission.Controls.Add(this.labelPrécisions);
            this.groupBoxMission.Controls.Add(this.labelDateOuverture);
            this.groupBoxMission.Controls.Add(this.comboBoxConsultant);
            this.groupBoxMission.Controls.Add(this.comboBoxQualification);
            this.groupBoxMission.Controls.Add(this.numericUpDownDuree);
            this.groupBoxMission.Controls.Add(this.textBoxPrecision);
            this.groupBoxMission.Controls.Add(this.dateTimePickerDateOuv);
            this.groupBoxMission.Controls.Add(this.buttonValider);
            this.groupBoxMission.Location = new System.Drawing.Point(22, 31);
            this.groupBoxMission.Name = "groupBoxMission";
            this.groupBoxMission.Size = new System.Drawing.Size(457, 409);
            this.groupBoxMission.TabIndex = 0;
            this.groupBoxMission.TabStop = false;
            this.groupBoxMission.Text = "Informations";
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.missionBindingSource, "Motif", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.comboBoxMotif.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.missionBindingSource, "Motif", true));
            this.comboBoxMotif.DataSource = this.motifBindingSource;
            this.comboBoxMotif.DisplayMember = "LibelleMotif";
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(145, 362);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(120, 21);
            this.comboBoxMotif.TabIndex = 30;
            // 
            // missionBindingSource
            // 
            this.missionBindingSource.DataSource = typeof(GérerMission.Metier.Mission);
            // 
            // motifBindingSource
            // 
            this.motifBindingSource.DataSource = typeof(GérerMission.Metier.MotifFin);
            // 
            // comboBoxNiveau
            // 
            this.comboBoxNiveau.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.missionBindingSource, "NiveauDemande", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.comboBoxNiveau.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.missionBindingSource, "NiveauDemande", true));
            this.comboBoxNiveau.DataSource = this.niveauBindingSource;
            this.comboBoxNiveau.DisplayMember = "Libelle";
            this.comboBoxNiveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNiveau.FormattingEnabled = true;
            this.comboBoxNiveau.Location = new System.Drawing.Point(145, 282);
            this.comboBoxNiveau.Name = "comboBoxNiveau";
            this.comboBoxNiveau.Size = new System.Drawing.Size(120, 21);
            this.comboBoxNiveau.TabIndex = 29;
            // 
            // niveauBindingSource
            // 
            this.niveauBindingSource.DataSource = typeof(GérerMission.Metier.Niveau);
            // 
            // textBoxRemuneration
            // 
            this.textBoxRemuneration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missionBindingSource, "RemunerationProposee", true));
            this.textBoxRemuneration.Location = new System.Drawing.Point(145, 117);
            this.textBoxRemuneration.Name = "textBoxRemuneration";
            this.textBoxRemuneration.Size = new System.Drawing.Size(118, 20);
            this.textBoxRemuneration.TabIndex = 28;
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.Location = new System.Drawing.Point(15, 285);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(84, 13);
            this.labelNiveau.TabIndex = 27;
            this.labelNiveau.Text = "Niveau d\'études";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(314, 41);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(83, 25);
            this.buttonAnnuler.TabIndex = 25;
            this.buttonAnnuler.Text = "Retour";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // labelMotif
            // 
            this.labelMotif.AutoSize = true;
            this.labelMotif.Location = new System.Drawing.Point(15, 370);
            this.labelMotif.Name = "labelMotif";
            this.labelMotif.Size = new System.Drawing.Size(59, 13);
            this.labelMotif.TabIndex = 24;
            this.labelMotif.Text = "Motif de fin";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(15, 327);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(59, 13);
            this.labelDateFin.TabIndex = 22;
            this.labelDateFin.Text = "Date de fin";
            // 
            // maskedTextBoxDateFin
            // 
            this.maskedTextBoxDateFin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missionBindingSource, "DateFin", true));
            this.maskedTextBoxDateFin.Location = new System.Drawing.Point(145, 324);
            this.maskedTextBoxDateFin.Mask = "00/00/0000";
            this.maskedTextBoxDateFin.Name = "maskedTextBoxDateFin";
            this.maskedTextBoxDateFin.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBoxDateFin.TabIndex = 8;
            this.maskedTextBoxDateFin.ValidatingType = typeof(System.DateTime);
            // 
            // labelConsultant
            // 
            this.labelConsultant.AutoSize = true;
            this.labelConsultant.Location = new System.Drawing.Point(15, 246);
            this.labelConsultant.Name = "labelConsultant";
            this.labelConsultant.Size = new System.Drawing.Size(57, 13);
            this.labelConsultant.TabIndex = 20;
            this.labelConsultant.Text = "Consultant";
            // 
            // labelQualif
            // 
            this.labelQualif.AutoSize = true;
            this.labelQualif.Location = new System.Drawing.Point(15, 199);
            this.labelQualif.Name = "labelQualif";
            this.labelQualif.Size = new System.Drawing.Size(65, 13);
            this.labelQualif.TabIndex = 18;
            this.labelQualif.Text = "Qualification";
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Location = new System.Drawing.Point(15, 157);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(36, 13);
            this.labelDuree.TabIndex = 17;
            this.labelDuree.Text = "Durée";
            // 
            // labelRemuneration
            // 
            this.labelRemuneration.AutoSize = true;
            this.labelRemuneration.Location = new System.Drawing.Point(15, 120);
            this.labelRemuneration.Name = "labelRemuneration";
            this.labelRemuneration.Size = new System.Drawing.Size(120, 13);
            this.labelRemuneration.TabIndex = 16;
            this.labelRemuneration.Text = "Rémunération proposée";
            // 
            // labelPrécisions
            // 
            this.labelPrécisions.AutoSize = true;
            this.labelPrécisions.Location = new System.Drawing.Point(15, 85);
            this.labelPrécisions.Name = "labelPrécisions";
            this.labelPrécisions.Size = new System.Drawing.Size(55, 13);
            this.labelPrécisions.TabIndex = 15;
            this.labelPrécisions.Text = "Précisions";
            // 
            // labelDateOuverture
            // 
            this.labelDateOuverture.AutoSize = true;
            this.labelDateOuverture.Location = new System.Drawing.Point(15, 47);
            this.labelDateOuverture.Name = "labelDateOuverture";
            this.labelDateOuverture.Size = new System.Drawing.Size(86, 13);
            this.labelDateOuverture.TabIndex = 14;
            this.labelDateOuverture.Text = "Date d\'ouverture";
            // 
            // comboBoxConsultant
            // 
            this.comboBoxConsultant.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.missionBindingSource, "Consult", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.comboBoxConsultant.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.missionBindingSource, "Consult", true));
            this.comboBoxConsultant.DataSource = this.consultantBindingSource;
            this.comboBoxConsultant.DisplayMember = "NomConsultant";
            this.comboBoxConsultant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConsultant.FormattingEnabled = true;
            this.comboBoxConsultant.Location = new System.Drawing.Point(145, 243);
            this.comboBoxConsultant.Name = "comboBoxConsultant";
            this.comboBoxConsultant.Size = new System.Drawing.Size(120, 21);
            this.comboBoxConsultant.TabIndex = 6;
            // 
            // consultantBindingSource
            // 
            this.consultantBindingSource.DataSource = typeof(GérerMission.Metier.Consultant);
            // 
            // comboBoxQualification
            // 
            this.comboBoxQualification.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.missionBindingSource, "QualificationDemandee", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.comboBoxQualification.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.missionBindingSource, "QualificationDemandee", true));
            this.comboBoxQualification.DataSource = this.qualificationBindingSource;
            this.comboBoxQualification.DisplayMember = "LibelleQualification";
            this.comboBoxQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQualification.FormattingEnabled = true;
            this.comboBoxQualification.Location = new System.Drawing.Point(145, 196);
            this.comboBoxQualification.Name = "comboBoxQualification";
            this.comboBoxQualification.Size = new System.Drawing.Size(120, 21);
            this.comboBoxQualification.TabIndex = 5;
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataSource = typeof(GérerMission.Metier.Qualification);
            // 
            // numericUpDownDuree
            // 
            this.numericUpDownDuree.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.missionBindingSource, "Duree", true));
            this.numericUpDownDuree.Location = new System.Drawing.Point(145, 155);
            this.numericUpDownDuree.Name = "numericUpDownDuree";
            this.numericUpDownDuree.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDuree.TabIndex = 4;
            // 
            // textBoxPrecision
            // 
            this.textBoxPrecision.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missionBindingSource, "Precisions", true));
            this.textBoxPrecision.Location = new System.Drawing.Point(145, 82);
            this.textBoxPrecision.MaxLength = 250;
            this.textBoxPrecision.Multiline = true;
            this.textBoxPrecision.Name = "textBoxPrecision";
            this.textBoxPrecision.Size = new System.Drawing.Size(118, 23);
            this.textBoxPrecision.TabIndex = 2;
            // 
            // dateTimePickerDateOuv
            // 
            this.dateTimePickerDateOuv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOuv.Location = new System.Drawing.Point(145, 41);
            this.dateTimePickerDateOuv.Name = "dateTimePickerDateOuv";
            this.dateTimePickerDateOuv.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerDateOuv.TabIndex = 1;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(314, 85);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(83, 25);
            this.buttonValider.TabIndex = 10;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // AfficherDétails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 472);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxMission);
            this.Name = "AfficherDétails";
            this.Text = "Détails";
            this.Load += new System.EventHandler(this.AfficherDétails_Load);
            this.groupBoxMission.ResumeLayout(false);
            this.groupBoxMission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMission;
        private System.Windows.Forms.Label labelNiveau;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelMotif;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateFin;
        private System.Windows.Forms.Label labelConsultant;
        private System.Windows.Forms.Label labelQualif;
        private System.Windows.Forms.Label labelDuree;
        private System.Windows.Forms.Label labelRemuneration;
        private System.Windows.Forms.Label labelPrécisions;
        private System.Windows.Forms.Label labelDateOuverture;
        private System.Windows.Forms.ComboBox comboBoxConsultant;
        private System.Windows.Forms.ComboBox comboBoxQualification;
        private System.Windows.Forms.NumericUpDown numericUpDownDuree;
        private System.Windows.Forms.TextBox textBoxPrecision;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOuv;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.BindingSource consultantBindingSource;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private System.Windows.Forms.BindingSource motifBindingSource;
        private System.Windows.Forms.BindingSource niveauBindingSource;
        private System.Windows.Forms.BindingSource missionBindingSource;
        private System.Windows.Forms.TextBox textBoxRemuneration;
        private System.Windows.Forms.ComboBox comboBoxNiveau;
        private System.Windows.Forms.ComboBox comboBoxMotif;
    }
}