namespace Assignment4
{
    partial class ProductInfoForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebcamTextBox = new System.Windows.Forms.TextBox();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.OrderDetailsGroupBox.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitApplication);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderDetailsGroupBox
            // 
            this.OrderDetailsGroupBox.Controls.Add(this.CostTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.ConditionTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.CostLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.ProductIDTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.ConditionLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.ProductIDLabel);
            this.OrderDetailsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.OrderDetailsGroupBox.Name = "OrderDetailsGroupBox";
            this.OrderDetailsGroupBox.Size = new System.Drawing.Size(736, 47);
            this.OrderDetailsGroupBox.TabIndex = 1;
            this.OrderDetailsGroupBox.TabStop = false;
            this.OrderDetailsGroupBox.Text = "Order Details";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.White;
            this.CostTextBox.Enabled = false;
            this.CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox.Location = new System.Drawing.Point(602, 12);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(128, 29);
            this.CostTextBox.TabIndex = 3;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.BackColor = System.Drawing.Color.White;
            this.ConditionTextBox.Enabled = false;
            this.ConditionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionTextBox.Location = new System.Drawing.Point(359, 12);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(115, 29);
            this.ConditionTextBox.TabIndex = 3;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(549, 15);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(47, 24);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.BackColor = System.Drawing.Color.White;
            this.ProductIDTextBox.Enabled = false;
            this.ProductIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDTextBox.Location = new System.Drawing.Point(109, 12);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.ReadOnly = true;
            this.ProductIDTextBox.Size = new System.Drawing.Size(77, 29);
            this.ProductIDTextBox.TabIndex = 1;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(263, 15);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(90, 24);
            this.ConditionLabel.TabIndex = 2;
            this.ConditionLabel.Text = "Condition";
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(7, 15);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(97, 24);
            this.ProductIDLabel.TabIndex = 0;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.OSTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ModelTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(13, 81);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(735, 90);
            this.ProductInfoGroupBox.TabIndex = 2;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // OSTextBox
            // 
            this.OSTextBox.BackColor = System.Drawing.Color.White;
            this.OSTextBox.Enabled = false;
            this.OSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSTextBox.Location = new System.Drawing.Point(429, 13);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.ReadOnly = true;
            this.OSTextBox.Size = new System.Drawing.Size(300, 29);
            this.OSTextBox.TabIndex = 8;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.White;
            this.ModelTextBox.Enabled = false;
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(429, 46);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(300, 29);
            this.ModelTextBox.TabIndex = 7;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.BackColor = System.Drawing.Color.White;
            this.PlatformTextBox.Enabled = false;
            this.PlatformTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformTextBox.Location = new System.Drawing.Point(132, 13);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(222, 29);
            this.PlatformTextBox.TabIndex = 6;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.BackColor = System.Drawing.Color.White;
            this.ManufacturerTextBox.Enabled = false;
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTextBox.Location = new System.Drawing.Point(132, 46);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(222, 29);
            this.ManufacturerTextBox.TabIndex = 5;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(49, 16);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(77, 24);
            this.PlatformLabel.TabIndex = 4;
            this.PlatformLabel.Text = "Platform";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 49);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(120, 24);
            this.ManufacturerLabel.TabIndex = 3;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(386, 16);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(37, 24);
            this.OSLabel.TabIndex = 2;
            this.OSLabel.Text = "OS";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(360, 49);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(63, 24);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebcamTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.WebcamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryTextBox);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(13, 178);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(735, 136);
            this.TechSpecsGroupBox.TabIndex = 3;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebcamTextBox
            // 
            this.WebcamTextBox.BackColor = System.Drawing.Color.White;
            this.WebcamTextBox.Enabled = false;
            this.WebcamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebcamTextBox.Location = new System.Drawing.Point(552, 91);
            this.WebcamTextBox.Name = "WebcamTextBox";
            this.WebcamTextBox.ReadOnly = true;
            this.WebcamTextBox.Size = new System.Drawing.Size(177, 29);
            this.WebcamTextBox.TabIndex = 24;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebcamLabel.Location = new System.Drawing.Point(460, 94);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(86, 24);
            this.WebcamLabel.TabIndex = 23;
            this.WebcamLabel.Text = "Webcam";
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.BackColor = System.Drawing.Color.White;
            this.GPUTypeTextBox.Enabled = false;
            this.GPUTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeTextBox.Location = new System.Drawing.Point(552, 56);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.ReadOnly = true;
            this.GPUTypeTextBox.Size = new System.Drawing.Size(177, 29);
            this.GPUTypeTextBox.TabIndex = 22;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeLabel.Location = new System.Drawing.Point(449, 59);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(97, 24);
            this.GPUTypeLabel.TabIndex = 21;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.BackColor = System.Drawing.Color.White;
            this.HDDTextBox.Enabled = false;
            this.HDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDTextBox.Location = new System.Drawing.Point(552, 21);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.ReadOnly = true;
            this.HDDTextBox.Size = new System.Drawing.Size(177, 29);
            this.HDDTextBox.TabIndex = 20;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.Location = new System.Drawing.Point(492, 24);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(50, 24);
            this.HDDLabel.TabIndex = 19;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.BackColor = System.Drawing.Color.White;
            this.CPUSpeedTextBox.Enabled = false;
            this.CPUSpeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(360, 91);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.ReadOnly = true;
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(79, 29);
            this.CPUSpeedTextBox.TabIndex = 18;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(243, 94);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(109, 24);
            this.CPUSpeedLabel.TabIndex = 17;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.BackColor = System.Drawing.Color.White;
            this.CPUNumberTextBox.Enabled = false;
            this.CPUNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberTextBox.Location = new System.Drawing.Point(360, 56);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.ReadOnly = true;
            this.CPUNumberTextBox.Size = new System.Drawing.Size(79, 29);
            this.CPUNumberTextBox.TabIndex = 16;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(232, 59);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(122, 24);
            this.CPUNumberLabel.TabIndex = 15;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.BackColor = System.Drawing.Color.White;
            this.LCDSizeTextBox.Enabled = false;
            this.LCDSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeTextBox.Location = new System.Drawing.Point(360, 21);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.ReadOnly = true;
            this.LCDSizeTextBox.Size = new System.Drawing.Size(79, 29);
            this.LCDSizeTextBox.TabIndex = 14;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeLabel.Location = new System.Drawing.Point(267, 24);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(87, 24);
            this.LCDSizeLabel.TabIndex = 13;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.BackColor = System.Drawing.Color.White;
            this.CPUTypeTextBox.Enabled = false;
            this.CPUTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeTextBox.Location = new System.Drawing.Point(115, 91);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.ReadOnly = true;
            this.CPUTypeTextBox.Size = new System.Drawing.Size(111, 29);
            this.CPUTypeTextBox.TabIndex = 12;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(13, 94);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(96, 24);
            this.CPUTypeLabel.TabIndex = 11;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.BackColor = System.Drawing.Color.White;
            this.CPUBrandTextBox.Enabled = false;
            this.CPUBrandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandTextBox.Location = new System.Drawing.Point(115, 56);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.ReadOnly = true;
            this.CPUBrandTextBox.Size = new System.Drawing.Size(111, 29);
            this.CPUBrandTextBox.TabIndex = 10;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(6, 59);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(103, 24);
            this.CPUBrandLabel.TabIndex = 9;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.BackColor = System.Drawing.Color.White;
            this.MemoryTextBox.Enabled = false;
            this.MemoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryTextBox.Location = new System.Drawing.Point(115, 21);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.ReadOnly = true;
            this.MemoryTextBox.Size = new System.Drawing.Size(111, 29);
            this.MemoryTextBox.TabIndex = 8;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(30, 24);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(79, 24);
            this.MemoryLabel.TabIndex = 7;
            this.MemoryLabel.Text = "Memory";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(510, 320);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(116, 31);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.ExitApplication);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(632, 320);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(116, 31);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 320);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(186, 31);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Select Another";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 357);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.OrderDetailsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.OrderDetailsGroupBox.ResumeLayout(false);
            this.OrderDetailsGroupBox.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.GroupBox OrderDetailsGroupBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.TextBox WebcamTextBox;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
    }
}