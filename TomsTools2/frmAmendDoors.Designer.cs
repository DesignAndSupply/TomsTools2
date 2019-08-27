namespace TomsTools2
{
    partial class frmAmendDoors
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
            this.rd_buff = new System.Windows.Forms.RadioButton();
            this.rd_weld = new System.Windows.Forms.RadioButton();
            this.rd_pack = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_buff
            // 
            this.rd_buff.AutoSize = true;
            this.rd_buff.Location = new System.Drawing.Point(256, 12);
            this.rd_buff.Name = "rd_buff";
            this.rd_buff.Size = new System.Drawing.Size(58, 17);
            this.rd_buff.TabIndex = 0;
            this.rd_buff.TabStop = true;
            this.rd_buff.Text = "Buffing";
            this.rd_buff.UseVisualStyleBackColor = true;
            this.rd_buff.CheckedChanged += new System.EventHandler(this.Rd_buff_CheckedChanged);
            // 
            // rd_weld
            // 
            this.rd_weld.AutoSize = true;
            this.rd_weld.Location = new System.Drawing.Point(344, 12);
            this.rd_weld.Name = "rd_weld";
            this.rd_weld.Size = new System.Drawing.Size(64, 17);
            this.rd_weld.TabIndex = 1;
            this.rd_weld.TabStop = true;
            this.rd_weld.Text = "Welding";
            this.rd_weld.UseVisualStyleBackColor = true;
            this.rd_weld.CheckedChanged += new System.EventHandler(this.Rd_weld_CheckedChanged);
            // 
            // rd_pack
            // 
            this.rd_pack.AutoSize = true;
            this.rd_pack.Location = new System.Drawing.Point(438, 12);
            this.rd_pack.Name = "rd_pack";
            this.rd_pack.Size = new System.Drawing.Size(64, 17);
            this.rd_pack.TabIndex = 2;
            this.rd_pack.TabStop = true;
            this.rd_pack.Text = "Packing";
            this.rd_pack.UseVisualStyleBackColor = true;
            this.rd_pack.CheckedChanged += new System.EventHandler(this.Rd_pack_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 387);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmAmendDoors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 434);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rd_pack);
            this.Controls.Add(this.rd_weld);
            this.Controls.Add(this.rd_buff);
            this.Name = "frmAmendDoors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_amend_doors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_buff;
        private System.Windows.Forms.RadioButton rd_weld;
        private System.Windows.Forms.RadioButton rd_pack;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}