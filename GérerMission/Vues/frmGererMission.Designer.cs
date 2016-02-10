namespace GérerMission
{
    partial class GererMission
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxChoixEntreprise = new System.Windows.Forms.ComboBox();
            this.entrepriseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelChoixEntreprise = new System.Windows.Forms.Label();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.dataGridViewMissions = new System.Windows.Forms.DataGridView();
            this.idMissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOuvertureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDemandeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remunerationProposeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.precisionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrepriseOffreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveauDemandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxChoixEntreprise
            // 
            this.comboBoxChoixEntreprise.DataSource = this.entrepriseBindingSource;
            this.comboBoxChoixEntreprise.DisplayMember = "RaisonSociale";
            this.comboBoxChoixEntreprise.FormattingEnabled = true;
            this.comboBoxChoixEntreprise.Location = new System.Drawing.Point(158, 31);
            this.comboBoxChoixEntreprise.Name = "comboBoxChoixEntreprise";
            this.comboBoxChoixEntreprise.Size = new System.Drawing.Size(130, 21);
            this.comboBoxChoixEntreprise.TabIndex = 0;
            this.comboBoxChoixEntreprise.ValueMember = "IdEntreprise";
            this.comboBoxChoixEntreprise.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoixEntreprise_SelectedIndexChanged);
            // 
            // entrepriseBindingSource
            // 
            this.entrepriseBindingSource.DataSource = typeof(GérerMission.Metier.Entreprise);
            // 
            // labelChoixEntreprise
            // 
            this.labelChoixEntreprise.AutoSize = true;
            this.labelChoixEntreprise.Location = new System.Drawing.Point(12, 34);
            this.labelChoixEntreprise.Name = "labelChoixEntreprise";
            this.labelChoixEntreprise.Size = new System.Drawing.Size(136, 13);
            this.labelChoixEntreprise.TabIndex = 1;
            this.labelChoixEntreprise.Text = "Sélectionner une entreprise";
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(601, 27);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(83, 25);
            this.buttonQuitter.TabIndex = 2;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(318, 27);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(98, 25);
            this.buttonCreer.TabIndex = 3;
            this.buttonCreer.Text = "Créer Mission";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // dataGridViewMissions
            // 
            this.dataGridViewMissions.AllowUserToAddRows = false;
            this.dataGridViewMissions.AllowUserToDeleteRows = false;
            this.dataGridViewMissions.AutoGenerateColumns = false;
            this.dataGridViewMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMissionDataGridViewTextBoxColumn,
            this.dateOuvertureDataGridViewTextBoxColumn,
            this.qualificationDemandeeDataGridViewTextBoxColumn,
            this.remunerationProposeeDataGridViewTextBoxColumn,
            this.Details,
            this.Modifier,
            this.Supprimer,
            this.precisionsDataGridViewTextBoxColumn,
            this.dureeDataGridViewTextBoxColumn,
            this.entrepriseOffreDataGridViewTextBoxColumn,
            this.niveauDemandeDataGridViewTextBoxColumn,
            this.consultDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn});
            this.dataGridViewMissions.DataSource = this.missionBindingSource;
            this.dataGridViewMissions.Location = new System.Drawing.Point(3, 98);
            this.dataGridViewMissions.Name = "dataGridViewMissions";
            this.dataGridViewMissions.ReadOnly = true;
            this.dataGridViewMissions.Size = new System.Drawing.Size(681, 245);
            this.dataGridViewMissions.TabIndex = 5;
            this.dataGridViewMissions.Visible = false;
            this.dataGridViewMissions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMissions_CellContentClick);
            // 
            // idMissionDataGridViewTextBoxColumn
            // 
            this.idMissionDataGridViewTextBoxColumn.DataPropertyName = "IdMission";
            this.idMissionDataGridViewTextBoxColumn.HeaderText = "IdMission";
            this.idMissionDataGridViewTextBoxColumn.Name = "idMissionDataGridViewTextBoxColumn";
            this.idMissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMissionDataGridViewTextBoxColumn.Width = 60;
            // 
            // dateOuvertureDataGridViewTextBoxColumn
            // 
            this.dateOuvertureDataGridViewTextBoxColumn.DataPropertyName = "DateOuverture";
            this.dateOuvertureDataGridViewTextBoxColumn.HeaderText = "DateOuverture";
            this.dateOuvertureDataGridViewTextBoxColumn.Name = "dateOuvertureDataGridViewTextBoxColumn";
            this.dateOuvertureDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOuvertureDataGridViewTextBoxColumn.Width = 80;
            // 
            // qualificationDemandeeDataGridViewTextBoxColumn
            // 
            this.qualificationDemandeeDataGridViewTextBoxColumn.DataPropertyName = "QualificationDemandee";
            this.qualificationDemandeeDataGridViewTextBoxColumn.DataSource = this.qualificationBindingSource;
            this.qualificationDemandeeDataGridViewTextBoxColumn.DisplayMember = "LibelleQualification";
            this.qualificationDemandeeDataGridViewTextBoxColumn.HeaderText = "QualificationDemandee";
            this.qualificationDemandeeDataGridViewTextBoxColumn.Name = "qualificationDemandeeDataGridViewTextBoxColumn";
            this.qualificationDemandeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.qualificationDemandeeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.qualificationDemandeeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.qualificationDemandeeDataGridViewTextBoxColumn.ValueMember = "Self";
            this.qualificationDemandeeDataGridViewTextBoxColumn.Width = 135;
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataSource = typeof(GérerMission.Metier.Qualification);
            // 
            // remunerationProposeeDataGridViewTextBoxColumn
            // 
            this.remunerationProposeeDataGridViewTextBoxColumn.DataPropertyName = "RemunerationProposee";
            this.remunerationProposeeDataGridViewTextBoxColumn.HeaderText = "RemunerationProposee";
            this.remunerationProposeeDataGridViewTextBoxColumn.Name = "remunerationProposeeDataGridViewTextBoxColumn";
            this.remunerationProposeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.remunerationProposeeDataGridViewTextBoxColumn.Width = 120;
            // 
            // Details
            // 
            this.Details.HeaderText = "";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Text = "Détails";
            this.Details.UseColumnTextForButtonValue = true;
            this.Details.Width = 80;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            this.Modifier.Width = 80;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            this.Supprimer.Width = 80;
            // 
            // precisionsDataGridViewTextBoxColumn
            // 
            this.precisionsDataGridViewTextBoxColumn.DataPropertyName = "Precisions";
            this.precisionsDataGridViewTextBoxColumn.HeaderText = "Precisions";
            this.precisionsDataGridViewTextBoxColumn.Name = "precisionsDataGridViewTextBoxColumn";
            this.precisionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.precisionsDataGridViewTextBoxColumn.Visible = false;
            // 
            // dureeDataGridViewTextBoxColumn
            // 
            this.dureeDataGridViewTextBoxColumn.DataPropertyName = "Duree";
            this.dureeDataGridViewTextBoxColumn.HeaderText = "Duree";
            this.dureeDataGridViewTextBoxColumn.Name = "dureeDataGridViewTextBoxColumn";
            this.dureeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dureeDataGridViewTextBoxColumn.Visible = false;
            // 
            // entrepriseOffreDataGridViewTextBoxColumn
            // 
            this.entrepriseOffreDataGridViewTextBoxColumn.DataPropertyName = "EntrepriseOffre";
            this.entrepriseOffreDataGridViewTextBoxColumn.HeaderText = "EntrepriseOffre";
            this.entrepriseOffreDataGridViewTextBoxColumn.Name = "entrepriseOffreDataGridViewTextBoxColumn";
            this.entrepriseOffreDataGridViewTextBoxColumn.ReadOnly = true;
            this.entrepriseOffreDataGridViewTextBoxColumn.Visible = false;
            // 
            // niveauDemandeDataGridViewTextBoxColumn
            // 
            this.niveauDemandeDataGridViewTextBoxColumn.DataPropertyName = "NiveauDemande";
            this.niveauDemandeDataGridViewTextBoxColumn.HeaderText = "NiveauDemande";
            this.niveauDemandeDataGridViewTextBoxColumn.Name = "niveauDemandeDataGridViewTextBoxColumn";
            this.niveauDemandeDataGridViewTextBoxColumn.ReadOnly = true;
            this.niveauDemandeDataGridViewTextBoxColumn.Visible = false;
            // 
            // consultDataGridViewTextBoxColumn
            // 
            this.consultDataGridViewTextBoxColumn.DataPropertyName = "Consult";
            this.consultDataGridViewTextBoxColumn.HeaderText = "Consult";
            this.consultDataGridViewTextBoxColumn.Name = "consultDataGridViewTextBoxColumn";
            this.consultDataGridViewTextBoxColumn.ReadOnly = true;
            this.consultDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            this.dateFinDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateFinDataGridViewTextBoxColumn.Visible = false;
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "Motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "Motif";
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            this.motifDataGridViewTextBoxColumn.ReadOnly = true;
            this.motifDataGridViewTextBoxColumn.Visible = false;
            // 
            // missionBindingSource
            // 
            this.missionBindingSource.DataSource = typeof(GérerMission.Metier.Mission);
            // 
            // GererMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 495);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewMissions);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.labelChoixEntreprise);
            this.Controls.Add(this.comboBoxChoixEntreprise);
            this.Name = "GererMission";
            this.Text = "Gérer Mission";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GererMission_FormClosing);
            this.Load += new System.EventHandler(this.GererMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoixEntreprise;
        private System.Windows.Forms.Label labelChoixEntreprise;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.DataGridView dataGridViewMissions;
        private System.Windows.Forms.BindingSource entrepriseBindingSource;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private System.Windows.Forms.BindingSource missionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOuvertureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn qualificationDemandeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remunerationProposeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn precisionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrepriseOffreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveauDemandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
    }
}

