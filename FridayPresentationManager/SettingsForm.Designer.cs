namespace FridayPresentationManager
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.bSave = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bBrowsePresentationsFolder = new System.Windows.Forms.Button();
            this.bExplorePresentationsFolder = new System.Windows.Forms.Button();
            this.tbPresentationsFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderPresentationsDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.bBrowseServerFolder = new System.Windows.Forms.Button();
            this.bExploreServerFolder = new System.Windows.Forms.Button();
            this.tbServerFolderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAutostartOpenedPresentation = new System.Windows.Forms.CheckBox();
            this.cbAutoupdatePresentationsList = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(369, 379);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 23;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bExit
            // 
            this.bExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bExit.Location = new System.Drawing.Point(450, 379);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 22;
            this.bExit.Text = "Закрыть";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bBrowsePresentationsFolder
            // 
            this.bBrowsePresentationsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowsePresentationsFolder.Image = ((System.Drawing.Image)(resources.GetObject("bBrowsePresentationsFolder.Image")));
            this.bBrowsePresentationsFolder.Location = new System.Drawing.Point(469, 6);
            this.bBrowsePresentationsFolder.Name = "bBrowsePresentationsFolder";
            this.bBrowsePresentationsFolder.Size = new System.Drawing.Size(25, 25);
            this.bBrowsePresentationsFolder.TabIndex = 27;
            this.bBrowsePresentationsFolder.Text = "...";
            this.bBrowsePresentationsFolder.UseVisualStyleBackColor = true;
            this.bBrowsePresentationsFolder.Click += new System.EventHandler(this.bBrowsePresentationsFolder_Click);
            // 
            // bExplorePresentationsFolder
            // 
            this.bExplorePresentationsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExplorePresentationsFolder.Location = new System.Drawing.Point(500, 6);
            this.bExplorePresentationsFolder.Name = "bExplorePresentationsFolder";
            this.bExplorePresentationsFolder.Size = new System.Drawing.Size(25, 25);
            this.bExplorePresentationsFolder.TabIndex = 26;
            this.bExplorePresentationsFolder.Text = "...";
            this.bExplorePresentationsFolder.UseVisualStyleBackColor = true;
            this.bExplorePresentationsFolder.Click += new System.EventHandler(this.bExplorePresentationsFolder_Click);
            // 
            // tbPresentationsFolderPath
            // 
            this.tbPresentationsFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPresentationsFolderPath.Enabled = false;
            this.tbPresentationsFolderPath.Location = new System.Drawing.Point(196, 6);
            this.tbPresentationsFolderPath.Name = "tbPresentationsFolderPath";
            this.tbPresentationsFolderPath.Size = new System.Drawing.Size(248, 20);
            this.tbPresentationsFolderPath.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Корневая папка с презентациями";
            // 
            // bBrowseServerFolder
            // 
            this.bBrowseServerFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowseServerFolder.Image = ((System.Drawing.Image)(resources.GetObject("bBrowseServerFolder.Image")));
            this.bBrowseServerFolder.Location = new System.Drawing.Point(469, 37);
            this.bBrowseServerFolder.Name = "bBrowseServerFolder";
            this.bBrowseServerFolder.Size = new System.Drawing.Size(25, 25);
            this.bBrowseServerFolder.TabIndex = 31;
            this.bBrowseServerFolder.Text = "...";
            this.bBrowseServerFolder.UseVisualStyleBackColor = true;
            this.bBrowseServerFolder.Click += new System.EventHandler(this.bBrowseServerFolder_Click);
            // 
            // bExploreServerFolder
            // 
            this.bExploreServerFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExploreServerFolder.Location = new System.Drawing.Point(500, 37);
            this.bExploreServerFolder.Name = "bExploreServerFolder";
            this.bExploreServerFolder.Size = new System.Drawing.Size(25, 25);
            this.bExploreServerFolder.TabIndex = 30;
            this.bExploreServerFolder.Text = "...";
            this.bExploreServerFolder.UseVisualStyleBackColor = true;
            this.bExploreServerFolder.Click += new System.EventHandler(this.bExploreServerFolder_Click);
            // 
            // tbServerFolderPath
            // 
            this.tbServerFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServerFolderPath.Enabled = false;
            this.tbServerFolderPath.Location = new System.Drawing.Point(196, 37);
            this.tbServerFolderPath.Name = "tbServerFolderPath";
            this.tbServerFolderPath.Size = new System.Drawing.Size(248, 20);
            this.tbServerFolderPath.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Серверная папка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Автоматически запускать показ открытой презентации";
            // 
            // cbAutostartOpenedPresentation
            // 
            this.cbAutostartOpenedPresentation.AutoSize = true;
            this.cbAutostartOpenedPresentation.Location = new System.Drawing.Point(310, 68);
            this.cbAutostartOpenedPresentation.Name = "cbAutostartOpenedPresentation";
            this.cbAutostartOpenedPresentation.Size = new System.Drawing.Size(15, 14);
            this.cbAutostartOpenedPresentation.TabIndex = 33;
            this.cbAutostartOpenedPresentation.UseVisualStyleBackColor = true;
            // 
            // cbAutoupdatePresentationsList
            // 
            this.cbAutoupdatePresentationsList.AutoSize = true;
            this.cbAutoupdatePresentationsList.Location = new System.Drawing.Point(310, 90);
            this.cbAutoupdatePresentationsList.Name = "cbAutoupdatePresentationsList";
            this.cbAutoupdatePresentationsList.Size = new System.Drawing.Size(15, 14);
            this.cbAutoupdatePresentationsList.TabIndex = 35;
            this.cbAutoupdatePresentationsList.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Автоматически проверять обновления презентаций";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 414);
            this.Controls.Add(this.cbAutoupdatePresentationsList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAutostartOpenedPresentation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bBrowseServerFolder);
            this.Controls.Add(this.bExploreServerFolder);
            this.Controls.Add(this.tbServerFolderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bBrowsePresentationsFolder);
            this.Controls.Add(this.bExplorePresentationsFolder);
            this.Controls.Add(this.tbPresentationsFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bExit);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bBrowsePresentationsFolder;
        private System.Windows.Forms.Button bExplorePresentationsFolder;
        private System.Windows.Forms.TextBox tbPresentationsFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderPresentationsDialog;
        private System.Windows.Forms.Button bBrowseServerFolder;
        private System.Windows.Forms.Button bExploreServerFolder;
        private System.Windows.Forms.TextBox tbServerFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbAutostartOpenedPresentation;
        private System.Windows.Forms.CheckBox cbAutoupdatePresentationsList;
        private System.Windows.Forms.Label label4;
    }
}