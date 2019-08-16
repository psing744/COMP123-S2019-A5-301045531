namespace COMP123_S2019_A5_301045531.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.osOutputLabel = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.webcamOutputLabel = new System.Windows.Forms.Label();
            this.webcamLabel = new System.Windows.Forms.Label();
            this.gpuTypeOuputLabel = new System.Windows.Forms.Label();
            this.gpuTypeLabel = new System.Windows.Forms.Label();
            this.hddOutputLabel = new System.Windows.Forms.Label();
            this.hddLabel = new System.Windows.Forms.Label();
            this.cpuTypeOutputLabel = new System.Windows.Forms.Label();
            this.cpuBrandOutputLabel = new System.Windows.Forms.Label();
            this.cpuTypeLabel = new System.Windows.Forms.Label();
            this.cpuBrandLabel = new System.Windows.Forms.Label();
            this.memoryOutputLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.cpuSpeedOutputLabel = new System.Windows.Forms.Label();
            this.cpuNumberOutputLabel = new System.Windows.Forms.Label();
            this.lcdSizeOutputLabel = new System.Windows.Forms.Label();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.cpuNumberLabel = new System.Windows.Forms.Label();
            this.lcdSizeLabel = new System.Windows.Forms.Label();
            this.modelOutputLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.manufacturerOutputLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.platformOutputLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.conditionOutputLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceOutputLabel = new System.Windows.Forms.Label();
            this.salesTaxOutputLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.priceOutputLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.laptopPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laptopPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.osOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.osLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.webcamOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.webcamLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.gpuTypeOuputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.gpuTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.hddOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.hddLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.cpuTypeOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.cpuBrandOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.cpuTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.cpuBrandLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.memoryOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.memoryLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.cpuSpeedOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.cpuNumberOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.lcdSizeOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.cpuSpeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.cpuNumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.lcdSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.modelOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.modelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.manufacturerOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.manufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.platformOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.platformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.conditionOutputLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(446, 469);
            this.SystemComponentsGroupBox.TabIndex = 1;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // osOutputLabel
            // 
            this.osOutputLabel.BackColor = System.Drawing.Color.White;
            this.osOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osOutputLabel.Location = new System.Drawing.Point(128, 412);
            this.osOutputLabel.Name = "osOutputLabel";
            this.osOutputLabel.Size = new System.Drawing.Size(282, 25);
            this.osOutputLabel.TabIndex = 31;
            this.osOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // osLabel
            // 
            this.osLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osLabel.Location = new System.Drawing.Point(22, 412);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(100, 25);
            this.osLabel.TabIndex = 32;
            this.osLabel.Text = "OS";
            this.osLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // webcamOutputLabel
            // 
            this.webcamOutputLabel.BackColor = System.Drawing.Color.White;
            this.webcamOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamOutputLabel.Location = new System.Drawing.Point(128, 377);
            this.webcamOutputLabel.Name = "webcamOutputLabel";
            this.webcamOutputLabel.Size = new System.Drawing.Size(282, 35);
            this.webcamOutputLabel.TabIndex = 29;
            this.webcamOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // webcamLabel
            // 
            this.webcamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamLabel.Location = new System.Drawing.Point(22, 387);
            this.webcamLabel.Name = "webcamLabel";
            this.webcamLabel.Size = new System.Drawing.Size(100, 25);
            this.webcamLabel.TabIndex = 30;
            this.webcamLabel.Text = "WebCam";
            this.webcamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpuTypeOuputLabel
            // 
            this.gpuTypeOuputLabel.BackColor = System.Drawing.Color.White;
            this.gpuTypeOuputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTypeOuputLabel.Location = new System.Drawing.Point(128, 345);
            this.gpuTypeOuputLabel.Name = "gpuTypeOuputLabel";
            this.gpuTypeOuputLabel.Size = new System.Drawing.Size(282, 38);
            this.gpuTypeOuputLabel.TabIndex = 27;
            this.gpuTypeOuputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpuTypeLabel
            // 
            this.gpuTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTypeLabel.Location = new System.Drawing.Point(22, 352);
            this.gpuTypeLabel.Name = "gpuTypeLabel";
            this.gpuTypeLabel.Size = new System.Drawing.Size(100, 25);
            this.gpuTypeLabel.TabIndex = 28;
            this.gpuTypeLabel.Text = "GPU Type";
            this.gpuTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hddOutputLabel
            // 
            this.hddOutputLabel.BackColor = System.Drawing.Color.White;
            this.hddOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddOutputLabel.Location = new System.Drawing.Point(128, 311);
            this.hddOutputLabel.Name = "hddOutputLabel";
            this.hddOutputLabel.Size = new System.Drawing.Size(282, 34);
            this.hddOutputLabel.TabIndex = 25;
            this.hddOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hddLabel
            // 
            this.hddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddLabel.Location = new System.Drawing.Point(22, 317);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(100, 23);
            this.hddLabel.TabIndex = 26;
            this.hddLabel.Text = "HDD";
            this.hddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuTypeOutputLabel
            // 
            this.cpuTypeOutputLabel.BackColor = System.Drawing.Color.White;
            this.cpuTypeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTypeOutputLabel.Location = new System.Drawing.Point(128, 209);
            this.cpuTypeOutputLabel.Name = "cpuTypeOutputLabel";
            this.cpuTypeOutputLabel.Size = new System.Drawing.Size(282, 34);
            this.cpuTypeOutputLabel.TabIndex = 19;
            this.cpuTypeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuBrandOutputLabel
            // 
            this.cpuBrandOutputLabel.BackColor = System.Drawing.Color.White;
            this.cpuBrandOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuBrandOutputLabel.Location = new System.Drawing.Point(128, 176);
            this.cpuBrandOutputLabel.Name = "cpuBrandOutputLabel";
            this.cpuBrandOutputLabel.Size = new System.Drawing.Size(282, 33);
            this.cpuBrandOutputLabel.TabIndex = 20;
            this.cpuBrandOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuTypeLabel
            // 
            this.cpuTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTypeLabel.Location = new System.Drawing.Point(6, 218);
            this.cpuTypeLabel.Name = "cpuTypeLabel";
            this.cpuTypeLabel.Size = new System.Drawing.Size(116, 25);
            this.cpuTypeLabel.TabIndex = 21;
            this.cpuTypeLabel.Text = "CPU Type";
            this.cpuTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuBrandLabel
            // 
            this.cpuBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuBrandLabel.Location = new System.Drawing.Point(6, 184);
            this.cpuBrandLabel.Name = "cpuBrandLabel";
            this.cpuBrandLabel.Size = new System.Drawing.Size(116, 25);
            this.cpuBrandLabel.TabIndex = 22;
            this.cpuBrandLabel.Text = "CPU Brand";
            this.cpuBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // memoryOutputLabel
            // 
            this.memoryOutputLabel.BackColor = System.Drawing.Color.White;
            this.memoryOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryOutputLabel.Location = new System.Drawing.Point(128, 142);
            this.memoryOutputLabel.Name = "memoryOutputLabel";
            this.memoryOutputLabel.Size = new System.Drawing.Size(282, 34);
            this.memoryOutputLabel.TabIndex = 23;
            this.memoryOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // memoryLabel
            // 
            this.memoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryLabel.Location = new System.Drawing.Point(22, 148);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(100, 23);
            this.memoryLabel.TabIndex = 24;
            this.memoryLabel.Text = "Memory";
            this.memoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuSpeedOutputLabel
            // 
            this.cpuSpeedOutputLabel.BackColor = System.Drawing.Color.White;
            this.cpuSpeedOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuSpeedOutputLabel.Location = new System.Drawing.Point(128, 277);
            this.cpuSpeedOutputLabel.Name = "cpuSpeedOutputLabel";
            this.cpuSpeedOutputLabel.Size = new System.Drawing.Size(282, 34);
            this.cpuSpeedOutputLabel.TabIndex = 13;
            this.cpuSpeedOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuNumberOutputLabel
            // 
            this.cpuNumberOutputLabel.BackColor = System.Drawing.Color.White;
            this.cpuNumberOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNumberOutputLabel.Location = new System.Drawing.Point(128, 243);
            this.cpuNumberOutputLabel.Name = "cpuNumberOutputLabel";
            this.cpuNumberOutputLabel.Size = new System.Drawing.Size(282, 34);
            this.cpuNumberOutputLabel.TabIndex = 14;
            this.cpuNumberOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lcdSizeOutputLabel
            // 
            this.lcdSizeOutputLabel.BackColor = System.Drawing.Color.White;
            this.lcdSizeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcdSizeOutputLabel.Location = new System.Drawing.Point(128, 108);
            this.lcdSizeOutputLabel.Name = "lcdSizeOutputLabel";
            this.lcdSizeOutputLabel.Size = new System.Drawing.Size(282, 34);
            this.lcdSizeOutputLabel.TabIndex = 15;
            this.lcdSizeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuSpeedLabel.Location = new System.Drawing.Point(13, 286);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(109, 25);
            this.cpuSpeedLabel.TabIndex = 16;
            this.cpuSpeedLabel.Text = "CPU speed";
            this.cpuSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuNumberLabel
            // 
            this.cpuNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNumberLabel.Location = new System.Drawing.Point(9, 252);
            this.cpuNumberLabel.Name = "cpuNumberLabel";
            this.cpuNumberLabel.Size = new System.Drawing.Size(113, 25);
            this.cpuNumberLabel.TabIndex = 17;
            this.cpuNumberLabel.Text = "CPU number";
            this.cpuNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lcdSizeLabel
            // 
            this.lcdSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcdSizeLabel.Location = new System.Drawing.Point(22, 114);
            this.lcdSizeLabel.Name = "lcdSizeLabel";
            this.lcdSizeLabel.Size = new System.Drawing.Size(100, 23);
            this.lcdSizeLabel.TabIndex = 18;
            this.lcdSizeLabel.Text = "LCD Size";
            this.lcdSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modelOutputLabel
            // 
            this.modelOutputLabel.BackColor = System.Drawing.Color.White;
            this.modelOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelOutputLabel.Location = new System.Drawing.Point(308, 50);
            this.modelOutputLabel.Name = "modelOutputLabel";
            this.modelOutputLabel.Size = new System.Drawing.Size(102, 22);
            this.modelOutputLabel.TabIndex = 11;
            this.modelOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modelLabel
            // 
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(222, 50);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(80, 23);
            this.modelLabel.TabIndex = 12;
            this.modelLabel.Text = "Model";
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manufacturerOutputLabel
            // 
            this.manufacturerOutputLabel.BackColor = System.Drawing.Color.White;
            this.manufacturerOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerOutputLabel.Location = new System.Drawing.Point(128, 51);
            this.manufacturerOutputLabel.Name = "manufacturerOutputLabel";
            this.manufacturerOutputLabel.Size = new System.Drawing.Size(101, 22);
            this.manufacturerOutputLabel.TabIndex = 9;
            this.manufacturerOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLabel.Location = new System.Drawing.Point(6, 50);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(116, 23);
            this.manufacturerLabel.TabIndex = 10;
            this.manufacturerLabel.Text = "Manufacturer";
            this.manufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // platformOutputLabel
            // 
            this.platformOutputLabel.BackColor = System.Drawing.Color.White;
            this.platformOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformOutputLabel.Location = new System.Drawing.Point(308, 15);
            this.platformOutputLabel.Name = "platformOutputLabel";
            this.platformOutputLabel.Size = new System.Drawing.Size(102, 22);
            this.platformOutputLabel.TabIndex = 7;
            this.platformOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // platformLabel
            // 
            this.platformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLabel.Location = new System.Drawing.Point(222, 15);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(80, 23);
            this.platformLabel.TabIndex = 8;
            this.platformLabel.Text = "Platform";
            this.platformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // conditionOutputLabel
            // 
            this.conditionOutputLabel.BackColor = System.Drawing.Color.White;
            this.conditionOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutputLabel.Location = new System.Drawing.Point(128, 16);
            this.conditionOutputLabel.Name = "conditionOutputLabel";
            this.conditionOutputLabel.Size = new System.Drawing.Size(101, 22);
            this.conditionOutputLabel.TabIndex = 5;
            this.conditionOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(22, 16);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(100, 23);
            this.ConditionLabel.TabIndex = 6;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.totalPriceOutputLabel);
            this.priceGroupBox.Controls.Add(this.salesTaxOutputLabel);
            this.priceGroupBox.Controls.Add(this.priceLabel);
            this.priceGroupBox.Controls.Add(this.totalLabel);
            this.priceGroupBox.Controls.Add(this.priceOutputLabel);
            this.priceGroupBox.Controls.Add(this.salesTaxLabel);
            this.priceGroupBox.Location = new System.Drawing.Point(464, 245);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(304, 165);
            this.priceGroupBox.TabIndex = 2;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Your Price";
            // 
            // totalPriceOutputLabel
            // 
            this.totalPriceOutputLabel.BackColor = System.Drawing.Color.White;
            this.totalPriceOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceOutputLabel.Location = new System.Drawing.Point(179, 117);
            this.totalPriceOutputLabel.Name = "totalPriceOutputLabel";
            this.totalPriceOutputLabel.Size = new System.Drawing.Size(119, 22);
            this.totalPriceOutputLabel.TabIndex = 9;
            this.totalPriceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxOutputLabel
            // 
            this.salesTaxOutputLabel.BackColor = System.Drawing.Color.White;
            this.salesTaxOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTaxOutputLabel.Location = new System.Drawing.Point(201, 71);
            this.salesTaxOutputLabel.Name = "salesTaxOutputLabel";
            this.salesTaxOutputLabel.Size = new System.Drawing.Size(97, 22);
            this.salesTaxOutputLabel.TabIndex = 9;
            this.salesTaxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(10, 34);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 23);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(10, 116);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(116, 23);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceOutputLabel
            // 
            this.priceOutputLabel.BackColor = System.Drawing.Color.White;
            this.priceOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceOutputLabel.Location = new System.Drawing.Point(201, 34);
            this.priceOutputLabel.Name = "priceOutputLabel";
            this.priceOutputLabel.Size = new System.Drawing.Size(97, 22);
            this.priceOutputLabel.TabIndex = 5;
            this.priceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTaxLabel.Location = new System.Drawing.Point(10, 70);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(149, 23);
            this.salesTaxLabel.TabIndex = 10;
            this.salesTaxLabel.Text = "Sales Tax (13%)";
            this.salesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(580, 461);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 48);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(480, 461);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 48);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(684, 461);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(94, 48);
            this.finishButton.TabIndex = 4;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // laptopPictureBox
            // 
            this.laptopPictureBox.Image = global::COMP123_S2019_A5_301045531.Properties.Resources.desktop;
            this.laptopPictureBox.Location = new System.Drawing.Point(503, 83);
            this.laptopPictureBox.Name = "laptopPictureBox";
            this.laptopPictureBox.Size = new System.Drawing.Size(171, 153);
            this.laptopPictureBox.TabIndex = 3;
            this.laptopPictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.laptopPictureBox);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.priceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laptopPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.Label conditionOutputLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label platformOutputLabel;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.Label manufacturerOutputLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label modelOutputLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label cpuSpeedOutputLabel;
        private System.Windows.Forms.Label cpuNumberOutputLabel;
        private System.Windows.Forms.Label lcdSizeOutputLabel;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.Label cpuNumberLabel;
        private System.Windows.Forms.Label lcdSizeLabel;
        private System.Windows.Forms.Label cpuTypeOutputLabel;
        private System.Windows.Forms.Label cpuBrandOutputLabel;
        private System.Windows.Forms.Label cpuTypeLabel;
        private System.Windows.Forms.Label cpuBrandLabel;
        private System.Windows.Forms.Label memoryOutputLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label hddOutputLabel;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.Label gpuTypeOuputLabel;
        private System.Windows.Forms.Label gpuTypeLabel;
        private System.Windows.Forms.Label webcamOutputLabel;
        private System.Windows.Forms.Label webcamLabel;
        private System.Windows.Forms.Label osOutputLabel;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.Label totalPriceOutputLabel;
        private System.Windows.Forms.Label salesTaxOutputLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label priceOutputLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.PictureBox laptopPictureBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button finishButton;
    }
}