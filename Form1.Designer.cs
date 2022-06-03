namespace Pages
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.RAMGrid = new System.Windows.Forms.DataGridView();
            this.PageFameNamber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VirtualPageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PTGrid = new System.Windows.Forms.DataGridView();
            this.VPNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresenceBit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhisicalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAddresInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rmInput = new System.Windows.Forms.ComboBox();
            this.algorithmInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PageFrameNumberL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PAddressL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RAMGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAddresInput)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(897, 488);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(94, 29);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // RAMGrid
            // 
            this.RAMGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RAMGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageFameNamber,
            this.VirtualPageNumber});
            this.RAMGrid.Location = new System.Drawing.Point(12, 55);
            this.RAMGrid.Name = "RAMGrid";
            this.RAMGrid.RowHeadersWidth = 51;
            this.RAMGrid.RowTemplate.Height = 29;
            this.RAMGrid.Size = new System.Drawing.Size(208, 537);
            this.RAMGrid.TabIndex = 1;
            // 
            // PageFameNamber
            // 
            this.PageFameNamber.HeaderText = "№";
            this.PageFameNamber.MinimumWidth = 6;
            this.PageFameNamber.Name = "PageFameNamber";
            this.PageFameNamber.Width = 30;
            // 
            // VirtualPageNumber
            // 
            this.VirtualPageNumber.HeaderText = "Virtul Page №";
            this.VirtualPageNumber.MinimumWidth = 6;
            this.VirtualPageNumber.Name = "VirtualPageNumber";
            this.VirtualPageNumber.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "RAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 32);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Page tble";
            // 
            // PTGrid
            // 
            this.PTGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PTGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VPNumber,
            this.Addresses,
            this.PresenceBit,
            this.PhisicalAddress,
            this.R,
            this.M});
            this.PTGrid.Location = new System.Drawing.Point(281, 55);
            this.PTGrid.Name = "PTGrid";
            this.PTGrid.RowHeadersWidth = 51;
            this.PTGrid.RowTemplate.Height = 29;
            this.PTGrid.Size = new System.Drawing.Size(464, 537);
            this.PTGrid.TabIndex = 4;
            // 
            // VPNumber
            // 
            this.VPNumber.HeaderText = "№";
            this.VPNumber.MinimumWidth = 6;
            this.VPNumber.Name = "VPNumber";
            this.VPNumber.Width = 30;
            // 
            // Addresses
            // 
            this.Addresses.HeaderText = "Addresses";
            this.Addresses.MinimumWidth = 6;
            this.Addresses.Name = "Addresses";
            this.Addresses.Width = 125;
            // 
            // PresenceBit
            // 
            this.PresenceBit.HeaderText = "Presentce Bit";
            this.PresenceBit.MinimumWidth = 6;
            this.PresenceBit.Name = "PresenceBit";
            this.PresenceBit.Width = 85;
            // 
            // PhisicalAddress
            // 
            this.PhisicalAddress.HeaderText = "Phisical Address";
            this.PhisicalAddress.MinimumWidth = 6;
            this.PhisicalAddress.Name = "PhisicalAddress";
            this.PhisicalAddress.Width = 85;
            // 
            // R
            // 
            this.R.HeaderText = "R";
            this.R.MinimumWidth = 6;
            this.R.Name = "R";
            this.R.Width = 30;
            // 
            // M
            // 
            this.M.HeaderText = "M";
            this.M.MinimumWidth = 6;
            this.M.Name = "M";
            this.M.Width = 30;
            // 
            // vAddresInput
            // 
            this.vAddresInput.Location = new System.Drawing.Point(800, 136);
            this.vAddresInput.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.vAddresInput.Name = "vAddresInput";
            this.vAddresInput.Size = new System.Drawing.Size(191, 27);
            this.vAddresInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(800, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Virual Address";
            // 
            // rmInput
            // 
            this.rmInput.FormattingEnabled = true;
            this.rmInput.Items.AddRange(new object[] {
            "Read",
            "Write"});
            this.rmInput.Location = new System.Drawing.Point(800, 169);
            this.rmInput.Name = "rmInput";
            this.rmInput.Size = new System.Drawing.Size(191, 28);
            this.rmInput.TabIndex = 7;
            // 
            // algorithmInput
            // 
            this.algorithmInput.FormattingEnabled = true;
            this.algorithmInput.Items.AddRange(new object[] {
            "NRU",
            "FIFO"});
            this.algorithmInput.Location = new System.Drawing.Point(802, 296);
            this.algorithmInput.Name = "algorithmInput";
            this.algorithmInput.Size = new System.Drawing.Size(189, 28);
            this.algorithmInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(802, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Algorithm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(802, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Page Frame № : ";
            // 
            // PageFrameNumberL
            // 
            this.PageFrameNumberL.AutoSize = true;
            this.PageFrameNumberL.Location = new System.Drawing.Point(941, 360);
            this.PageFrameNumberL.Name = "PageFrameNumberL";
            this.PageFrameNumberL.Size = new System.Drawing.Size(18, 20);
            this.PageFrameNumberL.TabIndex = 11;
            this.PageFrameNumberL.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(802, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phisical address : ";
            // 
            // PAddressL
            // 
            this.PAddressL.AutoSize = true;
            this.PAddressL.Location = new System.Drawing.Point(941, 405);
            this.PAddressL.Name = "PAddressL";
            this.PAddressL.Size = new System.Drawing.Size(18, 20);
            this.PAddressL.TabIndex = 13;
            this.PAddressL.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 647);
            this.Controls.Add(this.PAddressL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PageFrameNumberL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.algorithmInput);
            this.Controls.Add(this.rmInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vAddresInput);
            this.Controls.Add(this.PTGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RAMGrid);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RAMGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PTGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAddresInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startBtn;
        private DataGridView RAMGrid;
        private DataGridViewTextBoxColumn PageFameNamber;
        private DataGridViewTextBoxColumn VirtualPageNumber;
        private Label label1;
        private Label label2;
        private DataGridView PTGrid;
        private DataGridViewTextBoxColumn VPNumber;
        private DataGridViewTextBoxColumn Addresses;
        private DataGridViewTextBoxColumn PresenceBit;
        private DataGridViewTextBoxColumn PhisicalAddress;
        private DataGridViewTextBoxColumn R;
        private DataGridViewTextBoxColumn M;
        private NumericUpDown vAddresInput;
        private Label label3;
        private ComboBox rmInput;
        private ComboBox algorithmInput;
        private Label label4;
        private Label label5;
        private Label PageFrameNumberL;
        private Label label6;
        private Label PAddressL;
    }
}