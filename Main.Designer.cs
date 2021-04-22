namespace JungleDiamond
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fLabel = new System.Windows.Forms.Label();
            this.functionBox = new System.Windows.Forms.ComboBox();
            this.scriptList = new System.Windows.Forms.ListView();
            this.nbCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.argCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activePanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.LoadBox = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadText = new System.Windows.Forms.TextBox();
            this.WaitBox = new System.Windows.Forms.GroupBox();
            this.waitDuration = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CopyBox = new System.Windows.Forms.GroupBox();
            this.btnBrowseDestinationTransfer = new System.Windows.Forms.Button();
            this.btnBrowseSourceTransfer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.destText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.srcText = new System.Windows.Forms.TextBox();
            this.saveBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveText = new System.Windows.Forms.TextBox();
            this.generateScript = new System.Windows.Forms.Button();
            this.RecalibBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.InteractBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.compoundRecalText = new System.Windows.Forms.TextBox();
            this.AddVcBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.compoundVCText = new System.Windows.Forms.TextBox();
            this.CCSBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ccsText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.compoundCCSText = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.resetButton = new System.Windows.Forms.Button();
            this.RecalBlendBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.compoundBlendText = new System.Windows.Forms.TextBox();
            this.ExportBox = new System.Windows.Forms.GroupBox();
            this.btnSelectExportDestination = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.expName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.expPath = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.expFormat = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.compoundExpText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoadBox.SuspendLayout();
            this.WaitBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitDuration)).BeginInit();
            this.CopyBox.SuspendLayout();
            this.saveBox.SuspendLayout();
            this.RecalibBox.SuspendLayout();
            this.AddVcBox.SuspendLayout();
            this.CCSBox.SuspendLayout();
            this.RecalBlendBox.SuspendLayout();
            this.ExportBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // fLabel
            // 
            this.fLabel.AutoSize = true;
            this.fLabel.Location = new System.Drawing.Point(49, 142);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(53, 13);
            this.fLabel.TabIndex = 5;
            this.fLabel.Text = "Function";
            // 
            // functionBox
            // 
            this.functionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.functionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.functionBox.ForeColor = System.Drawing.SystemColors.Window;
            this.functionBox.FormattingEnabled = true;
            this.functionBox.Items.AddRange(new object[] {
            "Load",
            "Save",
            "Copy/transfer",
            "Wait",
            "Recalibrate",
            "Recalculate Blending [3D]",
            "Add VC to display Geometry",
            "Custom content space conversion",
            "Export"});
            this.functionBox.Location = new System.Drawing.Point(49, 159);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(228, 21);
            this.functionBox.TabIndex = 6;
            this.functionBox.SelectedIndexChanged += new System.EventHandler(this.functionBox_indexChanged);
            // 
            // scriptList
            // 
            this.scriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(160)))));
            this.scriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nbCol,
            this.nameCol,
            this.argCol});
            this.scriptList.ForeColor = System.Drawing.SystemColors.Window;
            this.scriptList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.scriptList.HideSelection = false;
            this.scriptList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.scriptList.Location = new System.Drawing.Point(430, 24);
            this.scriptList.Name = "scriptList";
            this.scriptList.Size = new System.Drawing.Size(610, 366);
            this.scriptList.TabIndex = 12;
            this.scriptList.TabStop = false;
            this.scriptList.UseCompatibleStateImageBehavior = false;
            this.scriptList.View = System.Windows.Forms.View.Details;
            // 
            // nbCol
            // 
            this.nbCol.Text = " Nb";
            this.nbCol.Width = 36;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Name";
            this.nameCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameCol.Width = 163;
            // 
            // argCol
            // 
            this.argCol.Text = "Arguments";
            this.argCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.argCol.Width = 410;
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.Transparent;
            this.activePanel.Location = new System.Drawing.Point(49, 197);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(267, 193);
            this.activePanel.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.ForestGreen;
            this.addButton.Enabled = false;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(340, 224);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(56, 44);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add ";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_click);
            // 
            // LoadBox
            // 
            this.LoadBox.Controls.Add(this.btnLoad);
            this.LoadBox.Controls.Add(this.label3);
            this.LoadBox.Controls.Add(this.label2);
            this.LoadBox.Controls.Add(this.loadText);
            this.LoadBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LoadBox.Location = new System.Drawing.Point(847, 481);
            this.LoadBox.Name = "LoadBox";
            this.LoadBox.Size = new System.Drawing.Size(239, 89);
            this.LoadBox.TabIndex = 14;
            this.LoadBox.TabStop = false;
            this.LoadBox.Text = "Load";
            this.LoadBox.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(169, 38);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(57, 22);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Browse";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(.sps)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "File ";
            // 
            // loadText
            // 
            this.loadText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.loadText.ForeColor = System.Drawing.SystemColors.Window;
            this.loadText.Location = new System.Drawing.Point(15, 37);
            this.loadText.Name = "loadText";
            this.loadText.Size = new System.Drawing.Size(146, 22);
            this.loadText.TabIndex = 0;
            // 
            // WaitBox
            // 
            this.WaitBox.Controls.Add(this.waitDuration);
            this.WaitBox.Controls.Add(this.label8);
            this.WaitBox.Controls.Add(this.label9);
            this.WaitBox.ForeColor = System.Drawing.SystemColors.Window;
            this.WaitBox.Location = new System.Drawing.Point(49, 632);
            this.WaitBox.Name = "WaitBox";
            this.WaitBox.Size = new System.Drawing.Size(123, 90);
            this.WaitBox.TabIndex = 15;
            this.WaitBox.TabStop = false;
            this.WaitBox.Text = "Wait";
            this.WaitBox.Visible = false;
            // 
            // waitDuration
            // 
            this.waitDuration.Location = new System.Drawing.Point(15, 51);
            this.waitDuration.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.waitDuration.Name = "waitDuration";
            this.waitDuration.Size = new System.Drawing.Size(56, 22);
            this.waitDuration.TabIndex = 22;
            this.waitDuration.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Time";
            // 
            // CopyBox
            // 
            this.CopyBox.Controls.Add(this.btnBrowseDestinationTransfer);
            this.CopyBox.Controls.Add(this.btnBrowseSourceTransfer);
            this.CopyBox.Controls.Add(this.label6);
            this.CopyBox.Controls.Add(this.label7);
            this.CopyBox.Controls.Add(this.destText);
            this.CopyBox.Controls.Add(this.label4);
            this.CopyBox.Controls.Add(this.label5);
            this.CopyBox.Controls.Add(this.srcText);
            this.CopyBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CopyBox.Location = new System.Drawing.Point(49, 463);
            this.CopyBox.Name = "CopyBox";
            this.CopyBox.Size = new System.Drawing.Size(224, 141);
            this.CopyBox.TabIndex = 16;
            this.CopyBox.TabStop = false;
            this.CopyBox.Text = "Copy/transfer";
            this.CopyBox.Visible = false;
            // 
            // btnBrowseDestinationTransfer
            // 
            this.btnBrowseDestinationTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseDestinationTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseDestinationTransfer.Location = new System.Drawing.Point(157, 93);
            this.btnBrowseDestinationTransfer.Name = "btnBrowseDestinationTransfer";
            this.btnBrowseDestinationTransfer.Size = new System.Drawing.Size(61, 23);
            this.btnBrowseDestinationTransfer.TabIndex = 13;
            this.btnBrowseDestinationTransfer.Text = "Browse";
            this.btnBrowseDestinationTransfer.UseVisualStyleBackColor = false;
            this.btnBrowseDestinationTransfer.Click += new System.EventHandler(this.btnBrowseDestinationTransfer_Click);
            // 
            // btnBrowseSourceTransfer
            // 
            this.btnBrowseSourceTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseSourceTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSourceTransfer.Location = new System.Drawing.Point(157, 44);
            this.btnBrowseSourceTransfer.Name = "btnBrowseSourceTransfer";
            this.btnBrowseSourceTransfer.Size = new System.Drawing.Size(61, 23);
            this.btnBrowseSourceTransfer.TabIndex = 12;
            this.btnBrowseSourceTransfer.Text = "Browse";
            this.btnBrowseSourceTransfer.UseVisualStyleBackColor = false;
            this.btnBrowseSourceTransfer.Click += new System.EventHandler(this.btnBrowseSourceTransfer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(.sps)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Destination";
            // 
            // destText
            // 
            this.destText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.destText.ForeColor = System.Drawing.SystemColors.Window;
            this.destText.Location = new System.Drawing.Point(15, 95);
            this.destText.Name = "destText";
            this.destText.Size = new System.Drawing.Size(136, 22);
            this.destText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(.sps)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Source";
            // 
            // srcText
            // 
            this.srcText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.srcText.ForeColor = System.Drawing.SystemColors.Window;
            this.srcText.Location = new System.Drawing.Point(15, 46);
            this.srcText.Name = "srcText";
            this.srcText.Size = new System.Drawing.Size(136, 22);
            this.srcText.TabIndex = 0;
            // 
            // saveBox
            // 
            this.saveBox.Controls.Add(this.label1);
            this.saveBox.Controls.Add(this.label10);
            this.saveBox.Controls.Add(this.saveText);
            this.saveBox.ForeColor = System.Drawing.SystemColors.Window;
            this.saveBox.Location = new System.Drawing.Point(327, 668);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(232, 84);
            this.saveBox.TabIndex = 15;
            this.saveBox.TabStop = false;
            this.saveBox.Text = "Save";
            this.saveBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "(.sps)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "File";
            // 
            // saveText
            // 
            this.saveText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.saveText.ForeColor = System.Drawing.SystemColors.Window;
            this.saveText.Location = new System.Drawing.Point(15, 38);
            this.saveText.Name = "saveText";
            this.saveText.Size = new System.Drawing.Size(136, 22);
            this.saveText.TabIndex = 0;
            // 
            // generateScript
            // 
            this.generateScript.BackColor = System.Drawing.Color.Transparent;
            this.generateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateScript.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateScript.ForeColor = System.Drawing.Color.White;
            this.generateScript.Location = new System.Drawing.Point(927, 409);
            this.generateScript.Name = "generateScript";
            this.generateScript.Size = new System.Drawing.Size(113, 44);
            this.generateScript.TabIndex = 17;
            this.generateScript.Text = "Generate";
            this.generateScript.UseVisualStyleBackColor = false;
            this.generateScript.Click += new System.EventHandler(this.generateScript_Click);
            // 
            // RecalibBox
            // 
            this.RecalibBox.Controls.Add(this.label11);
            this.RecalibBox.Controls.Add(this.InteractBox);
            this.RecalibBox.Controls.Add(this.label12);
            this.RecalibBox.Controls.Add(this.compoundRecalText);
            this.RecalibBox.ForeColor = System.Drawing.SystemColors.Window;
            this.RecalibBox.Location = new System.Drawing.Point(327, 463);
            this.RecalibBox.Name = "RecalibBox";
            this.RecalibBox.Size = new System.Drawing.Size(229, 107);
            this.RecalibBox.TabIndex = 16;
            this.RecalibBox.TabStop = false;
            this.RecalibBox.Text = "Recalibrate";
            this.RecalibBox.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Interaction Level";
            // 
            // InteractBox
            // 
            this.InteractBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.InteractBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InteractBox.ForeColor = System.Drawing.SystemColors.Window;
            this.InteractBox.FormattingEnabled = true;
            this.InteractBox.Items.AddRange(new object[] {
            "None",
            "Minimal",
            "Reduced",
            "All"});
            this.InteractBox.Location = new System.Drawing.Point(120, 69);
            this.InteractBox.Name = "InteractBox";
            this.InteractBox.Size = new System.Drawing.Size(103, 21);
            this.InteractBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Compound Name";
            // 
            // compoundRecalText
            // 
            this.compoundRecalText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.compoundRecalText.ForeColor = System.Drawing.SystemColors.Window;
            this.compoundRecalText.Location = new System.Drawing.Point(15, 41);
            this.compoundRecalText.Name = "compoundRecalText";
            this.compoundRecalText.Size = new System.Drawing.Size(206, 22);
            this.compoundRecalText.TabIndex = 0;
            // 
            // AddVcBox
            // 
            this.AddVcBox.Controls.Add(this.label14);
            this.AddVcBox.Controls.Add(this.compoundVCText);
            this.AddVcBox.ForeColor = System.Drawing.SystemColors.Window;
            this.AddVcBox.Location = new System.Drawing.Point(327, 586);
            this.AddVcBox.Name = "AddVcBox";
            this.AddVcBox.Size = new System.Drawing.Size(229, 75);
            this.AddVcBox.TabIndex = 17;
            this.AddVcBox.TabStop = false;
            this.AddVcBox.Text = "Add VC to display geometry";
            this.AddVcBox.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Compound Name";
            // 
            // compoundVCText
            // 
            this.compoundVCText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.compoundVCText.ForeColor = System.Drawing.SystemColors.Window;
            this.compoundVCText.Location = new System.Drawing.Point(15, 42);
            this.compoundVCText.Name = "compoundVCText";
            this.compoundVCText.Size = new System.Drawing.Size(136, 22);
            this.compoundVCText.TabIndex = 0;
            // 
            // CCSBox
            // 
            this.CCSBox.Controls.Add(this.label15);
            this.CCSBox.Controls.Add(this.ccsText);
            this.CCSBox.Controls.Add(this.label13);
            this.CCSBox.Controls.Add(this.compoundCCSText);
            this.CCSBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CCSBox.Location = new System.Drawing.Point(849, 583);
            this.CCSBox.Name = "CCSBox";
            this.CCSBox.Size = new System.Drawing.Size(229, 125);
            this.CCSBox.TabIndex = 18;
            this.CCSBox.TabStop = false;
            this.CCSBox.Text = "Custom Content Space";
            this.CCSBox.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Content Space";
            // 
            // ccsText
            // 
            this.ccsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ccsText.ForeColor = System.Drawing.SystemColors.Window;
            this.ccsText.Location = new System.Drawing.Point(13, 90);
            this.ccsText.Name = "ccsText";
            this.ccsText.Size = new System.Drawing.Size(206, 22);
            this.ccsText.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Compound Name";
            // 
            // compoundCCSText
            // 
            this.compoundCCSText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.compoundCCSText.ForeColor = System.Drawing.SystemColors.Window;
            this.compoundCCSText.Location = new System.Drawing.Point(13, 45);
            this.compoundCCSText.Name = "compoundCCSText";
            this.compoundCCSText.Size = new System.Drawing.Size(206, 22);
            this.compoundCCSText.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "ini";
            this.saveFileDialog1.FileName = "MyScript";
            this.saveFileDialog1.Filter = "VIOSO script |*.ini";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.resetButton.Location = new System.Drawing.Point(849, 409);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(54, 44);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // RecalBlendBox
            // 
            this.RecalBlendBox.Controls.Add(this.label16);
            this.RecalBlendBox.Controls.Add(this.compoundBlendText);
            this.RecalBlendBox.ForeColor = System.Drawing.SystemColors.Window;
            this.RecalBlendBox.Location = new System.Drawing.Point(587, 470);
            this.RecalBlendBox.Name = "RecalBlendBox";
            this.RecalBlendBox.Size = new System.Drawing.Size(229, 75);
            this.RecalBlendBox.TabIndex = 18;
            this.RecalBlendBox.TabStop = false;
            this.RecalBlendBox.Text = "Recalculate Blending [3D]";
            this.RecalBlendBox.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Compound Name";
            // 
            // compoundBlendText
            // 
            this.compoundBlendText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.compoundBlendText.ForeColor = System.Drawing.SystemColors.Window;
            this.compoundBlendText.Location = new System.Drawing.Point(15, 42);
            this.compoundBlendText.Name = "compoundBlendText";
            this.compoundBlendText.Size = new System.Drawing.Size(206, 22);
            this.compoundBlendText.TabIndex = 0;
            // 
            // ExportBox
            // 
            this.ExportBox.Controls.Add(this.btnSelectExportDestination);
            this.ExportBox.Controls.Add(this.label19);
            this.ExportBox.Controls.Add(this.expName);
            this.ExportBox.Controls.Add(this.label20);
            this.ExportBox.Controls.Add(this.expPath);
            this.ExportBox.Controls.Add(this.label18);
            this.ExportBox.Controls.Add(this.expFormat);
            this.ExportBox.Controls.Add(this.label17);
            this.ExportBox.Controls.Add(this.compoundExpText);
            this.ExportBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ExportBox.Location = new System.Drawing.Point(587, 561);
            this.ExportBox.Name = "ExportBox";
            this.ExportBox.Size = new System.Drawing.Size(229, 189);
            this.ExportBox.TabIndex = 19;
            this.ExportBox.TabStop = false;
            this.ExportBox.Text = "Export";
            this.ExportBox.Visible = false;
            // 
            // btnSelectExportDestination
            // 
            this.btnSelectExportDestination.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectExportDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectExportDestination.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectExportDestination.ForeColor = System.Drawing.Color.White;
            this.btnSelectExportDestination.Location = new System.Drawing.Point(149, 147);
            this.btnSelectExportDestination.Name = "btnSelectExportDestination";
            this.btnSelectExportDestination.Size = new System.Drawing.Size(75, 23);
            this.btnSelectExportDestination.TabIndex = 16;
            this.btnSelectExportDestination.Text = "Select";
            this.btnSelectExportDestination.UseVisualStyleBackColor = false;
            this.btnSelectExportDestination.Click += new System.EventHandler(this.btnSelectExportDestination_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "File Name";
            // 
            // expName
            // 
            this.expName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.expName.ForeColor = System.Drawing.SystemColors.Window;
            this.expName.Location = new System.Drawing.Point(17, 100);
            this.expName.Name = "expName";
            this.expName.Size = new System.Drawing.Size(158, 22);
            this.expName.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 128);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Destination";
            // 
            // expPath
            // 
            this.expPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.expPath.ForeColor = System.Drawing.SystemColors.Window;
            this.expPath.Location = new System.Drawing.Point(15, 147);
            this.expPath.Name = "expPath";
            this.expPath.Size = new System.Drawing.Size(128, 22);
            this.expPath.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(178, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Format";
            // 
            // expFormat
            // 
            this.expFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.expFormat.ForeColor = System.Drawing.SystemColors.Window;
            this.expFormat.Location = new System.Drawing.Point(181, 100);
            this.expFormat.Name = "expFormat";
            this.expFormat.Size = new System.Drawing.Size(40, 22);
            this.expFormat.TabIndex = 8;
            this.expFormat.Text = "vwf";
            this.expFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Compound Name";
            // 
            // compoundExpText
            // 
            this.compoundExpText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.compoundExpText.ForeColor = System.Drawing.SystemColors.Window;
            this.compoundExpText.Location = new System.Drawing.Point(15, 42);
            this.compoundExpText.Name = "compoundExpText";
            this.compoundExpText.Size = new System.Drawing.Size(206, 22);
            this.compoundExpText.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VIOSOScriptGenerator.Properties.Resources.Logo_VIOSO_trans;
            this.pictureBox1.Location = new System.Drawing.Point(67, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.titleLabel.Location = new System.Drawing.Point(102, 81);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(186, 20);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "SCRIPT GENERATOR V0000";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1058, 466);
            this.Controls.Add(this.LoadBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExportBox);
            this.Controls.Add(this.RecalBlendBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.CCSBox);
            this.Controls.Add(this.AddVcBox);
            this.Controls.Add(this.RecalibBox);
            this.Controls.Add(this.generateScript);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.WaitBox);
            this.Controls.Add(this.CopyBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.fLabel);
            this.Controls.Add(this.scriptList);
            this.Controls.Add(this.functionBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.Main_Load);
            this.LoadBox.ResumeLayout(false);
            this.LoadBox.PerformLayout();
            this.WaitBox.ResumeLayout(false);
            this.WaitBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitDuration)).EndInit();
            this.CopyBox.ResumeLayout(false);
            this.CopyBox.PerformLayout();
            this.saveBox.ResumeLayout(false);
            this.saveBox.PerformLayout();
            this.RecalibBox.ResumeLayout(false);
            this.RecalibBox.PerformLayout();
            this.AddVcBox.ResumeLayout(false);
            this.AddVcBox.PerformLayout();
            this.CCSBox.ResumeLayout(false);
            this.CCSBox.PerformLayout();
            this.RecalBlendBox.ResumeLayout(false);
            this.RecalBlendBox.PerformLayout();
            this.ExportBox.ResumeLayout(false);
            this.ExportBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.ComboBox functionBox;
        private System.Windows.Forms.ListView scriptList;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader argCol;
        private System.Windows.Forms.ColumnHeader nbCol;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox LoadBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loadText;
        private System.Windows.Forms.GroupBox WaitBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.GroupBox CopyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox destText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox srcText;
        private System.Windows.Forms.GroupBox saveBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox saveText;
        private System.Windows.Forms.Button generateScript;
        private System.Windows.Forms.GroupBox RecalibBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox compoundRecalText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox InteractBox;
        private System.Windows.Forms.GroupBox AddVcBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox compoundVCText;
        private System.Windows.Forms.GroupBox CCSBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ccsText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox compoundCCSText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox RecalBlendBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox compoundBlendText;
        private System.Windows.Forms.GroupBox ExportBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox expPath;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox expFormat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox compoundExpText;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox expName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btnSelectExportDestination;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowseSourceTransfer;
        private System.Windows.Forms.Button btnBrowseDestinationTransfer;
        private System.Windows.Forms.NumericUpDown waitDuration;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

