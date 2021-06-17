namespace BasicCompiuter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.lbl_current_file_name = new System.Windows.Forms.Label();
            this.loadFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.datagrid_ram = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ram = new System.Windows.Forms.Label();
            this.lbl_SC = new System.Windows.Forms.Label();
            this.txt_SC = new System.Windows.Forms.TextBox();
            this.txt_PC = new System.Windows.Forms.TextBox();
            this.lbl_PC = new System.Windows.Forms.Label();
            this.txt_AR = new System.Windows.Forms.TextBox();
            this.lbl_AR = new System.Windows.Forms.Label();
            this.txt_IR = new System.Windows.Forms.TextBox();
            this.lbl_IR = new System.Windows.Forms.Label();
            this.txt_DR = new System.Windows.Forms.TextBox();
            this.lbl_DR = new System.Windows.Forms.Label();
            this.txt_AC = new System.Windows.Forms.TextBox();
            this.lbl_AC = new System.Windows.Forms.Label();
            this.txt_TR = new System.Windows.Forms.TextBox();
            this.lbl_TR = new System.Windows.Forms.Label();
            this.txt_INPR = new System.Windows.Forms.TextBox();
            this.lbl_INPR = new System.Windows.Forms.Label();
            this.txt_OUTR = new System.Windows.Forms.TextBox();
            this.lbl_OUTR = new System.Windows.Forms.Label();
            this.txt_I = new System.Windows.Forms.TextBox();
            this.lbl_I = new System.Windows.Forms.Label();
            this.txt_S = new System.Windows.Forms.TextBox();
            this.lbl_S = new System.Windows.Forms.Label();
            this.txt_E = new System.Windows.Forms.TextBox();
            this.lbl_E = new System.Windows.Forms.Label();
            this.txt_R = new System.Windows.Forms.TextBox();
            this.lbl_R = new System.Windows.Forms.Label();
            this.txt_IEN = new System.Windows.Forms.TextBox();
            this.lbl_IEN = new System.Windows.Forms.Label();
            this.txt_FGI = new System.Windows.Forms.TextBox();
            this.lbl_FGI = new System.Windows.Forms.Label();
            this.txt_FGO = new System.Windows.Forms.TextBox();
            this.lbl_FGO = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_next_step = new System.Windows.Forms.Button();
            this.btn_compile = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lbl_input = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(27, 81);
            this.txt_code.Multiline = true;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(480, 703);
            this.txt_code.TabIndex = 0;
            this.txt_code.TextChanged += new System.EventHandler(this.Txt_code_TextChanged);
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(24, 61);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(79, 17);
            this.lbl_code.TabIndex = 1;
            this.lbl_code.Text = "Enter Code";
            this.lbl_code.Click += new System.EventHandler(this.Label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1578, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.Location = new System.Drawing.Point(24, 44);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(83, 17);
            this.lbl_file_name.TabIndex = 3;
            this.lbl_file_name.Text = "File Name : ";
            this.lbl_file_name.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // lbl_current_file_name
            // 
            this.lbl_current_file_name.AutoSize = true;
            this.lbl_current_file_name.Location = new System.Drawing.Point(121, 44);
            this.lbl_current_file_name.Name = "lbl_current_file_name";
            this.lbl_current_file_name.Size = new System.Drawing.Size(0, 17);
            this.lbl_current_file_name.TabIndex = 4;
            // 
            // datagrid_ram
            // 
            this.datagrid_ram.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.datagrid_ram.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_ram.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_ram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_ram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Label,
            this.Address,
            this.Instruction,
            this.Hex});
            this.datagrid_ram.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrid_ram.Location = new System.Drawing.Point(954, 81);
            this.datagrid_ram.Name = "datagrid_ram";
            this.datagrid_ram.ReadOnly = true;
            this.datagrid_ram.RowTemplate.Height = 24;
            this.datagrid_ram.Size = new System.Drawing.Size(575, 703);
            this.datagrid_ram.TabIndex = 6;
            this.datagrid_ram.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Label
            // 
            this.Label.HeaderText = "Label";
            this.Label.Name = "Label";
            this.Label.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Instruction
            // 
            this.Instruction.HeaderText = "Instruction";
            this.Instruction.Name = "Instruction";
            this.Instruction.ReadOnly = true;
            // 
            // Hex
            // 
            this.Hex.HeaderText = "Hex";
            this.Hex.Name = "Hex";
            this.Hex.ReadOnly = true;
            // 
            // lbl_ram
            // 
            this.lbl_ram.AutoSize = true;
            this.lbl_ram.Location = new System.Drawing.Point(951, 61);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(38, 17);
            this.lbl_ram.TabIndex = 7;
            this.lbl_ram.Text = "RAM";
            this.lbl_ram.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // lbl_SC
            // 
            this.lbl_SC.AutoSize = true;
            this.lbl_SC.Location = new System.Drawing.Point(619, 61);
            this.lbl_SC.Name = "lbl_SC";
            this.lbl_SC.Size = new System.Drawing.Size(34, 17);
            this.lbl_SC.TabIndex = 8;
            this.lbl_SC.Text = "SC :";
            // 
            // txt_SC
            // 
            this.txt_SC.Location = new System.Drawing.Point(671, 61);
            this.txt_SC.Name = "txt_SC";
            this.txt_SC.ReadOnly = true;
            this.txt_SC.Size = new System.Drawing.Size(189, 22);
            this.txt_SC.TabIndex = 9;
            // 
            // txt_PC
            // 
            this.txt_PC.Location = new System.Drawing.Point(671, 114);
            this.txt_PC.Name = "txt_PC";
            this.txt_PC.ReadOnly = true;
            this.txt_PC.Size = new System.Drawing.Size(189, 22);
            this.txt_PC.TabIndex = 11;
            // 
            // lbl_PC
            // 
            this.lbl_PC.AutoSize = true;
            this.lbl_PC.Location = new System.Drawing.Point(619, 114);
            this.lbl_PC.Name = "lbl_PC";
            this.lbl_PC.Size = new System.Drawing.Size(34, 17);
            this.lbl_PC.TabIndex = 10;
            this.lbl_PC.Text = "PC :";
            // 
            // txt_AR
            // 
            this.txt_AR.Location = new System.Drawing.Point(671, 170);
            this.txt_AR.Name = "txt_AR";
            this.txt_AR.ReadOnly = true;
            this.txt_AR.Size = new System.Drawing.Size(189, 22);
            this.txt_AR.TabIndex = 13;
            // 
            // lbl_AR
            // 
            this.lbl_AR.AutoSize = true;
            this.lbl_AR.Location = new System.Drawing.Point(619, 170);
            this.lbl_AR.Name = "lbl_AR";
            this.lbl_AR.Size = new System.Drawing.Size(35, 17);
            this.lbl_AR.TabIndex = 12;
            this.lbl_AR.Text = "AR :";
            // 
            // txt_IR
            // 
            this.txt_IR.Location = new System.Drawing.Point(671, 222);
            this.txt_IR.Name = "txt_IR";
            this.txt_IR.ReadOnly = true;
            this.txt_IR.Size = new System.Drawing.Size(189, 22);
            this.txt_IR.TabIndex = 15;
            // 
            // lbl_IR
            // 
            this.lbl_IR.AutoSize = true;
            this.lbl_IR.Location = new System.Drawing.Point(619, 222);
            this.lbl_IR.Name = "lbl_IR";
            this.lbl_IR.Size = new System.Drawing.Size(29, 17);
            this.lbl_IR.TabIndex = 14;
            this.lbl_IR.Text = "IR :";
            // 
            // txt_DR
            // 
            this.txt_DR.Location = new System.Drawing.Point(671, 268);
            this.txt_DR.Name = "txt_DR";
            this.txt_DR.ReadOnly = true;
            this.txt_DR.Size = new System.Drawing.Size(189, 22);
            this.txt_DR.TabIndex = 17;
            // 
            // lbl_DR
            // 
            this.lbl_DR.AutoSize = true;
            this.lbl_DR.Location = new System.Drawing.Point(619, 268);
            this.lbl_DR.Name = "lbl_DR";
            this.lbl_DR.Size = new System.Drawing.Size(36, 17);
            this.lbl_DR.TabIndex = 16;
            this.lbl_DR.Text = "DR :";
            // 
            // txt_AC
            // 
            this.txt_AC.Location = new System.Drawing.Point(671, 314);
            this.txt_AC.Name = "txt_AC";
            this.txt_AC.ReadOnly = true;
            this.txt_AC.Size = new System.Drawing.Size(189, 22);
            this.txt_AC.TabIndex = 19;
            // 
            // lbl_AC
            // 
            this.lbl_AC.AutoSize = true;
            this.lbl_AC.Location = new System.Drawing.Point(619, 314);
            this.lbl_AC.Name = "lbl_AC";
            this.lbl_AC.Size = new System.Drawing.Size(34, 17);
            this.lbl_AC.TabIndex = 18;
            this.lbl_AC.Text = "AC :";
            // 
            // txt_TR
            // 
            this.txt_TR.Location = new System.Drawing.Point(671, 373);
            this.txt_TR.Name = "txt_TR";
            this.txt_TR.ReadOnly = true;
            this.txt_TR.Size = new System.Drawing.Size(189, 22);
            this.txt_TR.TabIndex = 21;
            // 
            // lbl_TR
            // 
            this.lbl_TR.AutoSize = true;
            this.lbl_TR.Location = new System.Drawing.Point(619, 373);
            this.lbl_TR.Name = "lbl_TR";
            this.lbl_TR.Size = new System.Drawing.Size(35, 17);
            this.lbl_TR.TabIndex = 20;
            this.lbl_TR.Text = "TR :";
            // 
            // txt_INPR
            // 
            this.txt_INPR.Location = new System.Drawing.Point(671, 433);
            this.txt_INPR.Name = "txt_INPR";
            this.txt_INPR.ReadOnly = true;
            this.txt_INPR.Size = new System.Drawing.Size(189, 22);
            this.txt_INPR.TabIndex = 23;
            // 
            // lbl_INPR
            // 
            this.lbl_INPR.AutoSize = true;
            this.lbl_INPR.Location = new System.Drawing.Point(619, 433);
            this.lbl_INPR.Name = "lbl_INPR";
            this.lbl_INPR.Size = new System.Drawing.Size(48, 17);
            this.lbl_INPR.TabIndex = 22;
            this.lbl_INPR.Text = "INPR :";
            // 
            // txt_OUTR
            // 
            this.txt_OUTR.Location = new System.Drawing.Point(671, 488);
            this.txt_OUTR.Name = "txt_OUTR";
            this.txt_OUTR.ReadOnly = true;
            this.txt_OUTR.Size = new System.Drawing.Size(189, 22);
            this.txt_OUTR.TabIndex = 25;
            // 
            // lbl_OUTR
            // 
            this.lbl_OUTR.AutoSize = true;
            this.lbl_OUTR.Location = new System.Drawing.Point(609, 491);
            this.lbl_OUTR.Name = "lbl_OUTR";
            this.lbl_OUTR.Size = new System.Drawing.Size(56, 17);
            this.lbl_OUTR.TabIndex = 24;
            this.lbl_OUTR.Text = "OUTR :";
            // 
            // txt_I
            // 
            this.txt_I.Location = new System.Drawing.Point(556, 595);
            this.txt_I.Name = "txt_I";
            this.txt_I.ReadOnly = true;
            this.txt_I.Size = new System.Drawing.Size(50, 22);
            this.txt_I.TabIndex = 29;
            // 
            // lbl_I
            // 
            this.lbl_I.AutoSize = true;
            this.lbl_I.Location = new System.Drawing.Point(534, 598);
            this.lbl_I.Name = "lbl_I";
            this.lbl_I.Size = new System.Drawing.Size(19, 17);
            this.lbl_I.TabIndex = 28;
            this.lbl_I.Text = "I :";
            this.lbl_I.Click += new System.EventHandler(this.Label11_Click);
            // 
            // txt_S
            // 
            this.txt_S.Location = new System.Drawing.Point(671, 593);
            this.txt_S.Name = "txt_S";
            this.txt_S.ReadOnly = true;
            this.txt_S.Size = new System.Drawing.Size(50, 22);
            this.txt_S.TabIndex = 31;
            // 
            // lbl_S
            // 
            this.lbl_S.AutoSize = true;
            this.lbl_S.Location = new System.Drawing.Point(649, 596);
            this.lbl_S.Name = "lbl_S";
            this.lbl_S.Size = new System.Drawing.Size(25, 17);
            this.lbl_S.TabIndex = 30;
            this.lbl_S.Text = "S :";
            // 
            // txt_E
            // 
            this.txt_E.Location = new System.Drawing.Point(781, 593);
            this.txt_E.Name = "txt_E";
            this.txt_E.ReadOnly = true;
            this.txt_E.Size = new System.Drawing.Size(50, 22);
            this.txt_E.TabIndex = 33;
            // 
            // lbl_E
            // 
            this.lbl_E.AutoSize = true;
            this.lbl_E.Location = new System.Drawing.Point(759, 596);
            this.lbl_E.Name = "lbl_E";
            this.lbl_E.Size = new System.Drawing.Size(25, 17);
            this.lbl_E.TabIndex = 32;
            this.lbl_E.Text = "E :";
            // 
            // txt_R
            // 
            this.txt_R.Location = new System.Drawing.Point(889, 591);
            this.txt_R.Name = "txt_R";
            this.txt_R.ReadOnly = true;
            this.txt_R.Size = new System.Drawing.Size(50, 22);
            this.txt_R.TabIndex = 35;
            // 
            // lbl_R
            // 
            this.lbl_R.AutoSize = true;
            this.lbl_R.Location = new System.Drawing.Point(867, 594);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(26, 17);
            this.lbl_R.TabIndex = 34;
            this.lbl_R.Text = "R :";
            // 
            // txt_IEN
            // 
            this.txt_IEN.Location = new System.Drawing.Point(618, 649);
            this.txt_IEN.Name = "txt_IEN";
            this.txt_IEN.ReadOnly = true;
            this.txt_IEN.Size = new System.Drawing.Size(50, 22);
            this.txt_IEN.TabIndex = 37;
            // 
            // lbl_IEN
            // 
            this.lbl_IEN.AutoSize = true;
            this.lbl_IEN.Location = new System.Drawing.Point(577, 652);
            this.lbl_IEN.Name = "lbl_IEN";
            this.lbl_IEN.Size = new System.Drawing.Size(38, 17);
            this.lbl_IEN.TabIndex = 36;
            this.lbl_IEN.Text = "IEN :";
            // 
            // txt_FGI
            // 
            this.txt_FGI.Location = new System.Drawing.Point(728, 649);
            this.txt_FGI.Name = "txt_FGI";
            this.txt_FGI.ReadOnly = true;
            this.txt_FGI.Size = new System.Drawing.Size(50, 22);
            this.txt_FGI.TabIndex = 39;
            // 
            // lbl_FGI
            // 
            this.lbl_FGI.AutoSize = true;
            this.lbl_FGI.Location = new System.Drawing.Point(687, 652);
            this.lbl_FGI.Name = "lbl_FGI";
            this.lbl_FGI.Size = new System.Drawing.Size(38, 17);
            this.lbl_FGI.TabIndex = 38;
            this.lbl_FGI.Text = "FGI :";
            // 
            // txt_FGO
            // 
            this.txt_FGO.Location = new System.Drawing.Point(843, 649);
            this.txt_FGO.Name = "txt_FGO";
            this.txt_FGO.ReadOnly = true;
            this.txt_FGO.Size = new System.Drawing.Size(50, 22);
            this.txt_FGO.TabIndex = 41;
            // 
            // lbl_FGO
            // 
            this.lbl_FGO.AutoSize = true;
            this.lbl_FGO.Location = new System.Drawing.Point(800, 652);
            this.lbl_FGO.Name = "lbl_FGO";
            this.lbl_FGO.Size = new System.Drawing.Size(46, 17);
            this.lbl_FGO.TabIndex = 40;
            this.lbl_FGO.Text = "FGO :";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(556, 698);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(145, 27);
            this.btn_run.TabIndex = 42;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            // 
            // btn_next_step
            // 
            this.btn_next_step.Location = new System.Drawing.Point(748, 698);
            this.btn_next_step.Name = "btn_next_step";
            this.btn_next_step.Size = new System.Drawing.Size(145, 27);
            this.btn_next_step.TabIndex = 43;
            this.btn_next_step.Text = "Next Step";
            this.btn_next_step.UseVisualStyleBackColor = true;
            this.btn_next_step.Click += new System.EventHandler(this.Btn_next_step_Click);
            // 
            // btn_compile
            // 
            this.btn_compile.Location = new System.Drawing.Point(556, 747);
            this.btn_compile.Name = "btn_compile";
            this.btn_compile.Size = new System.Drawing.Size(145, 27);
            this.btn_compile.TabIndex = 44;
            this.btn_compile.Text = "Compile";
            this.btn_compile.UseVisualStyleBackColor = true;
            this.btn_compile.Click += new System.EventHandler(this.Btn_compile_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(748, 747);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(145, 27);
            this.btn_reset.TabIndex = 45;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // txt_input
            // 
            this.txt_input.BackColor = System.Drawing.SystemColors.Info;
            this.txt_input.Location = new System.Drawing.Point(580, 544);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(359, 22);
            this.txt_input.TabIndex = 47;
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(534, 547);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(47, 17);
            this.lbl_input.TabIndex = 46;
            this.lbl_input.Text = "input :";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(BasicCompiuter.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 849);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_compile);
            this.Controls.Add(this.btn_next_step);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.txt_FGO);
            this.Controls.Add(this.lbl_FGO);
            this.Controls.Add(this.txt_FGI);
            this.Controls.Add(this.lbl_FGI);
            this.Controls.Add(this.txt_IEN);
            this.Controls.Add(this.lbl_IEN);
            this.Controls.Add(this.txt_R);
            this.Controls.Add(this.lbl_R);
            this.Controls.Add(this.txt_E);
            this.Controls.Add(this.lbl_E);
            this.Controls.Add(this.txt_S);
            this.Controls.Add(this.lbl_S);
            this.Controls.Add(this.txt_I);
            this.Controls.Add(this.lbl_I);
            this.Controls.Add(this.txt_OUTR);
            this.Controls.Add(this.lbl_OUTR);
            this.Controls.Add(this.txt_INPR);
            this.Controls.Add(this.lbl_INPR);
            this.Controls.Add(this.txt_TR);
            this.Controls.Add(this.lbl_TR);
            this.Controls.Add(this.txt_AC);
            this.Controls.Add(this.lbl_AC);
            this.Controls.Add(this.txt_DR);
            this.Controls.Add(this.lbl_DR);
            this.Controls.Add(this.txt_IR);
            this.Controls.Add(this.lbl_IR);
            this.Controls.Add(this.txt_AR);
            this.Controls.Add(this.lbl_AR);
            this.Controls.Add(this.txt_PC);
            this.Controls.Add(this.lbl_PC);
            this.Controls.Add(this.txt_SC);
            this.Controls.Add(this.lbl_SC);
            this.Controls.Add(this.lbl_ram);
            this.Controls.Add(this.datagrid_ram);
            this.Controls.Add(this.lbl_current_file_name);
            this.Controls.Add(this.lbl_file_name);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.txt_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Basic Computer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Label lbl_file_name;
        private System.Windows.Forms.Label lbl_current_file_name;
        private System.Windows.Forms.SaveFileDialog loadFileDialog;
        private System.Windows.Forms.DataGridView datagrid_ram;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.Label lbl_SC;
        private System.Windows.Forms.TextBox txt_SC;
        private System.Windows.Forms.TextBox txt_PC;
        private System.Windows.Forms.Label lbl_PC;
        private System.Windows.Forms.TextBox txt_AR;
        private System.Windows.Forms.Label lbl_AR;
        private System.Windows.Forms.TextBox txt_IR;
        private System.Windows.Forms.Label lbl_IR;
        private System.Windows.Forms.TextBox txt_DR;
        private System.Windows.Forms.Label lbl_DR;
        private System.Windows.Forms.TextBox txt_AC;
        private System.Windows.Forms.Label lbl_AC;
        private System.Windows.Forms.TextBox txt_TR;
        private System.Windows.Forms.Label lbl_TR;
        private System.Windows.Forms.TextBox txt_INPR;
        private System.Windows.Forms.Label lbl_INPR;
        private System.Windows.Forms.TextBox txt_OUTR;
        private System.Windows.Forms.Label lbl_OUTR;
        private System.Windows.Forms.TextBox txt_I;
        private System.Windows.Forms.Label lbl_I;
        private System.Windows.Forms.TextBox txt_S;
        private System.Windows.Forms.Label lbl_S;
        private System.Windows.Forms.TextBox txt_E;
        private System.Windows.Forms.Label lbl_E;
        private System.Windows.Forms.TextBox txt_R;
        private System.Windows.Forms.Label lbl_R;
        private System.Windows.Forms.TextBox txt_IEN;
        private System.Windows.Forms.Label lbl_IEN;
        private System.Windows.Forms.TextBox txt_FGI;
        private System.Windows.Forms.Label lbl_FGI;
        private System.Windows.Forms.TextBox txt_FGO;
        private System.Windows.Forms.Label lbl_FGO;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_next_step;
        private System.Windows.Forms.Button btn_compile;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hex;
    }
}

