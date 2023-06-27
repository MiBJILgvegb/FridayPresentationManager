using System.Windows.Forms;

namespace FridayPresentationManager
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deputyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentationsNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPresentationsDatesList = new System.Windows.Forms.ListBox();
            this.cbPresentationByYearsFilter = new System.Windows.Forms.ComboBox();
            this.pbDepartmentOfCityDistrictMarker = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfCityDistrict = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfPropertyRelationsMarker = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfSecurityCouncilMarker = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfJKHMarker = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfPropertyRelations = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfSecurityCouncil = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfJKH = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfAKRMarker = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfSocialDevelopmentMarker = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfEconomicDevelopmentMarker = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfFinancePolicyMarker = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfAPKMarker = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfAKR = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfSocialDevelopment = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfEconomicDevelopment = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfFinancePolicy = new System.Windows.Forms.PictureBox();
            this.gbDepartmentList = new System.Windows.Forms.GroupBox();
            this.pbEDDS = new System.Windows.Forms.PictureBox();
            this.pbEDDSMarker = new System.Windows.Forms.PictureBox();
            this.pbGlava = new System.Windows.Forms.PictureBox();
            this.pbGlavaMarker = new System.Windows.Forms.PictureBox();
            this.pbMCU = new System.Windows.Forms.PictureBox();
            this.pbMCUMarker = new System.Windows.Forms.PictureBox();
            this.pbDepartmentOfAPK = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPresentationsFolderPath = new System.Windows.Forms.TextBox();
            this.bExploreFolder = new System.Windows.Forms.Button();
            this.bBrowseFolder = new System.Windows.Forms.Button();
            this.folderPresentationsDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cmsPB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ttPB = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfCityDistrictMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfCityDistrict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfPropertyRelationsMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfSecurityCouncilMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfJKHMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfPropertyRelations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfSecurityCouncil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfJKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfAKRMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfSocialDevelopmentMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfEconomicDevelopmentMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfFinancePolicyMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfAPKMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfAKR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfSocialDevelopment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfEconomicDevelopment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfFinancePolicy)).BeginInit();
            this.gbDepartmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEDDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEDDSMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlavaMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMCU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMCUMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfAPK)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deputyToolStripMenuItem,
            this.presentationsNamesToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.administrationToolStripMenuItem.Text = "Администрирование";
            // 
            // deputyToolStripMenuItem
            // 
            this.deputyToolStripMenuItem.Name = "deputyToolStripMenuItem";
            this.deputyToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.deputyToolStripMenuItem.Text = "Заместители";
            this.deputyToolStripMenuItem.Click += new System.EventHandler(this.deputyToolStripMenuItem_Click);
            // 
            // presentationsNamesToolStripMenuItem
            // 
            this.presentationsNamesToolStripMenuItem.Name = "presentationsNamesToolStripMenuItem";
            this.presentationsNamesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.presentationsNamesToolStripMenuItem.Text = "Названия презентаций";
            this.presentationsNamesToolStripMenuItem.Click += new System.EventHandler(this.presentationsNamesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 604);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 22);
            this.progressBar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lbPresentationsDatesList);
            this.groupBox1.Controls.Add(this.cbPresentationByYearsFilter);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 577);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lbPresentationsDatesList
            // 
            this.lbPresentationsDatesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPresentationsDatesList.FormattingEnabled = true;
            this.lbPresentationsDatesList.Location = new System.Drawing.Point(6, 37);
            this.lbPresentationsDatesList.Name = "lbPresentationsDatesList";
            this.lbPresentationsDatesList.Size = new System.Drawing.Size(121, 537);
            this.lbPresentationsDatesList.TabIndex = 1;
            this.lbPresentationsDatesList.SelectedIndexChanged += new System.EventHandler(this.lbPresentationsDatesList_SelectedIndexChanged);
            // 
            // cbPresentationByYearsFilter
            // 
            this.cbPresentationByYearsFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPresentationByYearsFilter.FormattingEnabled = true;
            this.cbPresentationByYearsFilter.Location = new System.Drawing.Point(6, 10);
            this.cbPresentationByYearsFilter.Name = "cbPresentationByYearsFilter";
            this.cbPresentationByYearsFilter.Size = new System.Drawing.Size(121, 21);
            this.cbPresentationByYearsFilter.TabIndex = 0;
            this.cbPresentationByYearsFilter.SelectedIndexChanged += new System.EventHandler(this.cbPresentationByYearsFilter_SelectedIndexChanged);
            // 
            // pbDepartmentOfCityDistrictMarker
            // 
            this.pbDepartmentOfCityDistrictMarker.Location = new System.Drawing.Point(1, 142);
            this.pbDepartmentOfCityDistrictMarker.Name = "pbDepartmentOfCityDistrictMarker";
            this.pbDepartmentOfCityDistrictMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDepartmentOfCityDistrictMarker.TabIndex = 0;
            this.pbDepartmentOfCityDistrictMarker.TabStop = false;
            // 
            // pbDepartmentOfCityDistrict
            // 
            this.pbDepartmentOfCityDistrict.AllowDrop = true;
            this.pbDepartmentOfCityDistrict.Location = new System.Drawing.Point(6, 147);
            this.pbDepartmentOfCityDistrict.Name = "pbDepartmentOfCityDistrict";
            this.pbDepartmentOfCityDistrict.Size = new System.Drawing.Size(80, 80);
            this.pbDepartmentOfCityDistrict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartmentOfCityDistrict.TabIndex = 12;
            this.pbDepartmentOfCityDistrict.TabStop = false;
            // 
            // pbDepartmentOfPropertyRelationsMarker
            // 
            this.pbDepartmentOfPropertyRelationsMarker.Location = new System.Drawing.Point(1, 233);
            this.pbDepartmentOfPropertyRelationsMarker.Name = "pbDepartmentOfPropertyRelationsMarker";
            this.pbDepartmentOfPropertyRelationsMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDepartmentOfPropertyRelationsMarker.TabIndex = 13;
            this.pbDepartmentOfPropertyRelationsMarker.TabStop = false;
            // 
            // pbDepartmentOfSecurityCouncilMarker
            // 
            this.pbDepartmentOfSecurityCouncilMarker.Location = new System.Drawing.Point(1, 324);
            this.pbDepartmentOfSecurityCouncilMarker.Name = "pbDepartmentOfSecurityCouncilMarker";
            this.pbDepartmentOfSecurityCouncilMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDepartmentOfSecurityCouncilMarker.TabIndex = 14;
            this.pbDepartmentOfSecurityCouncilMarker.TabStop = false;
            // 
            // pbDepartmentOfJKHMarker
            // 
            this.pbDepartmentOfJKHMarker.Location = new System.Drawing.Point(1, 51);
            this.pbDepartmentOfJKHMarker.Name = "pbDepartmentOfJKHMarker";
            this.pbDepartmentOfJKHMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDepartmentOfJKHMarker.TabIndex = 15;
            this.pbDepartmentOfJKHMarker.TabStop = false;
            // 
            // pbDepartmentOfPropertyRelations
            // 
            this.pbDepartmentOfPropertyRelations.AllowDrop = true;
            this.pbDepartmentOfPropertyRelations.Location = new System.Drawing.Point(6, 238);
            this.pbDepartmentOfPropertyRelations.Name = "pbDepartmentOfPropertyRelations";
            this.pbDepartmentOfPropertyRelations.Size = new System.Drawing.Size(80, 80);
            this.pbDepartmentOfPropertyRelations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartmentOfPropertyRelations.TabIndex = 16;
            this.pbDepartmentOfPropertyRelations.TabStop = false;
            // 
            // pbDepartmentOfSecurityCouncil
            // 
            this.pbDepartmentOfSecurityCouncil.AllowDrop = true;
            this.pbDepartmentOfSecurityCouncil.Location = new System.Drawing.Point(6, 329);
            this.pbDepartmentOfSecurityCouncil.Name = "pbDepartmentOfSecurityCouncil";
            this.pbDepartmentOfSecurityCouncil.Size = new System.Drawing.Size(80, 80);
            this.pbDepartmentOfSecurityCouncil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartmentOfSecurityCouncil.TabIndex = 17;
            this.pbDepartmentOfSecurityCouncil.TabStop = false;
            // 
            // pbDepartmentOfJKH
            // 
            this.pbDepartmentOfJKH.AllowDrop = true;
            this.pbDepartmentOfJKH.Location = new System.Drawing.Point(6, 56);
            this.pbDepartmentOfJKH.Name = "pbDepartmentOfJKH";
            this.pbDepartmentOfJKH.Size = new System.Drawing.Size(80, 80);
            this.pbDepartmentOfJKH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartmentOfJKH.TabIndex = 18;
            this.pbDepartmentOfJKH.TabStop = false;
            // 
            // pbDepartmentOfAKRMarker
            // 
            this.pbDepartmentOfAKRMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDepartmentOfAKRMarker.Location = new System.Drawing.Point(570, 51);
            this.pbDepartmentOfAKRMarker.Name = "pbDepartmentOfAKRMarker";
            this.pbDepartmentOfAKRMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDepartmentOfAKRMarker.TabIndex = 19;
            this.pbDepartmentOfAKRMarker.TabStop = false;
            // 
            // pbDepartmentOfSocialDevelopmentMarker
            // 
            this.pbDepartmentOfSocialDevelopmentMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDepartmentOfSocialDevelopmentMarker.Location = new System.Drawing.Point(570, 142);
            this.pbDepartmentOfSocialDevelopmentMarker.Name = "pbDepartmentOfSocialDevelopmentMarker";
            this.pbDepartmentOfSocialDevelopmentMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDepartmentOfSocialDevelopmentMarker.TabIndex = 20;
            this.pbDepartmentOfSocialDevelopmentMarker.TabStop = false;
            // 
            // pbDepartmentOfEconomicDevelopmentMarker
            // 
            this.pbDepartmentOfEconomicDevelopmentMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDepartmentOfEconomicDevelopmentMarker.Location = new System.Drawing.Point(570, 233);
            this.pbDepartmentOfEconomicDevelopmentMarker.Name = "pbDepartmentOfEconomicDevelopmentMarker";
            this.pbDepartmentOfEconomicDevelopmentMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDepartmentOfEconomicDevelopmentMarker.TabIndex = 21;
            this.pbDepartmentOfEconomicDevelopmentMarker.TabStop = false;
            // 
            // pbDepartmentOfFinancePolicyMarker
            // 
            this.pbDepartmentOfFinancePolicyMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDepartmentOfFinancePolicyMarker.Location = new System.Drawing.Point(570, 324);
            this.pbDepartmentOfFinancePolicyMarker.Name = "pbDepartmentOfFinancePolicyMarker";
            this.pbDepartmentOfFinancePolicyMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDepartmentOfFinancePolicyMarker.TabIndex = 22;
            this.pbDepartmentOfFinancePolicyMarker.TabStop = false;
            // 
            // pbDepartmentOfAPKMarker
            // 
            this.pbDepartmentOfAPKMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDepartmentOfAPKMarker.Location = new System.Drawing.Point(570, 415);
            this.pbDepartmentOfAPKMarker.Name = "pbDepartmentOfAPKMarker";
            this.pbDepartmentOfAPKMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDepartmentOfAPKMarker.TabIndex = 23;
            this.pbDepartmentOfAPKMarker.TabStop = false;
            // 
            // pbDepartmentOfAKR
            // 
            this.pbDepartmentOfAKR.AllowDrop = true;
            this.pbDepartmentOfAKR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDepartmentOfAKR.Location = new System.Drawing.Point(575, 56);
            this.pbDepartmentOfAKR.Name = "pbDepartmentOfAKR";
            this.pbDepartmentOfAKR.Size = new System.Drawing.Size(80, 80);
            this.pbDepartmentOfAKR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartmentOfAKR.TabIndex = 24;
            this.pbDepartmentOfAKR.TabStop = false;
            // 
            // pbDepartmentOfSocialDevelopment
            // 
            this.pbDepartmentOfSocialDevelopment.AllowDrop = true;
            this.pbDepartmentOfSocialDevelopment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDepartmentOfSocialDevelopment.Location = new System.Drawing.Point(575, 147);
            this.pbDepartmentOfSocialDevelopment.Name = "pbDepartmentOfSocialDevelopment";
            this.pbDepartmentOfSocialDevelopment.Size = new System.Drawing.Size(80, 80);
            this.pbDepartmentOfSocialDevelopment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartmentOfSocialDevelopment.TabIndex = 25;
            this.pbDepartmentOfSocialDevelopment.TabStop = false;
            // 
            // pbDepartmentOfEconomicDevelopment
            // 
            this.pbDepartmentOfEconomicDevelopment.AllowDrop = true;
            this.pbDepartmentOfEconomicDevelopment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDepartmentOfEconomicDevelopment.Location = new System.Drawing.Point(575, 238);
            this.pbDepartmentOfEconomicDevelopment.Name = "pbDepartmentOfEconomicDevelopment";
            this.pbDepartmentOfEconomicDevelopment.Size = new System.Drawing.Size(80, 80);
            this.pbDepartmentOfEconomicDevelopment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartmentOfEconomicDevelopment.TabIndex = 26;
            this.pbDepartmentOfEconomicDevelopment.TabStop = false;
            // 
            // pbDepartmentOfFinancePolicy
            // 
            this.pbDepartmentOfFinancePolicy.AllowDrop = true;
            this.pbDepartmentOfFinancePolicy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDepartmentOfFinancePolicy.Location = new System.Drawing.Point(575, 329);
            this.pbDepartmentOfFinancePolicy.Name = "pbDepartmentOfFinancePolicy";
            this.pbDepartmentOfFinancePolicy.Size = new System.Drawing.Size(80, 80);
            this.pbDepartmentOfFinancePolicy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartmentOfFinancePolicy.TabIndex = 27;
            this.pbDepartmentOfFinancePolicy.TabStop = false;
            // 
            // gbDepartmentList
            // 
            this.gbDepartmentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDepartmentList.Controls.Add(this.pbEDDS);
            this.gbDepartmentList.Controls.Add(this.pbEDDSMarker);
            this.gbDepartmentList.Controls.Add(this.pbGlava);
            this.gbDepartmentList.Controls.Add(this.pbGlavaMarker);
            this.gbDepartmentList.Controls.Add(this.pbMCU);
            this.gbDepartmentList.Controls.Add(this.pbMCUMarker);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfAPK);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfFinancePolicy);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfEconomicDevelopment);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfSocialDevelopment);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfAKR);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfAPKMarker);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfFinancePolicyMarker);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfEconomicDevelopmentMarker);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfSocialDevelopmentMarker);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfAKRMarker);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfJKH);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfSecurityCouncil);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfPropertyRelations);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfJKHMarker);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfSecurityCouncilMarker);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfPropertyRelationsMarker);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfCityDistrict);
            this.gbDepartmentList.Controls.Add(this.pbDepartmentOfCityDistrictMarker);
            this.gbDepartmentList.Location = new System.Drawing.Point(139, 27);
            this.gbDepartmentList.Name = "gbDepartmentList";
            this.gbDepartmentList.Size = new System.Drawing.Size(661, 513);
            this.gbDepartmentList.TabIndex = 3;
            this.gbDepartmentList.TabStop = false;
            // 
            // pbEDDS
            // 
            this.pbEDDS.AllowDrop = true;
            this.pbEDDS.Location = new System.Drawing.Point(97, 329);
            this.pbEDDS.Name = "pbEDDS";
            this.pbEDDS.Size = new System.Drawing.Size(80, 80);
            this.pbEDDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEDDS.TabIndex = 34;
            this.pbEDDS.TabStop = false;
            // 
            // pbEDDSMarker
            // 
            this.pbEDDSMarker.Location = new System.Drawing.Point(92, 324);
            this.pbEDDSMarker.Name = "pbEDDSMarker";
            this.pbEDDSMarker.Size = new System.Drawing.Size(90, 90);
            this.pbEDDSMarker.TabIndex = 33;
            this.pbEDDSMarker.TabStop = false;
            // 
            // pbGlava
            // 
            this.pbGlava.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbGlava.Image = ((System.Drawing.Image)(resources.GetObject("pbGlava.Image")));
            this.pbGlava.Location = new System.Drawing.Point(264, 14);
            this.pbGlava.Name = "pbGlava";
            this.pbGlava.Size = new System.Drawing.Size(80, 80);
            this.pbGlava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGlava.TabIndex = 32;
            this.pbGlava.TabStop = false;
            // 
            // pbGlavaMarker
            // 
            this.pbGlavaMarker.Location = new System.Drawing.Point(259, 9);
            this.pbGlavaMarker.Name = "pbGlavaMarker";
            this.pbGlavaMarker.Size = new System.Drawing.Size(90, 90);
            this.pbGlavaMarker.TabIndex = 31;
            this.pbGlavaMarker.TabStop = false;
            // 
            // pbMCU
            // 
            this.pbMCU.AllowDrop = true;
            this.pbMCU.Location = new System.Drawing.Point(6, 420);
            this.pbMCU.Name = "pbMCU";
            this.pbMCU.Size = new System.Drawing.Size(80, 80);
            this.pbMCU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMCU.TabIndex = 30;
            this.pbMCU.TabStop = false;
            // 
            // pbMCUMarker
            // 
            this.pbMCUMarker.Location = new System.Drawing.Point(1, 415);
            this.pbMCUMarker.Name = "pbMCUMarker";
            this.pbMCUMarker.Size = new System.Drawing.Size(90, 90);
            this.pbMCUMarker.TabIndex = 29;
            this.pbMCUMarker.TabStop = false;
            // 
            // pbDepartmentOfAPK
            // 
            this.pbDepartmentOfAPK.AllowDrop = true;
            this.pbDepartmentOfAPK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDepartmentOfAPK.Location = new System.Drawing.Point(575, 420);
            this.pbDepartmentOfAPK.Name = "pbDepartmentOfAPK";
            this.pbDepartmentOfAPK.Size = new System.Drawing.Size(80, 80);
            this.pbDepartmentOfAPK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartmentOfAPK.TabIndex = 28;
            this.pbDepartmentOfAPK.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Корневая папка с презентациями";
            // 
            // tbPresentationsFolderPath
            // 
            this.tbPresentationsFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPresentationsFolderPath.Enabled = false;
            this.tbPresentationsFolderPath.Location = new System.Drawing.Point(429, 575);
            this.tbPresentationsFolderPath.Name = "tbPresentationsFolderPath";
            this.tbPresentationsFolderPath.Size = new System.Drawing.Size(303, 20);
            this.tbPresentationsFolderPath.TabIndex = 5;
            // 
            // bExploreFolder
            // 
            this.bExploreFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExploreFolder.Location = new System.Drawing.Point(769, 572);
            this.bExploreFolder.Name = "bExploreFolder";
            this.bExploreFolder.Size = new System.Drawing.Size(25, 25);
            this.bExploreFolder.TabIndex = 6;
            this.bExploreFolder.Text = "...";
            this.bExploreFolder.UseVisualStyleBackColor = true;
            this.bExploreFolder.Click += new System.EventHandler(this.bBrowseFolder_Click);
            // 
            // bBrowseFolder
            // 
            this.bBrowseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowseFolder.Image = ((System.Drawing.Image)(resources.GetObject("bBrowseFolder.Image")));
            this.bBrowseFolder.Location = new System.Drawing.Point(738, 572);
            this.bBrowseFolder.Name = "bBrowseFolder";
            this.bBrowseFolder.Size = new System.Drawing.Size(25, 25);
            this.bBrowseFolder.TabIndex = 7;
            this.bBrowseFolder.Text = "...";
            this.bBrowseFolder.UseVisualStyleBackColor = true;
            this.bBrowseFolder.Click += new System.EventHandler(this.bExploreFolder_Click);
            // 
            // cmsPB
            // 
            this.cmsPB.Name = "cmsPB";
            this.cmsPB.Size = new System.Drawing.Size(61, 4);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.bBrowseFolder);
            this.Controls.Add(this.bExploreFolder);
            this.Controls.Add(this.tbPresentationsFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDepartmentList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "FridayPresentationManager";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfCityDistrictMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfCityDistrict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfPropertyRelationsMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfSecurityCouncilMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfJKHMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfPropertyRelations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfSecurityCouncil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfJKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfAKRMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfSocialDevelopmentMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfEconomicDevelopmentMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfFinancePolicyMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfAPKMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfAKR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfSocialDevelopment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfEconomicDevelopment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfFinancePolicy)).EndInit();
            this.gbDepartmentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEDDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEDDSMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlavaMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMCU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMCUMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentOfAPK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deputyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal PictureBox pbDepartmentOfCityDistrictMarker;
        internal PictureBox pbDepartmentOfCityDistrict;
        internal PictureBox pbDepartmentOfPropertyRelationsMarker;
        internal PictureBox pbDepartmentOfSecurityCouncilMarker;
        internal PictureBox pbDepartmentOfJKHMarker;
        internal PictureBox pbDepartmentOfPropertyRelations;
        internal PictureBox pbDepartmentOfSecurityCouncil;
        internal PictureBox pbDepartmentOfJKH;
        internal PictureBox pbDepartmentOfAKRMarker;
        internal PictureBox pbDepartmentOfSocialDevelopmentMarker;
        internal PictureBox pbDepartmentOfEconomicDevelopmentMarker;
        internal PictureBox pbDepartmentOfFinancePolicyMarker;
        internal PictureBox pbDepartmentOfAPKMarker;
        internal PictureBox pbDepartmentOfAKR;
        internal PictureBox pbDepartmentOfSocialDevelopment;
        internal PictureBox pbDepartmentOfEconomicDevelopment;
        internal PictureBox pbDepartmentOfFinancePolicy;
        private GroupBox gbDepartmentList;
        internal PictureBox pbGlava;
        internal PictureBox pbGlavaMarker;
        internal PictureBox pbMCU;
        internal PictureBox pbMCUMarker;
        internal PictureBox pbDepartmentOfAPK;
        private Label label1;
        private TextBox tbPresentationsFolderPath;
        private Button bExploreFolder;
        private Button bBrowseFolder;
        private FolderBrowserDialog folderPresentationsDialog;
        internal ListBox lbPresentationsDatesList;
        internal PictureBox pbEDDS;
        internal PictureBox pbEDDSMarker;
        internal ComboBox cbPresentationByYearsFilter;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem presentationsNamesToolStripMenuItem;
        internal ContextMenuStrip cmsPB;
        private ToolTip ttPB;
    }
}

