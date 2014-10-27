namespace armsim
{
    partial class ArmSimForm
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
            this.contFull = new System.Windows.Forms.SplitContainer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBreak = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.contRight = new System.Windows.Forms.SplitContainer();
            this.contCenter = new System.Windows.Forms.SplitContainer();
            this.pnlDisassembly = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMemory = new System.Windows.Forms.TabPage();
            this.gridMem = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDisassembly = new System.Windows.Forms.TabPage();
            this.txtDisassembly = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlRegisters = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRegisters = new System.Windows.Forms.TabPage();
            this.gridRegs = new System.Windows.Forms.DataGridView();
            this.RegName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStack = new System.Windows.Forms.TabPage();
            this.gridStack = new System.Windows.Forms.DataGridView();
            this.StackAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contFull)).BeginInit();
            this.contFull.Panel1.SuspendLayout();
            this.contFull.Panel2.SuspendLayout();
            this.contFull.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contRight)).BeginInit();
            this.contRight.Panel1.SuspendLayout();
            this.contRight.Panel2.SuspendLayout();
            this.contRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contCenter)).BeginInit();
            this.contCenter.Panel1.SuspendLayout();
            this.contCenter.Panel2.SuspendLayout();
            this.contCenter.SuspendLayout();
            this.pnlDisassembly.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMem)).BeginInit();
            this.tabDisassembly.SuspendLayout();
            this.pnlRegisters.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRegisters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegs)).BeginInit();
            this.tabStack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contFull
            // 
            this.contFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contFull.Location = new System.Drawing.Point(0, 0);
            this.contFull.Name = "contFull";
            // 
            // contFull.Panel1
            // 
            this.contFull.Panel1.Controls.Add(this.checkBox1);
            this.contFull.Panel1.Controls.Add(this.label10);
            this.contFull.Panel1.Controls.Add(this.txtMem);
            this.contFull.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.contFull.Panel1.Controls.Add(this.label1);
            this.contFull.Panel1.Controls.Add(this.lblFileName);
            this.contFull.Panel1.Controls.Add(this.btnLoad);
            this.contFull.Panel1.Controls.Add(this.btnReset);
            this.contFull.Panel1.Controls.Add(this.btnBreak);
            this.contFull.Panel1.Controls.Add(this.btnStep);
            this.contFull.Panel1.Controls.Add(this.btnRun);
            this.contFull.Panel1.Controls.Add(this.menuStrip1);
            // 
            // contFull.Panel2
            // 
            this.contFull.Panel2.Controls.Add(this.contRight);
            this.contFull.Size = new System.Drawing.Size(617, 325);
            this.contFull.SplitterDistance = 107;
            this.contFull.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBox1.Location = new System.Drawing.Point(0, 150);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Decimal";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Location = new System.Drawing.Point(0, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Start Address";
            // 
            // txtMem
            // 
            this.txtMem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMem.Location = new System.Drawing.Point(0, 188);
            this.txtMem.Name = "txtMem";
            this.txtMem.Size = new System.Drawing.Size(107, 22);
            this.txtMem.TabIndex = 8;
            this.txtMem.TextChanged += new System.EventHandler(this.txtMem_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(107, 80);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "F";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Flags:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFileName.Location = new System.Drawing.Point(0, 28);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(42, 17);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "None";
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLoad.Location = new System.Drawing.Point(0, 210);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(107, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReset.Location = new System.Drawing.Point(0, 233);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBreak.Location = new System.Drawing.Point(0, 256);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(107, 23);
            this.btnBreak.TabIndex = 2;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnStep
            // 
            this.btnStep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStep.Location = new System.Drawing.Point(0, 279);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(107, 23);
            this.btnStep.TabIndex = 1;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRun.Location = new System.Drawing.Point(0, 302);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(107, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(107, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoad,
            this.menuRun,
            this.menuStep,
            this.menuBreak,
            this.menuTrace,
            this.menuReset});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuLoad.Size = new System.Drawing.Size(166, 24);
            this.menuLoad.Text = "Load";
            this.menuLoad.Click += new System.EventHandler(this.menuLoad_Click);
            // 
            // menuRun
            // 
            this.menuRun.Name = "menuRun";
            this.menuRun.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuRun.Size = new System.Drawing.Size(166, 24);
            this.menuRun.Text = "Run";
            this.menuRun.Click += new System.EventHandler(this.menuRun_Click);
            // 
            // menuStep
            // 
            this.menuStep.Name = "menuStep";
            this.menuStep.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.menuStep.Size = new System.Drawing.Size(166, 24);
            this.menuStep.Text = "Step";
            this.menuStep.Click += new System.EventHandler(this.menuStep_Click);
            // 
            // menuBreak
            // 
            this.menuBreak.Name = "menuBreak";
            this.menuBreak.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuBreak.Size = new System.Drawing.Size(166, 24);
            this.menuBreak.Text = "Break";
            this.menuBreak.Click += new System.EventHandler(this.menuBreak_Click);
            // 
            // menuTrace
            // 
            this.menuTrace.Checked = true;
            this.menuTrace.CheckOnClick = true;
            this.menuTrace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuTrace.Name = "menuTrace";
            this.menuTrace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuTrace.Size = new System.Drawing.Size(166, 24);
            this.menuTrace.Text = "Trace";
            this.menuTrace.Click += new System.EventHandler(this.menuTrace_Click);
            // 
            // menuReset
            // 
            this.menuReset.Name = "menuReset";
            this.menuReset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuReset.Size = new System.Drawing.Size(166, 24);
            this.menuReset.Text = "Reset";
            this.menuReset.Click += new System.EventHandler(this.menuReset_Click);
            // 
            // contRight
            // 
            this.contRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contRight.Location = new System.Drawing.Point(0, 0);
            this.contRight.Name = "contRight";
            // 
            // contRight.Panel1
            // 
            this.contRight.Panel1.Controls.Add(this.contCenter);
            // 
            // contRight.Panel2
            // 
            this.contRight.Panel2.Controls.Add(this.pnlRegisters);
            this.contRight.Size = new System.Drawing.Size(506, 325);
            this.contRight.SplitterDistance = 329;
            this.contRight.TabIndex = 0;
            // 
            // contCenter
            // 
            this.contCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contCenter.Location = new System.Drawing.Point(0, 0);
            this.contCenter.Name = "contCenter";
            this.contCenter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // contCenter.Panel1
            // 
            this.contCenter.Panel1.Controls.Add(this.pnlDisassembly);
            // 
            // contCenter.Panel2
            // 
            this.contCenter.Panel2.Controls.Add(this.textBox1);
            this.contCenter.Size = new System.Drawing.Size(329, 325);
            this.contCenter.SplitterDistance = 231;
            this.contCenter.TabIndex = 0;
            // 
            // pnlDisassembly
            // 
            this.pnlDisassembly.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDisassembly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDisassembly.Controls.Add(this.tabControl1);
            this.pnlDisassembly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisassembly.Location = new System.Drawing.Point(0, 0);
            this.pnlDisassembly.Name = "pnlDisassembly";
            this.pnlDisassembly.Size = new System.Drawing.Size(329, 231);
            this.pnlDisassembly.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMemory);
            this.tabControl1.Controls.Add(this.tabDisassembly);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(327, 229);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMemory
            // 
            this.tabMemory.Controls.Add(this.gridMem);
            this.tabMemory.Location = new System.Drawing.Point(4, 25);
            this.tabMemory.Name = "tabMemory";
            this.tabMemory.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemory.Size = new System.Drawing.Size(319, 200);
            this.tabMemory.TabIndex = 0;
            this.tabMemory.Text = "Memory";
            this.tabMemory.UseVisualStyleBackColor = true;
            // 
            // gridMem
            // 
            this.gridMem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.Word1,
            this.Word2,
            this.Word3,
            this.Word4});
            this.gridMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMem.Location = new System.Drawing.Point(3, 3);
            this.gridMem.Name = "gridMem";
            this.gridMem.RowTemplate.Height = 24;
            this.gridMem.Size = new System.Drawing.Size(313, 194);
            this.gridMem.TabIndex = 0;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Word1
            // 
            this.Word1.HeaderText = "Word 1";
            this.Word1.Name = "Word1";
            this.Word1.ReadOnly = true;
            // 
            // Word2
            // 
            this.Word2.HeaderText = "Word 2";
            this.Word2.Name = "Word2";
            this.Word2.ReadOnly = true;
            // 
            // Word3
            // 
            this.Word3.HeaderText = "Word 3";
            this.Word3.Name = "Word3";
            this.Word3.ReadOnly = true;
            // 
            // Word4
            // 
            this.Word4.HeaderText = "Word 4";
            this.Word4.Name = "Word4";
            this.Word4.ReadOnly = true;
            // 
            // tabDisassembly
            // 
            this.tabDisassembly.Controls.Add(this.txtDisassembly);
            this.tabDisassembly.Location = new System.Drawing.Point(4, 25);
            this.tabDisassembly.Name = "tabDisassembly";
            this.tabDisassembly.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisassembly.Size = new System.Drawing.Size(319, 200);
            this.tabDisassembly.TabIndex = 1;
            this.tabDisassembly.Text = "Disassembly";
            this.tabDisassembly.UseVisualStyleBackColor = true;
            // 
            // txtDisassembly
            // 
            this.txtDisassembly.AcceptsReturn = true;
            this.txtDisassembly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisassembly.Location = new System.Drawing.Point(3, 3);
            this.txtDisassembly.Multiline = true;
            this.txtDisassembly.Name = "txtDisassembly";
            this.txtDisassembly.ReadOnly = true;
            this.txtDisassembly.Size = new System.Drawing.Size(313, 194);
            this.txtDisassembly.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(329, 90);
            this.textBox1.TabIndex = 1;
            // 
            // pnlRegisters
            // 
            this.pnlRegisters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegisters.Controls.Add(this.tabControl2);
            this.pnlRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisters.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisters.Name = "pnlRegisters";
            this.pnlRegisters.Size = new System.Drawing.Size(173, 325);
            this.pnlRegisters.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabRegisters);
            this.tabControl2.Controls.Add(this.tabStack);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(171, 323);
            this.tabControl2.TabIndex = 1;
            // 
            // tabRegisters
            // 
            this.tabRegisters.Controls.Add(this.gridRegs);
            this.tabRegisters.Location = new System.Drawing.Point(4, 25);
            this.tabRegisters.Name = "tabRegisters";
            this.tabRegisters.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegisters.Size = new System.Drawing.Size(163, 294);
            this.tabRegisters.TabIndex = 0;
            this.tabRegisters.Text = "Registers";
            this.tabRegisters.UseVisualStyleBackColor = true;
            // 
            // gridRegs
            // 
            this.gridRegs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegName,
            this.Value});
            this.gridRegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRegs.Location = new System.Drawing.Point(3, 3);
            this.gridRegs.Name = "gridRegs";
            this.gridRegs.RowTemplate.Height = 24;
            this.gridRegs.Size = new System.Drawing.Size(157, 288);
            this.gridRegs.TabIndex = 0;
            // 
            // RegName
            // 
            this.RegName.HeaderText = "Regs";
            this.RegName.Name = "RegName";
            this.RegName.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // tabStack
            // 
            this.tabStack.Controls.Add(this.gridStack);
            this.tabStack.Location = new System.Drawing.Point(4, 25);
            this.tabStack.Name = "tabStack";
            this.tabStack.Padding = new System.Windows.Forms.Padding(3);
            this.tabStack.Size = new System.Drawing.Size(163, 294);
            this.tabStack.TabIndex = 1;
            this.tabStack.Text = "Stack";
            this.tabStack.UseVisualStyleBackColor = true;
            // 
            // gridStack
            // 
            this.gridStack.AllowUserToDeleteRows = false;
            this.gridStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StackAddr,
            this.Stack});
            this.gridStack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStack.Location = new System.Drawing.Point(3, 3);
            this.gridStack.Name = "gridStack";
            this.gridStack.RowTemplate.Height = 24;
            this.gridStack.Size = new System.Drawing.Size(157, 288);
            this.gridStack.TabIndex = 0;
            // 
            // StackAddr
            // 
            this.StackAddr.HeaderText = "StackAddr";
            this.StackAddr.Name = "StackAddr";
            this.StackAddr.ReadOnly = true;
            // 
            // Stack
            // 
            this.Stack.HeaderText = "Stack";
            this.Stack.Name = "Stack";
            this.Stack.ReadOnly = true;
            // 
            // ArmSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 325);
            this.Controls.Add(this.contFull);
            this.Name = "ArmSimForm";
            this.Text = "Form1";
            this.contFull.Panel1.ResumeLayout(false);
            this.contFull.Panel1.PerformLayout();
            this.contFull.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contFull)).EndInit();
            this.contFull.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contRight.Panel1.ResumeLayout(false);
            this.contRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contRight)).EndInit();
            this.contRight.ResumeLayout(false);
            this.contCenter.Panel1.ResumeLayout(false);
            this.contCenter.Panel2.ResumeLayout(false);
            this.contCenter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contCenter)).EndInit();
            this.contCenter.ResumeLayout(false);
            this.pnlDisassembly.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabMemory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMem)).EndInit();
            this.tabDisassembly.ResumeLayout(false);
            this.tabDisassembly.PerformLayout();
            this.pnlRegisters.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabRegisters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegs)).EndInit();
            this.tabStack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer contFull;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.SplitContainer contRight;
        private System.Windows.Forms.SplitContainer contCenter;
        private System.Windows.Forms.Panel pnlRegisters;
        private System.Windows.Forms.Panel pnlDisassembly;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMemory;
        private System.Windows.Forms.TabPage tabDisassembly;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRegisters;
        private System.Windows.Forms.TabPage tabStack;
        private System.Windows.Forms.DataGridView gridMem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word4;
        private System.Windows.Forms.DataGridView gridRegs;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuLoad;
        private System.Windows.Forms.ToolStripMenuItem menuRun;
        private System.Windows.Forms.ToolStripMenuItem menuStep;
        private System.Windows.Forms.ToolStripMenuItem menuBreak;
        private System.Windows.Forms.ToolStripMenuItem menuTrace;
        private System.Windows.Forms.ToolStripMenuItem menuReset;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtDisassembly;
        private System.Windows.Forms.DataGridView gridStack;
        private System.Windows.Forms.DataGridViewTextBoxColumn StackAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stack;


    }
}

