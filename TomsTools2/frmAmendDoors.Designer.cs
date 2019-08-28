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
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.btn_updateDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_buff
            // 
            this.rd_buff.AutoSize = true;
            this.rd_buff.Location = new System.Drawing.Point(154, 10);
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
            this.rd_weld.Location = new System.Drawing.Point(242, 10);
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
            this.rd_pack.Location = new System.Drawing.Point(336, 10);
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(735, 387);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // txt_filter
            // 
            this.txt_filter.Location = new System.Drawing.Point(12, 9);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(119, 20);
            this.txt_filter.TabIndex = 5;
            this.txt_filter.TextChanged += new System.EventHandler(this.Txt_filter_TextChanged);
            this.txt_filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_filter_KeyPress);
            // 
            // btn_updateDelete
            // 
            this.btn_updateDelete.Location = new System.Drawing.Point(406, 6);
            this.btn_updateDelete.Name = "btn_updateDelete";
            this.btn_updateDelete.Size = new System.Drawing.Size(87, 23);
            this.btn_updateDelete.TabIndex = 6;
            this.btn_updateDelete.Text = "Delete/Update";
            this.btn_updateDelete.UseVisualStyleBackColor = true;
            this.btn_updateDelete.Click += new System.EventHandler(this.Btn_updateDelete_Click);
            // 
            // frmAmendDoors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 434);
            this.Controls.Add(this.btn_updateDelete);
            this.Controls.Add(this.txt_filter);
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
        private System.Windows.Forms.TextBox txt_filter;
        private System.Windows.Forms.Button btn_updateDelete;
    }
}