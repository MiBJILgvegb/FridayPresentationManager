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
            this.pbDeputyOfCityDistrictMarker = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfCityDistrict = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfPropertyRelationsMarker = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfSecurityCouncilMarker = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfJKHMarker = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfPropertyRelations = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfSecurityCouncil = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfJKH = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfAKRMarker = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfSocialDevelopmentMarker = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfEconomicDevelopmentMarker = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfFinancePolicyMarker = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfAPKMarker = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfAKR = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfSocialDevelopment = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfEconomicDevelopment = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfFinancePolicy = new System.Windows.Forms.PictureBox();
            this.gbDeputyList = new System.Windows.Forms.GroupBox();
            this.pbEDDS = new System.Windows.Forms.PictureBox();
            this.pbEDDSMarker = new System.Windows.Forms.PictureBox();
            this.pbGlava = new System.Windows.Forms.PictureBox();
            this.pbGlavaMarker = new System.Windows.Forms.PictureBox();
            this.pbMCU = new System.Windows.Forms.PictureBox();
            this.pbMCUMarker = new System.Windows.Forms.PictureBox();
            this.pbDeputyOfAPK = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPresentationsFolderPath = new System.Windows.Forms.TextBox();
            this.bExploreFolder = new System.Windows.Forms.Button();
            this.bBrowseFolder = new System.Windows.Forms.Button();
            this.folderPresentationsDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cmsPB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ttPB = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfCityDistrictMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfCityDistrict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfPropertyRelationsMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfSecurityCouncilMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfJKHMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfPropertyRelations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfSecurityCouncil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfJKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfAKRMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfSocialDevelopmentMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfEconomicDevelopmentMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfFinancePolicyMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfAPKMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfAKR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfSocialDevelopment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfEconomicDevelopment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfFinancePolicy)).BeginInit();
            this.gbDeputyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEDDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEDDSMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlavaMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMCU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMCUMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfAPK)).BeginInit();
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
            // pbDeputyOfCityDistrictMarker
            // 
            this.pbDeputyOfCityDistrictMarker.Location = new System.Drawing.Point(1, 51);
            this.pbDeputyOfCityDistrictMarker.Name = "pbDeputyOfCityDistrictMarker";
            this.pbDeputyOfCityDistrictMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDeputyOfCityDistrictMarker.TabIndex = 0;
            this.pbDeputyOfCityDistrictMarker.TabStop = false;
            // 
            // pbDeputyOfCityDistrict
            // 
            this.pbDeputyOfCityDistrict.AllowDrop = true;
            this.pbDeputyOfCityDistrict.Location = new System.Drawing.Point(6, 56);
            this.pbDeputyOfCityDistrict.Name = "pbDeputyOfCityDistrict";
            this.pbDeputyOfCityDistrict.Size = new System.Drawing.Size(80, 80);
            this.pbDeputyOfCityDistrict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeputyOfCityDistrict.TabIndex = 12;
            this.pbDeputyOfCityDistrict.TabStop = false;
            // 
            // pbDeputyOfPropertyRelationsMarker
            // 
            this.pbDeputyOfPropertyRelationsMarker.Location = new System.Drawing.Point(1, 142);
            this.pbDeputyOfPropertyRelationsMarker.Name = "pbDeputyOfPropertyRelationsMarker";
            this.pbDeputyOfPropertyRelationsMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDeputyOfPropertyRelationsMarker.TabIndex = 13;
            this.pbDeputyOfPropertyRelationsMarker.TabStop = false;
            // 
            // pbDeputyOfSecurityCouncilMarker
            // 
            this.pbDeputyOfSecurityCouncilMarker.Location = new System.Drawing.Point(1, 233);
            this.pbDeputyOfSecurityCouncilMarker.Name = "pbDeputyOfSecurityCouncilMarker";
            this.pbDeputyOfSecurityCouncilMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDeputyOfSecurityCouncilMarker.TabIndex = 14;
            this.pbDeputyOfSecurityCouncilMarker.TabStop = false;
            // 
            // pbDeputyOfJKHMarker
            // 
            this.pbDeputyOfJKHMarker.Location = new System.Drawing.Point(1, 324);
            this.pbDeputyOfJKHMarker.Name = "pbDeputyOfJKHMarker";
            this.pbDeputyOfJKHMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDeputyOfJKHMarker.TabIndex = 15;
            this.pbDeputyOfJKHMarker.TabStop = false;
            // 
            // pbDeputyOfPropertyRelations
            // 
            this.pbDeputyOfPropertyRelations.AllowDrop = true;
            this.pbDeputyOfPropertyRelations.Location = new System.Drawing.Point(6, 147);
            this.pbDeputyOfPropertyRelations.Name = "pbDeputyOfPropertyRelations";
            this.pbDeputyOfPropertyRelations.Size = new System.Drawing.Size(80, 80);
            this.pbDeputyOfPropertyRelations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeputyOfPropertyRelations.TabIndex = 16;
            this.pbDeputyOfPropertyRelations.TabStop = false;
            // 
            // pbDeputyOfSecurityCouncil
            // 
            this.pbDeputyOfSecurityCouncil.AllowDrop = true;
            this.pbDeputyOfSecurityCouncil.Location = new System.Drawing.Point(6, 238);
            this.pbDeputyOfSecurityCouncil.Name = "pbDeputyOfSecurityCouncil";
            this.pbDeputyOfSecurityCouncil.Size = new System.Drawing.Size(80, 80);
            this.pbDeputyOfSecurityCouncil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeputyOfSecurityCouncil.TabIndex = 17;
            this.pbDeputyOfSecurityCouncil.TabStop = false;
            // 
            // pbDeputyOfJKH
            // 
            this.pbDeputyOfJKH.AllowDrop = true;
            this.pbDeputyOfJKH.Location = new System.Drawing.Point(6, 329);
            this.pbDeputyOfJKH.Name = "pbDeputyOfJKH";
            this.pbDeputyOfJKH.Size = new System.Drawing.Size(80, 80);
            this.pbDeputyOfJKH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeputyOfJKH.TabIndex = 18;
            this.pbDeputyOfJKH.TabStop = false;
            // 
            // pbDeputyOfAKRMarker
            // 
            this.pbDeputyOfAKRMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeputyOfAKRMarker.Location = new System.Drawing.Point(570, 51);
            this.pbDeputyOfAKRMarker.Name = "pbDeputyOfAKRMarker";
            this.pbDeputyOfAKRMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDeputyOfAKRMarker.TabIndex = 19;
            this.pbDeputyOfAKRMarker.TabStop = false;
            // 
            // pbDeputyOfSocialDevelopmentMarker
            // 
            this.pbDeputyOfSocialDevelopmentMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeputyOfSocialDevelopmentMarker.Location = new System.Drawing.Point(570, 142);
            this.pbDeputyOfSocialDevelopmentMarker.Name = "pbDeputyOfSocialDevelopmentMarker";
            this.pbDeputyOfSocialDevelopmentMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDeputyOfSocialDevelopmentMarker.TabIndex = 20;
            this.pbDeputyOfSocialDevelopmentMarker.TabStop = false;
            // 
            // pbDeputyOfEconomicDevelopmentMarker
            // 
            this.pbDeputyOfEconomicDevelopmentMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeputyOfEconomicDevelopmentMarker.Location = new System.Drawing.Point(570, 233);
            this.pbDeputyOfEconomicDevelopmentMarker.Name = "pbDeputyOfEconomicDevelopmentMarker";
            this.pbDeputyOfEconomicDevelopmentMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDeputyOfEconomicDevelopmentMarker.TabIndex = 21;
            this.pbDeputyOfEconomicDevelopmentMarker.TabStop = false;
            // 
            // pbDeputyOfFinancePolicyMarker
            // 
            this.pbDeputyOfFinancePolicyMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeputyOfFinancePolicyMarker.Location = new System.Drawing.Point(570, 324);
            this.pbDeputyOfFinancePolicyMarker.Name = "pbDeputyOfFinancePolicyMarker";
            this.pbDeputyOfFinancePolicyMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDeputyOfFinancePolicyMarker.TabIndex = 22;
            this.pbDeputyOfFinancePolicyMarker.TabStop = false;
            // 
            // pbDeputyOfAPKMarker
            // 
            this.pbDeputyOfAPKMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeputyOfAPKMarker.Location = new System.Drawing.Point(570, 415);
            this.pbDeputyOfAPKMarker.Name = "pbDeputyOfAPKMarker";
            this.pbDeputyOfAPKMarker.Size = new System.Drawing.Size(90, 90);
            this.pbDeputyOfAPKMarker.TabIndex = 23;
            this.pbDeputyOfAPKMarker.TabStop = false;
            // 
            // pbDeputyOfAKR
            // 
            this.pbDeputyOfAKR.AllowDrop = true;
            this.pbDeputyOfAKR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeputyOfAKR.Location = new System.Drawing.Point(575, 56);
            this.pbDeputyOfAKR.Name = "pbDeputyOfAKR";
            this.pbDeputyOfAKR.Size = new System.Drawing.Size(80, 80);
            this.pbDeputyOfAKR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeputyOfAKR.TabIndex = 24;
            this.pbDeputyOfAKR.TabStop = false;
            // 
            // pbDeputyOfSocialDevelopment
            // 
            this.pbDeputyOfSocialDevelopment.AllowDrop = true;
            this.pbDeputyOfSocialDevelopment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeputyOfSocialDevelopment.Location = new System.Drawing.Point(575, 147);
            this.pbDeputyOfSocialDevelopment.Name = "pbDeputyOfSocialDevelopment";
            this.pbDeputyOfSocialDevelopment.Size = new System.Drawing.Size(80, 80);
            this.pbDeputyOfSocialDevelopment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeputyOfSocialDevelopment.TabIndex = 25;
            this.pbDeputyOfSocialDevelopment.TabStop = false;
            // 
            // pbDeputyOfEconomicDevelopment
            // 
            this.pbDeputyOfEconomicDevelopment.AllowDrop = true;
            this.pbDeputyOfEconomicDevelopment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeputyOfEconomicDevelopment.Location = new System.Drawing.Point(575, 238);
            this.pbDeputyOfEconomicDevelopment.Name = "pbDeputyOfEconomicDevelopment";
            this.pbDeputyOfEconomicDevelopment.Size = new System.Drawing.Size(80, 80);
            this.pbDeputyOfEconomicDevelopment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeputyOfEconomicDevelopment.TabIndex = 26;
            this.pbDeputyOfEconomicDevelopment.TabStop = false;
            // 
            // pbDeputyOfFinancePolicy
            // 
            this.pbDeputyOfFinancePolicy.AllowDrop = true;
            this.pbDeputyOfFinancePolicy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeputyOfFinancePolicy.Location = new System.Drawing.Point(575, 329);
            this.pbDeputyOfFinancePolicy.Name = "pbDeputyOfFinancePolicy";
            this.pbDeputyOfFinancePolicy.Size = new System.Drawing.Size(80, 80);
            this.pbDeputyOfFinancePolicy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeputyOfFinancePolicy.TabIndex = 27;
            this.pbDeputyOfFinancePolicy.TabStop = false;
            // 
            // gbDeputyList
            // 
            this.gbDeputyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDeputyList.Controls.Add(this.pbEDDS);
            this.gbDeputyList.Controls.Add(this.pbEDDSMarker);
            this.gbDeputyList.Controls.Add(this.pbGlava);
            this.gbDeputyList.Controls.Add(this.pbGlavaMarker);
            this.gbDeputyList.Controls.Add(this.pbMCU);
            this.gbDeputyList.Controls.Add(this.pbMCUMarker);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfAPK);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfFinancePolicy);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfEconomicDevelopment);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfSocialDevelopment);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfAKR);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfAPKMarker);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfFinancePolicyMarker);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfEconomicDevelopmentMarker);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfSocialDevelopmentMarker);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfAKRMarker);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfJKH);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfSecurityCouncil);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfPropertyRelations);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfJKHMarker);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfSecurityCouncilMarker);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfPropertyRelationsMarker);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfCityDistrict);
            this.gbDeputyList.Controls.Add(this.pbDeputyOfCityDistrictMarker);
            this.gbDeputyList.Location = new System.Drawing.Point(139, 27);
            this.gbDeputyList.Name = "gbDeputyList";
            this.gbDeputyList.Size = new System.Drawing.Size(661, 539);
            this.gbDeputyList.TabIndex = 3;
            this.gbDeputyList.TabStop = false;
            // 
            // pbEDDS
            // 
            this.pbEDDS.AllowDrop = true;
            this.pbEDDS.Location = new System.Drawing.Point(102, 238);
            this.pbEDDS.Name = "pbEDDS";
            this.pbEDDS.Size = new System.Drawing.Size(80, 80);
            this.pbEDDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEDDS.TabIndex = 34;
            this.pbEDDS.TabStop = false;
            // 
            // pbEDDSMarker
            // 
            this.pbEDDSMarker.Location = new System.Drawing.Point(97, 233);
            this.pbEDDSMarker.Name = "pbEDDSMarker";
            this.pbEDDSMarker.Size = new System.Drawing.Size(90, 90);
            this.pbEDDSMarker.TabIndex = 33;
            this.pbEDDSMarker.TabStop = false;
            // 
            // pbGlava
            // 
            this.pbGlava.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbGlava.Image = ((System.Drawing.Image)(resources.GetObject("pbGlava.Image")));
            this.pbGlava.Location = new System.Drawing.Point(280, 19);
            this.pbGlava.Name = "pbGlava";
            this.pbGlava.Size = new System.Drawing.Size(80, 80);
            this.pbGlava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGlava.TabIndex = 32;
            this.pbGlava.TabStop = false;
            // 
            // pbGlavaMarker
            // 
            this.pbGlavaMarker.Location = new System.Drawing.Point(223, 14);
            this.pbGlavaMarker.Name = "pbGlavaMarker";
            this.pbGlavaMarker.Size = new System.Drawing.Size(90, 90);
            this.pbGlavaMarker.TabIndex = 31;
            this.pbGlavaMarker.TabStop = false;
            // 
            // pbMCU
            // 
            this.pbMCU.AllowDrop = true;
            this.pbMCU.Location = new System.Drawing.Point(6, 448);
            this.pbMCU.Name = "pbMCU";
            this.pbMCU.Size = new System.Drawing.Size(80, 80);
            this.pbMCU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMCU.TabIndex = 30;
            this.pbMCU.TabStop = false;
            // 
            // pbMCUMarker
            // 
            this.pbMCUMarker.Location = new System.Drawing.Point(1, 443);
            this.pbMCUMarker.Name = "pbMCUMarker";
            this.pbMCUMarker.Size = new System.Drawing.Size(90, 90);
            this.pbMCUMarker.TabIndex = 29;
            this.pbMCUMarker.TabStop = false;
            // 
            // pbDeputyOfAPK
            // 
            this.pbDeputyOfAPK.AllowDrop = true;
            this.pbDeputyOfAPK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeputyOfAPK.Location = new System.Drawing.Point(575, 420);
            this.pbDeputyOfAPK.Name = "pbDeputyOfAPK";
            this.pbDeputyOfAPK.Size = new System.Drawing.Size(80, 80);
            this.pbDeputyOfAPK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeputyOfAPK.TabIndex = 28;
            this.pbDeputyOfAPK.TabStop = false;
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
            this.Controls.Add(this.gbDeputyList);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfCityDistrictMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfCityDistrict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfPropertyRelationsMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfSecurityCouncilMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfJKHMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfPropertyRelations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfSecurityCouncil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfJKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfAKRMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfSocialDevelopmentMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfEconomicDevelopmentMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfFinancePolicyMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfAPKMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfAKR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfSocialDevelopment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfEconomicDevelopment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfFinancePolicy)).EndInit();
            this.gbDeputyList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEDDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEDDSMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlavaMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMCU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMCUMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeputyOfAPK)).EndInit();
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
        internal PictureBox pbDeputyOfCityDistrictMarker;
        internal PictureBox pbDeputyOfCityDistrict;
        internal PictureBox pbDeputyOfPropertyRelationsMarker;
        internal PictureBox pbDeputyOfSecurityCouncilMarker;
        internal PictureBox pbDeputyOfJKHMarker;
        internal PictureBox pbDeputyOfPropertyRelations;
        internal PictureBox pbDeputyOfSecurityCouncil;
        internal PictureBox pbDeputyOfJKH;
        internal PictureBox pbDeputyOfAKRMarker;
        internal PictureBox pbDeputyOfSocialDevelopmentMarker;
        internal PictureBox pbDeputyOfEconomicDevelopmentMarker;
        internal PictureBox pbDeputyOfFinancePolicyMarker;
        internal PictureBox pbDeputyOfAPKMarker;
        internal PictureBox pbDeputyOfAKR;
        internal PictureBox pbDeputyOfSocialDevelopment;
        internal PictureBox pbDeputyOfEconomicDevelopment;
        internal PictureBox pbDeputyOfFinancePolicy;
        private GroupBox gbDeputyList;
        internal PictureBox pbGlava;
        internal PictureBox pbGlavaMarker;
        internal PictureBox pbMCU;
        internal PictureBox pbMCUMarker;
        internal PictureBox pbDeputyOfAPK;
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

