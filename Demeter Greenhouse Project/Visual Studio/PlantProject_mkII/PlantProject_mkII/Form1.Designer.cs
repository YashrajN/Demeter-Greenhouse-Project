namespace PlantProject_mkII
{
    partial class frmPlantProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlantProject));
            this.chkTwicePerDay = new System.Windows.Forms.CheckBox();
            this.chkThricePerDay = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkOncePerDay = new System.Windows.Forms.CheckBox();
            this.grpDaily = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmboDaylightHours = new System.Windows.Forms.ComboBox();
            this.aclblTest = new System.Windows.Forms.Label();
            this.grpTypeOfSunlight = new System.Windows.Forms.GroupBox();
            this.rdoIndirect = new System.Windows.Forms.RadioButton();
            this.rdoDirect = new System.Windows.Forms.RadioButton();
            this.grpTemperature = new System.Windows.Forms.GroupBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.tabMainTabs = new System.Windows.Forms.TabControl();
            this.tabManualSettings = new System.Windows.Forms.TabPage();
            this.tabAutomaticSettings = new System.Windows.Forms.TabPage();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.lblTemperatureInfo = new System.Windows.Forms.Label();
            this.lblDirectOrIndirectInfo = new System.Windows.Forms.Label();
            this.lblHoursOfSunlightInfo = new System.Windows.Forms.Label();
            this.lblWaterInfo = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblTypeOfSunlight = new System.Windows.Forms.Label();
            this.lblHoursOfSunlight = new System.Windows.Forms.Label();
            this.lblDailyWater = new System.Windows.Forms.Label();
            this.cmboPlantList = new System.Windows.Forms.ComboBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.grpPicture = new System.Windows.Forms.GroupBox();
            this.picbxAfricanViolet = new System.Windows.Forms.PictureBox();
            this.picbxGeneralFern = new System.Windows.Forms.PictureBox();
            this.picbxBostonFern = new System.Windows.Forms.PictureBox();
            this.picbxBirdsNestFern = new System.Windows.Forms.PictureBox();
            this.picbxCanaryDatePalm = new System.Windows.Forms.PictureBox();
            this.picbxAloeVera = new System.Windows.Forms.PictureBox();
            this.picbxCoralCactus = new System.Windows.Forms.PictureBox();
            this.picbxBirdOfParadise = new System.Windows.Forms.PictureBox();
            this.picbxIvy = new System.Windows.Forms.PictureBox();
            this.grpDaily.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTypeOfSunlight.SuspendLayout();
            this.grpTemperature.SuspendLayout();
            this.tabMainTabs.SuspendLayout();
            this.tabManualSettings.SuspendLayout();
            this.tabAutomaticSettings.SuspendLayout();
            this.grpInformation.SuspendLayout();
            this.grpPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAfricanViolet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGeneralFern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBostonFern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBirdsNestFern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxCanaryDatePalm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAloeVera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxCoralCactus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBirdOfParadise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxIvy)).BeginInit();
            this.SuspendLayout();
            // 
            // chkTwicePerDay
            // 
            this.chkTwicePerDay.AutoSize = true;
            this.chkTwicePerDay.Location = new System.Drawing.Point(170, 28);
            this.chkTwicePerDay.Name = "chkTwicePerDay";
            this.chkTwicePerDay.Size = new System.Drawing.Size(121, 21);
            this.chkTwicePerDay.TabIndex = 1;
            this.chkTwicePerDay.Text = "Twice Per Day";
            this.chkTwicePerDay.UseVisualStyleBackColor = true;
            this.chkTwicePerDay.CheckedChanged += new System.EventHandler(this.chkTwicePerDay_CheckedChanged);
            // 
            // chkThricePerDay
            // 
            this.chkThricePerDay.AutoSize = true;
            this.chkThricePerDay.Location = new System.Drawing.Point(311, 28);
            this.chkThricePerDay.Name = "chkThricePerDay";
            this.chkThricePerDay.Size = new System.Drawing.Size(125, 21);
            this.chkThricePerDay.TabIndex = 2;
            this.chkThricePerDay.Text = "Thrice Per Day";
            this.chkThricePerDay.UseVisualStyleBackColor = true;
            this.chkThricePerDay.CheckedChanged += new System.EventHandler(this.chkThricePerDay_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(8, 245);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkOncePerDay
            // 
            this.chkOncePerDay.AutoSize = true;
            this.chkOncePerDay.Location = new System.Drawing.Point(16, 28);
            this.chkOncePerDay.Name = "chkOncePerDay";
            this.chkOncePerDay.Size = new System.Drawing.Size(119, 21);
            this.chkOncePerDay.TabIndex = 0;
            this.chkOncePerDay.Text = "Once Per Day";
            this.chkOncePerDay.UseVisualStyleBackColor = true;
            this.chkOncePerDay.CheckedChanged += new System.EventHandler(this.chkOncePerDay_CheckedChanged);
            // 
            // grpDaily
            // 
            this.grpDaily.Controls.Add(this.chkThricePerDay);
            this.grpDaily.Controls.Add(this.chkOncePerDay);
            this.grpDaily.Controls.Add(this.chkTwicePerDay);
            this.grpDaily.Location = new System.Drawing.Point(7, 6);
            this.grpDaily.Name = "grpDaily";
            this.grpDaily.Size = new System.Drawing.Size(496, 64);
            this.grpDaily.TabIndex = 4;
            this.grpDaily.TabStop = false;
            this.grpDaily.Text = "Daily Water (1)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmboDaylightHours);
            this.groupBox1.Location = new System.Drawing.Point(525, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Light (2)";
            // 
            // cmboDaylightHours
            // 
            this.cmboDaylightHours.FormattingEnabled = true;
            this.cmboDaylightHours.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmboDaylightHours.Location = new System.Drawing.Point(8, 21);
            this.cmboDaylightHours.Name = "cmboDaylightHours";
            this.cmboDaylightHours.Size = new System.Drawing.Size(121, 24);
            this.cmboDaylightHours.TabIndex = 7;
            this.cmboDaylightHours.SelectedIndexChanged += new System.EventHandler(this.cmboDaylightHours_SelectedIndexChanged);
            // 
            // aclblTest
            // 
            this.aclblTest.AutoSize = true;
            this.aclblTest.Location = new System.Drawing.Point(117, 251);
            this.aclblTest.Name = "aclblTest";
            this.aclblTest.Size = new System.Drawing.Size(94, 17);
            this.aclblTest.TabIndex = 6;
            this.aclblTest.Text = "Testing Label";
            this.aclblTest.Visible = false;
            // 
            // grpTypeOfSunlight
            // 
            this.grpTypeOfSunlight.Controls.Add(this.rdoIndirect);
            this.grpTypeOfSunlight.Controls.Add(this.rdoDirect);
            this.grpTypeOfSunlight.Location = new System.Drawing.Point(7, 101);
            this.grpTypeOfSunlight.Name = "grpTypeOfSunlight";
            this.grpTypeOfSunlight.Size = new System.Drawing.Size(201, 64);
            this.grpTypeOfSunlight.TabIndex = 5;
            this.grpTypeOfSunlight.TabStop = false;
            this.grpTypeOfSunlight.Text = "Type Sunlight (3)";
            // 
            // rdoIndirect
            // 
            this.rdoIndirect.AutoSize = true;
            this.rdoIndirect.Location = new System.Drawing.Point(107, 26);
            this.rdoIndirect.Name = "rdoIndirect";
            this.rdoIndirect.Size = new System.Drawing.Size(75, 21);
            this.rdoIndirect.TabIndex = 1;
            this.rdoIndirect.TabStop = true;
            this.rdoIndirect.Text = "Indirect";
            this.rdoIndirect.UseVisualStyleBackColor = true;
            this.rdoIndirect.CheckedChanged += new System.EventHandler(this.rdoIndirect_CheckedChanged);
            // 
            // rdoDirect
            // 
            this.rdoDirect.AutoSize = true;
            this.rdoDirect.Location = new System.Drawing.Point(16, 26);
            this.rdoDirect.Name = "rdoDirect";
            this.rdoDirect.Size = new System.Drawing.Size(66, 21);
            this.rdoDirect.TabIndex = 0;
            this.rdoDirect.TabStop = true;
            this.rdoDirect.Text = "Direct";
            this.rdoDirect.UseVisualStyleBackColor = true;
            this.rdoDirect.CheckedChanged += new System.EventHandler(this.rdoDirect_CheckedChanged);
            // 
            // grpTemperature
            // 
            this.grpTemperature.Controls.Add(this.txtTemperature);
            this.grpTemperature.Location = new System.Drawing.Point(233, 101);
            this.grpTemperature.Name = "grpTemperature";
            this.grpTemperature.Size = new System.Drawing.Size(137, 64);
            this.grpTemperature.TabIndex = 6;
            this.grpTemperature.TabStop = false;
            this.grpTemperature.Text = "Temperature (4)";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(7, 26);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(107, 22);
            this.txtTemperature.TabIndex = 0;
            this.txtTemperature.TextChanged += new System.EventHandler(this.txtTemperature_TextChanged);
            // 
            // tabMainTabs
            // 
            this.tabMainTabs.Controls.Add(this.tabManualSettings);
            this.tabMainTabs.Controls.Add(this.tabAutomaticSettings);
            this.tabMainTabs.Location = new System.Drawing.Point(3, 0);
            this.tabMainTabs.Name = "tabMainTabs";
            this.tabMainTabs.SelectedIndex = 0;
            this.tabMainTabs.Size = new System.Drawing.Size(685, 244);
            this.tabMainTabs.TabIndex = 7;
            // 
            // tabManualSettings
            // 
            this.tabManualSettings.Controls.Add(this.grpDaily);
            this.tabManualSettings.Controls.Add(this.grpTemperature);
            this.tabManualSettings.Controls.Add(this.groupBox1);
            this.tabManualSettings.Controls.Add(this.grpTypeOfSunlight);
            this.tabManualSettings.Location = new System.Drawing.Point(4, 25);
            this.tabManualSettings.Name = "tabManualSettings";
            this.tabManualSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabManualSettings.Size = new System.Drawing.Size(677, 215);
            this.tabManualSettings.TabIndex = 0;
            this.tabManualSettings.Text = "Manual Settings";
            this.tabManualSettings.UseVisualStyleBackColor = true;
            // 
            // tabAutomaticSettings
            // 
            this.tabAutomaticSettings.Controls.Add(this.grpInformation);
            this.tabAutomaticSettings.Controls.Add(this.grpPicture);
            this.tabAutomaticSettings.Controls.Add(this.cmboPlantList);
            this.tabAutomaticSettings.Location = new System.Drawing.Point(4, 25);
            this.tabAutomaticSettings.Name = "tabAutomaticSettings";
            this.tabAutomaticSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutomaticSettings.Size = new System.Drawing.Size(677, 215);
            this.tabAutomaticSettings.TabIndex = 1;
            this.tabAutomaticSettings.Text = "Automatic Settings";
            this.tabAutomaticSettings.UseVisualStyleBackColor = true;
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.lblTemperatureInfo);
            this.grpInformation.Controls.Add(this.lblDirectOrIndirectInfo);
            this.grpInformation.Controls.Add(this.lblHoursOfSunlightInfo);
            this.grpInformation.Controls.Add(this.lblWaterInfo);
            this.grpInformation.Controls.Add(this.lblTemperature);
            this.grpInformation.Controls.Add(this.lblTypeOfSunlight);
            this.grpInformation.Controls.Add(this.lblHoursOfSunlight);
            this.grpInformation.Controls.Add(this.lblDailyWater);
            this.grpInformation.Location = new System.Drawing.Point(390, 6);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(281, 200);
            this.grpInformation.TabIndex = 2;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Information";
            // 
            // lblTemperatureInfo
            // 
            this.lblTemperatureInfo.AutoSize = true;
            this.lblTemperatureInfo.Location = new System.Drawing.Point(128, 156);
            this.lblTemperatureInfo.Name = "lblTemperatureInfo";
            this.lblTemperatureInfo.Size = new System.Drawing.Size(41, 17);
            this.lblTemperatureInfo.TabIndex = 7;
            this.lblTemperatureInfo.Text = "(info)";
            this.lblTemperatureInfo.Visible = false;
            // 
            // lblDirectOrIndirectInfo
            // 
            this.lblDirectOrIndirectInfo.AutoSize = true;
            this.lblDirectOrIndirectInfo.Location = new System.Drawing.Point(128, 116);
            this.lblDirectOrIndirectInfo.Name = "lblDirectOrIndirectInfo";
            this.lblDirectOrIndirectInfo.Size = new System.Drawing.Size(41, 17);
            this.lblDirectOrIndirectInfo.TabIndex = 6;
            this.lblDirectOrIndirectInfo.Text = "(info)";
            this.lblDirectOrIndirectInfo.Visible = false;
            // 
            // lblHoursOfSunlightInfo
            // 
            this.lblHoursOfSunlightInfo.AutoSize = true;
            this.lblHoursOfSunlightInfo.Location = new System.Drawing.Point(128, 77);
            this.lblHoursOfSunlightInfo.Name = "lblHoursOfSunlightInfo";
            this.lblHoursOfSunlightInfo.Size = new System.Drawing.Size(41, 17);
            this.lblHoursOfSunlightInfo.TabIndex = 5;
            this.lblHoursOfSunlightInfo.Text = "(info)";
            this.lblHoursOfSunlightInfo.Visible = false;
            // 
            // lblWaterInfo
            // 
            this.lblWaterInfo.AutoSize = true;
            this.lblWaterInfo.Location = new System.Drawing.Point(128, 41);
            this.lblWaterInfo.Name = "lblWaterInfo";
            this.lblWaterInfo.Size = new System.Drawing.Size(41, 17);
            this.lblWaterInfo.TabIndex = 4;
            this.lblWaterInfo.Text = "(info)";
            this.lblWaterInfo.Visible = false;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(6, 156);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(94, 17);
            this.lblTemperature.TabIndex = 3;
            this.lblTemperature.Text = "Temperature:";
            // 
            // lblTypeOfSunlight
            // 
            this.lblTypeOfSunlight.AutoSize = true;
            this.lblTypeOfSunlight.Location = new System.Drawing.Point(6, 116);
            this.lblTypeOfSunlight.Name = "lblTypeOfSunlight";
            this.lblTypeOfSunlight.Size = new System.Drawing.Size(116, 17);
            this.lblTypeOfSunlight.TabIndex = 2;
            this.lblTypeOfSunlight.Text = "Direct or Indirect:";
            // 
            // lblHoursOfSunlight
            // 
            this.lblHoursOfSunlight.AutoSize = true;
            this.lblHoursOfSunlight.Location = new System.Drawing.Point(6, 77);
            this.lblHoursOfSunlight.Name = "lblHoursOfSunlight";
            this.lblHoursOfSunlight.Size = new System.Drawing.Size(121, 17);
            this.lblHoursOfSunlight.TabIndex = 1;
            this.lblHoursOfSunlight.Text = "Hours of Sunlight:";
            // 
            // lblDailyWater
            // 
            this.lblDailyWater.AutoSize = true;
            this.lblDailyWater.Location = new System.Drawing.Point(6, 41);
            this.lblDailyWater.Name = "lblDailyWater";
            this.lblDailyWater.Size = new System.Drawing.Size(85, 17);
            this.lblDailyWater.TabIndex = 0;
            this.lblDailyWater.Text = "Daily Water:";
            // 
            // cmboPlantList
            // 
            this.cmboPlantList.FormattingEnabled = true;
            this.cmboPlantList.Items.AddRange(new object[] {
            "African Violet",
            "General Fern",
            "Birds Nest Fern",
            "Canary Date Palm",
            "Aloe Vera",
            "Coral Cactus",
            "Bird of Paradise",
            "Ivy"});
            this.cmboPlantList.Location = new System.Drawing.Point(6, 6);
            this.cmboPlantList.Name = "cmboPlantList";
            this.cmboPlantList.Size = new System.Drawing.Size(172, 24);
            this.cmboPlantList.TabIndex = 0;
            this.cmboPlantList.SelectedIndexChanged += new System.EventHandler(this.cmboPlantList_SelectedIndexChanged);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM3";
            // 
            // grpPicture
            // 
            this.grpPicture.Controls.Add(this.picbxIvy);
            this.grpPicture.Controls.Add(this.picbxBirdOfParadise);
            this.grpPicture.Controls.Add(this.picbxCoralCactus);
            this.grpPicture.Controls.Add(this.picbxAloeVera);
            this.grpPicture.Controls.Add(this.picbxCanaryDatePalm);
            this.grpPicture.Controls.Add(this.picbxBirdsNestFern);
            this.grpPicture.Controls.Add(this.picbxBostonFern);
            this.grpPicture.Controls.Add(this.picbxGeneralFern);
            this.grpPicture.Controls.Add(this.picbxAfricanViolet);
            this.grpPicture.Location = new System.Drawing.Point(184, 3);
            this.grpPicture.Name = "grpPicture";
            this.grpPicture.Size = new System.Drawing.Size(200, 203);
            this.grpPicture.TabIndex = 1;
            this.grpPicture.TabStop = false;
            this.grpPicture.Text = "Picture";
            // 
            // picbxAfricanViolet
            // 
            this.picbxAfricanViolet.Image = ((System.Drawing.Image)(resources.GetObject("picbxAfricanViolet.Image")));
            this.picbxAfricanViolet.Location = new System.Drawing.Point(7, 22);
            this.picbxAfricanViolet.Name = "picbxAfricanViolet";
            this.picbxAfricanViolet.Size = new System.Drawing.Size(187, 181);
            this.picbxAfricanViolet.TabIndex = 0;
            this.picbxAfricanViolet.TabStop = false;
            this.picbxAfricanViolet.Visible = false;
            // 
            // picbxGeneralFern
            // 
            this.picbxGeneralFern.Image = ((System.Drawing.Image)(resources.GetObject("picbxGeneralFern.Image")));
            this.picbxGeneralFern.Location = new System.Drawing.Point(6, 21);
            this.picbxGeneralFern.Name = "picbxGeneralFern";
            this.picbxGeneralFern.Size = new System.Drawing.Size(187, 181);
            this.picbxGeneralFern.TabIndex = 1;
            this.picbxGeneralFern.TabStop = false;
            this.picbxGeneralFern.Visible = false;
            // 
            // picbxBostonFern
            // 
            this.picbxBostonFern.Image = ((System.Drawing.Image)(resources.GetObject("picbxBostonFern.Image")));
            this.picbxBostonFern.Location = new System.Drawing.Point(6, 21);
            this.picbxBostonFern.Name = "picbxBostonFern";
            this.picbxBostonFern.Size = new System.Drawing.Size(187, 181);
            this.picbxBostonFern.TabIndex = 2;
            this.picbxBostonFern.TabStop = false;
            this.picbxBostonFern.Visible = false;
            // 
            // picbxBirdsNestFern
            // 
            this.picbxBirdsNestFern.Image = ((System.Drawing.Image)(resources.GetObject("picbxBirdsNestFern.Image")));
            this.picbxBirdsNestFern.Location = new System.Drawing.Point(7, 21);
            this.picbxBirdsNestFern.Name = "picbxBirdsNestFern";
            this.picbxBirdsNestFern.Size = new System.Drawing.Size(187, 181);
            this.picbxBirdsNestFern.TabIndex = 3;
            this.picbxBirdsNestFern.TabStop = false;
            this.picbxBirdsNestFern.Visible = false;
            // 
            // picbxCanaryDatePalm
            // 
            this.picbxCanaryDatePalm.Image = ((System.Drawing.Image)(resources.GetObject("picbxCanaryDatePalm.Image")));
            this.picbxCanaryDatePalm.Location = new System.Drawing.Point(7, 21);
            this.picbxCanaryDatePalm.Name = "picbxCanaryDatePalm";
            this.picbxCanaryDatePalm.Size = new System.Drawing.Size(187, 181);
            this.picbxCanaryDatePalm.TabIndex = 4;
            this.picbxCanaryDatePalm.TabStop = false;
            this.picbxCanaryDatePalm.Visible = false;
            // 
            // picbxAloeVera
            // 
            this.picbxAloeVera.Image = ((System.Drawing.Image)(resources.GetObject("picbxAloeVera.Image")));
            this.picbxAloeVera.Location = new System.Drawing.Point(7, 21);
            this.picbxAloeVera.Name = "picbxAloeVera";
            this.picbxAloeVera.Size = new System.Drawing.Size(187, 181);
            this.picbxAloeVera.TabIndex = 5;
            this.picbxAloeVera.TabStop = false;
            this.picbxAloeVera.Visible = false;
            // 
            // picbxCoralCactus
            // 
            this.picbxCoralCactus.Image = ((System.Drawing.Image)(resources.GetObject("picbxCoralCactus.Image")));
            this.picbxCoralCactus.Location = new System.Drawing.Point(7, 21);
            this.picbxCoralCactus.Name = "picbxCoralCactus";
            this.picbxCoralCactus.Size = new System.Drawing.Size(187, 181);
            this.picbxCoralCactus.TabIndex = 6;
            this.picbxCoralCactus.TabStop = false;
            this.picbxCoralCactus.Visible = false;
            // 
            // picbxBirdOfParadise
            // 
            this.picbxBirdOfParadise.Image = ((System.Drawing.Image)(resources.GetObject("picbxBirdOfParadise.Image")));
            this.picbxBirdOfParadise.Location = new System.Drawing.Point(7, 21);
            this.picbxBirdOfParadise.Name = "picbxBirdOfParadise";
            this.picbxBirdOfParadise.Size = new System.Drawing.Size(187, 181);
            this.picbxBirdOfParadise.TabIndex = 7;
            this.picbxBirdOfParadise.TabStop = false;
            this.picbxBirdOfParadise.Visible = false;
            // 
            // picbxIvy
            // 
            this.picbxIvy.Image = ((System.Drawing.Image)(resources.GetObject("picbxIvy.Image")));
            this.picbxIvy.Location = new System.Drawing.Point(7, 22);
            this.picbxIvy.Name = "picbxIvy";
            this.picbxIvy.Size = new System.Drawing.Size(187, 181);
            this.picbxIvy.TabIndex = 8;
            this.picbxIvy.TabStop = false;
            this.picbxIvy.Visible = false;
            // 
            // frmPlantProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 280);
            this.Controls.Add(this.tabMainTabs);
            this.Controls.Add(this.aclblTest);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmPlantProject";
            this.Text = "PlantProject";
            this.Load += new System.EventHandler(this.frmPlantProject_Load);
            this.grpDaily.ResumeLayout(false);
            this.grpDaily.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpTypeOfSunlight.ResumeLayout(false);
            this.grpTypeOfSunlight.PerformLayout();
            this.grpTemperature.ResumeLayout(false);
            this.grpTemperature.PerformLayout();
            this.tabMainTabs.ResumeLayout(false);
            this.tabManualSettings.ResumeLayout(false);
            this.tabAutomaticSettings.ResumeLayout(false);
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.grpPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbxAfricanViolet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGeneralFern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBostonFern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBirdsNestFern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxCanaryDatePalm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAloeVera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxCoralCactus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBirdOfParadise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxIvy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkTwicePerDay;
        private System.Windows.Forms.CheckBox chkThricePerDay;
        private System.Windows.Forms.Button btnSubmit;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chkOncePerDay;
        private System.Windows.Forms.GroupBox grpDaily;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmboDaylightHours;
        private System.Windows.Forms.Label aclblTest;
        private System.Windows.Forms.GroupBox grpTypeOfSunlight;
        private System.Windows.Forms.RadioButton rdoIndirect;
        private System.Windows.Forms.RadioButton rdoDirect;
        private System.Windows.Forms.GroupBox grpTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TabControl tabMainTabs;
        private System.Windows.Forms.TabPage tabManualSettings;
        private System.Windows.Forms.TabPage tabAutomaticSettings;
        private System.Windows.Forms.ComboBox cmboPlantList;
        private System.Windows.Forms.Label aclblTestingTwo;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblTypeOfSunlight;
        private System.Windows.Forms.Label lblHoursOfSunlight;
        private System.Windows.Forms.Label lblDailyWater;
        private System.Windows.Forms.Label lblTemperatureInfo;
        private System.Windows.Forms.Label lblDirectOrIndirectInfo;
        private System.Windows.Forms.Label lblHoursOfSunlightInfo;
        private System.Windows.Forms.Label lblWaterInfo;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.GroupBox grpPicture;
        private System.Windows.Forms.PictureBox picbxAfricanViolet;
        private System.Windows.Forms.PictureBox picbxGeneralFern;
        private System.Windows.Forms.PictureBox picbxBostonFern;
        private System.Windows.Forms.PictureBox picbxBirdsNestFern;
        private System.Windows.Forms.PictureBox picbxCanaryDatePalm;
        private System.Windows.Forms.PictureBox picbxAloeVera;
        private System.Windows.Forms.PictureBox picbxCoralCactus;
        private System.Windows.Forms.PictureBox picbxBirdOfParadise;
        private System.Windows.Forms.PictureBox picbxIvy;
    }
}

