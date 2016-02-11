namespace GérerMission
{
    partial class frmAccueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gererMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererCandidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerMissionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fenetresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatuslblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.gererMissionToolStripMenuItem,
            this.gererCandidatToolStripMenuItem,
            this.gererContactToolStripMenuItem,
            this.fenetresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.fenetresToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripAcceuil";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gererMissionToolStripMenuItem
            // 
            this.gererMissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerMissionToolStripMenuItem1});
            this.gererMissionToolStripMenuItem.Enabled = false;
            this.gererMissionToolStripMenuItem.Name = "gererMissionToolStripMenuItem";
            this.gererMissionToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.gererMissionToolStripMenuItem.Text = "Gestion Mission";
            // 
            // gererCandidatToolStripMenuItem
            // 
            this.gererCandidatToolStripMenuItem.Enabled = false;
            this.gererCandidatToolStripMenuItem.Name = "gererCandidatToolStripMenuItem";
            this.gererCandidatToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.gererCandidatToolStripMenuItem.Text = "Gestion Candidat";
            // 
            // gererContactToolStripMenuItem
            // 
            this.gererContactToolStripMenuItem.Enabled = false;
            this.gererContactToolStripMenuItem.Name = "gererContactToolStripMenuItem";
            this.gererContactToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.gererContactToolStripMenuItem.Text = "Gestion Contact";
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            this.sidentifierToolStripMenuItem.Click += new System.EventHandler(this.sidentifierToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // gérerMissionToolStripMenuItem1
            // 
            this.gérerMissionToolStripMenuItem1.Name = "gérerMissionToolStripMenuItem1";
            this.gérerMissionToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.gérerMissionToolStripMenuItem1.Text = "Gérer Mission";
            this.gérerMissionToolStripMenuItem1.Click += new System.EventHandler(this.gérerMissionToolStripMenuItem1_Click);
            // 
            // fenetresToolStripMenuItem
            // 
            this.fenetresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalesToolStripMenuItem,
            this.verticalesToolStripMenuItem});
            this.fenetresToolStripMenuItem.Enabled = false;
            this.fenetresToolStripMenuItem.Name = "fenetresToolStripMenuItem";
            this.fenetresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenetresToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalesToolStripMenuItem
            // 
            this.horizontalesToolStripMenuItem.Name = "horizontalesToolStripMenuItem";
            this.horizontalesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horizontalesToolStripMenuItem.Text = "Horizontales";
            this.horizontalesToolStripMenuItem.Click += new System.EventHandler(this.horizontalesToolStripMenuItem_Click);
            // 
            // verticalesToolStripMenuItem
            // 
            this.verticalesToolStripMenuItem.Name = "verticalesToolStripMenuItem";
            this.verticalesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verticalesToolStripMenuItem.Text = "Verticales";
            this.verticalesToolStripMenuItem.Click += new System.EventHandler(this.verticalesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatuslblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(754, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatuslblDate
            // 
            this.toolStripStatuslblDate.Name = "toolStripStatuslblDate";
            this.toolStripStatuslblDate.Size = new System.Drawing.Size(0, 17);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 662);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccueil_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererMissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererCandidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererContactToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerMissionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fenetresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslblDate;
    }
}