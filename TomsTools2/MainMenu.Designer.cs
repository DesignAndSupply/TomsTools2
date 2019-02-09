namespace TomsTools2
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnStockPriceIncrease = new System.Windows.Forms.Button();
            this.btnCompletePunch = new System.Windows.Forms.Button();
            this.btnSlimlineSRInfo = new System.Windows.Forms.Button();
            this.btnSlimlineTimeFix = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStockPriceIncrease
            // 
            this.btnStockPriceIncrease.Location = new System.Drawing.Point(12, 12);
            this.btnStockPriceIncrease.Name = "btnStockPriceIncrease";
            this.btnStockPriceIncrease.Size = new System.Drawing.Size(108, 41);
            this.btnStockPriceIncrease.TabIndex = 0;
            this.btnStockPriceIncrease.Text = "Batch Stock Price Adjustment";
            this.btnStockPriceIncrease.UseVisualStyleBackColor = true;
            this.btnStockPriceIncrease.Click += new System.EventHandler(this.btnStockPriceIncrease_Click);
            // 
            // btnCompletePunch
            // 
            this.btnCompletePunch.Location = new System.Drawing.Point(126, 12);
            this.btnCompletePunch.Name = "btnCompletePunch";
            this.btnCompletePunch.Size = new System.Drawing.Size(108, 41);
            this.btnCompletePunch.TabIndex = 1;
            this.btnCompletePunch.Text = "Doors Stuck at punch";
            this.btnCompletePunch.UseVisualStyleBackColor = true;
            this.btnCompletePunch.Click += new System.EventHandler(this.btnCompletePunch_Click);
            // 
            // btnSlimlineSRInfo
            // 
            this.btnSlimlineSRInfo.Location = new System.Drawing.Point(240, 12);
            this.btnSlimlineSRInfo.Name = "btnSlimlineSRInfo";
            this.btnSlimlineSRInfo.Size = new System.Drawing.Size(108, 41);
            this.btnSlimlineSRInfo.TabIndex = 2;
            this.btnSlimlineSRInfo.Text = "Slimline SR + Box Info";
            this.btnSlimlineSRInfo.UseVisualStyleBackColor = true;
            // 
            // btnSlimlineTimeFix
            // 
            this.btnSlimlineTimeFix.Location = new System.Drawing.Point(354, 12);
            this.btnSlimlineTimeFix.Name = "btnSlimlineTimeFix";
            this.btnSlimlineTimeFix.Size = new System.Drawing.Size(108, 41);
            this.btnSlimlineTimeFix.TabIndex = 3;
            this.btnSlimlineTimeFix.Text = "Slimline Times Fix";
            this.btnSlimlineTimeFix.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove Stuck Buff Job";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSlimlineTimeFix);
            this.Controls.Add(this.btnSlimlineSRInfo);
            this.Controls.Add(this.btnCompletePunch);
            this.Controls.Add(this.btnStockPriceIncrease);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Tom\'s Tool Box";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockPriceIncrease;
        private System.Windows.Forms.Button btnCompletePunch;
        private System.Windows.Forms.Button btnSlimlineSRInfo;
        private System.Windows.Forms.Button btnSlimlineTimeFix;
        private System.Windows.Forms.Button button1;
    }
}

