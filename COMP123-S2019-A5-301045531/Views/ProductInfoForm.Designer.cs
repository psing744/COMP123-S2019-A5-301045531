namespace COMP123_S2019_A5_301045531.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.productOverviewGroupBox = new System.Windows.Forms.GroupBox();
            this.costOutputLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.conditionOutputLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ProductIdOutputLabel = new System.Windows.Forms.Label();
            this.productInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.manufacturerOutputLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.modelOutputLabel = new System.Windows.Forms.Label();
            this.osOutputLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.platformOutputLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.techSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.cpuTypeOutputLabel = new System.Windows.Forms.Label();
            this.cpuBrandOutputLabel = new System.Windows.Forms.Label();
            this.cpuTypeLabel = new System.Windows.Forms.Label();
            this.cpuBrandLabel = new System.Windows.Forms.Label();
            this.webcamOutputLabel = new System.Windows.Forms.Label();
            this.gpuTypeOuputLabel = new System.Windows.Forms.Label();
            this.cpuSpeedOutputLabel = new System.Windows.Forms.Label();
            this.cpuNumberOutputLabel = new System.Windows.Forms.Label();
            this.hddOutputLabel = new System.Windows.Forms.Label();
            this.lcdSizeOutputLabel = new System.Windows.Forms.Label();
            this.webcamLabel = new System.Windows.Forms.Label();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.gpuTypeLabel = new System.Windows.Forms.Label();
            this.cpuNumberLabel = new System.Windows.Forms.Label();
            this.hddLabel = new System.Windows.Forms.Label();
            this.lcdSizeLabel = new System.Windows.Forms.Label();
            this.memoryOutputLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.selectAnotherProductButton = new System.Windows.Forms.Button();
            this.ProductOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.productOverviewGroupBox.SuspendLayout();
            this.productInfoGroupBox.SuspendLayout();
            this.techSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Se&lect Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.selectAnotherProductButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(692, 390);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(94, 48);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(578, 390);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 48);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdLabel.Location = new System.Drawing.Point(22, 16);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(100, 23);
            this.ProductIdLabel.TabIndex = 4;
            this.ProductIdLabel.Text = "Product ID";
            this.ProductIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productOverviewGroupBox
            // 
            this.productOverviewGroupBox.Controls.Add(this.costOutputLabel);
            this.productOverviewGroupBox.Controls.Add(this.costLabel);
            this.productOverviewGroupBox.Controls.Add(this.conditionOutputLabel);
            this.productOverviewGroupBox.Controls.Add(this.ConditionLabel);
            this.productOverviewGroupBox.Controls.Add(this.ProductIdOutputLabel);
            this.productOverviewGroupBox.Controls.Add(this.ProductIdLabel);
            this.productOverviewGroupBox.Location = new System.Drawing.Point(12, 27);
            this.productOverviewGroupBox.Name = "productOverviewGroupBox";
            this.productOverviewGroupBox.Size = new System.Drawing.Size(774, 54);
            this.productOverviewGroupBox.TabIndex = 5;
            this.productOverviewGroupBox.TabStop = false;
            // 
            // costOutputLabel
            // 
            this.costOutputLabel.BackColor = System.Drawing.Color.White;
            this.costOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costOutputLabel.Location = new System.Drawing.Point(641, 15);
            this.costOutputLabel.Name = "costOutputLabel";
            this.costOutputLabel.Size = new System.Drawing.Size(127, 22);
            this.costOutputLabel.TabIndex = 4;
            this.costOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // costLabel
            // 
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(535, 15);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 23);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // conditionOutputLabel
            // 
            this.conditionOutputLabel.BackColor = System.Drawing.Color.White;
            this.conditionOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutputLabel.Location = new System.Drawing.Point(364, 16);
            this.conditionOutputLabel.Name = "conditionOutputLabel";
            this.conditionOutputLabel.Size = new System.Drawing.Size(143, 22);
            this.conditionOutputLabel.TabIndex = 4;
            this.conditionOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(258, 16);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(100, 23);
            this.ConditionLabel.TabIndex = 4;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductIdOutputLabel
            // 
            this.ProductIdOutputLabel.BackColor = System.Drawing.Color.White;
            this.ProductIdOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdOutputLabel.Location = new System.Drawing.Point(128, 16);
            this.ProductIdOutputLabel.Name = "ProductIdOutputLabel";
            this.ProductIdOutputLabel.Size = new System.Drawing.Size(115, 22);
            this.ProductIdOutputLabel.TabIndex = 4;
            this.ProductIdOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productInfoGroupBox
            // 
            this.productInfoGroupBox.Controls.Add(this.manufacturerOutputLabel);
            this.productInfoGroupBox.Controls.Add(this.manufacturerLabel);
            this.productInfoGroupBox.Controls.Add(this.modelOutputLabel);
            this.productInfoGroupBox.Controls.Add(this.osOutputLabel);
            this.productInfoGroupBox.Controls.Add(this.modelLabel);
            this.productInfoGroupBox.Controls.Add(this.osLabel);
            this.productInfoGroupBox.Controls.Add(this.platformOutputLabel);
            this.productInfoGroupBox.Controls.Add(this.platformLabel);
            this.productInfoGroupBox.Location = new System.Drawing.Point(12, 87);
            this.productInfoGroupBox.Name = "productInfoGroupBox";
            this.productInfoGroupBox.Size = new System.Drawing.Size(774, 116);
            this.productInfoGroupBox.TabIndex = 5;
            this.productInfoGroupBox.TabStop = false;
            this.productInfoGroupBox.Text = "Product Info";
            // 
            // manufacturerOutputLabel
            // 
            this.manufacturerOutputLabel.BackColor = System.Drawing.Color.White;
            this.manufacturerOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerOutputLabel.Location = new System.Drawing.Point(128, 74);
            this.manufacturerOutputLabel.Name = "manufacturerOutputLabel";
            this.manufacturerOutputLabel.Size = new System.Drawing.Size(115, 22);
            this.manufacturerOutputLabel.TabIndex = 4;
            this.manufacturerOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLabel.Location = new System.Drawing.Point(6, 73);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(116, 23);
            this.manufacturerLabel.TabIndex = 4;
            this.manufacturerLabel.Text = "Manufacturer";
            this.manufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modelOutputLabel
            // 
            this.modelOutputLabel.BackColor = System.Drawing.Color.White;
            this.modelOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelOutputLabel.Location = new System.Drawing.Point(364, 73);
            this.modelOutputLabel.Name = "modelOutputLabel";
            this.modelOutputLabel.Size = new System.Drawing.Size(367, 22);
            this.modelOutputLabel.TabIndex = 4;
            this.modelOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // osOutputLabel
            // 
            this.osOutputLabel.BackColor = System.Drawing.Color.White;
            this.osOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osOutputLabel.Location = new System.Drawing.Point(364, 16);
            this.osOutputLabel.Name = "osOutputLabel";
            this.osOutputLabel.Size = new System.Drawing.Size(367, 22);
            this.osOutputLabel.TabIndex = 4;
            this.osOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modelLabel
            // 
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(258, 73);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(100, 23);
            this.modelLabel.TabIndex = 4;
            this.modelLabel.Text = "Model";
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // osLabel
            // 
            this.osLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osLabel.Location = new System.Drawing.Point(258, 15);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(100, 23);
            this.osLabel.TabIndex = 4;
            this.osLabel.Text = "OS";
            this.osLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // platformOutputLabel
            // 
            this.platformOutputLabel.BackColor = System.Drawing.Color.White;
            this.platformOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformOutputLabel.Location = new System.Drawing.Point(128, 17);
            this.platformOutputLabel.Name = "platformOutputLabel";
            this.platformOutputLabel.Size = new System.Drawing.Size(115, 22);
            this.platformOutputLabel.TabIndex = 4;
            this.platformOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // platformLabel
            // 
            this.platformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLabel.Location = new System.Drawing.Point(22, 17);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(100, 23);
            this.platformLabel.TabIndex = 4;
            this.platformLabel.Text = "Platform";
            this.platformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // techSpecsGroupBox
            // 
            this.techSpecsGroupBox.Controls.Add(this.cpuTypeOutputLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuBrandOutputLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuTypeLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuBrandLabel);
            this.techSpecsGroupBox.Controls.Add(this.webcamOutputLabel);
            this.techSpecsGroupBox.Controls.Add(this.gpuTypeOuputLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuSpeedOutputLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuNumberOutputLabel);
            this.techSpecsGroupBox.Controls.Add(this.hddOutputLabel);
            this.techSpecsGroupBox.Controls.Add(this.lcdSizeOutputLabel);
            this.techSpecsGroupBox.Controls.Add(this.webcamLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuSpeedLabel);
            this.techSpecsGroupBox.Controls.Add(this.gpuTypeLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuNumberLabel);
            this.techSpecsGroupBox.Controls.Add(this.hddLabel);
            this.techSpecsGroupBox.Controls.Add(this.lcdSizeLabel);
            this.techSpecsGroupBox.Controls.Add(this.memoryOutputLabel);
            this.techSpecsGroupBox.Controls.Add(this.memoryLabel);
            this.techSpecsGroupBox.Location = new System.Drawing.Point(12, 209);
            this.techSpecsGroupBox.Name = "techSpecsGroupBox";
            this.techSpecsGroupBox.Size = new System.Drawing.Size(774, 175);
            this.techSpecsGroupBox.TabIndex = 5;
            this.techSpecsGroupBox.TabStop = false;
            this.techSpecsGroupBox.Text = "Tech Specs";
            // 
            // cpuTypeOutputLabel
            // 
            this.cpuTypeOutputLabel.BackColor = System.Drawing.Color.White;
            this.cpuTypeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTypeOutputLabel.Location = new System.Drawing.Point(128, 130);
            this.cpuTypeOutputLabel.Name = "cpuTypeOutputLabel";
            this.cpuTypeOutputLabel.Size = new System.Drawing.Size(115, 24);
            this.cpuTypeOutputLabel.TabIndex = 4;
            this.cpuTypeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuBrandOutputLabel
            // 
            this.cpuBrandOutputLabel.BackColor = System.Drawing.Color.White;
            this.cpuBrandOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuBrandOutputLabel.Location = new System.Drawing.Point(128, 74);
            this.cpuBrandOutputLabel.Name = "cpuBrandOutputLabel";
            this.cpuBrandOutputLabel.Size = new System.Drawing.Size(115, 24);
            this.cpuBrandOutputLabel.TabIndex = 4;
            this.cpuBrandOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuTypeLabel
            // 
            this.cpuTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTypeLabel.Location = new System.Drawing.Point(6, 129);
            this.cpuTypeLabel.Name = "cpuTypeLabel";
            this.cpuTypeLabel.Size = new System.Drawing.Size(116, 25);
            this.cpuTypeLabel.TabIndex = 4;
            this.cpuTypeLabel.Text = "CPU Type";
            this.cpuTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuBrandLabel
            // 
            this.cpuBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuBrandLabel.Location = new System.Drawing.Point(6, 73);
            this.cpuBrandLabel.Name = "cpuBrandLabel";
            this.cpuBrandLabel.Size = new System.Drawing.Size(116, 25);
            this.cpuBrandLabel.TabIndex = 4;
            this.cpuBrandLabel.Text = "CPU Brand";
            this.cpuBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // webcamOutputLabel
            // 
            this.webcamOutputLabel.BackColor = System.Drawing.Color.White;
            this.webcamOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamOutputLabel.Location = new System.Drawing.Point(641, 128);
            this.webcamOutputLabel.Name = "webcamOutputLabel";
            this.webcamOutputLabel.Size = new System.Drawing.Size(127, 24);
            this.webcamOutputLabel.TabIndex = 4;
            this.webcamOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpuTypeOuputLabel
            // 
            this.gpuTypeOuputLabel.BackColor = System.Drawing.Color.White;
            this.gpuTypeOuputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTypeOuputLabel.Location = new System.Drawing.Point(641, 72);
            this.gpuTypeOuputLabel.Name = "gpuTypeOuputLabel";
            this.gpuTypeOuputLabel.Size = new System.Drawing.Size(127, 24);
            this.gpuTypeOuputLabel.TabIndex = 4;
            this.gpuTypeOuputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuSpeedOutputLabel
            // 
            this.cpuSpeedOutputLabel.BackColor = System.Drawing.Color.White;
            this.cpuSpeedOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuSpeedOutputLabel.Location = new System.Drawing.Point(364, 129);
            this.cpuSpeedOutputLabel.Name = "cpuSpeedOutputLabel";
            this.cpuSpeedOutputLabel.Size = new System.Drawing.Size(143, 24);
            this.cpuSpeedOutputLabel.TabIndex = 4;
            this.cpuSpeedOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuNumberOutputLabel
            // 
            this.cpuNumberOutputLabel.BackColor = System.Drawing.Color.White;
            this.cpuNumberOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNumberOutputLabel.Location = new System.Drawing.Point(364, 73);
            this.cpuNumberOutputLabel.Name = "cpuNumberOutputLabel";
            this.cpuNumberOutputLabel.Size = new System.Drawing.Size(143, 24);
            this.cpuNumberOutputLabel.TabIndex = 4;
            this.cpuNumberOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hddOutputLabel
            // 
            this.hddOutputLabel.BackColor = System.Drawing.Color.White;
            this.hddOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddOutputLabel.Location = new System.Drawing.Point(641, 17);
            this.hddOutputLabel.Name = "hddOutputLabel";
            this.hddOutputLabel.Size = new System.Drawing.Size(127, 22);
            this.hddOutputLabel.TabIndex = 4;
            this.hddOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lcdSizeOutputLabel
            // 
            this.lcdSizeOutputLabel.BackColor = System.Drawing.Color.White;
            this.lcdSizeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcdSizeOutputLabel.Location = new System.Drawing.Point(364, 17);
            this.lcdSizeOutputLabel.Name = "lcdSizeOutputLabel";
            this.lcdSizeOutputLabel.Size = new System.Drawing.Size(143, 22);
            this.lcdSizeOutputLabel.TabIndex = 4;
            this.lcdSizeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // webcamLabel
            // 
            this.webcamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamLabel.Location = new System.Drawing.Point(535, 128);
            this.webcamLabel.Name = "webcamLabel";
            this.webcamLabel.Size = new System.Drawing.Size(100, 25);
            this.webcamLabel.TabIndex = 4;
            this.webcamLabel.Text = "WebCam";
            this.webcamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuSpeedLabel.Location = new System.Drawing.Point(249, 128);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(109, 25);
            this.cpuSpeedLabel.TabIndex = 4;
            this.cpuSpeedLabel.Text = "CPU speed";
            this.cpuSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpuTypeLabel
            // 
            this.gpuTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTypeLabel.Location = new System.Drawing.Point(535, 72);
            this.gpuTypeLabel.Name = "gpuTypeLabel";
            this.gpuTypeLabel.Size = new System.Drawing.Size(100, 25);
            this.gpuTypeLabel.TabIndex = 4;
            this.gpuTypeLabel.Text = "GPU Type";
            this.gpuTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuNumberLabel
            // 
            this.cpuNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNumberLabel.Location = new System.Drawing.Point(245, 73);
            this.cpuNumberLabel.Name = "cpuNumberLabel";
            this.cpuNumberLabel.Size = new System.Drawing.Size(113, 25);
            this.cpuNumberLabel.TabIndex = 4;
            this.cpuNumberLabel.Text = "CPU number";
            this.cpuNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hddLabel
            // 
            this.hddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddLabel.Location = new System.Drawing.Point(535, 17);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(100, 23);
            this.hddLabel.TabIndex = 4;
            this.hddLabel.Text = "HDD";
            this.hddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lcdSizeLabel
            // 
            this.lcdSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcdSizeLabel.Location = new System.Drawing.Point(258, 16);
            this.lcdSizeLabel.Name = "lcdSizeLabel";
            this.lcdSizeLabel.Size = new System.Drawing.Size(100, 23);
            this.lcdSizeLabel.TabIndex = 4;
            this.lcdSizeLabel.Text = "LCD Size";
            this.lcdSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // memoryOutputLabel
            // 
            this.memoryOutputLabel.BackColor = System.Drawing.Color.White;
            this.memoryOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryOutputLabel.Location = new System.Drawing.Point(128, 17);
            this.memoryOutputLabel.Name = "memoryOutputLabel";
            this.memoryOutputLabel.Size = new System.Drawing.Size(115, 22);
            this.memoryOutputLabel.TabIndex = 4;
            this.memoryOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // memoryLabel
            // 
            this.memoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryLabel.Location = new System.Drawing.Point(22, 17);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(100, 23);
            this.memoryLabel.TabIndex = 4;
            this.memoryLabel.Text = "Memory";
            this.memoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectAnotherProductButton
            // 
            this.selectAnotherProductButton.Location = new System.Drawing.Point(407, 390);
            this.selectAnotherProductButton.Name = "selectAnotherProductButton";
            this.selectAnotherProductButton.Size = new System.Drawing.Size(152, 48);
            this.selectAnotherProductButton.TabIndex = 2;
            this.selectAnotherProductButton.Text = "Select Another Product";
            this.selectAnotherProductButton.UseVisualStyleBackColor = true;
            this.selectAnotherProductButton.Click += new System.EventHandler(this.selectAnotherProductButton_Click);
            // 
            // ProductOpenFileDialog
            // 
            this.ProductOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.ControlBox = false;
            this.Controls.Add(this.techSpecsGroupBox);
            this.Controls.Add(this.productInfoGroupBox);
            this.Controls.Add(this.productOverviewGroupBox);
            this.Controls.Add(this.selectAnotherProductButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.productOverviewGroupBox.ResumeLayout(false);
            this.productInfoGroupBox.ResumeLayout(false);
            this.techSpecsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.GroupBox productOverviewGroupBox;
        private System.Windows.Forms.Label costOutputLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label conditionOutputLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ProductIdOutputLabel;
        private System.Windows.Forms.GroupBox productInfoGroupBox;
        private System.Windows.Forms.Label manufacturerOutputLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label modelOutputLabel;
        private System.Windows.Forms.Label osOutputLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label platformOutputLabel;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.GroupBox techSpecsGroupBox;
        private System.Windows.Forms.Label cpuTypeOutputLabel;
        private System.Windows.Forms.Label cpuBrandOutputLabel;
        private System.Windows.Forms.Label cpuTypeLabel;
        private System.Windows.Forms.Label cpuBrandLabel;
        private System.Windows.Forms.Label webcamOutputLabel;
        private System.Windows.Forms.Label gpuTypeOuputLabel;
        private System.Windows.Forms.Label cpuSpeedOutputLabel;
        private System.Windows.Forms.Label cpuNumberOutputLabel;
        private System.Windows.Forms.Label hddOutputLabel;
        private System.Windows.Forms.Label lcdSizeOutputLabel;
        private System.Windows.Forms.Label webcamLabel;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.Label gpuTypeLabel;
        private System.Windows.Forms.Label cpuNumberLabel;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.Label lcdSizeLabel;
        private System.Windows.Forms.Label memoryOutputLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Button selectAnotherProductButton;
        private System.Windows.Forms.OpenFileDialog ProductOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog ProductSaveFileDialog;
    }
}