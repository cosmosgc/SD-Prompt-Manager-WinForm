namespace SD_Prompt_Manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Prompt = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt2imgPositive = new FastColoredTextBoxNS.FastColoredTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt2imgNegative = new FastColoredTextBoxNS.FastColoredTextBox();
            this.imagepreview = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.STEPS = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Denoise = new System.Windows.Forms.TrackBar();
            this.CFG = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TrackBar();
            this.Height = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.WidthText = new System.Windows.Forms.TextBox();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.CFGText = new System.Windows.Forms.TextBox();
            this.DenoiseText = new System.Windows.Forms.TextBox();
            this.img2imgPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PromptDataGrid = new System.Windows.Forms.DataGridView();
            this.SEED = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Prompt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt2imgPositive)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt2imgNegative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagepreview)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STEPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Denoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromptDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEED)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promptToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // promptToolStripMenuItem
            // 
            this.promptToolStripMenuItem.Name = "promptToolStripMenuItem";
            this.promptToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.promptToolStripMenuItem.Text = "Prompt";
            this.promptToolStripMenuItem.Click += new System.EventHandler(this.promptToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Prompt);
            this.tabControl1.Controls.Add(this.img2imgPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // Prompt
            // 
            this.Prompt.Controls.Add(this.splitContainer2);
            this.Prompt.Location = new System.Drawing.Point(4, 22);
            this.Prompt.Name = "Prompt";
            this.Prompt.Padding = new System.Windows.Forms.Padding(3);
            this.Prompt.Size = new System.Drawing.Size(635, 400);
            this.Prompt.TabIndex = 0;
            this.Prompt.Text = "txt2img";
            this.Prompt.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(629, 394);
            this.splitContainer2.SplitterDistance = 241;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.imagepreview);
            this.splitContainer6.Size = new System.Drawing.Size(629, 241);
            this.splitContainer6.SplitterDistance = 452;
            this.splitContainer6.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Size = new System.Drawing.Size(452, 241);
            this.splitContainer3.SplitterDistance = 123;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt2imgPositive);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POSITIVE";
            // 
            // txt2imgPositive
            // 
            this.txt2imgPositive.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txt2imgPositive.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txt2imgPositive.BackBrush = null;
            this.txt2imgPositive.CharHeight = 14;
            this.txt2imgPositive.CharWidth = 8;
            this.txt2imgPositive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt2imgPositive.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt2imgPositive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt2imgPositive.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txt2imgPositive.IsReplaceMode = false;
            this.txt2imgPositive.Location = new System.Drawing.Point(3, 16);
            this.txt2imgPositive.Name = "txt2imgPositive";
            this.txt2imgPositive.Paddings = new System.Windows.Forms.Padding(0);
            this.txt2imgPositive.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt2imgPositive.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt2imgPositive.ServiceColors")));
            this.txt2imgPositive.Size = new System.Drawing.Size(446, 104);
            this.txt2imgPositive.TabIndex = 0;
            this.txt2imgPositive.Zoom = 100;
            this.txt2imgPositive.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.txt2imgPositive_TextChangedDelayed);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt2imgNegative);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NEGATIVE";
            // 
            // txt2imgNegative
            // 
            this.txt2imgNegative.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txt2imgNegative.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txt2imgNegative.BackBrush = null;
            this.txt2imgNegative.CharHeight = 14;
            this.txt2imgNegative.CharWidth = 8;
            this.txt2imgNegative.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt2imgNegative.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt2imgNegative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt2imgNegative.IsReplaceMode = false;
            this.txt2imgNegative.Location = new System.Drawing.Point(3, 16);
            this.txt2imgNegative.Name = "txt2imgNegative";
            this.txt2imgNegative.Paddings = new System.Windows.Forms.Padding(0);
            this.txt2imgNegative.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt2imgNegative.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt2imgNegative.ServiceColors")));
            this.txt2imgNegative.Size = new System.Drawing.Size(446, 95);
            this.txt2imgNegative.TabIndex = 0;
            this.txt2imgNegative.Zoom = 100;
            this.txt2imgNegative.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.txt2imgNegative_TextChangedDelayed);
            // 
            // imagepreview
            // 
            this.imagepreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagepreview.Location = new System.Drawing.Point(0, 0);
            this.imagepreview.Name = "imagepreview";
            this.imagepreview.Size = new System.Drawing.Size(173, 241);
            this.imagepreview.TabIndex = 0;
            this.imagepreview.TabStop = false;
            this.imagepreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.imagepreview_DragDrop);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.70238F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.29762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.STEPS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Denoise, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CFG, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Width, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Height, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.WidthText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightText, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CFGText, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.DenoiseText, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.SEED, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "STEPS";
            // 
            // STEPS
            // 
            this.STEPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.STEPS.Location = new System.Drawing.Point(3, 3);
            this.STEPS.Name = "STEPS";
            this.STEPS.Size = new System.Drawing.Size(233, 20);
            this.STEPS.TabIndex = 0;
            this.STEPS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.STEPS.ValueChanged += new System.EventHandler(this.STEPS_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SEED";
            // 
            // Denoise
            // 
            this.Denoise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Denoise.Location = new System.Drawing.Point(3, 83);
            this.Denoise.Name = "Denoise";
            this.Denoise.Size = new System.Drawing.Size(233, 14);
            this.Denoise.TabIndex = 7;
            this.Denoise.Scroll += new System.EventHandler(this.Denoise_Scroll);
            // 
            // CFG
            // 
            this.CFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CFG.Location = new System.Drawing.Point(3, 63);
            this.CFG.Name = "CFG";
            this.CFG.Size = new System.Drawing.Size(233, 14);
            this.CFG.TabIndex = 2;
            this.CFG.Scroll += new System.EventHandler(this.CFG_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CFG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "DENOISE";
            // 
            // Width
            // 
            this.Width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Width.Location = new System.Drawing.Point(3, 23);
            this.Width.Maximum = 2048;
            this.Width.Minimum = 64;
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(233, 14);
            this.Width.TabIndex = 9;
            this.Width.Value = 512;
            this.Width.Scroll += new System.EventHandler(this.Width_Scroll);
            // 
            // Height
            // 
            this.Height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Height.Location = new System.Drawing.Point(3, 43);
            this.Height.Maximum = 2048;
            this.Height.Minimum = 64;
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(233, 14);
            this.Height.TabIndex = 10;
            this.Height.Value = 512;
            this.Height.Scroll += new System.EventHandler(this.Height_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Width";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Height";
            // 
            // WidthText
            // 
            this.WidthText.Location = new System.Drawing.Point(322, 23);
            this.WidthText.Name = "WidthText";
            this.WidthText.ReadOnly = true;
            this.WidthText.Size = new System.Drawing.Size(100, 20);
            this.WidthText.TabIndex = 13;
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(322, 43);
            this.HeightText.Name = "HeightText";
            this.HeightText.ReadOnly = true;
            this.HeightText.Size = new System.Drawing.Size(100, 20);
            this.HeightText.TabIndex = 14;
            // 
            // CFGText
            // 
            this.CFGText.Location = new System.Drawing.Point(322, 63);
            this.CFGText.Name = "CFGText";
            this.CFGText.ReadOnly = true;
            this.CFGText.Size = new System.Drawing.Size(100, 20);
            this.CFGText.TabIndex = 15;
            // 
            // DenoiseText
            // 
            this.DenoiseText.Location = new System.Drawing.Point(322, 83);
            this.DenoiseText.Name = "DenoiseText";
            this.DenoiseText.ReadOnly = true;
            this.DenoiseText.Size = new System.Drawing.Size(100, 20);
            this.DenoiseText.TabIndex = 16;
            // 
            // img2imgPage
            // 
            this.img2imgPage.Location = new System.Drawing.Point(4, 22);
            this.img2imgPage.Name = "img2imgPage";
            this.img2imgPage.Padding = new System.Windows.Forms.Padding(3);
            this.img2imgPage.Size = new System.Drawing.Size(635, 400);
            this.img2imgPage.TabIndex = 1;
            this.img2imgPage.Text = "img2img";
            this.img2imgPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PromptDataGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 2;
            // 
            // PromptDataGrid
            // 
            this.PromptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PromptDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromptDataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PromptDataGrid.Location = new System.Drawing.Point(0, 0);
            this.PromptDataGrid.Name = "PromptDataGrid";
            this.PromptDataGrid.ReadOnly = true;
            this.PromptDataGrid.RowHeadersVisible = false;
            this.PromptDataGrid.Size = new System.Drawing.Size(153, 426);
            this.PromptDataGrid.TabIndex = 0;
            this.PromptDataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PromptDataGrid_RowEnter);
            // 
            // SEED
            // 
            this.SEED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SEED.Location = new System.Drawing.Point(3, 103);
            this.SEED.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.SEED.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.SEED.Name = "SEED";
            this.SEED.Size = new System.Drawing.Size(233, 20);
            this.SEED.TabIndex = 17;
            this.SEED.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.SEED.ValueChanged += new System.EventHandler(this.SEED_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Prompt.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt2imgPositive)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt2imgNegative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagepreview)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STEPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Denoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CFG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PromptDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Prompt;
        private System.Windows.Forms.TabPage img2imgPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private FastColoredTextBoxNS.FastColoredTextBox txt2imgPositive;
        private System.Windows.Forms.GroupBox groupBox2;
        private FastColoredTextBoxNS.FastColoredTextBox txt2imgNegative;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown STEPS;
        private System.Windows.Forms.TrackBar CFG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PromptDataGrid;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.PictureBox imagepreview;
        private System.Windows.Forms.TrackBar Denoise;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar Width;
        private System.Windows.Forms.TrackBar Height;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox WidthText;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.TextBox CFGText;
        private System.Windows.Forms.TextBox DenoiseText;
        private System.Windows.Forms.ToolStripMenuItem promptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown SEED;
    }
}

