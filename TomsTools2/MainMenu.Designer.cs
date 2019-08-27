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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCameraUpload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_amend_list = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStockPriceIncrease
            // 
            this.btnStockPriceIncrease.Location = new System.Drawing.Point(6, 19);
            this.btnStockPriceIncrease.Name = "btnStockPriceIncrease";
            this.btnStockPriceIncrease.Size = new System.Drawing.Size(108, 41);
            this.btnStockPriceIncrease.TabIndex = 0;
            this.btnStockPriceIncrease.Text = "Batch Stock Price Adjustment";
            this.btnStockPriceIncrease.UseVisualStyleBackColor = true;
            this.btnStockPriceIncrease.Click += new System.EventHandler(this.btnStockPriceIncrease_Click);
            // 
            // btnCompletePunch
            // 
            this.btnCompletePunch.Location = new System.Drawing.Point(120, 19);
            this.btnCompletePunch.Name = "btnCompletePunch";
            this.btnCompletePunch.Size = new System.Drawing.Size(108, 41);
            this.btnCompletePunch.TabIndex = 1;
            this.btnCompletePunch.Text = "Doors Stuck at punch";
            this.btnCompletePunch.UseVisualStyleBackColor = true;
            this.btnCompletePunch.Click += new System.EventHandler(this.btnCompletePunch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove Stuck Buff Job";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCameraUpload
            // 
            this.btnCameraUpload.Location = new System.Drawing.Point(6, 19);
            this.btnCameraUpload.Name = "btnCameraUpload";
            this.btnCameraUpload.Size = new System.Drawing.Size(108, 41);
            this.btnCameraUpload.TabIndex = 5;
            this.btnCameraUpload.Text = "Upload Dispatch Camera";
            this.btnCameraUpload.UseVisualStyleBackColor = true;
            this.btnCameraUpload.Click += new System.EventHandler(this.btnCameraUpload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnStockPriceIncrease);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 190);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Office Tools:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "sqlAnywhere";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_amend_list);
            this.groupBox2.Controls.Add(this.btnCameraUpload);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnCompletePunch);
            this.groupBox2.Location = new System.Drawing.Point(18, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 198);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shop Floor Tools:";
            // 
            // btn_amend_list
            // 
            this.btn_amend_list.Location = new System.Drawing.Point(348, 19);
            this.btn_amend_list.Name = "btn_amend_list";
            this.btn_amend_list.Size = new System.Drawing.Size(108, 41);
            this.btn_amend_list.TabIndex = 6;
            this.btn_amend_list.Text = "ryucxd";
            this.btn_amend_list.UseVisualStyleBackColor = true;
            this.btn_amend_list.Click += new System.EventHandler(this.Btn_amend_list_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tom\'s Tool Box";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockPriceIncrease;
        private System.Windows.Forms.Button btnCompletePunch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCameraUpload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_amend_list;
    }
}

