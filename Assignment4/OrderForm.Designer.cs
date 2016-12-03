namespace Assignment4
{
    partial class OrderForm
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
            this.OrderDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.SpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.SpecsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.CheckoutGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderDetailsGroupBox.SuspendLayout();
            this.SpecsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.CheckoutGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderDetailsGroupBox
            // 
            this.OrderDetailsGroupBox.Controls.Add(this.ConditionLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.ConditionTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.PlatformLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.PlatformTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.ModelLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.ModelTextBox);
            this.OrderDetailsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.OrderDetailsGroupBox.Controls.Add(this.ManufacturerTextBox);
            this.OrderDetailsGroupBox.Location = new System.Drawing.Point(12, 28);
            this.OrderDetailsGroupBox.Name = "OrderDetailsGroupBox";
            this.OrderDetailsGroupBox.Size = new System.Drawing.Size(508, 86);
            this.OrderDetailsGroupBox.TabIndex = 0;
            this.OrderDetailsGroupBox.TabStop = false;
            this.OrderDetailsGroupBox.Text = "Order Details";
            // 
            // SpecsGroupBox
            // 
            this.SpecsGroupBox.Controls.Add(this.SpecsRichTextBox);
            this.SpecsGroupBox.Controls.Add(this.WebcamLabel);
            this.SpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SpecsGroupBox.Controls.Add(this.OSLabel);
            this.SpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SpecsGroupBox.Controls.Add(this.HDDLabel);
            this.SpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.SpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.SpecsGroupBox.Location = new System.Drawing.Point(12, 111);
            this.SpecsGroupBox.Name = "SpecsGroupBox";
            this.SpecsGroupBox.Size = new System.Drawing.Size(508, 268);
            this.SpecsGroupBox.TabIndex = 1;
            this.SpecsGroupBox.TabStop = false;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebcamLabel.Location = new System.Drawing.Point(39, 204);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(86, 24);
            this.WebcamLabel.TabIndex = 55;
            this.WebcamLabel.Text = "Webcam";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeLabel.Location = new System.Drawing.Point(28, 180);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(97, 24);
            this.GPUTypeLabel.TabIndex = 53;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.Location = new System.Drawing.Point(75, 156);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(50, 24);
            this.HDDLabel.TabIndex = 51;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(17, 132);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(109, 24);
            this.CPUSpeedLabel.TabIndex = 49;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(3, 108);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(122, 24);
            this.CPUNumberLabel.TabIndex = 47;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeLabel.Location = new System.Drawing.Point(39, 12);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(87, 24);
            this.LCDSizeLabel.TabIndex = 45;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(29, 84);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(96, 24);
            this.CPUTypeLabel.TabIndex = 43;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(23, 60);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(103, 24);
            this.CPUBrandLabel.TabIndex = 41;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.White;
            this.ModelTextBox.Enabled = false;
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(359, 48);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(142, 29);
            this.ModelTextBox.TabIndex = 37;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.BackColor = System.Drawing.Color.White;
            this.ManufacturerTextBox.Enabled = false;
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTextBox.Location = new System.Drawing.Point(132, 48);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.ReadOnly = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(142, 29);
            this.ManufacturerTextBox.TabIndex = 35;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 51);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(120, 24);
            this.ManufacturerLabel.TabIndex = 33;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(294, 51);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(63, 24);
            this.ModelLabel.TabIndex = 27;
            this.ModelLabel.Text = "Model";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.BackColor = System.Drawing.Color.White;
            this.ConditionTextBox.Enabled = false;
            this.ConditionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionTextBox.Location = new System.Drawing.Point(132, 13);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.ReadOnly = true;
            this.ConditionTextBox.Size = new System.Drawing.Size(142, 29);
            this.ConditionTextBox.TabIndex = 32;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.BackColor = System.Drawing.Color.White;
            this.PlatformTextBox.Enabled = false;
            this.PlatformTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformTextBox.Location = new System.Drawing.Point(359, 13);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.ReadOnly = true;
            this.PlatformTextBox.Size = new System.Drawing.Size(142, 29);
            this.PlatformTextBox.TabIndex = 36;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(280, 16);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(77, 24);
            this.PlatformLabel.TabIndex = 34;
            this.PlatformLabel.Text = "Platform";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(88, 228);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(37, 24);
            this.OSLabel.TabIndex = 29;
            this.OSLabel.Text = "OS";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(47, 36);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(79, 24);
            this.MemoryLabel.TabIndex = 38;
            this.MemoryLabel.Text = "Memory";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(36, 16);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(90, 24);
            this.ConditionLabel.TabIndex = 28;
            this.ConditionLabel.Text = "Condition";
            // 
            // SpecsRichTextBox
            // 
            this.SpecsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecsRichTextBox.Location = new System.Drawing.Point(132, 9);
            this.SpecsRichTextBox.Name = "SpecsRichTextBox";
            this.SpecsRichTextBox.Size = new System.Drawing.Size(369, 249);
            this.SpecsRichTextBox.TabIndex = 57;
            this.SpecsRichTextBox.Text = "";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(544, 385);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(626, 385);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(708, 385);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.BackgroundImage = global::Assignment4.Properties.Resources.laptop;
            this.PreviewPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviewPictureBox.ImageLocation = "";
            this.PreviewPictureBox.Location = new System.Drawing.Point(527, 29);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(256, 194);
            this.PreviewPictureBox.TabIndex = 5;
            this.PreviewPictureBox.TabStop = false;
            // 
            // CheckoutGroupBox
            // 
            this.CheckoutGroupBox.Controls.Add(this.TotalTextBox);
            this.CheckoutGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.CheckoutGroupBox.Controls.Add(this.PriceTextBox);
            this.CheckoutGroupBox.Controls.Add(this.TotalLabel);
            this.CheckoutGroupBox.Controls.Add(this.SalesTaxLabel);
            this.CheckoutGroupBox.Controls.Add(this.PriceLabel);
            this.CheckoutGroupBox.Location = new System.Drawing.Point(527, 229);
            this.CheckoutGroupBox.Name = "CheckoutGroupBox";
            this.CheckoutGroupBox.Size = new System.Drawing.Size(256, 138);
            this.CheckoutGroupBox.TabIndex = 6;
            this.CheckoutGroupBox.TabStop = false;
            this.CheckoutGroupBox.Text = "Checkout";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(29, 20);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(6, 53);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(54, 13);
            this.SalesTaxLabel.TabIndex = 1;
            this.SalesTaxLabel.Text = "Sales Tax";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(29, 86);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(150, 17);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 3;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(150, 50);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesTaxTextBox.TabIndex = 4;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(150, 83);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 434);
            this.ControlBox = false;
            this.Controls.Add(this.CheckoutGroupBox);
            this.Controls.Add(this.PreviewPictureBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SpecsGroupBox);
            this.Controls.Add(this.OrderDetailsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.OrderDetailsGroupBox.ResumeLayout(false);
            this.OrderDetailsGroupBox.PerformLayout();
            this.SpecsGroupBox.ResumeLayout(false);
            this.SpecsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.CheckoutGroupBox.ResumeLayout(false);
            this.CheckoutGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox OrderDetailsGroupBox;
        private System.Windows.Forms.GroupBox SpecsGroupBox;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.RichTextBox SpecsRichTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private System.Windows.Forms.GroupBox CheckoutGroupBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}