namespace serial_com_modbus
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cSTARTbits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cSTOPbits = new System.Windows.Forms.ComboBox();
            this.cPARITYbits = new System.Windows.Forms.ComboBox();
            this.cDATAbits = new System.Windows.Forms.ComboBox();
            this.cBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.txtParity = new System.Windows.Forms.Label();
            this.txtStopBits = new System.Windows.Forms.Label();
            this.txtDataBits = new System.Windows.Forms.Label();
            this.txtBaudRate = new System.Windows.Forms.Label();
            this.txtCOMPORT = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSendData = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFlowControl = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpSaved = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSrNo = new System.Windows.Forms.TextBox();
            this.cBoxType = new System.Windows.Forms.TextBox();
            this.txtSaved = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxModel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxDevice = new System.Windows.Forms.ComboBox();
            this.cBoxGas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SlvAddText = new System.Windows.Forms.Label();
            this.slvAdd = new System.Windows.Forms.NumericUpDown();
            this.txtValue = new System.Windows.Forms.NumericUpDown();
            this.txtReceiMsg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnWriteSingleRegister = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpSendData.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.grpSaved.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slvAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cSTARTbits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cSTOPbits);
            this.groupBox1.Controls.Add(this.cPARITYbits);
            this.groupBox1.Controls.Add(this.cDATAbits);
            this.groupBox1.Controls.Add(this.cBoxBAUDRATE);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Controls.Add(this.txtParity);
            this.groupBox1.Controls.Add(this.txtStopBits);
            this.groupBox1.Controls.Add(this.txtDataBits);
            this.groupBox1.Controls.Add(this.txtBaudRate);
            this.groupBox1.Controls.Add(this.txtCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // cSTARTbits
            // 
            this.cSTARTbits.FormattingEnabled = true;
            this.cSTARTbits.Items.AddRange(new object[] {
            "One ",
            "Two"});
            this.cSTARTbits.Location = new System.Drawing.Point(113, 138);
            this.cSTARTbits.Name = "cSTARTbits";
            this.cSTARTbits.Size = new System.Drawing.Size(179, 28);
            this.cSTARTbits.TabIndex = 12;
            this.cSTARTbits.Text = "One";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "START BITS";
            // 
            // cSTOPbits
            // 
            this.cSTOPbits.FormattingEnabled = true;
            this.cSTOPbits.Items.AddRange(new object[] {
            "One ",
            "Two"});
            this.cSTOPbits.Location = new System.Drawing.Point(113, 178);
            this.cSTOPbits.Name = "cSTOPbits";
            this.cSTOPbits.Size = new System.Drawing.Size(179, 28);
            this.cSTOPbits.TabIndex = 10;
            this.cSTOPbits.Text = "One";
            // 
            // cPARITYbits
            // 
            this.cPARITYbits.FormattingEnabled = true;
            this.cPARITYbits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cPARITYbits.Location = new System.Drawing.Point(113, 220);
            this.cPARITYbits.Name = "cPARITYbits";
            this.cPARITYbits.Size = new System.Drawing.Size(179, 28);
            this.cPARITYbits.TabIndex = 9;
            this.cPARITYbits.Text = "None";
            // 
            // cDATAbits
            // 
            this.cDATAbits.FormattingEnabled = true;
            this.cDATAbits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cDATAbits.Location = new System.Drawing.Point(113, 102);
            this.cDATAbits.Name = "cDATAbits";
            this.cDATAbits.Size = new System.Drawing.Size(180, 28);
            this.cDATAbits.TabIndex = 8;
            this.cDATAbits.Text = "8";
            // 
            // cBoxBAUDRATE
            // 
            this.cBoxBAUDRATE.FormattingEnabled = true;
            this.cBoxBAUDRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.cBoxBAUDRATE.Location = new System.Drawing.Point(114, 63);
            this.cBoxBAUDRATE.Name = "cBoxBAUDRATE";
            this.cBoxBAUDRATE.Size = new System.Drawing.Size(179, 28);
            this.cBoxBAUDRATE.TabIndex = 7;
            this.cBoxBAUDRATE.Text = "115200";
            this.cBoxBAUDRATE.SelectedIndexChanged += new System.EventHandler(this.cBoxBAUDRATE_SelectedIndexChanged);
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(113, 29);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(180, 28);
            this.cBoxCOMPORT.TabIndex = 6;
            this.cBoxCOMPORT.SelectedIndexChanged += new System.EventHandler(this.cBoxCOMPORT_SelectedIndexChanged);
            // 
            // txtParity
            // 
            this.txtParity.AutoSize = true;
            this.txtParity.Location = new System.Drawing.Point(6, 220);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(107, 20);
            this.txtParity.TabIndex = 4;
            this.txtParity.Text = "PARITY BITS";
            this.txtParity.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtStopBits
            // 
            this.txtStopBits.AutoSize = true;
            this.txtStopBits.Location = new System.Drawing.Point(6, 178);
            this.txtStopBits.Name = "txtStopBits";
            this.txtStopBits.Size = new System.Drawing.Size(91, 20);
            this.txtStopBits.TabIndex = 3;
            this.txtStopBits.Text = "STOP BITS";
            // 
            // txtDataBits
            // 
            this.txtDataBits.AutoSize = true;
            this.txtDataBits.Location = new System.Drawing.Point(6, 102);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(92, 20);
            this.txtDataBits.TabIndex = 2;
            this.txtDataBits.Text = "DATA BITS";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.AutoSize = true;
            this.txtBaudRate.Location = new System.Drawing.Point(6, 68);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(102, 20);
            this.txtBaudRate.TabIndex = 1;
            this.txtBaudRate.Text = "BAUD RATE";
            // 
            // txtCOMPORT
            // 
            this.txtCOMPORT.AutoSize = true;
            this.txtCOMPORT.Location = new System.Drawing.Point(6, 37);
            this.txtCOMPORT.Name = "txtCOMPORT";
            this.txtCOMPORT.Size = new System.Drawing.Size(92, 20);
            this.txtCOMPORT.TabIndex = 0;
            this.txtCOMPORT.Text = "COM PORT";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(93, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpSendData
            // 
            this.grpSendData.Controls.Add(this.button1);
            this.grpSendData.Controls.Add(this.progressBar1);
            this.grpSendData.Controls.Add(this.btnOpen);
            this.grpSendData.Controls.Add(this.btnClose);
            this.grpSendData.Location = new System.Drawing.Point(15, 286);
            this.grpSendData.Name = "grpSendData";
            this.grpSendData.Size = new System.Drawing.Size(298, 152);
            this.grpSendData.TabIndex = 3;
            this.grpSendData.TabStop = false;
            this.grpSendData.Text = "Connection";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 82);
            this.button1.TabIndex = 4;
            this.button1.Text = "Configure ramp rate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 32);
            this.progressBar1.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 30);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 34);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unit ID";
            // 
            // txtUnitID
            // 
            this.txtUnitID.Location = new System.Drawing.Point(89, 63);
            this.txtUnitID.Multiline = true;
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.Size = new System.Drawing.Size(142, 28);
            this.txtUnitID.TabIndex = 13;
            this.txtUnitID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Flow Control";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFlowControl
            // 
            this.txtFlowControl.FormattingEnabled = true;
            this.txtFlowControl.Location = new System.Drawing.Point(103, 131);
            this.txtFlowControl.Name = "txtFlowControl";
            this.txtFlowControl.Size = new System.Drawing.Size(180, 28);
            this.txtFlowControl.TabIndex = 11;
            this.txtFlowControl.SelectedIndexChanged += new System.EventHandler(this.txtFlowControl_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(99, 171);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 34);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grpSaved
            // 
            this.grpSaved.Controls.Add(this.label7);
            this.grpSaved.Controls.Add(this.txtSrNo);
            this.grpSaved.Controls.Add(this.cBoxType);
            this.grpSaved.Controls.Add(this.txtSaved);
            this.grpSaved.Controls.Add(this.btnDelete);
            this.grpSaved.Controls.Add(this.btnSave);
            this.grpSaved.Controls.Add(this.btnLoad);
            this.grpSaved.Location = new System.Drawing.Point(330, 227);
            this.grpSaved.Name = "grpSaved";
            this.grpSaved.Size = new System.Drawing.Size(458, 211);
            this.grpSaved.TabIndex = 21;
            this.grpSaved.TabStop = false;
            this.grpSaved.Text = "Saved sessions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sr.No.";
            // 
            // txtSrNo
            // 
            this.txtSrNo.Location = new System.Drawing.Point(65, 25);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.Size = new System.Drawing.Size(55, 26);
            this.txtSrNo.TabIndex = 24;
            // 
            // cBoxType
            // 
            this.cBoxType.Location = new System.Drawing.Point(135, 25);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(286, 26);
            this.cBoxType.TabIndex = 23;
            this.cBoxType.Text = "Type name...";
            this.cBoxType.TextChanged += new System.EventHandler(this.cBoxType_TextChanged);
            // 
            // txtSaved
            // 
            this.txtSaved.Location = new System.Drawing.Point(19, 62);
            this.txtSaved.Multiline = true;
            this.txtSaved.Name = "txtSaved";
            this.txtSaved.Size = new System.Drawing.Size(402, 103);
            this.txtSaved.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 34);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxModel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cBoxDevice);
            this.groupBox2.Controls.Add(this.cBoxGas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUnitID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFlowControl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(330, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 210);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Device";
            // 
            // cBoxModel
            // 
            this.cBoxModel.FormattingEnabled = true;
            this.cBoxModel.Items.AddRange(new object[] {
            "FY100",
            "FY101",
            "FY400",
            "FY600",
            "FY700",
            "FY800",
            "FY900"});
            this.cBoxModel.Location = new System.Drawing.Point(89, 165);
            this.cBoxModel.Name = "cBoxModel";
            this.cBoxModel.Size = new System.Drawing.Size(180, 28);
            this.cBoxModel.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Model ";
            // 
            // cBoxDevice
            // 
            this.cBoxDevice.FormattingEnabled = true;
            this.cBoxDevice.Items.AddRange(new object[] {
            "TAIE",
            "Alicat",
            "Other.."});
            this.cBoxDevice.Location = new System.Drawing.Point(89, 29);
            this.cBoxDevice.Name = "cBoxDevice";
            this.cBoxDevice.Size = new System.Drawing.Size(194, 28);
            this.cBoxDevice.TabIndex = 26;
            this.cBoxDevice.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cBoxGas
            // 
            this.cBoxGas.FormattingEnabled = true;
            this.cBoxGas.Items.AddRange(new object[] {
            "Air",
            "Ar Argon",
            "CH4 Methane",
            "CO Carbon Monoxide",
            "CO2 Carbon Dioxide",
            "C2H6 Ethane",
            "H2 Hydrogen"});
            this.cBoxGas.Location = new System.Drawing.Point(89, 97);
            this.cBoxGas.Name = "cBoxGas";
            this.cBoxGas.Size = new System.Drawing.Size(142, 28);
            this.cBoxGas.TabIndex = 13;
            this.cBoxGas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Device";
            this.label5.Click += new System.EventHandler(this.label5_Click_2);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(336, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 33);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SlvAddText);
            this.groupBox3.Controls.Add(this.slvAdd);
            this.groupBox3.Controls.Add(this.txtValue);
            this.groupBox3.Controls.Add(this.txtReceiMsg);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSendMsg);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnWriteSingleRegister);
            this.groupBox3.Location = new System.Drawing.Point(812, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(653, 389);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // SlvAddText
            // 
            this.SlvAddText.AutoSize = true;
            this.SlvAddText.Location = new System.Drawing.Point(21, 242);
            this.SlvAddText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SlvAddText.Name = "SlvAddText";
            this.SlvAddText.Size = new System.Drawing.Size(115, 20);
            this.SlvAddText.TabIndex = 17;
            this.SlvAddText.Text = "Slave Address:";
            this.SlvAddText.Click += new System.EventHandler(this.SlvAddText_Click);
            // 
            // slvAdd
            // 
            this.slvAdd.Location = new System.Drawing.Point(178, 240);
            this.slvAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.slvAdd.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.slvAdd.Name = "slvAdd";
            this.slvAdd.Size = new System.Drawing.Size(165, 26);
            this.slvAdd.TabIndex = 16;
            this.slvAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slvAdd.ValueChanged += new System.EventHandler(this.slvAdd_ValueChanged);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(178, 212);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValue.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(165, 26);
            this.txtValue.TabIndex = 15;
            this.txtValue.Value = new decimal(new int[] {
            1983,
            0,
            0,
            0});
            this.txtValue.ValueChanged += new System.EventHandler(this.txtValue_ValueChanged);
            // 
            // txtReceiMsg
            // 
            this.txtReceiMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiMsg.Location = new System.Drawing.Point(178, 163);
            this.txtReceiMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiMsg.Name = "txtReceiMsg";
            this.txtReceiMsg.ReadOnly = true;
            this.txtReceiMsg.Size = new System.Drawing.Size(451, 26);
            this.txtReceiMsg.TabIndex = 10;
            this.txtReceiMsg.TextChanged += new System.EventHandler(this.txtReceiMsg_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Value:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Receiver Message:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendMsg.Location = new System.Drawing.Point(178, 123);
            this.txtSendMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.ReadOnly = true;
            this.txtSendMsg.Size = new System.Drawing.Size(451, 26);
            this.txtSendMsg.TabIndex = 9;
            this.txtSendMsg.TextChanged += new System.EventHandler(this.txtSendMsg_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 128);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Send Message:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnWriteSingleRegister
            // 
            this.btnWriteSingleRegister.Location = new System.Drawing.Point(352, 203);
            this.btnWriteSingleRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWriteSingleRegister.Name = "btnWriteSingleRegister";
            this.btnWriteSingleRegister.Size = new System.Drawing.Size(279, 45);
            this.btnWriteSingleRegister.TabIndex = 13;
            this.btnWriteSingleRegister.Text = "Write Single Register";
            this.btnWriteSingleRegister.UseVisualStyleBackColor = true;
            this.btnWriteSingleRegister.Click += new System.EventHandler(this.btnWriteSingleRegister_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpSaved);
            this.Controls.Add(this.grpSendData);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSendData.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.grpSaved.ResumeLayout(false);
            this.grpSaved.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slvAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cSTOPbits;
        private System.Windows.Forms.ComboBox cPARITYbits;
        private System.Windows.Forms.ComboBox cDATAbits;
        private System.Windows.Forms.ComboBox cBoxBAUDRATE;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Label txtParity;
        private System.Windows.Forms.Label txtStopBits;
        private System.Windows.Forms.Label txtDataBits;
        private System.Windows.Forms.Label txtBaudRate;
        private System.Windows.Forms.Label txtCOMPORT;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpSendData;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtFlowControl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox grpSaved;
        private System.Windows.Forms.TextBox txtSaved;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cSTARTbits;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cBoxGas;
        private System.Windows.Forms.TextBox cBoxType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxDevice;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ComboBox cBoxModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSrNo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label SlvAddText;
        private System.Windows.Forms.NumericUpDown slvAdd;
        private System.Windows.Forms.NumericUpDown txtValue;
        private System.Windows.Forms.TextBox txtReceiMsg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnWriteSingleRegister;
    }
}

