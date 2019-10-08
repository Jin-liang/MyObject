namespace TP_TestFile
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chbTouch = new System.Windows.Forms.ComboBox();
            this.chbProtocol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtI2CSpeed = new System.Windows.Forms.ComboBox();
            this.txtVDD1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVDD15 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVDD09 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVDD11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProgramming = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBSOFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTestPhase = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFWFile = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.chkTestSelection = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.txt2DTx_Number = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt2DRx_Number = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTx_Number = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRx_Number = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFlow = new System.Windows.Forms.CheckedListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.IntVDD1 = new System.Windows.Forms.NumericUpDown();
            this.intVDD15 = new System.Windows.Forms.NumericUpDown();
            this.intVDD09 = new System.Windows.Forms.NumericUpDown();
            this.intVDD11 = new System.Windows.Forms.NumericUpDown();
            this.int2DRx_Number = new System.Windows.Forms.NumericUpDown();
            this.int2DTx_Number = new System.Windows.Forms.NumericUpDown();
            this.intRx_Number = new System.Windows.Forms.NumericUpDown();
            this.intTx_Number = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntVDD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intVDD15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intVDD09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intVDD11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int2DRx_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int2DTx_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intRx_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intTx_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "DSO|TSR|Py File Path|SPI Flash Path";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(35, 54);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(679, 21);
            this.txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(35, 122);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(679, 21);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.Text = "D:\\TP_TESTER\\CFG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "CFG File OutPut Folder";
            // 
            // btnRead
            // 
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Location = new System.Drawing.Point(768, 54);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(174, 35);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read Project Settings";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.CFunction);
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(768, 119);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(174, 35);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate TESTER CFG";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.CFunction);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Touch Solution";
            // 
            // chbTouch
            // 
            this.chbTouch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chbTouch.FormattingEnabled = true;
            this.chbTouch.Location = new System.Drawing.Point(36, 188);
            this.chbTouch.Name = "chbTouch";
            this.chbTouch.Size = new System.Drawing.Size(124, 20);
            this.chbTouch.TabIndex = 7;
            // 
            // chbProtocol
            // 
            this.chbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chbProtocol.FormattingEnabled = true;
            this.chbProtocol.Location = new System.Drawing.Point(36, 248);
            this.chbProtocol.Name = "chbProtocol";
            this.chbProtocol.Size = new System.Drawing.Size(124, 20);
            this.chbProtocol.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Protocol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "I2C Address(Hex)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "I2C Speed";
            // 
            // txtI2CSpeed
            // 
            this.txtI2CSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtI2CSpeed.FormattingEnabled = true;
            this.txtI2CSpeed.Location = new System.Drawing.Point(36, 362);
            this.txtI2CSpeed.Name = "txtI2CSpeed";
            this.txtI2CSpeed.Size = new System.Drawing.Size(124, 20);
            this.txtI2CSpeed.TabIndex = 14;
            // 
            // txtVDD1
            // 
            this.txtVDD1.Location = new System.Drawing.Point(226, 188);
            this.txtVDD1.Name = "txtVDD1";
            this.txtVDD1.ReadOnly = true;
            this.txtVDD1.Size = new System.Drawing.Size(124, 21);
            this.txtVDD1.TabIndex = 16;
            this.txtVDD1.Text = "3000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "VDD(PIN_01)";
            // 
            // txtVDD15
            // 
            this.txtVDD15.Location = new System.Drawing.Point(226, 248);
            this.txtVDD15.Name = "txtVDD15";
            this.txtVDD15.ReadOnly = true;
            this.txtVDD15.Size = new System.Drawing.Size(124, 21);
            this.txtVDD15.TabIndex = 18;
            this.txtVDD15.Text = "1800";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "VDD(PIN_15)";
            // 
            // txtVDD09
            // 
            this.txtVDD09.Location = new System.Drawing.Point(226, 303);
            this.txtVDD09.Name = "txtVDD09";
            this.txtVDD09.ReadOnly = true;
            this.txtVDD09.Size = new System.Drawing.Size(124, 21);
            this.txtVDD09.TabIndex = 20;
            this.txtVDD09.Text = "1800";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "VDD(PIN_09)";
            // 
            // txtVDD11
            // 
            this.txtVDD11.Location = new System.Drawing.Point(226, 362);
            this.txtVDD11.Name = "txtVDD11";
            this.txtVDD11.ReadOnly = true;
            this.txtVDD11.Size = new System.Drawing.Size(124, 21);
            this.txtVDD11.TabIndex = 22;
            this.txtVDD11.Text = "3300";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "VDD(PIN_11)";
            // 
            // txtProgramming
            // 
            this.txtProgramming.Location = new System.Drawing.Point(593, 362);
            this.txtProgramming.Name = "txtProgramming";
            this.txtProgramming.ReadOnly = true;
            this.txtProgramming.Size = new System.Drawing.Size(124, 21);
            this.txtProgramming.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(591, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "Programming";
            // 
            // txtBSOFile
            // 
            this.txtBSOFile.Location = new System.Drawing.Point(593, 303);
            this.txtBSOFile.Name = "txtBSOFile";
            this.txtBSOFile.ReadOnly = true;
            this.txtBSOFile.Size = new System.Drawing.Size(124, 21);
            this.txtBSOFile.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(591, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "DSO File Version";
            // 
            // txtTestPhase
            // 
            this.txtTestPhase.Location = new System.Drawing.Point(593, 248);
            this.txtTestPhase.Name = "txtTestPhase";
            this.txtTestPhase.ReadOnly = true;
            this.txtTestPhase.Size = new System.Drawing.Size(124, 21);
            this.txtTestPhase.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(591, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "Test Phase";
            // 
            // txtSolution
            // 
            this.txtSolution.Location = new System.Drawing.Point(593, 188);
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.ReadOnly = true;
            this.txtSolution.Size = new System.Drawing.Size(124, 21);
            this.txtSolution.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(591, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "Solution Name";
            // 
            // txtFWFile
            // 
            this.txtFWFile.Location = new System.Drawing.Point(36, 413);
            this.txtFWFile.Name = "txtFWFile";
            this.txtFWFile.ReadOnly = true;
            this.txtFWFile.Size = new System.Drawing.Size(681, 21);
            this.txtFWFile.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 393);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "FW File";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 451);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 33;
            this.label16.Text = "Rx Mapping";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(39, 479);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(681, 21);
            this.textBox13.TabIndex = 34;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(39, 542);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(681, 21);
            this.textBox14.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 514);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 35;
            this.label17.Text = "Tx Mapping";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 575);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 37;
            this.label18.Text = "Status";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(36, 600);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(681, 67);
            this.textBox15.TabIndex = 38;
            // 
            // chkTestSelection
            // 
            this.chkTestSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTestSelection.FormattingEnabled = true;
            this.chkTestSelection.Location = new System.Drawing.Point(3, 17);
            this.chkTestSelection.Name = "chkTestSelection";
            this.chkTestSelection.Size = new System.Drawing.Size(71, 284);
            this.chkTestSelection.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTestSelection);
            this.groupBox1.Location = new System.Drawing.Point(806, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(77, 304);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Selection";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Disable Startup Confirmation",
            "Enable Test Log",
            "Enable Networtk"});
            this.checkedListBox2.Location = new System.Drawing.Point(948, 54);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(199, 52);
            this.checkedListBox2.TabIndex = 41;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            this.checkedListBox2.SelectedValueChanged += new System.EventHandler(this.checkedListBox2_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(950, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 70);
            this.panel1.TabIndex = 42;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(149, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Enable Serial Control";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Enable Barcode";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Disable Serial Port";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Image = global::TP_TestFile.Properties.Resources.folder_open;
            this.btnIn.Location = new System.Drawing.Point(720, 53);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(42, 21);
            this.btnIn.TabIndex = 43;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.CFunction);
            // 
            // btnOut
            // 
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Image = global::TP_TestFile.Properties.Resources.folder_open;
            this.btnOut.Location = new System.Drawing.Point(720, 121);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(42, 21);
            this.btnOut.TabIndex = 44;
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.CFunction);
            // 
            // txt2DTx_Number
            // 
            this.txt2DTx_Number.Location = new System.Drawing.Point(416, 248);
            this.txt2DTx_Number.Name = "txt2DTx_Number";
            this.txt2DTx_Number.ReadOnly = true;
            this.txt2DTx_Number.Size = new System.Drawing.Size(124, 21);
            this.txt2DTx_Number.TabIndex = 52;
            this.txt2DTx_Number.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(414, 228);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 51;
            this.label19.Text = "2D Tx Number";
            // 
            // txt2DRx_Number
            // 
            this.txt2DRx_Number.Location = new System.Drawing.Point(416, 188);
            this.txt2DRx_Number.Name = "txt2DRx_Number";
            this.txt2DRx_Number.ReadOnly = true;
            this.txt2DRx_Number.Size = new System.Drawing.Size(124, 21);
            this.txt2DRx_Number.TabIndex = 50;
            this.txt2DRx_Number.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(414, 173);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 49;
            this.label20.Text = "2D Rx Number";
            // 
            // txtTx_Number
            // 
            this.txtTx_Number.Location = new System.Drawing.Point(416, 362);
            this.txtTx_Number.Name = "txtTx_Number";
            this.txtTx_Number.ReadOnly = true;
            this.txtTx_Number.Size = new System.Drawing.Size(124, 21);
            this.txtTx_Number.TabIndex = 48;
            this.txtTx_Number.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(414, 339);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 47;
            this.label21.Text = "Tx Number";
            // 
            // txtRx_Number
            // 
            this.txtRx_Number.Location = new System.Drawing.Point(416, 303);
            this.txtRx_Number.Name = "txtRx_Number";
            this.txtRx_Number.ReadOnly = true;
            this.txtRx_Number.Size = new System.Drawing.Size(124, 21);
            this.txtRx_Number.TabIndex = 46;
            this.txtRx_Number.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(414, 285);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 45;
            this.label22.Text = "Rx Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFlow);
            this.groupBox2.Location = new System.Drawing.Point(768, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 465);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TestFlow";
            // 
            // chkFlow
            // 
            this.chkFlow.CheckOnClick = true;
            this.chkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFlow.FormattingEnabled = true;
            this.chkFlow.Location = new System.Drawing.Point(3, 17);
            this.chkFlow.Name = "chkFlow";
            this.chkFlow.Size = new System.Drawing.Size(328, 445);
            this.chkFlow.TabIndex = 39;
            this.chkFlow.SelectedIndexChanged += new System.EventHandler(this.chkFlow_SelectedIndexChanged);
            // 
            // btnGo
            // 
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Location = new System.Drawing.Point(932, 374);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(29, 35);
            this.btnGo.TabIndex = 54;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.CFunction);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Hexadecimal = true;
            this.numericUpDown1.Location = new System.Drawing.Point(39, 304);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 21);
            this.numericUpDown1.TabIndex = 55;
            // 
            // IntVDD1
            // 
            this.IntVDD1.Location = new System.Drawing.Point(226, 189);
            this.IntVDD1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.IntVDD1.Name = "IntVDD1";
            this.IntVDD1.Size = new System.Drawing.Size(124, 21);
            this.IntVDD1.TabIndex = 56;
            this.IntVDD1.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // intVDD15
            // 
            this.intVDD15.Location = new System.Drawing.Point(227, 248);
            this.intVDD15.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.intVDD15.Name = "intVDD15";
            this.intVDD15.Size = new System.Drawing.Size(123, 21);
            this.intVDD15.TabIndex = 57;
            this.intVDD15.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // intVDD09
            // 
            this.intVDD09.Location = new System.Drawing.Point(227, 303);
            this.intVDD09.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.intVDD09.Name = "intVDD09";
            this.intVDD09.Size = new System.Drawing.Size(123, 21);
            this.intVDD09.TabIndex = 58;
            this.intVDD09.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // intVDD11
            // 
            this.intVDD11.Location = new System.Drawing.Point(226, 363);
            this.intVDD11.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.intVDD11.Name = "intVDD11";
            this.intVDD11.Size = new System.Drawing.Size(124, 21);
            this.intVDD11.TabIndex = 59;
            this.intVDD11.Value = new decimal(new int[] {
            3300,
            0,
            0,
            0});
            // 
            // int2DRx_Number
            // 
            this.int2DRx_Number.Location = new System.Drawing.Point(417, 189);
            this.int2DRx_Number.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.int2DRx_Number.Name = "int2DRx_Number";
            this.int2DRx_Number.Size = new System.Drawing.Size(124, 21);
            this.int2DRx_Number.TabIndex = 60;
            // 
            // int2DTx_Number
            // 
            this.int2DTx_Number.Location = new System.Drawing.Point(416, 247);
            this.int2DTx_Number.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.int2DTx_Number.Name = "int2DTx_Number";
            this.int2DTx_Number.Size = new System.Drawing.Size(124, 21);
            this.int2DTx_Number.TabIndex = 61;
            // 
            // intRx_Number
            // 
            this.intRx_Number.Location = new System.Drawing.Point(416, 304);
            this.intRx_Number.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.intRx_Number.Name = "intRx_Number";
            this.intRx_Number.Size = new System.Drawing.Size(124, 21);
            this.intRx_Number.TabIndex = 62;
            // 
            // intTx_Number
            // 
            this.intTx_Number.Location = new System.Drawing.Point(416, 363);
            this.intTx_Number.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.intTx_Number.Name = "intTx_Number";
            this.intTx_Number.Size = new System.Drawing.Size(124, 21);
            this.intTx_Number.TabIndex = 63;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 696);
            this.Controls.Add(this.intTx_Number);
            this.Controls.Add(this.intRx_Number);
            this.Controls.Add(this.int2DTx_Number);
            this.Controls.Add(this.int2DRx_Number);
            this.Controls.Add(this.intVDD11);
            this.Controls.Add(this.intVDD09);
            this.Controls.Add(this.intVDD15);
            this.Controls.Add(this.IntVDD1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt2DTx_Number);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt2DRx_Number);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtTx_Number);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtRx_Number);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtFWFile);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtProgramming);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBSOFile);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTestPhase);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSolution);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtVDD11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVDD09);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVDD15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVDD1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtI2CSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chbProtocol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbTouch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP-TESTER CFG V1.0.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntVDD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intVDD15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intVDD09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intVDD11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int2DRx_Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int2DTx_Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intRx_Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intTx_Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox chbTouch;
        private System.Windows.Forms.ComboBox chbProtocol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtI2CSpeed;
        private System.Windows.Forms.TextBox txtVDD1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVDD15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVDD09;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVDD11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProgramming;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBSOFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTestPhase;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFWFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.CheckedListBox chkTestSelection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txt2DTx_Number;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt2DRx_Number;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTx_Number;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRx_Number;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox chkFlow;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown IntVDD1;
        private System.Windows.Forms.NumericUpDown intVDD15;
        private System.Windows.Forms.NumericUpDown intVDD09;
        private System.Windows.Forms.NumericUpDown intVDD11;
        private System.Windows.Forms.NumericUpDown int2DRx_Number;
        private System.Windows.Forms.NumericUpDown int2DTx_Number;
        private System.Windows.Forms.NumericUpDown intRx_Number;
        private System.Windows.Forms.NumericUpDown intTx_Number;
    }
}

