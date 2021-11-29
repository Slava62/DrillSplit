namespace DrillSplit.Source
{
    partial class DRSMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProgText = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressTace = new System.Windows.Forms.ToolStripProgressBar();
            this.tlStlblINFO = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlX = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlY = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlR = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlQ = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlF = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCodeInsert = new System.Windows.Forms.TextBox();
            this.cbxShowNC = new System.Windows.Forms.CheckBox();
            this.udpZum = new System.Windows.Forms.NumericUpDown();
            this.udpSplit_NUM = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udpZum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udpSplit_NUM)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProgText
            // 
            this.txtProgText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProgText.Location = new System.Drawing.Point(12, 12);
            this.txtProgText.Name = "txtProgText";
            this.txtProgText.Size = new System.Drawing.Size(561, 411);
            this.txtProgText.TabIndex = 0;
            this.txtProgText.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(577, 234);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressTace,
            this.tlStlblINFO,
            this.tlX,
            this.tlY,
            this.tlZ,
            this.tlR,
            this.tlQ,
            this.tlF});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressTace
            // 
            this.progressTace.Name = "progressTace";
            this.progressTace.Size = new System.Drawing.Size(100, 16);
            // 
            // tlStlblINFO
            // 
            this.tlStlblINFO.Name = "tlStlblINFO";
            this.tlStlblINFO.Size = new System.Drawing.Size(66, 17);
            this.tlStlblINFO.Text = "parameters";
            // 
            // tlX
            // 
            this.tlX.AutoSize = false;
            this.tlX.Name = "tlX";
            this.tlX.Size = new System.Drawing.Size(50, 17);
            this.tlX.Text = "x";
            // 
            // tlY
            // 
            this.tlY.AutoSize = false;
            this.tlY.Name = "tlY";
            this.tlY.Size = new System.Drawing.Size(50, 17);
            this.tlY.Text = "y";
            // 
            // tlZ
            // 
            this.tlZ.AutoSize = false;
            this.tlZ.Name = "tlZ";
            this.tlZ.Size = new System.Drawing.Size(50, 17);
            this.tlZ.Text = "z";
            // 
            // tlR
            // 
            this.tlR.AutoSize = false;
            this.tlR.Name = "tlR";
            this.tlR.Size = new System.Drawing.Size(50, 17);
            this.tlR.Text = "r";
            // 
            // tlQ
            // 
            this.tlQ.AutoSize = false;
            this.tlQ.Name = "tlQ";
            this.tlQ.Size = new System.Drawing.Size(50, 17);
            this.tlQ.Text = "q";
            // 
            // tlF
            // 
            this.tlF.AutoSize = false;
            this.tlF.Name = "tlF";
            this.tlF.Size = new System.Drawing.Size(50, 17);
            this.tlF.Text = "f";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(577, 263);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 3;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(577, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(577, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(577, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCodeInsert
            // 
            this.txtCodeInsert.Location = new System.Drawing.Point(12, 429);
            this.txtCodeInsert.Name = "txtCodeInsert";
            this.txtCodeInsert.Size = new System.Drawing.Size(561, 20);
            this.txtCodeInsert.TabIndex = 7;
            this.txtCodeInsert.TextChanged += new System.EventHandler(this.txtCodeInsert_TextChanged);
            // 
            // cbxShowNC
            // 
            this.cbxShowNC.AutoSize = true;
            this.cbxShowNC.Location = new System.Drawing.Point(577, 377);
            this.cbxShowNC.Name = "cbxShowNC";
            this.cbxShowNC.Size = new System.Drawing.Size(71, 17);
            this.cbxShowNC.TabIndex = 8;
            this.cbxShowNC.Text = "Show NC";
            this.cbxShowNC.UseVisualStyleBackColor = true;
            // 
            // udpZum
            // 
            this.udpZum.DecimalPlaces = 1;
            this.udpZum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udpZum.Location = new System.Drawing.Point(577, 400);
            this.udpZum.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udpZum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udpZum.Name = "udpZum";
            this.udpZum.Size = new System.Drawing.Size(71, 20);
            this.udpZum.TabIndex = 9;
            this.udpZum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udpZum.ValueChanged += new System.EventHandler(this.udpZum_ValueChanged);
            // 
            // udpSplit_NUM
            // 
            this.udpSplit_NUM.Location = new System.Drawing.Point(577, 25);
            this.udpSplit_NUM.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.udpSplit_NUM.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udpSplit_NUM.Name = "udpSplit_NUM";
            this.udpSplit_NUM.Size = new System.Drawing.Size(75, 20);
            this.udpSplit_NUM.TabIndex = 10;
            this.udpSplit_NUM.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udpSplit_NUM.ValueChanged += new System.EventHandler(this.udpSplit_NUM_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Split number";
            // 
            // DRSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udpSplit_NUM);
            this.Controls.Add(this.udpZum);
            this.Controls.Add(this.cbxShowNC);
            this.Controls.Add(this.txtCodeInsert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtProgText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 520);
            this.MinimumSize = new System.Drawing.Size(680, 520);
            this.Name = "DRSMain";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udpZum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udpSplit_NUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtProgText;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressTace;
        private System.Windows.Forms.ToolStripStatusLabel tlStlblINFO;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripStatusLabel tlX;
        private System.Windows.Forms.ToolStripStatusLabel tlY;
        private System.Windows.Forms.ToolStripStatusLabel tlZ;
        private System.Windows.Forms.ToolStripStatusLabel tlR;
        private System.Windows.Forms.ToolStripStatusLabel tlQ;
        private System.Windows.Forms.ToolStripStatusLabel tlF;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCodeInsert;
        private System.Windows.Forms.CheckBox cbxShowNC;
        private System.Windows.Forms.NumericUpDown udpZum;
        private System.Windows.Forms.NumericUpDown udpSplit_NUM;
        private System.Windows.Forms.Label label1;
    }
}

