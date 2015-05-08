namespace EasyNMR
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PPMShift = new System.Windows.Forms.TextBox();
            this.SignalType = new System.Windows.Forms.ComboBox();
            this.HydrogenCount = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.PeakView = new BrightIdeasSoftware.ObjectListView();
            this.Coupling = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeakView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportNMR);
            // 
            // PPMShift
            // 
            this.PPMShift.Location = new System.Drawing.Point(13, 28);
            this.PPMShift.Name = "PPMShift";
            this.PPMShift.Size = new System.Drawing.Size(100, 20);
            this.PPMShift.TabIndex = 1;
            // 
            // SignalType
            // 
            this.SignalType.FormattingEnabled = true;
            this.SignalType.Items.AddRange(new object[] {
            "s",
            "d",
            "t",
            "m"});
            this.SignalType.Location = new System.Drawing.Point(120, 28);
            this.SignalType.Name = "SignalType";
            this.SignalType.Size = new System.Drawing.Size(40, 21);
            this.SignalType.TabIndex = 2;
            // 
            // HydrogenCount
            // 
            this.HydrogenCount.Location = new System.Drawing.Point(167, 28);
            this.HydrogenCount.Name = "HydrogenCount";
            this.HydrogenCount.Size = new System.Drawing.Size(100, 20);
            this.HydrogenCount.TabIndex = 3;
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.Location = new System.Drawing.Point(380, 28);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(267, 20);
            this.Description.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(653, 28);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Ajouter";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddPeak);
            // 
            // PeakView
            // 
            this.PeakView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeakView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.PeakView.FullRowSelect = true;
            this.PeakView.GridLines = true;
            this.PeakView.Location = new System.Drawing.Point(13, 55);
            this.PeakView.Name = "PeakView";
            this.PeakView.ShowGroups = false;
            this.PeakView.Size = new System.Drawing.Size(715, 298);
            this.PeakView.TabIndex = 7;
            this.PeakView.UseCompatibleStateImageBehavior = false;
            this.PeakView.View = System.Windows.Forms.View.Details;
            this.PeakView.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.OnRightClick);
            // 
            // Coupling
            // 
            this.Coupling.Location = new System.Drawing.Point(274, 28);
            this.Coupling.Name = "Coupling";
            this.Coupling.Size = new System.Drawing.Size(100, 20);
            this.Coupling.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 365);
            this.Controls.Add(this.Coupling);
            this.Controls.Add(this.PeakView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.HydrogenCount);
            this.Controls.Add(this.SignalType);
            this.Controls.Add(this.PPMShift);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeakView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.TextBox PPMShift;
        private System.Windows.Forms.ComboBox SignalType;
        private System.Windows.Forms.TextBox HydrogenCount;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button AddButton;
        private BrightIdeasSoftware.ObjectListView PeakView;
        private System.Windows.Forms.TextBox Coupling;
    }
}

